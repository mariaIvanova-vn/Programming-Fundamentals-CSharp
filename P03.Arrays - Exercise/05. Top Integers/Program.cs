using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] topInteger = new int[array.Length];
            int topIntIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];
                bool isTopInt = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (currNum<=array[j])
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    topInteger[topIntIndex] = currNum;
                    topIntIndex++;
                }
            }
            for (int i = 0; i < topIntIndex; i++)
            {
                int currTopInt = topInteger[i];
                Console.Write($"{currTopInt} ");
            }
        }
    }
}
