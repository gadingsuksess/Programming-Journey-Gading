using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Perbandingan 
            Console.WriteLine("=== Program Operator perbandingan ===");

            Console.Write("Masukkan angka pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka kedua : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Hasil Perbandingan");
            Console.WriteLine($"{a} == {b} : " + (a == b));
            Console.WriteLine($"{a} != {b} : " + (a != b));
            Console.WriteLine($"{a} > {b} : " + (a > b));
            Console.WriteLine($"{a} < {b} : " + (a < b));
            Console.WriteLine($"{a} >= {b} : " + (a >= b));
            Console.WriteLine($"{a} <= {b} : " + (a <= b));
        }
    }
}
