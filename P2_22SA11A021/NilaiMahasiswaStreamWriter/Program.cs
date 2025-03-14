using System;
using System.IO;

namespace NilaiMahasiswaStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "nilai_mahasiswa.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("NIM: 22SA11A021, Nama: Bibit, Nilai: 99");
                writer.WriteLine("NIM: 22SA11022, Nama: Raikhan, Nilai: 90");
                writer.WriteLine("NIM: 22SA11023, Nama: Azzaki, Nilai: 95");
            }

            Console.WriteLine("Data nilai mahasiswa telah ditulis ke file.");

            Console.WriteLine("\nMembaca data dari file:");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}