using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Email
    {
        public void EmailValidation()
        {
            Regex email = new ("^[a-zA-Z0-9]([.+-_]{0,1}[a-zA-z0-9]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,}([.]{0,1}[A-Za-z]{2,}?([.]{0,1}[A-Za-z]{2,}))*[,]{0,1}$");
            Console.WriteLine("Enter your Email: ");
            string mail = Console.ReadLine();

            if (email.IsMatch(mail))
            {
                Console.WriteLine(mail + "  EMAIL is valid");
            }
            else
            {
                Console.WriteLine("The Email you entered is Invalid");
            }
        }
    }
}
