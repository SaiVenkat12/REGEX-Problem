using System;
namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration ");
            //Name FirstName = new Name();
            //FirstName.NameValidation();

            //Name LastName = new Name();
            //LastName.LNameValidation();

            Email EMail = new Email();
            EMail.EmailValidation();
        }
    }
}