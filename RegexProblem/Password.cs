using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Password
    {
        public void PassValidation()
        {
            Regex password = new ("(?=.*[A-Z])(?=.*[0-9])(?=.*[.,/+_@!#$%&*]{1}).{8,}$");
            Console.WriteLine("Enter the Password: ");
            string pass = Console.ReadLine();

            if (password.IsMatch(pass))
            {
                Console.WriteLine("The password is Valid");
            }
            else
            {
                Console.WriteLine("The Password you entered is InValid");
            }
        }
    }
}
