using System;

namespace Problem_1___The_Imitation_Game        //100/100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            string command;
            while ((command=Console.ReadLine())!= "Decode")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action== "Move")
                {
                    int numOfLetters = int.Parse(cmdArgs[1]);
                    string textToMove = encryptedMessage.Substring(0, numOfLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numOfLetters);
                    encryptedMessage = encryptedMessage.Insert(encryptedMessage.Length,textToMove); 
                }
                else if (action== "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
