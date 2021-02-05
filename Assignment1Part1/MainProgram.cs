using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Arrange the console Window
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear(); // color the background with Green
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Assigment1 Part 1";

            Pet petObj = new Pet();
            petObj.Start();

            Album albumObj = new Album();
            albumObj.StartAlbum();

            Console.WriteLine();
            Console.ReadLine();

          
        }

    }
}
