﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration
{
    class Validation
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public const string Regex_Password = "[\\S]{8,}";
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool ValidateMobile(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);
        }
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
    }
}
