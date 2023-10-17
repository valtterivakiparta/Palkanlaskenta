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





            // Databse integration ^^
        }
        public void register()
        {
            Console.Write("Username: ");            // asking username 
            string username = Console.ReadLine();   //getting input from user
            string email = askEmail();              // calling function that asks email address and stores that email value to email variable

            foreach (char item in email)            // loopping throught email variable as long as loop can fint this character @ to make sure it is email that user inputted
            {
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Invalid email address. It must contain '@'.");
                    askEmail(); // Re-ask for email
                }
                break;
            };
            askTel();                               // same thing here as with email functions    Missing code here 
            askPasswords();
            // Ask other information ^^
        }
        private string askTel()
        {
            Console.Write("Tel Number: ");
            string telNumber = Console.ReadLine();
            if (telNumber == null)
            {
                askEmail();
            }
            return telNumber;
        }
        private string askEmail()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (email == null)
            {
                askEmail();
            }
            return email;
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
                ;
            }
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