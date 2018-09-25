using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = true;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Autoværksteds App");
                Console.WriteLine("Gør alt herinde fra");

                Console.WriteLine("1. Opret en ny kunde og bil");
                Console.WriteLine("2. Se kunde info");
                Console.WriteLine("3. Opdater kunde");
                Console.WriteLine("4. Slet kunde");

                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Costumer.Create();
                        Console.WriteLine("Vil du gerne oprette en bil, til denne kunde?");
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
                        }                        
                        break;
                    case 2:
                        SQLCon.Select("Select * from customers");
                        SQLCon.Select("Select * from Car");
                        break;
                    case 3:
                        Costumer.Update();
                        Bil.Update();
                        break;
                    case 4:
                        Costumer.Delete();
                        Bil.Delete();
                        break;
                }
                //Console.ReadLine();
                Console.WriteLine("Vil du gerne forsætte programmet? ");
                Console.WriteLine("Tryk på 'N' for at slutte ");
                Console.Write("Tryk på 'Y' for at forsætte: ");
                string Choice = Console.ReadLine();
                if (Choice.ToUpper() == "Y")
                {                    
                }
                else
                {
                    done = false;
                }
            }
            while (done);            
        }
    }
}
