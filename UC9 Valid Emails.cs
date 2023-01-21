using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    public class RegulExpress
    {
        public static void fisrtName()          //Created first name method
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Rushi" };
            TestPattern(pattern, arr);
        }
        public static void lastName()          //Created last name method
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Ubalkar" };
            TestPattern(pattern, arr);
        }
        public static void validEmail()          //Created email method
        {
            string pattern = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
            string[] arr = { "abc.xyz@bl.co.in" };
            TestPattern(pattern, arr);
        }
        public static void phoneNumber()          //Created phone number method
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] arr = { "91 8999319108" };
            TestPattern(pattern, arr);
        }
        public static void password()          //Created passward method
        {
            string pattern = "^[A-Z]{1}[a-z]{7,}(@|#|$|&)[0-9]{1}$";
            string[] arr = { "Ajkdlabhl@7", "Ahaskj#kl77" };
            TestPattern(pattern, arr);
        }
        public static void validateEmails()            //Created Email validating method
        {
            string pattern = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
            string[] arr = { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            TestPattern(pattern, arr);
        }
        public static void TestPattern(string pattern, string[] arr)            //Created Test pattern method
        {
            foreach (string inputs in arr)
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0} is valid", inputs);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", inputs);
                }
            }
        }
    }
}
