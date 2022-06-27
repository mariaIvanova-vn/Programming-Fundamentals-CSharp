using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist            // 100 / 100 - s Class i List<class>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pianist> pianists = new List<Pianist>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currPiece = input[0];
                string currComposer = input[1];
                string currKey = input[2];

                Pianist currPianist = new Pianist(currPiece, currComposer, currKey);
                pianists.Add(currPianist);

            }
            string command;
            while ((command=Console.ReadLine())!= "Stop")
            {
                string[] cmdArgs = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];
                if (cmdType== "Add")
                {
                    string piece = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];

                    if (pianists.Any(p=>p.Piece==piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        Pianist currPiece = new Pianist(piece, composer, key);
                        pianists.Add(currPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }                    
                }
                else if (cmdType== "Remove")
                {
                    string piece = cmdArgs[1];
                    if (pianists.Any(p => p.Piece == piece))
                    {
                        Pianist itemToremove = pianists.FirstOrDefault(x => x.Piece == piece);
                    pianists.Remove(itemToremove);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string piece = cmdArgs[1];
                    string newKey = cmdArgs[2];
                    if (pianists.Any(p => p.Piece == piece))
                    {
                        Pianist itemToChange = pianists.FirstOrDefault(x => x.Piece == piece);
                        itemToChange.Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (Pianist item in pianists)
            {
                Console.WriteLine($"{item.Piece} -> Composer: {item.Composer}, Key: {item.Key}");
            }
        }
    }
    class Pianist
    {
        public Pianist(string piece,string composer,string key)
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
