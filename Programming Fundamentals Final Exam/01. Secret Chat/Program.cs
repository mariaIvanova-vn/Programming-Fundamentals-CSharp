using System;
using System.Linq;

namespace _01._Secret_Chat                 // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType== "InsertSpace")
                {
                    int index = int.Parse(cmdArgs[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (cmdType == "Reverse")
                {
                    string substring = cmdArgs[1];
                    if (message.Contains(substring))           //ako substringa se sudurja v message
                    {
                        int firstIndex = message.IndexOf(substring);    //namirame 1viq index na substringa
                        message = message.Remove(firstIndex, substring.Length);  //mahame substringa
                        message = message+String.Join("", substring.Reverse());    //dobavqme go nakraq na message Reverse-nat
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                    }
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
