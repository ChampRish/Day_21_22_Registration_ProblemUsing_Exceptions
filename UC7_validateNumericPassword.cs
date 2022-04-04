using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC7_validateNumericPassword
    {
        public void validateNumericPassword(string NumericPassword)
        {
            try
            {
                string stringForNumericPassword = "^.{8,}?";
                if (Regex.IsMatch(NumericPassword, stringForNumericPassword))
                    Console.WriteLine(NumericPassword + " is Valid");
                else
                    Console.WriteLine(NumericPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
