using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result=PrintTheMiddle(word);
            Console.WriteLine(result);
        }
        static string PrintTheMiddle(string word)
        {
            int len = word.Length;
            string result = "";
            if (len%2==1)
            {
                result = word[word.Length / 2].ToString();
            }
            else
            {
                result = word[word.Length / 2-1].ToString()+ word[word.Length / 2].ToString();
            }
            return result;
        }
    }
}
