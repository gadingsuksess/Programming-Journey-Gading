using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lat.while_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menghitung dari bilangan 1 sampai 5 ====");
            int bilangan = 0;
            int total = 0;

            while (bilangan < 5)
            {
                Console.Write($"Bilangan : {bilangan} ");
                bilangan = bilangan + 1;
                total += bilangan;
                Console.WriteLine("Menambahkan " + bilangan + ", : total sementara = " + total);

            }
            Console.WriteLine("\nHasil akhir penjumlahan atau total adalah : " + total);
        }
    }
}
