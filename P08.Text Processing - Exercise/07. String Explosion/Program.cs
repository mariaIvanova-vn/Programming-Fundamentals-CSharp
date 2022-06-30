using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (currCh=='>')
                {
                    int currBombPower = (int)input[i + 1] - 48;
                    outputText.Append(currCh);
                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower>0)  {  bombPower--;   }
                    else {
                        outputText.Append(currCh);  }
                }
            }
            Console.WriteLine(outputText.ToString());
        }
    }
}
