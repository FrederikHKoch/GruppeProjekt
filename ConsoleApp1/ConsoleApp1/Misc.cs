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
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading..");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Loading....");
            System.Threading.Thread.Sleep(5000);
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
        /*Console.WriteLine("Vil du gerne oprette en bil, til denne kunde?");
                          Console.Write("Tryk 'Y' for at oprette");
                          Console.WriteLine("Tryk 'N' For at slutte");
                          string answer2 = Console.ReadLine();

                          if (answer2.ToUpper() == "Y")
                          {
                              Bil.Create();
                          }
                          else
                          {
                              break;
                          }*/
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
            Console.WriteLine("Vælg 'K' For Kunde --- Vælg 'B' For bil");
        }
    }
}
