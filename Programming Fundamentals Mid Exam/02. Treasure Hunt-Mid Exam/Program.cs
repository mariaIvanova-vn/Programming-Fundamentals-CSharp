using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine().Split("|").ToList();
            List<string> result = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                List<string> cmdArgs = command.Split().ToList();
                string cmdType = cmdArgs[0];

                if (cmdType == "Loot")        
                {
                    for (int j = 1; j < cmdArgs.Count; j++)                       
                    {                       
                            if (!treasureChest.Contains(cmdArgs[j]))   //proverqva dali v treasureChest se sydyrja neshto ot cmdArgs
                        {                                              // ako ne ->
                                treasureChest.Insert(0, cmdArgs[j]);   // slaga na pyrwa poziciq itemite ot cmdArgs v treasureChest
                        }                       
                    }
                }
                else if (cmdType == "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index>=0 && index<treasureChest.Count)
                    {
                        string dropItem = treasureChest[index];
                        treasureChest.Remove(dropItem);
                        treasureChest.Add(dropItem);
                    }                   
                }
                else if (cmdType == "Steal")
                {
                    int count = int.Parse(cmdArgs[1]);
                    for (int i = treasureChest.Count-count; i < treasureChest.Count; i++)
                    {
                        result.Add(treasureChest[i]);  //cikyla e na posledite 3 el, dobavqme gi v result
                    }
                    Console.WriteLine(String.Join(", ", result));
                    result.Clear();

                    treasureChest.RemoveRange(treasureChest.Count - count, count);
                }
            }           
            if (treasureChest.Count!=0)
            {
                double sum = 0;
                int count = 0;
                for (int i = 0; i < treasureChest.Count; i++)
                {
                    sum += treasureChest[i].Length;
                    count++;
                }
                double totalSum = sum / count;
                Console.WriteLine($"Average treasure gain: {totalSum:f2} pirate credits.");
            }
            else { Console.WriteLine("Failed treasure hunt."); }
        }
    }
}

//80/100

//The following lines represent commands until "Yohoho!" which ends the treasure hunt:
//     •	"Loot {item1} {item2}…{itemn}":
//o Pick up treasure loot along the way. Insert the items at the beginning of the chest. 
//o	If an item is already contained, don't insert it.
//     •	"Drop {index}":
//o Remove the loot at the given position and add it at the end of the treasure chest. 
//o	If the index is invalid, skip the command.
//     •	"Steal {count}":
//o Someone steals the last count loot items. If there are fewer items than the given count, remove as much as there are. 
//o	Print the stolen items separated by ", ":
//"{item1}, {item2}, {item3} … {itemn}"

//In the end, output the average treasure gain, which is the sum of all treasure items length divided by the count of all items inside the chest formatted to the second decimal point:
//"Average treasure gain: {averageGain} pirate credits."
//If the chest is empty, print the following message:
//"Failed treasure hunt."
