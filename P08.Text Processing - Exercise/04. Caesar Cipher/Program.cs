using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currCh =(char) GetValue(text[i]);
                Console.Write(currCh);
            }
        }
        static int GetValue(char ch)
        {
            return (char)ch + 3;
        }
    }
}
