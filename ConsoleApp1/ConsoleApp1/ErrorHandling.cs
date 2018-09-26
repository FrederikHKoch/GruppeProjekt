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

        }

    }
}
