using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC6_validateUperCasePassword
    {
        public void validateUperCasePassword(string ucPassword)
        {
            string stringForUCPassword = "^[A-Z]+.{8,}?";
            try
            {
                if (Regex.IsMatch(ucPassword, stringForUCPassword))
                    Console.WriteLine(ucPassword + " is Valid");
                else
                    Console.WriteLine(ucPassword + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
