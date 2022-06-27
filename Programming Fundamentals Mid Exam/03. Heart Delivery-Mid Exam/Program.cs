using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            int currPosition = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = command.Split();
                int num = int.Parse(cmdArgs[1]);
                if (currPosition+num>=neighborhood.Count)
                {
                    currPosition = 0;
                }
                else
                {
                    currPosition += num;
                }
                neighborhood[currPosition] -= 2;
                if (neighborhood[currPosition]==0)
                {
                    Console.WriteLine($"Place {currPosition} has Valentine's day.");
                }
                else if (neighborhood[currPosition]<0)
                {
                    Console.WriteLine($"Place {currPosition} already had Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {currPosition}.");
            if (!neighborhood.Any(n=>n>0))                                // ako nqma chislo w masiva, koeto e > 0
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Count(n=>n>0)} places.");
            }                                        // broqt na chislata, koito sa > 0 
        }
    }
}

