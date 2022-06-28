using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool hasChanges = false;
            while (command != "end")
            {
                
                string[] token = command.Split();
                string action = token[0];
                if (action == "Add")
                {
                    int numToAdd = int.Parse(token[1]);
                    numbers.Add(numToAdd);
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    int numToRemove = int.Parse(token[1]);
                    numbers.Remove(numToRemove);
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(token[1]);
                    numbers.RemoveAt(indexToRemove);
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int indexToInsert = int.Parse(token[2]);
                    int numberToInsert = int.Parse(token[1]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    hasChanges = true;
                }
                else if (action=="Contains")
                {
                    int elementToCheck = int.Parse(token[1]);
                    if (numbers.Contains(elementToCheck)) 
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action=="PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(" ",evenNumbers);
                }
                else if (action == "PrintOdd)")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(" ", oddNumbers);
                }
                else if (action== "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (action== "Filter")
                {
                    string condition = token[1];
                    int numToComare = int.Parse(token[2]);
                    List<int> result = GetFilteredNumbers(numbers, condition, numToComare);
                    Console.WriteLine(String.Join(" ",result));
                }


                command = Console.ReadLine();
            }
            if (hasChanges==true)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
    }
        static List<int> GetFilteredNumbers(List<int> allNum,string condition,int numToCompare)
        {
            if (condition=="<")
            {
                List<int> result = allNum.FindAll(x => x < numToCompare);
                return result;
            }
            else if (condition==">")
            {
                List<int> result = allNum.FindAll(x => x > numToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNum.FindAll(x => x <= numToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNum.FindAll(x => x >= numToCompare);
                return result;
            }
            else
            {
                return allNum;
            }
            
        }
    }
}
