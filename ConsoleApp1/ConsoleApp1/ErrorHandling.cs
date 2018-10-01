using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class ErrorHandling
    {
        public static string BigStartLetters(string input)
        {
            string fullName = "";
            string[] splitName = input.Split(' ');
            foreach (var streng in splitName)
            {
                fullName += streng.Substring(0, 1).ToUpper() + streng.Substring(1).ToLower() + " ";
            }
            return fullName.TrimEnd();
        }

        public static string IsNameValid(string input)
        {
            string fullName = "";
            string[] splitName = input.Split(' ');
            foreach (var xName in splitName)
            {
                if (Regex.IsMatch(xName, @"^[a-zA-ZæÆøØåÅ]+$"))
                {
                    fullName += xName + " ";
                }
                else
                {
                    throw new Exception();
                }
            }
            return fullName.TrimEnd();
        }

        public static string IsAddressValid(string input)
        {
            string textString = "";
            if (Regex.IsMatch(input, @"^[,.'^+?´`|/()][=¤%&\<>]+$"))
            {
                return textString = "Ugyldig adresse";
            }
            else
            {
                string[] textSplit = input.Split(' ');
                foreach (var unit in textSplit)
                {
                    if (unit.Contains("0-9"))
                    {
                        textString += unit;
                    }
                    else
                    {
                        textString += unit.Substring(0, 1).ToUpper() + unit.Substring(1).ToLower() + " ";
                    }
                }
                return textString;
            }
        }
        public static string IsNumberValid(string number)
        {
            if (Regex.IsMatch(number,@"^[0-9]+$"))
            {
                return number;
            }
            else
            {
                Console.Clear();
                throw new Exception("Må ikke indeholde tegn eller bogstaver. kun tal fra 0-9");
                
            }
        }
        public static string IsRegValid(string regNr)
        {
            string fullReg = "";
            foreach (char letter in regNr)
            {
                if (Regex.IsMatch(Convert.ToString(letter),@"^[a-zA-Z]+$"))
                {
                    fullReg += Convert.ToString(letter).ToUpper();
                }
                else
                {
                    fullReg += letter;
                }
            }
            return fullReg;
        }
        public static string IsFuelValid(string fuelInput)
        {
            string fuelString = "";
            foreach (char letter in fuelInput)
            {
                if (Regex.IsMatch(Convert.ToString(letter),@"^[dDiIeEsSlLBbyYfFrR952]+$"))
                {
                    if (Regex.IsMatch(Convert.ToString(letter), @"^[dDiIeEsSlLBbyYfFrR]+$"))
                    {
                        fuelString += letter;
                    }
                    else if (Regex.IsMatch(Convert.ToString(letter), @"^[952]+$"))
                    {
                        fuelString += letter;
                    }
                    else
                    {
                        throw new Exception("Der kan kun stå 'Diesel', 'Blyfri 92 - 95', eller 'El'");
                    }
                }
            }
            return fuelString;

        }
        

    }
}
