using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
//Download Sqlite prior to this
//Tool => NuGet Package Manager => Manage NuGet Packages for Solutions
//Search "sqlite"
//Install "System.Data.SQLite"

//GUI METHOD
//Open SQLITE DB Browser => file is located in the bin folder
//Create table => add fields
//Write Changes, then  close the DB Browser *can't use the database with more than one thing using it


namespace SQLITE_demo
{
    public class Database
    {
        //Declare file location and command
        public static SQLiteConnection conn= new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        public static SQLiteCommand cmd = new SQLiteCommand(conn);
        // Creates an empty database file
        public static void CreateNewDatabase()
        {
            if (!File.Exists("./Ticket.sqlite3"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite3");
                Console.WriteLine("Database File Created\n");
            }
        }
        //OPEN CONNECTION
        public static void ConnectToDatabase()
        {
            conn.Open();
        }
        //CLOSE CONNECTION
        public static void CloseDatabase()
        {
            conn.Close();
        }
        //CREATE TABLE
       public static void CreateTable()
        {
            cmd = conn.CreateCommand();
            //CREATE TICKET TABLE
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS ticketTable
                (
ticketId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
ticketFirstName VARCHAR(500) , 
ticketLastName VARCHAR(500), 
email VARCHAR(500), 
phone VARCHAR(500),
address VARCHAR(500),
issueCategory VARCHAR(500),
priorityLevel VARCHAR(500),
description VARCHAR(500),
dateIssued VARCHAR(500),
dateCompleted VARCHAR(500),
costs VARCHAR(500), 
status VARCHAR(500),
UNIQUE ('ticketFirstName', 'ticketLastName')
);";
            cmd.ExecuteNonQuery();
            //CREATE USER TABLE
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS usersTable
                (
userId INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
userFirstName VARCHAR(500), 
userLastName VARCHAR(500), 
email VARCHAR(500), 
phone VARCHAR(500),
address VARCHAR(500),
FOREIGN KEY ('userFirstName', userLastName) REFERENCES 'ticketTable' ('ticketFirstName', 'ticketLastName')
); ";
            cmd.ExecuteNonQuery();
        }
       //FILL TABLE
        public static void FillTable()
        {
            //ADD VALUES TO TICKET TABLE
            cmd.CommandText = @"INSERT INTO ticketTable (
ticketFirstName, 
ticketLastName,
email,
phone,
address,
issueCategory,
priorityLevel,
description,
dateIssued,
dateCompleted,
costs,
status
) VALUES (
'James', 
'Silcott',
'james@gmail.com',
'907-250-7727',
'204 Betsinger Rd Sherill NY 13461',
'category',
'priority',
'description',
'TODAY',
'TBD',
'$0.00',
'ACTIVE'
);";
            cmd.ExecuteNonQuery();
            //ADD VALUES TO USER TABLE
            cmd.CommandText = @"INSERT INTO usersTable (
userFirstName, 
userLastName,
email,
phone,
address
) VALUES (
'James', 
'Silcott',
'james@gmail.com',
'907-250-7727',
'204 Betsinger Rd Sherill NY 13461'
);";
            cmd.ExecuteNonQuery();
        }
        //DELETE DATA AND TABLES
        public static void DeleteData()
        {
            cmd.CommandText = "delete from ticketTable";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "delete from usersTable";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"DROP TABLE IF EXISTS ticketTable;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"DROP TABLE IF EXISTS usersTable;";
            cmd.ExecuteNonQuery();
            
            Console.WriteLine("\nDatabase Deleted");
        }
        //PRINT TABLES
        public static void PrintDept()
        { 
            //TICKET TABLE
            cmd.CommandText = "select * from ticketTable";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                // printing the column names
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).ToString() + "\t\n");
                Console.Write(Environment.NewLine);
                // Always call Read before accesing data
                while (reader.Read())
                {
                    // printing the table content
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader.GetValue(i).ToString() + "\t\n");
                    Console.Write(Environment.NewLine);
                }
            }
            //USERS TABLE
            cmd.CommandText = "select * from usersTable";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                // printing the column names
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write(reader.GetName(i).ToString() + "\t");
                Console.Write(Environment.NewLine);
                // Always call Read before accesing data
                while (reader.Read())
                {
                    // printing the table content
                    for (int i = 0; i < reader.FieldCount; i++)
                        Console.Write(reader.GetValue(i).ToString() + "\t");
                    Console.Write(Environment.NewLine);
                }
            }
        }

        //LOAD DATABASE
        public static void LoadDatabase()
        {
            ConnectToDatabase();
            //DeleteData();
            CreateNewDatabase();
            CreateTable();
            FillTable();
            UpdateData();
            PrintDept();
            DeleteData();
            CloseDatabase();
        }
        //UPDATE DATABASE
        public static void UpdateData()
        {
            cmd.CommandText = "Update ticketTable SET address='whatever' where address='204 Betsinger Rd Sherill NY 13461';";
            cmd.ExecuteNonQuery();
        }

        //Test for building constructor
        public static void Test()
        {
            Console.WriteLine("Test");
        }
        public Database()
        {
            Test();
        }
    }
    class Program : Database 
    {
        static void Main(string[] args)
        {
            FullScreen.WideScreenMethod();
            Program p = new Program();
            Database d = new Database();
        }

        public Program()
        {
            Database.LoadDatabase();
        }
    }
    public static class FullScreen
    {
        //Make Fullscreen
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        //This will set the console window to full screen
        public static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
    }
}

