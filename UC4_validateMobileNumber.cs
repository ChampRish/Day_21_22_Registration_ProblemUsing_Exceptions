using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC4_validateMobileNumber
    {
        public void validateMobileNumber(string mobileNumber)
        {
            try
            {

                string stringForMobileNumber = "^[0-9]{10}";
                if (Regex.IsMatch(mobileNumber, stringForMobileNumber))
                    Console.WriteLine(mobileNumber + " is Valid MobileNumber");
                else
                    Console.WriteLine(mobileNumber + " is Invalid MobileNumber");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
