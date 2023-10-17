using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta.classes
{
    class Todentaminen
    {
        public static Valikot menu = new Valikot();
        public void login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
        }
        public void register()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            askPasswords();

        }
        private void askPasswords()
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Retype password: ");
            if (String.IsNullOrEmpty(password)) 
            {
                Console.WriteLine("Password cant be null");
                askPasswords();
;           }
            else
            {
                if (Console.ReadLine() == password)
                {
                    Console.Write("correct");
                }
                else
                {
                    Console.WriteLine("Passwords did not match");
                    askPasswords();
                }
            }
        }
    } 
}