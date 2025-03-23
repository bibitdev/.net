using System;

namespace NonThreadApp
{
    public class NonThread
    {
        public void Kuliah()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kuliah ke- {0}", i);
            }
        }

        public void Rapat()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Rapat ke- {0}", i);
            }
        }
    }
}