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
        public void addHours()   //tuntien lisäys funktio
        {
            int tunnit = Convert.ToInt32(Console.ReadLine());
        }
        public void addEmployee()    //työntekijän lisäsys funktio
        {
            Console.WriteLine("Anna työntekijän etunimi: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Anna työntekijän sukunimi: ");
            string lastName = Console.ReadLine();

            int age;
            do
            {
                Console.WriteLine("Työntekijän ikä: ");
            } while (!int.TryParse(Console.ReadLine(), out age));

            Console.WriteLine("Osoite: ");
            string address = Console.ReadLine();

            Console.WriteLine("Henkilötunnus: ");
            string ssn = Console.ReadLine();

            double salary;
            do
            {
                Console.WriteLine("Työntekijän palkka: ");
            } while (!double.TryParse(Console.ReadLine(), out salary));

        }
        public void paaValikko()
        {
            Console.WriteLine("Hei, valitse seuraavista");
            Console.WriteLine("Valitsemalla 0 Työntekijälista");
            Console.WriteLine("Valitsemalla 1 Työtunnit"); // --||--
            Console.WriteLine("Valitsemalla 2 Lisää työntekijä"); // funktio systeemi joka tarjoo lisätä työntekijän
            Console.WriteLine("Valitsemalla 3 Lisää työtunteja"); // funktio joka kysyy työtunnit yms
            Console.WriteLine("Valitsemalla 4 Työskentele tietokannan kanssa");

            int valinta = Convert.ToInt32(Console.ReadLine());

            switch (valinta)
            {
                case 0:
                    Console.WriteLine("Työntekijälista: ");
                    break;

                case 1:
                    Console.WriteLine("Työtuntisi: ");
                    break;

                case 2:
                    Console.WriteLine("Lisää työntekijä: ");
                    addEmployee();
                    break;
                case 3:
                    Console.WriteLine("Lisää työtunnit: ");
                    addHours();
                    break;
                case 4:
                    connect.CreateTables(connect.createConnect());
                    break;
            }
        }
    }
}
