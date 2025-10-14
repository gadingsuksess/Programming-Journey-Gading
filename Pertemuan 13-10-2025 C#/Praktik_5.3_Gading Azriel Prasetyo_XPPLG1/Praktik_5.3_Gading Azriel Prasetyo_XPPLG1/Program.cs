using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._3_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimpan input 
            string inputuser = "";

            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'");

            // Perulangan selama isi variabel inputuser TIDAK SAMA DENGAN "keluar"
            while (inputuser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti) : ");
                inputuser = Console.ReadLine(); // Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputuser);

            }

            Console.WriteLine("\nProgram selesai. Terima kasih! ");
        
        }
    }
}
