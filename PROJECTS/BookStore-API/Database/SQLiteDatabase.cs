using System;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace BookStore_API.Database
{
    class SQLiteDatabase
    {
        #region Get full control of users folder location of database
        //Method to give full control to the directory of database, in case it user has limited control
        private static void GrantAccess(string file)
        {
            bool exists = Directory.Exists(file);
            if (!exists)
            {
                Directory.CreateDirectory(file);
            }
        }
        #endregion
        #region CREATE Tables with Users and TIckets
        //Create SQLite Command
        private static SQLiteCommand sql_cmd;
        public static void CreateDatabase()
        {
            //Start up path 
            string path = ".\\";
            //Path to database
            string fileName = @"database\db.sqlite";
            //Give control to folder
            GrantAccess("database");
            //If the file is not there or deleted, create the database
            if (!File.Exists(Path.Combine(path, fileName)))
            {
                //Create file at startup path and destinated file location
                SQLiteConnection.CreateFile(Path.Combine(path, fileName));
                //Make the  SQLite connection string
                var sqlite2 = new SQLiteConnection($"Data Source=.\\database\\db.sqlite;");
                //Open connection to database
                sqlite2.Open();
                //Create the SQLite command
                sql_cmd = sqlite2.CreateCommand();
                //CREATE Table - Authors
                string createTableQuery1 = @"CREATE TABLE IF NOT EXISTS Authors ("+
                    "Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                    "Firstname NVARCHAR(2048)  NULL, " +
                    "Lastname NVARCHAR(2048)  NULL, " +
                    "Bio VARCHAR(2048)  NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery1;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - Books
                string createTableQuery2 = @"CREATE TABLE IF NOT EXISTS Books (" +
                   "Year INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                   "ISBN NVARCHAR(2048)  NULL, " +
                   "Summary NVARCHAR(2048)  NULL, " +
                   "Image NVARCHAR(2048)  NULL, " +
                   "Price REAL  NULL, " +
                   "AuthorId INTEGER NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery2;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //LOAD Author
                int id = 1;
                string firstName = "JamesTest";
                string lastName = "SilcottTest";
                string bio = "BioTest";
                string sqliteInsert_Authors = $"INSERT INTO Authors(" +
                    $"Id, " +
                    $"Firstname, " +
                    $"Lastname, " +
                    $"Bio) " +
                    $"VALUES ('" + 
                    id + "','" + 
                    firstName + "','" + 
                    lastName + "','" + 
                    bio + "');";
                sql_cmd.CommandText = sqliteInsert_Authors;
                sql_cmd.ExecuteNonQuery();

                //LOAD Author
                int year = 1;
                string ISBN = "978-3-16-148410-0";
                string summary = "An ISBN is assigned to each separate edition and variation (except reprintings) of a publication";
                string image = "image.file.path";
                float price = 125.00f;
                int authorId = 1;

                string sqliteInsert_Books = $"INSERT INTO Books(" +
                    $"Year, " +
                    $"ISBN, " +
                    $"Summary, " +
                    $"Image, " +
                    $"Price, " +
                    $"AuthorId) " +
                    $"VALUES ('" +
                    year + "','" +
                    ISBN + "','" +
                    summary + "','" +
                    image + "','" +
                    price + "','" +
                    authorId + "');";
                sql_cmd.CommandText = sqliteInsert_Books;
                sql_cmd.ExecuteNonQuery();


                //Close connection to database
                sqlite2.Close();

            }
            #endregion
        }
    }
}