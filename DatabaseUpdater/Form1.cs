using System.Data.SQLite;

namespace DatabaseUpdater
{
    public partial class Form1 : Form
    {

        private string db_file_path;
        private string csv_file_path;
        public Form1()
        {
            InitializeComponent();
            db_file_path = "";
            csv_file_path = "";
        }

        private void SelectDBButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "db files | *.db";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                db_file_path = openFileDialog.FileName;
            }
        }

        private void SelectcsvButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv files | *.csv";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                csv_file_path = openFileDialog.FileName;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Updater updater = new Updater(db_file_path, csv_file_path);
            updater.UpdateDB();
            MessageBox.Show("Updated the database.");
        }
    }
}