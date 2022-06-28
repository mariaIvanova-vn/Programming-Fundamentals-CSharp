using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (IsDivisible(i) && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsDivisible(int num)
        {
            int sum = 0;
            while (num>0)
            {
                sum += num % 10;
                num /= 10;
            }
            bool isDiv = sum % 8 == 0;
            return isDiv;
        }
        static bool OddDigit(int num)
        {
            while (num>0)
            {
                int currDigit = num % 10;
                if (currDigit%2==1)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
