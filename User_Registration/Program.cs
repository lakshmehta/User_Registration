using System;
using System.Collections.Generic;

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
            List<string> validEmailList = new List<string>()
            { "abc@yahoo.com", "abc-100@yahoo.com" ,"abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};

            foreach (string emails in validEmailList)
            {
                if (regexValidation.ValidateEmail(Email))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

            List<string> invalidEmailList = new List<string>()
            {"abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com",
             "abc@%*.com","abc..2002@gmail.com}","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au" };

            foreach (string emails in invalidEmailList)
            {
                if (regexValidation.ValidateEmail(Email))
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

        }
    }
}
