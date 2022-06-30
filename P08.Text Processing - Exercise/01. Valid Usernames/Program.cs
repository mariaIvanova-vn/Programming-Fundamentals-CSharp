using System;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine().Split(", ");
            StringBuilder validUserName = new StringBuilder();
            foreach (var user in userName)
            {
                if (user.Length >= 3 && user.Length <= 16 && IsValid(user))
                {
                    validUserName.Append(user);
                    Console.WriteLine(user);                   
                }
            }
        }
        private static bool IsValid(string user)
        {
            foreach (var ch in user)
            {
                if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                {
                    return false;
                }
            } 
            return true;
        }
    }
}
