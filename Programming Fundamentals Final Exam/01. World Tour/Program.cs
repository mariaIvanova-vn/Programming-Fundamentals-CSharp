using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command=Console.ReadLine())!= "Travel")
            {
                string[] cmdArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType== "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newString = cmdArgs[2];
                    if (index>=0 && index<input.Length)
                    {
                        input = input.Insert(index, newString);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                }
                else if (cmdType == "Remove Stop")
                {
                    int startindex = int.Parse(cmdArgs[1]);
                    int endindex = int.Parse(cmdArgs[2]);
                    if (startindex >= 0 && startindex < input.Length && endindex >= 0 && endindex < input.Length)
                    {
                        input = input.Remove(startindex, endindex-startindex+1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }
                }
                else if (cmdType == "Switch")
                {
                    string oldStr = cmdArgs[1];
                    string newStr = cmdArgs[2];
                    if (input.Contains(oldStr))
                    {
                        input = input.Replace(oldStr, newStr);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine(input);
                    }                   
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input.ToString()}");
        }
    }
}
