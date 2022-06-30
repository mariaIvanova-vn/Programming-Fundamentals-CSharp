using System;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine().TrimStart(new char[] { '0' });
            int secondLine = int.Parse(Console.ReadLine());
            if (secondLine == 0)
            {
                Console.WriteLine(0);
                return;
            }
            List<int> result = new List<int>();
            int decimalReminder = 0;
            int currentMultiplication = 0;
            for (int i = firstLine.Length - 1; i >= 0; i--)
            {
                int currentDigit = firstLine[i] - '0';
                currentMultiplication = currentDigit * secondLine;
                currentMultiplication += decimalReminder;
                result.Add(currentMultiplication % 10);
                decimalReminder = currentMultiplication / 10;
            }
            if (decimalReminder > 0)
            {
                result.Add(decimalReminder);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
