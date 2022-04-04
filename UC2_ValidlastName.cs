using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC2_ValidlastName
    {
        public void validateLastName(string lastName)
        {
            try
            {

                string stringForLastName = "^[A-Z][a-z]{3,}?";
                if (Regex.IsMatch(lastName, stringForLastName))
                    Console.WriteLine(lastName + " is Valid Lastname");
                else
                    Console.WriteLine(lastName + " is Invalid Lastname");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
