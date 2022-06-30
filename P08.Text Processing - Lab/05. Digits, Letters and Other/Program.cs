using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder otherChar = new StringBuilder();

            string text = Console.ReadLine();
            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if (char.IsNumber(item))
                {
                    numbers.Append(item);
                }
                else
                {
                    otherChar.Append(item);
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(otherChar);
        }
    }
}
