using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] companyArgs = input.Split(" -> ").ToArray();
                string company = companyArgs[0];
                string id = companyArgs[1];
                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers[company] = new List<string>();
                }
                if (!companyUsers[company].Contains(id))
                { companyUsers[company].Add(id); }
            }
            foreach (var kpv in companyUsers)
            {
                Console.WriteLine($"{kpv.Key}");
                foreach (var item in kpv.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
