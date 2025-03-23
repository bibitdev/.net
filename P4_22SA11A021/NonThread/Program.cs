using System;

namespace NonThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Mulai Keseharian (Non-Thread)");
            Console.WriteLine("******************************");

            NonThread nonThread = new NonThread();
            nonThread.Kuliah();
            nonThread.Rapat();

            Console.WriteLine("******************************");
            Console.WriteLine("Selesai...");
            Console.WriteLine("******************************");
        }
    }
}