using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType== "TakeOdd")
                {
                    char[] oddChars = message.Where((x,y) => y % 2 != 0).ToArray();
                    message = String.Join("", oddChars);
                    Console.WriteLine(message);
                }
                else if (cmdType== "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    message = message.Remove(index, length);
                    Console.WriteLine(message);
                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, substitute);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    } 
                }
            }
            Console.WriteLine($"Your password is: {message.ToString()}");
        }
    }
}
