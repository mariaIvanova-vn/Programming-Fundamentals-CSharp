using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory_Mid_Exam            // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine().Split(", ").ToList();
            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdType = cmdArgs[0];
                string item = cmdArgs[1];
                if (cmdType== "Collect")
                {
                 if(!collectingItems.Contains(item))
                    {
                        collectingItems.Add(item);
                    }
                }
                else   if (cmdType == "Drop")
                {
                    if (collectingItems.Contains(item))
                    {
                        collectingItems.Remove(item);
                    }
                }
                else if (cmdType== "Combine Items")
                {
                    string[] combine = item.Split(":").ToArray();
                    string oldItem = combine[0];
                    string newItem = combine[1];
                    if (collectingItems.Contains(oldItem))
                    {
                        for (int i = 0; i < collectingItems.Count; i++)
                        {
                            if (collectingItems[i]==oldItem)
                            {
                                collectingItems.Insert(i + 1, newItem);
                            }
                        }                       
                    }
                }
                else if (cmdType== "Renew")
                {
                    if (collectingItems.Contains(item))
                    {
                        collectingItems.Remove(item);
                        collectingItems.Add(item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", collectingItems));
        }
    }
}
