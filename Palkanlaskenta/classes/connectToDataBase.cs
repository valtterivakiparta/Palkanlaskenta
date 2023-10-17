using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta.classes
{
    class ConnectToDataBase
    {
        public SQLiteConnection createConnect()
        {
        SQLiteConnection SQLiteConn;
        SQLiteConn = new SQLiteConnection("Data Source = palkanlaskenta.db; Version = 3; New = True; Compress = True;");
            try
            {
                SQLiteConn.Open();
            }
            catch
            {

            }
            return SQLiteConn;
        }
        public void CreateTables(SQLiteConnection conn)
        {
            SQLiteCommand SQLiteCommand;
            // string dropTable = "DROP TABLE workerList";
            // string dropTables = "DROP TABLE SignIn";
            string createWorkerList = "CREATE TABLE IF NOT EXISTS workerList(PersonID INTEGER, LastName TEXT, FirstName TEXT, Salary REAL, address TEXT, age INTEGER)"; // Create Table if table no exists
            string createAccounts = "CREATE TABLE IF NOT EXISTS accounts(email TEXT, password TEXT, Username TEXT, tel TEXT)";                                          // Create Table if table no exists
            SQLiteCommand = conn.CreateCommand();
            SQLiteCommand.CommandText = createAccounts;
            SQLiteCommand.ExecuteNonQuery();
            SQLiteCommand.CommandText = createWorkerList; 
            SQLiteCommand.ExecuteNonQuery();
        }
       /* CREATE TABLE workersList(    
            PersonID INTEGER,
            LastName TEXT
            FirstName TEXT,
            Salary REAL,
            Address TEXT,
            Age INTEGER
        )
        
        CREATE TABLE account ( 
            Email TEXT,
            Password TEXT,
            Username TEXT,
            Tel TEXT
        )*/
        static void insertData(SQLiteConnection conn)
        {
            SQLiteCommand SQLiteCommand;
            SQLiteCommand = conn.CreateCommand();
            SQLiteCommand.CommandText = "";
            SQLiteCommand.ExecuteNonQuery();
        }
        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader SQLiteReader;
            SQLiteCommand SQLiteCommand;
            SQLiteCommand = conn.CreateCommand();
            SQLiteReader = SQLiteCommand.ExecuteReader();
            while (SQLiteReader.Read())
            {
                string readerString = SQLiteReader.GetString(0);
                Console.WriteLine(readerString);
            }
        }
    }
}