using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] token = command.Split();
                string action = token[0];
                if (action=="Add")
                {
                    int numToAdd = int.Parse(token[1]);
                    numbers.Add(numToAdd);
                }
                else if (action=="Remove")
                {
                    int numToRemove = int.Parse(token[1]);
                    numbers.Remove(numToRemove);
                }
                else if (action=="RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (action == "Insert")
                {
                    int indexToInsert = int.Parse(token[2]);
                    int numberToInsert = int.Parse(token[1]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
