using System;

namespace User_Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to registration form regex apllication by Laksh Mehta");
            Validation regexValidation = new Validation();
            Console.Write("Enter Your First Name::-");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateFirstName(FirstName));
            Console.Write("Enter Your Last Name:-");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateLastName(LastName));
            Console.WriteLine("Enter Your Email Address::-");
            string Email = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateEmail(Email));
            Console.WriteLine("Enter Your Mobile Number:-");
            string MobileNumber = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidateMobile(MobileNumber));
            Console.WriteLine("Enter Your Password");
            string Password = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword(Password));
        }
    }
}
