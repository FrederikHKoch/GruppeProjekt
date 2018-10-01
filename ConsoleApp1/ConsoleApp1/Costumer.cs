using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Costumer
    {
        public static void Create()
        {
            Console.WriteLine("Indtast kundens navn");
            string kundeIN = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine()));
            Console.WriteLine("Adresse");
            string addIN = ErrorHandling.IsAddressValid(Console.ReadLine());
            Console.WriteLine("Indtast kundens alder");
            int ageIN = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            string fullStatement = "insert into customers values ('" + kundeIN + "','" + addIN + "'," + ageIN + ", getdate())";
            SQLCon.Insert(fullStatement);
        }

        public static void Delete()
        {
            Console.WriteLine("Vælg kunde du vil slette (Kundeid)");
            int delAnswer = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            string fullSentence = "delete from customers where id = ('" + delAnswer + "')";
            SQLCon.Delete(fullSentence);
        }

        public static void Update()
        {
            Console.WriteLine("Vælg kunde du vil rette (Kunde id)");
            int chooseCustomer = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            Console.WriteLine("Vælg hvad du vil rette");
            Console.WriteLine("1. Navn");
            Console.WriteLine("2. Adresse");
            Console.WriteLine("3. Alder");
            string fullSentence;
            int answerTwo = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            switch (answerTwo)
            {
                case 1:
                    Console.Write("Skriv din ændring: ");
                    string retNavn = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine())); //Fejlhåndteret
                    fullSentence = "update customers set navn = ('" + retNavn + "') where id = ('" + chooseCustomer + "')";
                    SQLCon.Update(fullSentence);
                    break;
                case 2:
                    Console.Write("Skriv din ændring: ");
                    string retAdr = ErrorHandling.IsAddressValid(Console.ReadLine());
                    fullSentence = "update customers set adr = ('" + retAdr + "') where id = ('" + chooseCustomer + "')";
                    SQLCon.Update(fullSentence);
                    break;
                case 3:
                    Console.Write("Skriv din ændring: ");
                    int retAlder = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
                    fullSentence = "update customers set alder = ('" + retAlder + "') where id = ('" + chooseCustomer + "')";
                    SQLCon.Update(fullSentence);
                    break;
            }
        }
    }
}
