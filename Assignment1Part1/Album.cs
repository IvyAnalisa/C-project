using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1

{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numberOfTracks;
       


        public void StartAlbum()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Starting Album Program");
            Console.WriteLine("******************************************");
           
            ReadAndSavaAlbumData();
            DisplayInfoAlbum();


        }
        public void ReadAndSavaAlbumData()
        {
            // Read Album name 
            Console.Write("What is the name of the your favorit music album?");
            albumName = Console.ReadLine();
            Console.WriteLine();

            // Read a Artist Name;
            Console.Write("What is the name of the Artist or Band for " + albumName + "?");
            artistName = Console.ReadLine();
            Console.WriteLine();

            // Read number of Track,
            Console.WriteLine("How many tracks does " + albumName + "have?");
            

            numberOfTracks = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void DisplayInfoAlbum()
        {
           
            Console.WriteLine("++++++++++++++++++++++++");
            string display = "Album name: " + albumName + "\n"
                            + "Artist/Band: " + artistName+"\n"
            +"Number of Tracks:" + numberOfTracks;

            Console.WriteLine(display);
            Console.WriteLine("Enjoy listenning!");
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Press Enter to Exit");

        }
    }
}
