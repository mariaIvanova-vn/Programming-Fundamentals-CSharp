using System;

namespace _01._World_Tour_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType== "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string str = cmdArgs[2];
                    if (index>=0 && index<stops.Length)   {  stops = stops.Insert(index, str);  }
                    Console.WriteLine(stops);
                }
                else if (cmdType== "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endtIndex = int.Parse(cmdArgs[2]);
                    if (startIndex>= 0 && startIndex < stops.Length && endtIndex >= 0 && endtIndex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endtIndex+1 - startIndex);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdType == "Switch")
                {
                    string oldString = cmdArgs[1];
                    string newString = cmdArgs[2];
                    if (stops.Contains(oldString))  {  stops = stops.Replace(oldString, newString); }
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
