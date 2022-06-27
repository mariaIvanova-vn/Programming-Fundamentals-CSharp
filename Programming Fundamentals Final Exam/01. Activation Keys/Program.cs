using System;
using System.Linq;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType== "Contains")
                {
                    string substring = cmdArgs[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdType== "Flip")
                {
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    if (cmdArgs[1]== "Upper")
                    {
                        string newSub = activationKey.Substring(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        newSub = newSub.ToUpper();     
                        activationKey = activationKey.Insert(startIndex, newSub);
                        Console.WriteLine(activationKey);
                    }
                    else if (cmdArgs[1]== "Lower")
                    {
                        string newSub = activationKey.Substring(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        newSub = newSub.ToLower();
                        activationKey = activationKey.Insert(startIndex, newSub);
                        Console.WriteLine(activationKey);
                    }
                }
                else if (cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex-startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
