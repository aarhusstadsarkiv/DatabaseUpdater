# Description
The DatabaseUpdater tool is used to update a digiarch generated database with information about converted files.

# Installation
Prebuild windows binaries can be found under releases on the github page for DatabaseUpdater. To use the prebuild binary, download the release zip file and extract it. The extracted folder will include a windows executable (.exe) file. For ease of use, you can add a shortcut to the executable on your desktop.

# Usage
DatabaseUpdater is a GUI program. Usage of the program is as follows:
1. Select the database file you want to update.
2. Select a csv or .txt file of checksums for converted files saved from a previous database file. 
An example sql command for retrieving the checksums for converted files can be seen below:
```sql
SELECT checksum FROM Files WHERE Files.uuid IN (SELECT uuid FROM _ConvertedFiles);
```
3. Click the update button. The tool will find the `id` and `uuid` for all the files with a checksum listed in the csv file and insert these tuples `(id, uuid)` into the _ConvertedFiles table.
