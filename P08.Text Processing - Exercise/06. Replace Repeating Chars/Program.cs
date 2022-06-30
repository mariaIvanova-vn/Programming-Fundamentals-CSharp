using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToList();          
            for (int i = 0; i < text.Count-1; i++)
            {
                char currCh = text[i];
                char next = text[i + 1];
                if (currCh==next)
                {
                    text.RemoveAt(i);
                    i--;
                }                              
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
