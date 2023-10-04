using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Palkanlaskenta.classes
{
    internal class ConnectToDataBase
    {

        public void connectToDatabase()
        {
            SqliteConnection sqlite_conn;
            sqlite_conn = createDatabase();
            createTablebase(sqlite_conn);
            Console.WriteLine("Ali osaa koodaa");

        }

        static SqliteConnection createDatabase()
        {
            SqliteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SqliteConnection("");
            //Open the connection
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception e)
            {

            }
            return sqlite_conn;
        }
        public void createTablebase(SqliteConnection conn)
        {
            Console.WriteLine("luotu");
            SqliteCommand sqlite_cmd;
            string CreateTable = "CREATE TABLE workerslist (PersonID INT, LastName VARCHAR(20), FirstName VARCHAR(20), Salary DECIMAL, Address VARCHAR(30), Age INT)";
            string CreateTable1 = "CREATE TABLE SignIn (Email VARCHAR(40), Password VARCHAR(30), Username VARCHAR(40), Tel VARCHAR(20))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = CreateTable;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = CreateTable1;
            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertData(SqliteConnection conn)
        {
            Console.WriteLine("insertattu");
        }

        public void ReadData(SqliteConnection conn)
        {
            Console.WriteLine("luettu");
        }
    }
}