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

            Console.WriteLine("Indtast bilens model");
            string modelIN = Console.ReadLine();
            Console.WriteLine("Indtast bilens mærke");
            string brandIN = Console.ReadLine();
            Console.WriteLine("Hvad er bilens registrerings nummer?");
            string regIN = Console.ReadLine();
            Console.WriteLine("Hvor mange km har bilen kørt?");
            int kmIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hvilken type brandstof bruger bilen?");
            string fuelIN = Console.ReadLine();
            Console.WriteLine("Hvilket år er bilen fra?");
            int yearIN = Convert.ToInt32(Console.ReadLine());
            string fullStatement = "insert into Car (Model, Brand, RegNr, KiloMeter, Fuel, [Year]) values ('" + modelIN + "','" +brandIN + "','" + regIN + "', " + kmIN + ", '" + fuelIN + "', " + yearIN + ")";
            SQLCon.Insert(fullStatement);
        }

        public static void Delete()
        {
            Console.WriteLine("Vælg kunde du vil slette bil (Regnr)");
            string delAnswer = Console.ReadLine();
            string fullSentence = "delete from car where RegNr = ('" + delAnswer + "')";
            SQLCon.Delete(fullSentence);
        }

        public static void Update()
        {
            Console.WriteLine("Vælg bil du vil rette (Reg-Nr)");
            int chooseCar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vælg hvad du vil rette");
            Console.WriteLine("1. Km");
            Console.WriteLine("2. Fuel");            
            string fullSentence;
            int answerTwo = Convert.ToInt32(Console.ReadLine());
            switch (answerTwo)
            {
                case 1:
                    Console.Write("Skriv din ændring: ");
                    string retKM = Console.ReadLine();
                    fullSentence = "update car set KiloMeter = ('" + retKM + "') where RegNr = ('" + chooseCar + "')";
                    SQLCon.Update(fullSentence);
                    break;

                case 2:
                    Console.Write("Skriv din ændring: ");
                    string retFuel = Console.ReadLine();
                    fullSentence = "update car set Fuel = ('" + retFuel + "') where RegNr = ('" + chooseCar + "')";
                    SQLCon.Update(fullSentence);
                    break;
            }
        }
    }
    //public string Model { get; set; }
    //public string Brand { get; set; }
    //public string Fuel { get; set; }
    //public int RegNr { get; set; }
    //public int Year { get; set; }
    //public int KiloMeter { get; set; }


}

