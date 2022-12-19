using System;
using System.Data.SQLite;
using System.IO;


namespace WebApplication1
{
    public class SQLiteDatabase
    {

            public static string tableName = "tableName";

            public static string col1Name = "firstName";
            public static string col2Name = "lastName";
            public static string col3Name = "email";
            public static string col4Name = "phone";
            public static string col5Name = "address";
            public static string col6Name = "issueCategory";
            public static string col7Name = "priorityLevel";
            public static string col8Name = "description";
            public static string col9Name = "dateIssued";
            public static string col10Name = "dateCompleted";
            public static string col11Name = "costs";
            public static string col12Name = "status";

        public static string col1DataType = "varchar(20)";
            public static string col2DataType = "int";

            public static string col1Value = "value1";
            public static int col2Value = 999;

            public static string updateValue1 = "updateValue1";
            public static string updateValue2 = "updateValue2";
            public static string updateValue3 = "updateValue3";


            // Holds our connection with the database
            public static SQLiteConnection m_dbConnection;



            // Creates an empty database file
            public static void createNewDatabase()
            {
                if (!File.Exists("./MyDatabase.sqlite3"))
                {
                    SQLiteConnection.CreateFile("MyDatabase.sqlite3");
                    Console.WriteLine("Database File Created");
                }
            }

            // Creates a connection with our database file.
            public static void connectToDatabase()
            {
                m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                //Use Password
                //Data Source = c:\mydb.db; Version = 3; Password = myPassword;
                m_dbConnection.Open();
            }

            // Creates a table named 'highscores' with two columns: name (a string of max 20 characters) and score (an int)
            public static void createTable()
            {
                string sql = $"create table IF NOT EXISTS {tableName} (" +
                             $"{col1Name} {col1DataType}, " +
                             $"{col2Name} {col2DataType}" +
                             $"{col3Name} {col2DataType}" +
                             $"{col4Name} {col2DataType}" +
                             $"{col5Name} {col2DataType}" +
                             $"{col6Name} {col2DataType}" +
                             $"{col7Name} {col2DataType}" +
                             $"{col8Name} {col2DataType}" +
                             $"{col9Name} {col2DataType}" +
                             $"{col10Name} {col2DataType}" +
                             $"{col11Name} {col2DataType}" +
                             $"{col12Name} {col2DataType}" +
                             $")";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

            public static void deleteData()
            {
                string sql = $"delete from {tableName} WHERE {col1Name}=@{col1Name}";
                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue($"@{col1Name}", $"{updateValue1}");
                    command.ExecuteNonQuery();
                }
            }

            public static void updateData()
            {
                string sql = $"Update {tableName} SET {col1Name}=@{col1Name} WHERE {col2Name}=@{col2Name}";
                using (SQLiteCommand command = m_dbConnection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue($"@{col1Name}", $"{updateValue1}");
                    command.Parameters.AddWithValue($"@{col2Name}", $"{col2Value}");
                    command.ExecuteNonQuery();
                }
            }

            // Inserts some values in the highscores table.
            // As you can see, there is quite some duplicate code here, we'll solve this in part two.
            public static void fillTable()
            {
                string sql = $"insert into {tableName} ({col1Name}, {col2Name}) values (\"{col1Value}\", {col2Value})";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

            // Writes the highscores to the console sorted on score in descending order.
            public static void printDataTable()
            {
                string sql = $"select * from {tableName} order by {col2Name} desc";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    Console.WriteLine($"{col1Name}: " + reader[$"{col1Name}"] + $"\t{col2Name}: " + reader[$"{col2Name}"]);
                Console.ReadLine();
            }

            public static void LoadDatabase()
            {
                createNewDatabase();
                connectToDatabase();
                createTable();

            Console.WriteLine("Create Table");
                printDataTable();
                Console.WriteLine("Fill Table");
                fillTable();
                printDataTable();
                Console.WriteLine("Update Table");
                updateData();
                printDataTable();
                Console.WriteLine("Delete Table");
                deleteData();
                printDataTable();
        }
        
    }
}
