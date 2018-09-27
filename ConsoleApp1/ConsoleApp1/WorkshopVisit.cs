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
            string regNrIN = Console.ReadLine();
            string fullSentence = "INSERT INTO CarLog VALUES ((SELECT RegNr FROM Car WHERE RegNr = ('" + regNrIN + "')), GETDATE())";
            SQLCon.Insert(fullSentence);
        }



        public static void Update()
        {
            Console.WriteLine("Vælg værkstedsbesøg du gerne vil rette");
            int chooseCarLog = Convert.ToInt32(Console.ReadLine());
            string fullSentence;
            int answerTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv din ændring");
            string retRegNr = Console.ReadLine();
            fullSentence = "UPDATE CarLog SET RegNr = ('" + retRegNr + "') WHERE RegNr = ('" + chooseCarLog + "')";
            SQLCon.Update(fullSentence);
        }

        public static void Delete()
        {
            Console.WriteLine("Vælg værkstedsbesøg du vil slette(RegNr)");
            int delAnswer = Convert.ToInt32(Console.ReadLine());
            string fullSentence = "DELETE FROM CarLog WHERE RegNr = ('" + delAnswer + "')";
            SQLCon.Delete(fullSentence);
        }
    }
}
