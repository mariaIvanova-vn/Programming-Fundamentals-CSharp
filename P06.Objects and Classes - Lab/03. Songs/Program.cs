using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string Name { get; set; }
        public string TypeList { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_');
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typeList,
                    Time = time
                };
                songs.Add(newSong);
            }
            string typeListToSearch = Console.ReadLine();
           // string command = Console.ReadLine();
           
            if (typeListToSearch=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSong = songs.FindAll(song => song.TypeList == typeListToSearch);
                foreach (Song song in filteredSong)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
