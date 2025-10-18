using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mengkonversi nilai tukar uang ===");
            string x = "Rp";
            Console.Write("Masukkan jumlah uang dalam bentuk Rupiah (IDR) : " + x);
            double rp = (Convert.ToDouble(Console.ReadLine()));

            //Eksekusi Sesuai nilai kurs sekarang
            double usd = rp / 16669;
            double gbp = rp / 22397;
            double jpy = rp / 112;
            double sar = rp / 4444;

            //Hasil
            Console.WriteLine("=== Hasil ===");
            Console.WriteLine("Jumlah Rupiah            : Rp " + rp.ToString("N0"));
            Console.WriteLine("Ke Dolar AS              : $ " + usd.ToString("N2"));
            Console.WriteLine("Ke Poundsterling Inggris : £ " + gbp.ToString("N2"));
            Console.WriteLine("Ke Yen Jepang            : ¥ " + jpy.ToString("N2"));
            Console.WriteLine("Ke Riyal Saudi           : ﷼ " + sar.ToString("N2"));

        }
    }
}
