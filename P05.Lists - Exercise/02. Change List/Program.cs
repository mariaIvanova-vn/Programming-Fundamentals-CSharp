using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = command.Split().ToArray();
                string cmdType = cmdArgs[0];
                if (cmdType== "Delete")
                {
                    int givenEl = int.Parse(cmdArgs[1]);
                    numbers.RemoveAll(x=>x==givenEl);
                }
               else if (cmdType == "Insert")
                {
                    int givenEl = int.Parse(cmdArgs[1]);
                    int position= int.Parse(cmdArgs[2]);
                    numbers.Insert(position, givenEl);
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
