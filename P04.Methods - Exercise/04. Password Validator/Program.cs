using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            bool IsPassValid = ValidatePassword(password);
            
            if (IsPassValid)
            {
                Console.WriteLine("Password is valid");
            }
            
            static bool ValidatePassword(string password)
            {
                bool isPasswordValid = true;
                if (!LengthPass(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    isPasswordValid = false;
                }
                if (!IsValidLetterOrDigit(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isPasswordValid = false;
                }
                if (!ValidMinCountDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    isPasswordValid = false;
                }
                return isPasswordValid;
            }

        }
        static bool LengthPass(string password)
        {
            if (password.Length>=6 && password.Length<=10)
            {
                return true;
            }
            return false; 
        }
        static bool IsValidLetterOrDigit(string password)
        {
            foreach (char ch in password) 
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            
            }
            return true;
        }
        static bool ValidMinCountDigits(string password)
        {
            int digitCount = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }
            return digitCount >= 2;
           // return digitCount >= 2;
        }

    }
}
