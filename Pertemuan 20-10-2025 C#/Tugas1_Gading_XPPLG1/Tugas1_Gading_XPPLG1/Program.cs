using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_Gading_XPPLG1
{
    internal class Program
    {
        static double kali(double a, double b,double c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Perkalian 3 bilangan ==="); 

            Console.Write("Masukkan angka pertama : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua   : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Masukkan angka ketiga  : ");
            double c = double.Parse(Console.ReadLine());

            double hasil = kali(a,b,c);
            Console.WriteLine("Hasil penjumlahan : " +  hasil);
        }
    }
}
