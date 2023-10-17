using Palkanlaskenta.classes;
using System;
using System.Diagnostics;



namespace Palkanlaskenta
{

    class Program
    {
        public static ConnectToDataBase connect = new ConnectToDataBase();
        static void Main(string[] args)
        {
            connect.CreateTables(connect.createConnect()); // Making sure that database tables exists
            Valikot menu = new Valikot();
            menu.Valikko();
        }
    }
}