using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarasi variabel
            int umur = 15;
            double nilai = 99.9;
            char grade = 'A';
            string nama = "Gading Azriel Prasetyo";
            bool lulus = true;

            // Menampilkan nilai variabel
            Console.WriteLine("Nama Siswa            : " + nama);
            Console.WriteLine("Umur                  : " + umur);
            Console.WriteLine("Nilai                 : " + nilai);
            Console.WriteLine("Grade                 : " + grade);
            Console.WriteLine("StatuS Lulus          : " + lulus);

            Console.ReadKey(); // Menunggu input tombol sebelum keluar

        }
    }
}
