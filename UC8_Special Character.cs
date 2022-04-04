using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC8_Special_Character
    {
        public void SpecialPassword(string specialvalidate)
        {
            try
            {
                string RegexPattern = "^[a-zA-Z0-9]{1,}[@_?&*;:!$]{1}[a-zA-Z0-9]{1,}$";
                
                if (Regex.IsMatch(specialvalidate, RegexPattern))
                    Console.WriteLine(specialvalidate + " is Valid");
                else
                    Console.WriteLine(specialvalidate + " is Invalid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
        
    }
}
