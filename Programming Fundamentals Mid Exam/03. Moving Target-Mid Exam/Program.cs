using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target_Mid_Exam     //100/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdType = cmdArgs[0];

                if (cmdType == "Shoot")
                {
                    int index =int.Parse( cmdArgs[1]);
                    int power =int.Parse( cmdArgs[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        int currIndexPow = targets[index];
                        if (power < currIndexPow)
                        {
                            currIndexPow -= power;
                            targets.RemoveAt(index);
                            targets.Insert(index, currIndexPow);
                        }
                        else {  targets.RemoveAt(index); }
                    }
                }
                else if (cmdType == "Add")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else { Console.WriteLine("Invalid placement!"); }
                }
                else if (cmdType == "Strike")
                {
                    int indexStrike = int.Parse(cmdArgs[1]);
                    int radius = int.Parse(cmdArgs[2]);

                    if (indexStrike-radius>=0 && indexStrike+radius<targets.Count)
                    {
                        targets.RemoveRange(indexStrike - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }                  
                }
            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}


//•	"Strike {index} {radius}"
//o Remove the target at the given index and the ones before and after it depending on the radius.
//o	If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.
