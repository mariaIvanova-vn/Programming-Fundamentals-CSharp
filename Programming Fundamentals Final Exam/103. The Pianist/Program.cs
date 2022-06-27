using System;
using System.Collections.Generic;
using System.Linq;

namespace _103._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pianist> pianists = new Dictionary<string, Pianist>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                Pianist currPianist = new Pianist(piece, composer, key);
                pianists.Add(piece, currPianist);
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                string piece = cmdArgs[1];

                if (cmdType== "Add")
                {
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];
                    if (!pianists.ContainsKey(piece))
                    {
                        Pianist currPiece = new Pianist(piece, composer, key);
                        pianists.Add(piece, currPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{ piece} is already in the collection!");
                    }
                }
                else if (cmdType== "Remove")
                {
                    if (pianists.ContainsKey(piece))
                    {
                        pianists.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string newKey = cmdArgs[2];
                    if (pianists.ContainsKey(piece))
                    {
                        pianists[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in pianists)
            {
                Pianist currPianist = item.Value;
                Console.WriteLine($"{currPianist.Piece} -> Composer: {currPianist.Composer}, Key: {currPianist.Key}");
            } 
        }
    }
    class Pianist
    {
        public Pianist(string piece, string composer, string key)
        {
            this.Piece = piece;
            this.Composer = composer;
            this.Key = key;
        }
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
