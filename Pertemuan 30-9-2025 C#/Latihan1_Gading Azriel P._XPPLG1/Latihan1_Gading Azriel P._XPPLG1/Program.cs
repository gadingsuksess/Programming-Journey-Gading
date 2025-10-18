using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Mengubah suhu celcius ke fahrenheit dan reamur ===");
            Console.Write("Masukkan suhu celcius : ");
            double c = Convert.ToDouble(Console.ReadLine());
            string f = "°F";
            string re = "°Re";

            //Eksekusi
            //Fahrenheit
            double fx = (c * 9 / 5) + 32;

            //Reamur
            double fy = (c * 4 / 5);

            //Hasil
            Console.WriteLine("=== Hasil Konversi ===");
            Console.WriteLine($"Celcius : " + (fx) + (f));
            Console.WriteLine($"Reamur  : " + (fy) + (re));

        }
    }
}
