using System;
using System.Linq;

namespace _10._LadyBugs__not_included_in_final_score_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (ladyBugsIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                string[] cmArg = command.Split().ToArray();
                int initialIndex = int.Parse(cmArg[0]);
                string direction = cmArg[1];
                int flyLength = int.Parse(cmArg[2]);

                if (initialIndex<0 || initialIndex>=ladyBugsIndexes.Length)
                {
                    continue;
                }
                if (field[initialIndex]==0)
                {
                    continue;
                }
                field[initialIndex] = 0;
                int nextIndex = initialIndex;
                while (true)
                {
                    if (direction=="right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction=="left")
                    {
                        nextIndex -= flyLength;
                    }
                    if (nextIndex<0 || nextIndex>=field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex]==0)
                    {
                        break;
                    }
                }
                if (nextIndex>=0 && nextIndex<ladyBugsIndexes.Length)
                {
                    field[nextIndex] = 1;
                }
            } 
            Console.WriteLine(String.Join(" ",field));
        }
    }
}
