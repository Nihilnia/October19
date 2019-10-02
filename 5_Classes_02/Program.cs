using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Classes_02
{
    class Program
    {
        class Song
        {
            public int SongID { get; set; }
            public string Artist { get; set; }
            public string Name { get; set; }
            public double Duration { get; set; }
            public string Genre { get; set; }
        }

        static void Main(string[] args)
        {
            Song Song01 = new Song() {
                SongID = 01,
                Artist = "Rammstein",
                Name = "Engel",
                Duration = 4.24,
                Genre = "Rock IDK"
            };

            Song Song02 = new Song();
            Song02.SongID = 02;
            Song02.Artist = "Grandson";
            Song02.Name = "Overdose";
            Song02.Duration = 3.51;
            Song02.Genre = "IDK Really";

            Console.WriteLine("New song ID: ");
            int newSongID = int.Parse(Console.ReadLine());

            Console.WriteLine("New song Artist: ");
            string newSongArtist = Console.ReadLine();

            Console.WriteLine("New song Name: ");
            string newSongName = Console.ReadLine();

            Console.WriteLine("New song Duration: ");
            double newSongDuration = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("New song Genre: ");
            string newSongGenre = Console.ReadLine();

            Song Song03 = new Song() {
                SongID = newSongID,
                Artist = newSongArtist,
                Name = newSongName,
                Duration = newSongDuration,
                Genre = newSongGenre
            };

            //Song[] listOfSongs = { Song01, Song02, Song03};

            //for (int i = 0; i < listOfSongs.Length; i++)
            //{
            //    Console.WriteLine($"{listOfSongs[i].SongID} {listOfSongs[i].Name} {listOfSongs[i].Artist} {listOfSongs[i].Duration} {listOfSongs[i].Genre}");
            //}

            Song[] listOfSongs = new Song[3];
            listOfSongs[0] = Song01;
            listOfSongs[1] = Song02;
            listOfSongs[2] = Song03;

            for (int i = 0; i < listOfSongs.Length; i++)
            {
                Console.WriteLine($"{listOfSongs[i].SongID} {listOfSongs[i].Name} {listOfSongs[i].Artist} {listOfSongs[i].Duration} {listOfSongs[i].Genre}");
            }


            Console.Read();
        }
    }
}
