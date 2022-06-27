using System;

namespace _01._The_Imitation_Game          // 100 / 100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType== "Move")
                {
                    int numOfLetters = int.Parse(cmdArgs[1]);
                  string  newmessage = message.Substring(0, numOfLetters);
                    message = message.Remove(0, numOfLetters);
                    message = message.Insert(message.Length,newmessage) ;
                }
                else if (cmdType== "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    message = message.Insert(index, value);

                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {message.ToString()}");
        }
    }
}
