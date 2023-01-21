using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    public class RegularExpressio
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
        public static void passward()          //Created phone number method
        {
            string pattern = "^[a-zA-Z]{8,}$";
            string[] arr = { "ajkdlabh", "haskjkl" };
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
