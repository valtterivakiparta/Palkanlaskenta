using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta.classes
{
    class todentaminen
    {
        public static Valikot menu = new Valikot();


        
        
        
        
        
        public bool login()
        {

            Console.WriteLine("Ole hyvä ja syötä käyttäjätunnus");
           string kayttis = Console.ReadLine();
            Console.WriteLine("Ole hyvä ja syötä salasana");
          string salis = Console.ReadLine();
             
           if (kayttis == kayttis1) { }
         
            return true;
            
        }



        public string register()
        {
            Console.WriteLine("Ole hyvä ja syötä käyttäjätunnus");
            string kayttis1 = Console.ReadLine();

            Console.WriteLine("Ole hyvä ja syötä salasana");
            string salis1 = Console.ReadLine();

            Console.WriteLine("Ole hyvä ja syötä salasana uudelleen");
            string salis2 = Console.ReadLine();

            while (salis1 != salis2)
            {
                Console.WriteLine("Salasanat eivät täsmää. Yritä uudelleen.");
                Console.WriteLine("Ole hyvä ja syötä salasana");
                salis1 = Console.ReadLine();

                Console.WriteLine("Ole hyvä ja syötä salasana uudelleen");
                salis2 = Console.ReadLine();

                


                
                


                   
            }

            menu.Valikko();
            Console.WriteLine("Rekisteröityminen onnistui");

            return kayttis1, salis1;

        }
    } 
}