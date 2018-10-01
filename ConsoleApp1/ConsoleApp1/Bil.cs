using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bil
    {

        public static void Create()
        {
            Console.WriteLine("Vælg den kundes kundeNr du vil tilføje en bil til");
            int idChoice = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            Console.WriteLine("Indtast bilens model");
            string modelIN = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine()));
            Console.WriteLine("Indtast bilens mærke");
            string brandIN = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine()));
            Console.WriteLine("Hvad er bilens registrerings nummer?");
            string regIN = ErrorHandling.IsRegValid(Console.ReadLine());
            Console.WriteLine("Hvor mange km har bilen kørt?");
            int kmIN = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            Console.WriteLine("Hvilken type brandstof bruger bilen?");
            string fuelIN = ErrorHandling.IsFuelValid(Console.ReadLine());
            Console.WriteLine("Hvilket år er bilen fra?");
            int yearIN = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            string fullStatement = "insert into Car (id, Model, Brand, RegNr, KiloMeter, Fuel, [Year]) values ((select id from customers where id =(" + idChoice + ")),'" + modelIN + "','" + brandIN + "','" + regIN + "', " + kmIN + ", '" + fuelIN + "', " + yearIN + ")";
            SQLCon.Insert(fullStatement);
        }
        public static void Delete()
        {
            Console.WriteLine("Vælg kunde du vil slette bil (Regnr)");
            string delAnswer = ErrorHandling.IsRegValid(Console.ReadLine());
            string fullSentence = "delete from car where RegNr = ('" + delAnswer + "')";
            SQLCon.Delete(fullSentence);
        }
        public static void Update()
        {
            Console.WriteLine("Vælg bil du vil rette (Reg-Nr)");
            string chooseCar = ErrorHandling.IsRegValid(Console.ReadLine());
            Console.WriteLine("Vælg hvad du vil rette");
            Console.WriteLine("1. Km");
            Console.WriteLine("2. Fuel");            
            string fullSentence;
            int answerTwo = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            switch (answerTwo)
            {
                case 1:
                    Console.Write("Skriv din ændring: ");
                    int retKM = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
                    fullSentence = "update car set KiloMeter = ('" + retKM + "') where RegNr = ('" + chooseCar + "')";
                    SQLCon.Update(fullSentence);
                    break;

                case 2:
                    Console.Write("Skriv din ændring: ");
                    string retFuel = ErrorHandling.IsFuelValid(Console.ReadLine());
                    fullSentence = "update car set Fuel = ('" + retFuel + "') where RegNr = ('" + chooseCar + "')";
                    SQLCon.Update(fullSentence);
                    break;
            }
        }
        public static void AddCar()
        {
            Console.WriteLine("Tilføj en bil pr kunde (Kundes Id)");
            int CostumerId = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            Console.WriteLine("Indtast bilens model");
            string modelIN = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine()));
            Console.WriteLine("Indtast bilens mærke");
            string brandIN = ErrorHandling.BigStartLetters(ErrorHandling.IsNameValid(Console.ReadLine()));
            Console.WriteLine("Hvad er bilens registrerings nummer?");
            string regIN = ErrorHandling.IsRegValid(Console.ReadLine());
            Console.WriteLine("Hvor mange km har bilen kørt?");
            int kmIN = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            Console.WriteLine("Hvilken type brandstof bruger bilen?");
            string fuelIN = ErrorHandling.IsFuelValid(Console.ReadLine());
            Console.WriteLine("Hvilket år er bilen fra?");
            int yearIN = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            string fullSentence = "insert into Car (id, Model, Brand, RegNr, KiloMeter, Fuel, [Year]) values ((select id from customers where id =(" + CostumerId + ")),'" + modelIN + "','" + brandIN + "','" + regIN + "', " + kmIN + ", '" + fuelIN + "', " + yearIN + ")";
            SQLCon.Update(fullSentence);
        }
        public static void ViewCarSorted()
        {
            Console.WriteLine("Vælg den bil du vil se 'RegNr'");
            string CarRegNr = Console.ReadLine();
            SQLCon.SelectCar("select * from Car where RegNr = ('" + CarRegNr + "')");
        }

    }
}

