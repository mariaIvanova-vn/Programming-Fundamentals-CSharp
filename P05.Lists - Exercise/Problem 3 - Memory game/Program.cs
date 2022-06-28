using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Memory_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            int numIter = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                numIter++;
                string[] cmdArgs = command.Split().ToArray();
              //  int[] cmdArgs = command.Split(" ").Select(int.Parse).ToArray();
                int left = int.Parse(cmdArgs[0]);
                int right = int.Parse(cmdArgs[1]);

                if (left < 0 || right < 0 || left >= numbers.Count || right >= numbers.Count || left == right)
                {
                    numbers.Insert(numbers.Count / 2, $"-{numIter}a");
                    numbers.Insert(numbers.Count / 2, $"-{numIter}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                if (left >= 0 && right >= 0 && left < numbers.Count && right < numbers.Count && left != right)
                {
                    if (numbers[left] == numbers[right])
                    {

                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[left]}!");
                        if (left > right)
                        {
                            numbers.RemoveAt(left);
                            numbers.RemoveAt(right);
                        }
                        else
                        {
                            numbers.RemoveAt(right);
                            numbers.RemoveAt(left);
                        }

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numIter} turns!");
                            return;
                        }
                    }
                    else if (numbers[left] != numbers[right])
                    {
                        Console.WriteLine("Try again!");
                    }

                }
               
                
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
