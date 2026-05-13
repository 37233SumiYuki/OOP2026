using System.Diagnostics;
using System.Reflection;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();

            Console.WriteLine("*****曲の登録*****");
            while (true) {


                Console.Write("曲名:");
                string? title = Console.ReadLine();

                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Write("アーティスト名:");
                string? ArtistName = Console.ReadLine();

                Console.Write("演奏時間:");
                int length = int.Parse(Console.ReadLine());

                var song = new Song(title, ArtistName, length);

                songs.Add(song);

                Console.WriteLine();

                PrintSongs(songs);
            }
        }
        private static void PrintSongs(List<Song> songs) {

            foreach (var song in songs) {
                var min = song.Length / 60;
                var sec = song.Length % 60;
                Console.WriteLine($" 曲名:{song.Title}\r\n アーティスト名:{song.ArtistName}\r\n 演奏時間:{min:00}:{sec:00}");
            }
        }
    }
}
