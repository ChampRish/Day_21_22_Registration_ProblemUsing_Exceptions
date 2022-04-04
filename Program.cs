using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21_Registration_ProblemUsing_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC1_ValidFirstName firstname = new UC1_ValidFirstName();
            firstname.validateFirstName("Rishabh");

            UC2_ValidlastName lastName = new UC2_ValidlastName();
            lastName.validateLastName("Gupta");

            UC3_validateEmailId emailValid = new UC3_validateEmailId();
            emailValid.validateEmailId("ggupta123@gmail.com");

            UC4_validateMobileNumber phoneNumber = new UC4_validateMobileNumber();
            phoneNumber.validateMobileNumber("9627974345");

            UC5_validatePassword password = new UC5_validatePassword();
            password.validatePassword("GGupta@1234");

            UC6_validateUperCasePassword UpperCase = new UC6_validateUperCasePassword();
            UpperCase.validateUperCasePassword("G12345678");

            UC7_validateNumericPassword NumericPass = new UC7_validateNumericPassword();
            NumericPass.validateNumericPassword("12345678");

            UC8_Special_Character special = new UC8_Special_Character();
            special.SpecialPassword("12Rish@fyjf");
        }
    }
}
