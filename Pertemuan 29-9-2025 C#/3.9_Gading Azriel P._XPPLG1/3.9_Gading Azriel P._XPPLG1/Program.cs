using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logika
            Console.WriteLine("=== Program Operator Logika ===");

            Console.WriteLine("Masukkan angka pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHasil Logika");

            //AND 
            Console.WriteLine($"{a} > 5 && {b} < 10 : " + (a > 5 && b < 10));

            //OR
            Console.WriteLine($"{a} > 5 || {b} < 10 : " + (a > 5 || b < 10));

            //NOT 
            Console.WriteLine($"!({a} > {b}) : " + (!(a > b)));
        }
    }
}
