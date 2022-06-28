using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            FindChar(first, second);
        }
        static void FindChar(char firstCh,char secondCh)
        {

            int startCharacter = Math.Min(firstCh, secondCh);
            int endCharacter = Math.Max(firstCh, secondCh);

            for (int i = startCharacter+1; i < endCharacter; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
