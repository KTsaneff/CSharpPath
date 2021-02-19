using System;
using System.Collections.Generic;
using System.Linq;

namespace _114.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < lines; i++)
            {
                string[] newEntry = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                string list = newEntry[0];
                string title = newEntry[1];
                string duration = newEntry[2];

                Song newSong = new Song(list, title, duration);
                songs.Add(newSong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.SongTitle);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.SongTitle);
                    }
                }

            }
        }
    }
    class Song
    {
        public Song(string typeList, string songTitle, string duration)
        {
            TypeList = typeList;
            SongTitle = songTitle;
            Duration = duration;
        }

        public string TypeList { get; set; }
        public string SongTitle { get; set; }
        public string Duration { get; set; }
    }
}
