using System;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
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

            //TODO : Delete old Logbooks - use until known fix
            //DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/logs/");
            //FileInfo[] files = di.GetFiles("*.txt").Where(path => path.Extension == ".txt").ToArray();
            //foreach (FileInfo file in files)
            //{
            //    try
            //    {
            //        file.Attributes = FileAttributes.Normal;
            //        File.Delete(file.FullName);
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}

            //TODO : Delete current Database - use until known fix/fixed SeedData if statement see if the email already exists
            //if (File.Exists(Path.Combine(path, fileName)))
            //{
            //    File.Delete(Path.Combine(path, fileName));
            //}

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
                string createTableQuery1 = @"CREATE TABLE IF NOT EXISTS Authors (" +
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
                   "Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                   "Year INTEGER NULL , " +
                   "Title NVARCHAR(2048)  NULL, " +
                   "ISBN NVARCHAR(2048)  NULL, " +
                   "Summary NVARCHAR(2048)  NULL, " +
                   "Image NVARCHAR(2048)  NULL, " +
                   "Price REAL NULL, " +
                   "AuthorId INTEGER NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery2;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetRoles
                string createTableQuery3 = @"CREATE TABLE IF NOT EXISTS AspNetRoles (" +
                   "Id NVARCHAR(2048) NULL, " +
                   "Name NVARCHAR(2048)  NULL, " +
                   "NormalizedName NVARCHAR(2048)  NULL, " +
                   "ConcurrencyStamp NVARCHAR(2048)  NULL, " +
                   "Image NVARCHAR(2048)  NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery3;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetUsers
                string createTableQuery4 = @"CREATE TABLE IF NOT EXISTS AspNetUsers (" +
                   "Id NVARCHAR(2048) NOT NULL, " +
                   "UserName NVARCHAR(2048)  NULL, " +
                   "NormalizedUserName NVARCHAR(2048)  NULL, " +
                   "Email NVARCHAR(2048)  NULL, " +
                   "NormalizedEmail NVARCHAR(2048)  NULL, " +
                   "EmailConfirmed INTEGER NOT NULL, " +
                   "PasswordHash NVARCHAR(2048)  NULL, " +
                   "SecurityStamp NVARCHAR(2048)  NULL, " +
                   "ConcurrencyStamp NVARCHAR(2048)  NULL, " +
                   "PhoneNumber NVARCHAR(2048)  NULL, " +
                   "PhoneNumberConfirmed INTEGER NOT NULL, " +
                   "TwoFactorEnabled INTEGER NOT NULL, " +
                   "LockoutEnd NVARCHAR(2048)  NULL, " +
                   "LockoutEnabled INTEGER NOT NULL, " +
                   "AccessFailedCount INTEGER NOT NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery4;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetRoleClaims
                string createTableQuery5 = @"CREATE TABLE IF NOT EXISTS AspNetRoleClaims (" +
                   "Id INTEGER NOT NULL, " +
                   "RoleId NVARCHAR(2048) NOT NULL, " +
                   "ClaimType NVARCHAR(2048)  NULL, " +
                   "ClaimValue NVARCHAR(2048)  NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery5;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetUserClaims
                string createTableQuery6 = @"CREATE TABLE IF NOT EXISTS AspNetUserClaims (" +
                   "Id INTEGER NOT NULL, " +
                   "UserId NVARCHAR(2048) NOT NULL, " +
                   "ClaimType NVARCHAR(2048)  NULL, " +
                   "ClaimValue NVARCHAR(2048)  NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery6;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetUserLogins
                string createTableQuery7 = @"CREATE TABLE IF NOT EXISTS AspNetUserLogins (" +
                   "LoginProvider NVARCHAR(2048) NOT NULL, " +
                   "ProviderKey NVARCHAR(2048) NOT NULL, " +
                   "ProviderDisplayName NVARCHAR(2048)  NULL, " +
                   "UserId NVARCHAR(2048) NOT NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery7;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetUserRoles
                string createTableQuery8 = @"CREATE TABLE IF NOT EXISTS AspNetUserRoles (" +
                   "UserId NVARCHAR(2048) NOT NULL, " +
                   "RoleId NVARCHAR(2048) NOT NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery8;
                //End the command
                sql_cmd.ExecuteNonQuery();

                //CREATE Table - AspNetUserTokens
                string createTableQuery9 = @"CREATE TABLE IF NOT EXISTS AspNetUserTokens (" +
                   "UserId NVARCHAR(2048) NOT NULL, " +
                   "LoginProvider NVARCHAR(2048) NOT NULL, " +
                   "Name NVARCHAR(2048) NOT NULL, " +
                   "Value NVARCHAR(2048) NULL);";
                //Give the command query
                sql_cmd.CommandText = createTableQuery9;
                //End the command
                sql_cmd.ExecuteNonQuery();


                //LOAD Author

                int numberOfAuthors = 11;
                for (int i = 1; i < numberOfAuthors; )
                {
                    int id = i;
                    string firstName = $"{i} First Name";
                    string lastName = $"{i} Last Name";
                    string bio = $"{i} Bio";
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
                    i++;
                }
                
                //LOAD Book
                int numberOfBooks = 11;
                for (int i = 1; i < numberOfBooks;)
                {
                    int idBook = i;
                    string title = $"{i} : Book Title";
                    int year = Convert.ToInt32($"197{i + 7}");
                    string ISBN = $"978-3-16-148410-{i}";
                    string summary = $"{i} : An ISBN is assigned to each separate edition and variation (except reprintings) of a publication";
                    string image = $"{i}.image.file.path";
                    decimal price = Convert.ToDecimal($"{i}.{i+i}{i*i}");
                    int authorId = i;
                    string sqliteInsert_Books = $"INSERT INTO Books(" +
                        $"Id, " +
                        $"Title, " +
                        $"Year, " +
                        $"ISBN, " +
                        $"Summary, " +
                        $"Image, " +
                        $"Price, " +
                        $"AuthorId) " +
                        $"VALUES ('" +
                        idBook + "','" +
                        title + "','" +
                        year + "','" +
                        ISBN + "','" +
                        summary + "','" +
                        image + "','" +
                        price + "','" +
                        authorId + "');";
                    sql_cmd.CommandText = sqliteInsert_Books;
                    sql_cmd.ExecuteNonQuery();
                    i++;
                }

                //Close connection to database
                sqlite2.Close();

            }
            #endregion
        }
    }
}