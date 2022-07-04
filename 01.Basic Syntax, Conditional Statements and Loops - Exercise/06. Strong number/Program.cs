using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int factorialSum = 0;

            for (int i = 0; i <= number.Length-1; i++)
            {
                char currCh = number[i];
                int currDigit = (int)currCh - 48;
                int currDigitFactorial = 1;
                for (int r = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                }
                factorialSum += currDigitFactorial;
            }
            if (factorialSum == int.Parse(number)) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
