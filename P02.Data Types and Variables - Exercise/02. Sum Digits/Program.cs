using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                char currCh = num[i];
                int currNum = int.Parse(currCh.ToString());
                
                sum += currNum;
            }

            Console.WriteLine(sum);

        }
    }
}
