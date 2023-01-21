using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Programs");
            Console.WriteLine("Please enter the option given below");           //Taking user input
            Console.WriteLine("1:First name\n2:Create last name\n3:Create valid Email ID\n4:Mobile number with country code\n5:Password Rule\n6:Uppar Case\n7:Numeric Number\n8:Spacial Charactor");
            Console.WriteLine("1 First name\n9:Create valid Emails");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //using switch case calling different method
            {
                case 1:
                    RegularExpressio.fisrtName();
                    break;
                case 2:
                    RegularExpressio.last Name();
                    break;
                case 3:
                    RegurExpress.validEmail();
                    break;
                case 4:
                    RegularExpression.phoneNumber();
                    break;
                case 5:
                    RegularExpression.password Rule();
                    break;
                case 6:
                    RegularExpression.UpparCase();
                    break;
                case 7:
                    RegularExpression.NumaricNumber();
                    break;
                case 8:
                    RegularExpression.Spacial ();
                    break;
                case 9:
                    RegularExpression.valid Emails();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}
