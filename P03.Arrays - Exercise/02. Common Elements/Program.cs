using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
           // string[] newArr = new string[firstArray.Length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i]==firstArray[j])
                    {
                        // newArr[i] = secondArray[i];
                        Console.Write(secondArray[i]+" ");
                    }
                }
            }
        }
    }
}
