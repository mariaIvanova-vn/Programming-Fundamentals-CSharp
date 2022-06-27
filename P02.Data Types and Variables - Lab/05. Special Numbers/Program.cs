using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int numToProcess = i;
                int sum = 0;
                while (numToProcess!=0)
                {
                    int currDigit = numToProcess % 10;
                    numToProcess = numToProcess / 10;
                    sum += currDigit;
                }
                if (sum==5 || sum==7 || sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
