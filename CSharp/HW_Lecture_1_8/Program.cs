using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_Lecture_1_8
{
    class Player
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Album myFirstAlbum = new Album("My First Album"); // or new Album();
            myFirstAlbum.AddSongRange(new List<Song>()
            {
                new Song("Super Band","Super Song"),
                new Song(title:"Super Song"),
                new Song(band:"Super Band"),
                new Song("Giper Band","Awful Song"),
                new Song("Super Band","Super Song"),
                new Song("Just Band","Isn't Song"),
                new Song("Band of justice","Super Song"),
                new Song(),
                new Song("My", "First SOng", 500,300),
                new Song("My", "Second song", 1500,700),
            });

            var rand = new Random(DateTime.Now.Second);

            Console.Write($"We are ready to play All album ({myFirstAlbum.Songs.Count})");
            Console.ReadKey();
            PlayAlbum(myFirstAlbum);

            int from = rand.Next(0, myFirstAlbum.Songs.Count);
            Console.WriteLine(Environment.NewLine);
            Console.Write($"We are ready to play from #{from+1} to end of album");
            Console.ReadKey();
            PlayAlbum(myFirstAlbum, from);

            from = rand.Next(0, myFirstAlbum.Songs.Count);
            int to = rand.Next(from, myFirstAlbum.Songs.Count);
            Console.WriteLine(Environment.NewLine);
            Console.Write($"We are ready to play album from #{from+1} to #{to+1} songs");
            Console.ReadKey();
            PlayAlbum(myFirstAlbum, from, to);

            Console.WriteLine("That is all. Goodbye");
            Console.ReadKey();
        }

        static void PlayAlbum(Album album, int fromSongIndex = default(int), int toSongIndex = default(int))// – воспроизвести песни начиная с.
        {
            if (toSongIndex < 1 || toSongIndex > album.Songs.Count) toSongIndex = album.Songs.Count;

            string borderString = new string('=', Console.BufferWidth);
            Console.WriteLine(borderString);
            Console.WriteLine($"Album - {album.Title} from {fromSongIndex+1} to {toSongIndex+1}");
            Console.WriteLine(borderString);

            for (int songIndex = fromSongIndex; songIndex < toSongIndex; songIndex++)
            {
                Thread.Sleep(200);

                Console.WriteLine("{0:T}: Now playing the song \"{1} - {2}\": {3}mc",
                    DateTime.Now,
                    album[songIndex].Band,
                    album[songIndex].Title,
                    album[songIndex].Duration);

                album[songIndex].Play();
            }

        }

    }
}
