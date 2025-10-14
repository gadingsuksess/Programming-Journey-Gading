using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._8_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangipilihan;

            do
            {
                // --- Blok proses yang akan diulang ---
                Console.WriteLine("------------------------------------");
                Console.Write("Masukkan Nama Anda : ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai. ");
                // --------------------------------------
                // Pertanyaan untuk mengulang
                Console.Write("Apakah Anda ingin mengulang lagi? (ya/tidak) : ");
                ulangipilihan = Console.ReadLine().ToLower ();  
                Console.WriteLine(); // Baris kosong untuk kerapian

                // Kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "ya"

            } while (ulangipilihan == "ya");
              Console.WriteLine("Terima kasih. Program selesai.");

            }
        }
    }

