using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pengurangan int
            Console.Write("Masukkan angka pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua : ");
            int b = int.Parse(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("Hasil Pengurangan : " + (c));
            // Pengurangan double
            Console.Write("Masukkan angka ketiga : ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan angka keempat : ");
            double e = double.Parse(Console.ReadLine());
            double f = d - e;
            Console.WriteLine("Hasil Pengurangan (double) : " + (f));
        }
    }
}
