using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War_Mid_Exam            // 50 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maximumHealth = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];
                if (cmdType == "Fire")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int damage = int.Parse(cmdArgs[2]);
                    if (warShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                    if (index < warShip.Count)
                    {
                        warShip[index] -= damage;
                    }
                }
                else if (cmdType == "Defend")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int damage = int.Parse(cmdArgs[3]);
                    if (startIndex >= 0 && endIndex < pirateShip.Count)  // •	"Defend {startIndex} {endIndex} {damage}" - the warship attacks the pirate ship with the given damage at that range (indexes are inclusive).
                                                                         // Check if both indexes are valid and if not, skip the command. If the section breaks (health <= 0) the pirate ship sinks, print the following and stop the program:
                                                                         // "You lost! The pirate ship has sunken.
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int indexNumber = i;
                            int result = pirateShip[indexNumber] - damage;
                            if (result <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                            else
                            {
                                pirateShip.Remove(pirateShip[indexNumber]);
                                pirateShip.Insert(startIndex, result);
                                startIndex++;
                            }
                        }
                    }

                }
                else if (cmdType == "Repair")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int helth = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (helth > maximumHealth)
                        {
                            helth = maximumHealth;
                            pirateShip.RemoveAt(index);
                            pirateShip.Insert(index, helth);
                        }
                        else
                        {
                            int num = pirateShip[index];
                            pirateShip.RemoveAt(index);
                            pirateShip.Insert(index, helth + num);
                        }
                    }
                    else if (cmdType == "Status")
                    {
                        int count = 0;
                        double percent = maximumHealth * 0.2;
                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            int one = pirateShip[i];
                            if (percent > one)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"{count} sections need repair.");
                    }
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                sum1 += pirateShip[i];
            }
            Console.WriteLine($"Pirate ship status: {sum1}");
            for (int j = 0; j < warShip.Count; j++)
            {
                sum2 += warShip[j];
            }
            Console.WriteLine($"Warship status: {sum2}");
        }
    }
}


