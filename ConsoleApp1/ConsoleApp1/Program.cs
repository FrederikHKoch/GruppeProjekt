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
                try
                {
                    Misc.ProgramStart();
                    string choice = Console.ReadLine();
                    switch (choice.ToUpper())
                    {
                        case "K":
                            Misc.CustomerPart();
                            int answer = Convert.ToInt32(Console.ReadLine());
                            switch (answer)
                            {
                                case 1:
                                    //Costumer.Create();
                                    Console.WriteLine("Tilføj nu bil til kunde");
                                    Bil.Create();
                                    break;
                                case 2:
                                    Misc.ChooseCustomer();
                                    string customerChoice = Console.ReadLine();
                                    switch (customerChoice.ToUpper())
                                    {
                                        case "A":
                                            SQLCon.SelectCustomer("Select * from customers");
                                            SQLCon.SelectCar("Select * from Car");
                                            //SQLCon.Select("Select * from CarLog");
                                            //SQLCon.Select("Select * from CarLibary");
                                            break;
                                        case "E":
                                            SQLCon.SelectCustomer("Select * from customers where id = ()");
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case 3:
                                    Costumer.Update();
                                    break;
                                case 4:
                                    Costumer.Delete();
                                    Bil.Delete();
                                    break;
                            }
                            break;
                        case "B":
                            Misc.AskCar();
                            int ChoiceCar = Convert.ToInt32(Console.ReadLine());
                            switch (ChoiceCar)
                            {
                                case 1:
                                    Bil.AddCar();
                                    break;
                                case 2:
                                    Bil.Delete();
                                    break;
                                case 3:
                                    Bil.Update();
                                    break;
                                default:
                                    Console.WriteLine();
                                    break;
                            }
                            break;
                        default:
                            Misc.Load();
                            break;


                    }
                    Misc.Ask();
                    string Choice = Console.ReadLine();
                    if (Choice.ToUpper() == "Y")
                    {
                    }
                    else
                    {
                        Misc.Load();
                        done = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            while (done);            
        }
    }
}
