using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._11_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Masukkan angka bulan ( 1-12 ) : ");
            int bulan = int.Parse(Console.ReadLine());

            switch (bulan)
            {
                case 1: Console.WriteLine("Bulan Januari"); break;
                case 2: Console.WriteLine("Bulan Februari"); break;
                case 3: Console.WriteLine("Bulan Maret"); break;
                case 4: Console.WriteLine("Bulan April"); break;
                case 5: Console.WriteLine("Bulan Mei"); break;
                case 6: Console.WriteLine("Bulan Juni"); break;
                case 7: Console.WriteLine("Bulan Juli"); break;
                case 8: Console.WriteLine("Bulan Agustus"); break;
                case 9: Console.WriteLine("Bulan September"); break;
                case 10: Console.WriteLine("Bulan Oktober"); break;
                case 11: Console.WriteLine("Bulan November"); break;
                case 12: Console.WriteLine("Bulan Desember"); break;
                default: Console.WriteLine("Input tidak valid"); break;

            }
        }
    }
}
