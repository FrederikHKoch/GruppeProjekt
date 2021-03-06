﻿using System;
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
                    Console.Clear();
                    switch (choice.ToUpper())
                    {
                        case "K":
                            Misc.CustomerPart();
                            int answer = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
                            Console.Clear();
                            switch (answer)
                            {
                                case 1:
                                    Costumer.Create();
                                    Console.Clear();
                                    Console.WriteLine("Tilføj nu bil til kunde");                                   
                                    Bil.Create();
                                    break;
                                case 2:
                                    Console.WriteLine("1. Se alle kunder og biler, sorteret");
                                    Console.WriteLine("2. Se enkelt kunde og bil(er)");
                                    int Watch = Convert.ToInt32(Console.ReadLine());
                                    switch (Watch)
                                    {
                                        case 1:
                                            Misc.WatchTabel();
                                            break;
                                        case 2:
                                            Misc.ShowCustomer();
                                            break;
                                        default:
                                            break;
                                    }
                                    Misc.WatchTabel();
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
                            int ChoiceCar = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
                            Console.Clear();
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
                                case 4:
                                    Bil.ViewCarSorted();
                                    break;
                                default:
                                    Console.WriteLine();
                                    break;
                            }
                            break;
                        case "V":
                            Misc.AutoChoice();
                            int workshopAnswer = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
                            Console.Clear();
                            switch (workshopAnswer)
                            {
                                case 1:
                                    WorkshopVisit.Create();
                                    break;
                                case 2:
                                    WorkshopVisit.Update();
                                    break;
                                case 3:
                                    WorkshopVisit.Delete();
                                    break;
                                case 4:
                                    WorkshopVisit.View();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            Misc.Load();
                            break;
                    }
                    Misc.Ask();
                    string Choice = Console.ReadLine();
                    Console.Clear();
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
