using System;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                char[] wordArr = command.ToCharArray();
                Array.Reverse(wordArr);
                string reversedWord = new string(wordArr);
                Console.WriteLine($"{command} = {reversedWord}");
            }
        }
    }
}
