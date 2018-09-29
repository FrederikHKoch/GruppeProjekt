using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Misc
    {
        public static void Load()
        {
            Console.WriteLine("Loading.");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("Loading..");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("Loading....");
            System.Threading.Thread.Sleep(100);
        }
        public static void Ask()
        {
            Console.WriteLine("Vil du gerne forsætte programmet? ");
            Console.WriteLine("Tryk på 'N' for at slutte ");
            Console.Write("Tryk på 'Y' for at forsætte: ");
        }
        public static void AskCar()
        {
            Console.WriteLine("1. Tilføje en bil til nuværende kunde");
            Console.WriteLine("2. Slette bil fra kunde");
            Console.WriteLine("3. Opdatere en bil til nuværende kunde");
        }
         public static void CustomerPart()
         {
            Console.WriteLine("1. Opret en ny kunde og bil");
            Console.WriteLine("2. Se kunde info");
            Console.WriteLine("3. Opdater kunde");
            Console.WriteLine("4. Slet kunde");
         }
         public static void ProgramStart()
        {
            Console.WriteLine("");
            Console.WriteLine("Autoværksteds App");
            Console.WriteLine("Gør alt herinde fra");
            Console.WriteLine("Vil du Arbejde med kunder, eller med biler?");
            Console.WriteLine("Vælg 'K' For Kunde --- Vælg 'B' For bil --- Vælg 'V' For værkstedbesøg");
        }
        public static void AutoChoice()
        {
            Console.WriteLine("Vælg 1. For at oprette et besøg");
            Console.WriteLine("Vælg 2. For at redigere et besøg");
            Console.WriteLine("Vælg 3. For at slette et besøg");
            Console.WriteLine("Vælg 4. For at se biler på værksted");
        }
        public static void WatchTabel()
        {
            SQLCon.SelectCustomer("Select * from customers");
            SQLCon.SelectCar("Select * from Car");
        }
        public static void WatchLog()
        {
            Console.WriteLine("Vælg bilens Registreringsnummer for at få vist værkstedsbesøg");
            string chooseCar = ErrorHandling.IsRegValid(Console.ReadLine());
            SQLCon.SelectLog("Select * from CarLog where RegNr = ('" + chooseCar + "')");
        }

        public static void ChooseAllWatchLog()
        {
            Console.WriteLine("Liste over alle biler på værkstedet");
            Console.WriteLine();
            SQLCon.SelectLog("Select * from CarLog");
        }

        public static void WatchLibrary()
        {
            Console.WriteLine("Vælg bilens RegNr for at se alle bilens værkstedsbesøg");
            string chooseCar = ErrorHandling.IsRegValid(Console.ReadLine());
            SQLCon.SelectLibrary("select * from CarLibrary where RegNr = ('" + chooseCar + "')");
        }

        public static void ChooseAllWatchLibrary()
        {
            Console.WriteLine("En liste over alle biler der har været på værksted");
            SQLCon.SelectLibrary("select * from CarLibrary");
        }
    }
}
