﻿using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstNum = currRow[0];
                int secondNum = currRow[1];

                if (i%2!=0)
                {
                    arr1[i - 1] = firstNum;
                    arr2[i - 1] = secondNum;
                }
                else
                {
                    arr1[i - 1] = secondNum;
                    arr2[i - 1] = firstNum;
                }
            }
            Console.WriteLine(String.Join(" ",arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}
