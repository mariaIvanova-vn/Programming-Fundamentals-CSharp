using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();
            int countBlacklisted = 0;
            int countLosted = 0;
            string command;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];

                if (cmdType== "Blacklist")
                {
                    string name = cmdArgs[1];
                    string newName = "Blacklisted";
                    if (friends.Contains(name))
                    {
                        countBlacklisted++;
                        Console.WriteLine($"{name} was blacklisted.");
                        friends = friends.Select(x => x.Replace(name, newName)).ToList();
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (cmdType== "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = "Lost";
                    if (index >= 0 && index < friends.Count)
                    {
                        if (friends[index] != "Lost" && friends[index] != "Blacklisted")
                        {
                            countLosted++;
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends = friends.Select(x => x.Replace(friends[index], newName)).ToList();
                        }
                    }
                }
                else if (cmdType == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if (index >= 0 && index < friends.Count)
                    {
                        Console.WriteLine($"{friends[index]} changed his username to {newName}.");
                        friends = friends.Select(x => x.Replace(friends[index], newName)).ToList();
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countLosted}");
            Console.WriteLine(String.Join(" ", friends));
        }
    }
}
