using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmdArgs = command.Split().ToArray();

                if (cmdArgs.Length==2)
                {
                    int passFromNewVagon = int.Parse(cmdArgs[1]);
                    numbers.Add(passFromNewVagon);
                }
                else if(cmdArgs.Length==1)
                {
                    int passToAdd = int.Parse(cmdArgs[0]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]+passToAdd<=num)
                        {
                            numbers[i] += passToAdd;
                            break;
                        }
                        
                    }                  
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
