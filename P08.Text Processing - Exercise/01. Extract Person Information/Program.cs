using System;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int firstSymbolName = text.IndexOf('@');
                string startName = text.Substring(firstSymbolName+1 );
                int lastSymbolName = startName.LastIndexOf('|');
                string name = startName.Substring(0, lastSymbolName);

                int firstSymbolAge = text.IndexOf('#');
                
                string startage = text.Substring(firstSymbolAge+1);
                int lastSymbolAge = startage.IndexOf('*');
                string age = startage.Substring(0, lastSymbolAge);

                Console.WriteLine($"{name.Trim()} is {age.Trim()} years old.");
            }
        }
    }
}
