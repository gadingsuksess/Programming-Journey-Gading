using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_Gading_XPPLG1
{
    internal class Program
    {
        static double ratarata(double a, double b, double c)
        {
            return (a + b + c)/3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menghitung nilai rata-rata dari 3 bilangan");

            Console.Write("Masukkan angka pertama : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua   : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Masukkan angka ketiga  : ");
            double c = double.Parse(Console.ReadLine());

            double hasil = ratarata(a,b,c);
            Console.WriteLine("Rata - rata dari " + a + " + " + b + " + " + c + " = " + hasil.ToString("N2"));
            
        }
    }
}
