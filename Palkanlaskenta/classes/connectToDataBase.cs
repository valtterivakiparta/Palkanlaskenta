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
        public void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand SQLiteCommand;
            string createSQL = "select * from workerList";
            SQLiteCommand = conn.CreateCommand();
            SQLiteCommand.CommandText = createSQL;
            SQLiteCommand.ExecuteNonQuery();
        }
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

