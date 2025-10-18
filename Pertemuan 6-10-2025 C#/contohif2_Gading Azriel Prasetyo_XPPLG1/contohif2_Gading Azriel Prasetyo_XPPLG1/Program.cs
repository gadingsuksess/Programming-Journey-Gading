using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contohif2_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program untuk mempermudah pembayaran di suatu bioskop
            Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP ===");
            Console.WriteLine("1. Horor");
            Console.WriteLine("2. Romantic");
            Console.Write("Masukkan pilihan (1/2) : ");
            int jenis = int.Parse(Console.ReadLine());
            int harga = 0;
            string judul = "";

            // Pilihan untuk film horor
            if (jenis == 1)
            {
                Console.WriteLine("\n--- Daftar Film Horor ---");
                Console.WriteLine("1. kang solah from kang mak x Nenek gayung \tRp.30000");
                Console.WriteLine("2. Deat Whisperer 3 \tRp.30500");
                Console.WriteLine("3. Rest Area \t\tRp.40000");
                Console.Write("Pilih nomor film : ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "kang solah from kang mak x Nenek gayung";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "Deat Whisperer 3";
                    harga = 30500;
                }
                else if (pilih == 3)
                {
                    judul = "Rest Area";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    return;
                }
            }
            // Pilihan untuk film Romantic
            else if (jenis == 2)
            {
                Console.WriteLine("\n--- Daftar film Romantic ---");
                Console.WriteLine("1. The Arthitecture of love \r\n\t\tRp. 35000");
                Console.WriteLine("2. Sampai Nanti, Hanna!  \t         Rp. 30000");
                Console.WriteLine("3. Love for Sale  \t\t              Rp. 40000");
                Console.Write("Pilih nomor film : ");
                int pilih = int.Parse (Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "The Arthitecture of love";
                    harga = 35000;
                }
                else if (pilih == 2)
                {
                    judul = "Sampai Nanti, Hanna!";
                    harga = 30000;
                }
                else if (pilih == 3)
                {
                    judul = "Love for Sale";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Pilihan jenis film tidak valid!");
                return;
            }

            // Menampilkan hasil
            Console.WriteLine("\n==========================================");
            Console.WriteLine("Judul Film\t  : " + judul);
            Console.WriteLine("Harga Tiket\t  : " + harga);
            Console.WriteLine("==========================================");
            Console.WriteLine("Terima kasih telah membeli tiket!");

        }
    }
}
