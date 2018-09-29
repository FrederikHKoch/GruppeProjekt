using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WorkshopVisit
    {
        public static void Create()
        {

            Console.WriteLine("Vælg Bil du gerne vil have på værksted(RegNr)");
            string regNrIN = ErrorHandling.IsRegValid(Console.ReadLine());
            string fullSentence = "INSERT INTO CarLog VALUES ((SELECT RegNr FROM Car WHERE RegNr = ('" + regNrIN + "')), GETDATE())";
            SQLCon.Insert(fullSentence);
        }

        public static void Update()
        {
            Console.WriteLine("Vælg værkstedsbesøg du gerne vil rette (RegNr)");
            string chooseCarLog = ErrorHandling.IsRegValid(Console.ReadLine()); 
            string fullSentence;
            int answerTwo = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));

            Console.WriteLine("Skriv din ændring");
            string retRegNr = ErrorHandling.IsRegValid(Console.ReadLine()); 
            fullSentence = "UPDATE CarLog SET RegNr = ('" + retRegNr + "') WHERE RegNr = ('" + chooseCarLog + "')";
            SQLCon.Update(fullSentence);
        }

        public static void Delete()
        {
            Console.WriteLine("Vælg bil du vil slette(RegNr) fra værkstedet");
            string delAnswer = ErrorHandling.IsRegValid(Console.ReadLine());
            string insertSentence = "insert into CarLibary(RegNr, VisitDate, LeftDate) Values ((select RegNr from CarLog where RegNr = ('" + delAnswer + "')), (select VisitDate from CarLog where RegNr = ('" + delAnswer + "')), GETDATE())";
            string fullSentence = "DELETE FROM CarLog WHERE RegNr = ('" + delAnswer + "')";
            SQLCon.Insert(insertSentence);
            SQLCon.Delete(fullSentence);
        }

        public static void View()
        {
            Console.WriteLine("Tryk 1. for at se en enkelt bil på værksted");
            Console.WriteLine("Tryk 2. for at se en liste over alle biler på værksted");
            Console.WriteLine("Tryk 3. for at se en liste over en enkelts bil samlede værkstedsbesøg");
            Console.WriteLine("Tryk 4. for at se en alle biler der har været på værksted");
            int choice = Convert.ToInt32(ErrorHandling.IsNumberValid(Console.ReadLine()));
            switch (choice)
            {
                case 1:
                    Misc.WatchLog();
                    break;
                case 2:
                    Misc.ChooseAllWatchLog();
                    break;
                case 3:
                    Misc.WatchLibrary();
                    break;
                case 4:
                    Misc.ChooseAllWatchLibrary();
                    break;
                default:
                    break;
            }
        }
       
    }
}
