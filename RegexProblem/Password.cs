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
            Regex password = new ("(?=.*[A-Z])[A-za-z0-9]{8,}$");
            Console.WriteLine("Enter your Password: ");
            string pass = Console.ReadLine();

            if (password.IsMatch(pass))
            {
                Console.WriteLine("The password is valid");
            }
            else
            {
                Console.WriteLine("The Password you entered is Invalid");
            }
        }
    }
}
