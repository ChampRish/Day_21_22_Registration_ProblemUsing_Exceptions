using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class UC3_validateEmailId
    {
        public void validateEmailId(string emailID)

        {
            try
            {
                string stringForEmailId = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$";
                if (Regex.IsMatch(emailID, stringForEmailId))
                    Console.WriteLine(emailID + " is Valid EmailId");
                else
                    Console.WriteLine(emailID + " is Invalid EmailId");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
