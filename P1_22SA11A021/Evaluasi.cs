using System;

namespace P1_22SA11A021
{
    class Evaluasi
    {
        static void Main(string[] args)
        {
            int saldo = 1000000;  
            int jumlah, pilihan;

            while (true)
            {
                Console.WriteLine("Welcome To Developer Bank ATM Service! \n");
                Console.WriteLine("1. Current Balance \n");
                Console.WriteLine("2. Income \n");
                Console.WriteLine("3. Spending \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter Your Choise: ");
                pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("\nSaldo Anda saat ini adalah Rp: {0}", saldo);
                        break;

                    case 2:
                        Console.WriteLine("\nMasukkan jumlah pemasukan (Rp): ");
                        jumlah = int.Parse(Console.ReadLine());
                        if (jumlah <= 0)
                        {
                            Console.WriteLine("\nJumlah pemasukan harus lebih besar dari 0!");
                        }
                        else
                        {
                            saldo += jumlah; 
                            Console.WriteLine("\nPemasukan berhasil! Saldo Anda sekarang Rp: {0}", saldo);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nMasukkan jumlah pengeluaran (Rp): ");
                        jumlah = int.Parse(Console.ReadLine());
                        if (jumlah <= 0)
                        {
                            Console.WriteLine("\nJumlah pengeluaran harus lebih besar dari 0!");
                        }
                        else if (jumlah > saldo)
                        {
                            Console.WriteLine("\nSaldo Anda tidak cukup untuk melakukan pengeluaran tersebut.");
                        }
                        else
                        {
                            saldo -= jumlah; 
                            Console.WriteLine("\nPengeluaran berhasil! Saldo Anda sekarang Rp: {0}", saldo);
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nTerima kasih!");
                        return;

                    default:
                        Console.WriteLine("\nPilihan tidak valid, silakan pilih antara 1-4.");
                        break;
                }
            }
        }
    }
}