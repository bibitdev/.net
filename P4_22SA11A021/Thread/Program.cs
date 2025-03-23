using System;
using System.Threading;

namespace ThreadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Mulai Keseharian (Thread)");
            Console.WriteLine("******************************");

            Threads threads = new Threads();

            Thread kuliahThread = new Thread(new ThreadStart(threads.Kuliah));
            Thread rapatThread = new Thread(new ThreadStart(threads.Rapat));

            kuliahThread.Start();
            rapatThread.Start();

            kuliahThread.Join();
            rapatThread.Join();

            Console.WriteLine("******************************");
            Console.WriteLine("Selesai...");
            Console.WriteLine("******************************");
        }
    }
}