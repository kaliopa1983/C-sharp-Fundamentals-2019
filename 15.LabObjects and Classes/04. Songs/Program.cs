using System;
using System.Collections.Generic;


namespace _04._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
       
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int nubnerOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < nubnerOfSongs; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("_");
                    
                string typeList = data[0];
                string nameOfSong = data[1];
                string time = data[2];
                Song song = new Song();


                song.TypeList = typeList ;
                song.Name = nameOfSong;
                song.Time = time;
                songs.Add(song);
            }
            string typeList2 = Console.ReadLine();
            if (typeList2=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
               
            }
           


        }
    }
}
