using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfpeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses =(int) Math.Ceiling((double)numOfpeople / capacity);


            Console.WriteLine($"{courses}");
           
        }
    }
}
