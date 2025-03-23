using System;
using System.Threading;

namespace ThreadApp
{
    public class Threads
    {
        public void Kuliah()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kuliah ke- {0}", i);
                Thread.Sleep(100); // Simulasi delay
            }
        }

        public void Rapat()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Rapat ke- {0}", i);
                Thread.Sleep(100); // Simulasi delay
            }
        }
    }
}