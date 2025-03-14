using System;
using System.IO;

namespace NilaiMahasiswaWriteAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "nilai_mahasiswa.txt";

            string[] dataMahasiswa = {
                "NIM: 22SA1122, Nama: Raikhan, Nilai: 98",
                "NIM: 22SA1123, Nama: Alex, Nilai: 90",
                "NIM: 22SA1124, Nama: Boy, Nilai: 95"
            };

            File.WriteAllLines(path, dataMahasiswa);

            Console.WriteLine("Data nilai mahasiswa telah ditulis ke file.");

            Console.WriteLine("\nMembaca data dari file:");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}