using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs( int.Parse(Console.ReadLine()));
           int sumOfEven=GetSumOfEvenDigits(number);
            int sumOfOdd=GetSumOfOddDigits(number);
            Console.WriteLine(sumOfEven*sumOfOdd);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number!=0)
            {
                int digit = number % 10;
                if (digit%2==0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int even,int odd)
        {
            int result = even * odd;
            return result;
        }
    }
}
