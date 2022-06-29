using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int> { { "shards", 0 }, { "motes", 0 }, { "fragments", 0 } };          
            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (string.IsNullOrEmpty(itemObtained))
            {
                string materialLine = Console.ReadLine().ToLower();
                string[] materialArr = materialLine.Split().ToArray();
                for (int i = 0; i < materialArr.Length; i+=2)
                {                    
                    int currMaterialQty =int.Parse( materialArr[i]);
                    string currMaterial = materialArr[i + 1];
                    if (keyMaterials.ContainsKey(currMaterial))
                    {
                        keyMaterials[currMaterial] += currMaterialQty;
                        if (keyMaterials["shards"]>=250)
                        {
                            itemObtained = "Shadowmourne";
                            keyMaterials["shards"] -= 250;
                            break;
                        }
                        if (keyMaterials["fragments"] >= 250)
                        {
                            itemObtained = "Valanyr";
                            keyMaterials["fragments"] -= 250;
                            break;
                        }
                        if (keyMaterials["motes"] >= 250)
                        {
                            itemObtained = "Dragonwrath";
                            keyMaterials["motes"] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currMaterial))
                        {
                            junk[currMaterial] = 0;
                        }
                        junk[currMaterial] += currMaterialQty;
                    }
                }
            }
            PrintOutput(keyMaterials, junk, itemObtained);
        }
        static void PrintOutput(Dictionary<string,int> keyMaterials,Dictionary<string,int> junk,string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");
            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
