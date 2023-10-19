using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta.classes
{
     class Valikot
    {
        public static Todentaminen signin = new Todentaminen();
        public static ConnectToDataBase connect = new ConnectToDataBase();
        public void Valikko()

        {
            Console.WriteLine("1. kirjaudut");
            Console.WriteLine("2. rekisteröidy");
            int valinta = Convert.ToInt32(Console.ReadLine());

            switch (valinta)
            {
                case 1:

                    signin.login();


                    break;

                case 2:
                    
                    signin.register();

                    break;
            }
        }
        public void paaValikko()
        {
            Console.WriteLine("Hei, Anna valintasi.");
            Console.WriteLine("Valitsemalla 0 työntekijä lista");
            Console.WriteLine("Valitsemalla 1 Työtunnit"); // --||--
            Console.WriteLine("Valitsemalla 2 Lisää työntekijä"); // funktio systeemi joka tarjoo lisätä työntekijän
            Console.WriteLine("Valitsemalla 3 Lisää työtunteja"); // funktio joka kysyy työtunnit yms
            Console.WriteLine("Valitsemalla 4 työskentele tietokannan kanssa");

            int valinta = Convert.ToInt32(Console.ReadLine());

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
                    connect.CreateTables(connect.createConnect());
                    break;
            }
        }
    }
}
