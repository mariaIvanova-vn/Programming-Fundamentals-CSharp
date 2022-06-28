using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command=Console.ReadLine())!="End")
            {
                string[] cmdArgs = command.Split().ToArray();
                string cmdType = cmdArgs[0];
                if (cmdType=="Add")
                {
                    int appendNum = int.Parse(cmdArgs[1]);
                    numbers.Add(appendNum);
                }
                else if (cmdType=="Insert")
                {
                    int insertNum = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]); 
                    if (index<0 ||index>=numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, insertNum);
                }
                else if (cmdType=="Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);
                    if (removeIndex<0 || removeIndex>=numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeIndex);
                }
                else if (cmdType=="Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    if (direction=="left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (direction=="right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;
            for (int i = 0; i < realCount; i++)
            {
                int firstEl = numbers[0];
                numbers.Remove(firstEl);
                numbers.Add(firstEl);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realCount = count % numbers.Count;
            for (int i = 1; i <= realCount; i++)
            {
                int lastEl = numbers.Last();
                numbers.RemoveAt(numbers.Count-1);
                numbers.Insert(0,lastEl);
            }
        }
    }
}
