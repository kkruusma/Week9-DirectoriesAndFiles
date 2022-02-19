using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\samples";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine(); //või anda ise kausta nimi ette "WishList"
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine(); //või anda ise faili nimi ette "wishlist.txt"

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exists");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
