using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DatabaseUpdater
{
    internal class Updater
    {
        private string dbFilePath { get; set; }
        private string csvFilePath { get; set; }

        public Updater(string dbFilePath, string csvFilePath)
        {
            this.dbFilePath = dbFilePath;
            this.csvFilePath = csvFilePath;
        }

        // Returns a list of strings representing checksums for the converted files
        // as read from the csv file.
        private List<String> parseChecksums()
        {
            List<string> checksums = File.ReadAllLines(csvFilePath).ToList();
            
            // If the text file is generated as a csv file from DB Browser, the first line is the column name. 
            if (checksums[0] == "checksum")
            {
                checksums.RemoveAt(0);
            }
            return checksums;
        }

        // Retrieve a list of ConvertedFileInfo objets for each converted file.
        private List<ConvertedFileInfo> GetConvertedFileInfos()
        {
            List<ConvertedFileInfo> convertedFiles = new List<ConvertedFileInfo>();
            List<string> convertedChecksums = parseChecksums();
            
            // Setup database connection and query
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbFilePath);
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT id, uuid, checksum FROM Files";
            
            // Execute query
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string checksum = (string)reader["checksum"];
                if (convertedChecksums.Contains(checksum)) {
                    long id = (long)reader["id"];
                    string uuid = (string)reader["uuid"];
                    convertedFiles.Add(new ConvertedFileInfo(id, uuid));
                }    

            }

            connection.Close();
            return convertedFiles;
        }
        
        // Updates the database with the converted files.
        public void UpdateDB()
        {
            List<ConvertedFileInfo> convertedFiles = GetConvertedFileInfos();
            
            // Setup database query
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbFilePath);
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            
            // First create the _ConvertedFiles if it does not exist.
            command.CommandText = @"CREATE TABLE IF NOT EXISTS '_ConvertedFiles' 
                                    (file_id INTEGER NOT NULL, uuid VARCHAR NOT NULL,
                                    FOREIGN KEY(file_id) REFERENCES 'Files' (id))";
            
            command.ExecuteNonQuery();

            // Then insert the converted files
            command.CommandText = "INSERT INTO _ConvertedFiles VALUES (@id, @uuid)";
            
            // The entire insert process is wrapped in a transaction
            // in order to ensure fast record insertion.
            SQLiteTransaction transaction = connection.BeginTransaction();
            
            foreach(ConvertedFileInfo fileInfo in convertedFiles)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", fileInfo.id);
                command.Parameters.AddWithValue("@uuid", fileInfo.UUID);
                command.ExecuteNonQuery();

            }

            // Commit the transaction and close the database connection.
            transaction.Commit();
            connection.Close();

        }
    }
}
