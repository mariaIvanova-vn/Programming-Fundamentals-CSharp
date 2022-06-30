using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string str1 = input[0];
            string str2 = input[1];
            int totalSum = 0;
            int minLen = Math.Min(str1.Length, str2.Length);
            int maxLen = Math.Max(str1.Length, str2.Length);
            string longer = string.Empty;
            for (int i = 0; i < minLen; i++)
            {
                totalSum += (int)(str1[i]* str2[i]);
            }
            if (str1.Length > str2.Length)
            {
                longer = str1;
                for (int i = minLen; i < maxLen; i++)
                {
                    totalSum += longer[i];
                }
            }
            else
            {
                longer = str2;
                for (int i = minLen; i < maxLen; i++)
                {
                    totalSum += longer[i];
                }
            }
            Console.WriteLine(totalSum.ToString());
        }
    }
}
