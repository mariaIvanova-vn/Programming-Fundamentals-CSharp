using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();
            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split();
                string cmdType = cmdArgs[0];

                if (cmdType== "Urgent")
                {
                    string item = cmdArgs[1];
                    if (shopingList.Contains(item))
                    {
                        continue;
                    }
                    else { shopingList.Insert(0, item); }  //add on first index                  
                }
                else if (cmdType == "Unnecessary")
                {
                    string item = cmdArgs[1];
                    if (shopingList.Contains(item))
                    {
                        shopingList.Remove(item);
                    }                       
                }
                else if (cmdType == "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];
                   
                    shopingList = shopingList.Select(x => x.Replace(oldItem, newItem)).ToList();
                    //  replace an item in a string list
                }
                else if (cmdType == "Rearrange")
                {
                    string item = cmdArgs[1];
                    if (shopingList.Contains(item))
                    {
                        shopingList.Remove(item);
                        shopingList.Add(item);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", shopingList));
        }       
    }
}
//  100 / 100