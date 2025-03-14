using System;
using System.IO;

namespace P2_22SA11A021
{
    class Program  
    {
        static void Main(string[] args)
        {
            string folder = @"/Users/bibitraikhazzaki/Documents/kuliah/SEMESTER 6/SISTEM_TEDISTRIBUSI/P2_22SA11A021/";
            string fileName = "Output.txt";
            string fullPath = folder + fileName;

            // using (StreamWriter writer = new StreamWriter(fullPath))
            // {
            //     writer.WriteLine("Bibit Raikhan Azzaki");
            //     writer.WriteLine("Erling Haaland");
            //     writer.WriteLine("Antony Goat");
            //     writer.WriteLine("Garnacho");
            //     writer.WriteLine("Bejo");
            // }

              // With Array
            string[] player = { "Bibit Raikhan Azzaki", "Erling Haaland", "Antony Goat", "Garnacho", "Bejo" };
            File.WriteAllLines(fullPath, player);

            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}