using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Regex
{
    public class RegulaEx
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
