using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)\!(?<qty>\d+)";
            List<string> result = new List<string>();
            decimal totalMoney = 0m;
            string input;
            while ((input=Console.ReadLine())!= "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);
                if (furnitureInfo.Success)
                {
                    string fName = furnitureInfo.Groups["name"].Value;
                    decimal price = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int qty = int.Parse(furnitureInfo.Groups["qty"].Value);

                    result.Add(fName);
                    totalMoney += price * qty;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
