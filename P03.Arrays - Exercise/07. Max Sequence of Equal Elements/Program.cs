using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int maxIndex = 0;
            int index = inputArr[0];
            int best = 0;
            
            for (int i = 1; i < inputArr.Length; i++)
            {
                if (index==inputArr[i])
                {
                    count++;
                }
                else
                {
                    index = inputArr[i];
                    count = 1;
                }
                if (count>best)
                {
                    best = count;
                    maxIndex = inputArr[i];
                }
            }
            for (int i = 0; i < best; i++)
            {
                Console.Write($"{maxIndex} ");
            }
           
        }
    }
}
