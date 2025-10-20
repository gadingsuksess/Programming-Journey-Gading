using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_Gading_XPPLG1
{
    internal class Program
    {
        static double konversisuhu(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mengubah suhu celcius ke fahrenheit ===");
            Console.Write("Masukkan suhu celcius : ");
            double c = double.Parse(Console.ReadLine());
            string f = "°F";

            double hasil = konversisuhu(c);
            Console.WriteLine($"Fahrenheit : " + (hasil) + (f));
        }

    }
}
