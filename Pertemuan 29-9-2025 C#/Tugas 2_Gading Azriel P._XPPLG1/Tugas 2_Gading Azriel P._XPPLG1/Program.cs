using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tugas 2
            Console.WriteLine("=== Nilai Siswa ===");
            Console.Write("Masukkan nama siswa  : ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan kelas siswa : ");
            string kelas = Console.ReadLine();
            Console.Write("Masukkan Nilai Matematika       : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai Bahasa Indonesia : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Nilai Bahasa Inggris   : ");
            double c = Convert.ToDouble(Console.ReadLine());
            double ratarata = (a + b + c) / 3;
            Console.WriteLine("Nilai Rata - Rata adalah  : " + ratarata.ToString("N2"));
        }
    }
}
