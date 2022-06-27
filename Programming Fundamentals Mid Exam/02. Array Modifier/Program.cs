using System;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];
                if (cmdType== "swap")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);
                    (numbers[firstIndex], numbers[secondIndex]) = (numbers[secondIndex], numbers[firstIndex]);
                }
                else if (cmdType== "multiply")
                {
                    int firstIndex = int.Parse(cmdArgs[1]);
                    int secondIndex = int.Parse(cmdArgs[2]);
                    numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
                }
                else if (cmdType == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -=1;
                    }
                }
            }
            Console.WriteLine(String.Join(", ",numbers));
        }        
    }
}
