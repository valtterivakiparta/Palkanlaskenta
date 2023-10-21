using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string telNumber = askTel();            // same thing here as with email functions    Missing code here 
            string passWord = askPasswords();
            login();                                //lisätty funtkio, jotta jatkuu registerin jälkee suoraa login kohtaa ja jne

        }
        private string askTel()
        {
            string telNumber;
            Console.Write("Tel Number: ");
            telNumber = Console.ReadLine();
            if (String.IsNullOrEmpty(telNumber))
            {
                Console.WriteLine("Invalid phone number");
                askTel();
            }
            else if (isDigitOnly(telNumber) == false)
            {
                Console.WriteLine("Invalid phone number");
                askTel();
            }
            return telNumber;
        }
        bool isDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                    
                }
            }
            return true;
        }
        private string askEmail()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (String.IsNullOrEmpty(email))
            {
                askEmail();
            }

            foreach (char item in email)            // loopping throught email variable as long as loop can fint this character @ to make sure it is email that user inputted
            {
                if (!email.Contains("@"))
                {
                    Console.WriteLine("Invalid email address");
                    askEmail(); // Re-ask for email
                }
                break;
            }
            return email;
        }
        private string askPasswords()
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
                    Console.WriteLine("correct");
                }
                else
                {
                    Console.WriteLine("Passwords did not match");
                    askPasswords();
                }
            }
            return password;
        }

    }
}