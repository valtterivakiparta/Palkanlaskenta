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
            Console.WriteLine("Hei, Anna valintasi.");
            Console.WriteLine("Valitsemalla 0 työntekijä lista");
            Console.WriteLine("Valitsemalla 1 Työtunnit");
            Console.WriteLine("Valitsemalla 2 Lisää työntekijä");
            Console.WriteLine("Valitsemalla 3 Lisää työtunteja");
            Console.WriteLine("Valitsemalla 4 työskentele tietokannan kanssa");

            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 0:
                    Console.WriteLine("Näytä työntekijät");

                    break;

                case 1:
                    Console.WriteLine("Näytä työtunnit");
                    break;

                case 2:
                    Console.WriteLine("Lisää työntekijä");
                    break;
                case 3:

                    Console.WriteLine("Lisää työtunnit");
                    break;

                case 4:
                    connect.CreateTable(connect.createConnect());
                    break;
            }
        }
    }
}