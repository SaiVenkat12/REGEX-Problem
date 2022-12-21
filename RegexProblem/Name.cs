using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Name
    {

        public void NameValidation()
        {
            Regex name = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter FirstName: ");
            string FName = Console.ReadLine();

            if (name.IsMatch(FName))
            {
                Console.WriteLine("your First name is: " + FName + " is valid");
            }
            else
            {
                Console.WriteLine("The name you entered is Invalid");
            }
        }
        public void LNameValidation()
        {
            Regex name = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter LastName: ");
            string LName = Console.ReadLine();

            if (name.IsMatch(LName))
            {
                Console.WriteLine(LName + " :your Last name is valid");
            }
            else
            {
                Console.WriteLine("The name you entered is Invalid");
            }
        }
    }
}
