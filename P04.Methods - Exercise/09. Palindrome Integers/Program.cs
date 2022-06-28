using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            while (input!="END")
            {
                
                if (IsPalindrome(input))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                input = Console.ReadLine();
            }

        }
        static bool IsPalindrome(string number)
        {
            string reverseNum = "";
            for (int i = number.Length-1; i >= 0; i--)
            {
                char symbol = number[i];
                reverseNum += symbol;
            }
            if (reverseNum==number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
