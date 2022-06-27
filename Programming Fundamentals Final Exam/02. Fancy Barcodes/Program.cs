using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@{1}\#{1,})([A-Z][A-Za-z\d]{4,}[A-Z])(\@{1}\#{1,})";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                Match barcode = Regex.Match(text, pattern);
                if (barcode.Success)
                {
                    string word = barcode.Groups[2].Value;
                    StringBuilder nums = new StringBuilder();
                   
                    foreach (char ch in word)
                    {
                        if (char.IsDigit(ch))
                        {
                            nums.Append(ch);
                        }
                    }
                    if (nums.ToString()==string.Empty)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {nums.ToString()}");
                    }    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
