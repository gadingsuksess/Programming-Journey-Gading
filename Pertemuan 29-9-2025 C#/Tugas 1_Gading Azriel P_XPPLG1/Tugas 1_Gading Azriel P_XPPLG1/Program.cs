using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_Gading_Azriel_P_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tugas 1
            Console.WriteLine("=== VERSI INT ===");
            Console.WriteLine("=== Operator Matematika Penjumlahan,Pengurangan,Perkalian, dan Pembagian dari 3 buah bilangan ===");

            Console.Write("Masukkan angka pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka kedua   : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka ketiga  : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Penjumlahan  : " + (a + b + c));
            Console.WriteLine("Hasil pengurangan  : " + (a - b - c));
            Console.WriteLine("Hasil Perkalian    : " + (a * b * c));
            Console.WriteLine("Hasil Pembagian    : " + (a / b / c));

            Console.WriteLine("=== VERSI DOUBLE ===");
            Console.WriteLine("=== Operator Matematika Penjumlahan,Pengurangan,Perkalian, dan Pembagian dari 3 buah bilangan ===");

            Console.Write("Masukkan angka pertama : ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua   : ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga  : ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hasil Penjumlahan  : " + (d + e + f));
            Console.WriteLine("Hasil pengurangan  : " + (d - e - f));
            Console.WriteLine("Hasil Perkalian    : " + (d * e * f));
            Console.WriteLine("Hasil Pembagian    : " + (d / e / f));

        }
    }
}
