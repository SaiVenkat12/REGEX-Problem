using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class MobileNo
    {
        public void MobileNumber()
        {
            Regex num = new ("^[0-9]{2}[ ]*[6-9]{1}[0-9]{9}$");
            Console.WriteLine("Enter the Mobile Number: ");
            string mobile = Console.ReadLine();

            if (num.IsMatch(mobile))
            {
                Console.WriteLine("your Mobile Number : " + mobile + " is valid");
            }
            else
            {
                Console.WriteLine("The Mobile number you entered is Invalid");
            }
        }
    }
}
