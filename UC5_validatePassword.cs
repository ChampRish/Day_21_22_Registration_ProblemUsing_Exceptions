using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC5_validatePassword
    {
        public void validatePassword(string password)
        {
            string stringForPassword = "^.{8,}?";
            try
            {
                if (Regex.IsMatch(password, stringForPassword))
                    Console.WriteLine(password + " is Valid");
                else
                    Console.WriteLine(password + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
