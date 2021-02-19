using System;
using System.Collections.Generic;

namespace _104.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArg = Console.ReadLine().Split("_");

                string typeList = cmdArg[0];
                string name = cmdArg[1];
                string duration = cmdArg[2];

                Song song = new Song(typeList, name, duration);
                songs.Add(song);
            }

            string printOut = Console.ReadLine();

            if (printOut == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name); 
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == printOut)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string duration)
        {
            TypeList = typeList;
            Name = name;
            Duration = duration;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
