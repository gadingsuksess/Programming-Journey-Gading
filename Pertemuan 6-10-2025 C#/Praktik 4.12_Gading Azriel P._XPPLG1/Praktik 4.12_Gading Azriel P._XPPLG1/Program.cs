using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._12_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu makanan ===");
            Console.WriteLine("1. Mie Ayam");
            Console.WriteLine("2. Bakso");
            Console.WriteLine("3. Mie ayam + Bakso");
            Console.WriteLine("4. Bakso beranak");
            Console.Write("Pilih menu ( 1-4 ) : ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1: Console.WriteLine("Anda memilih Mie ayam. Harga: Rp.10.000"); break;
                case 2: Console.WriteLine("Anda memilih Bakso. Harga: Rp.10.000"); break;
                case 3: Console.WriteLine("Anda memilih Mie ayam + Bakso. Harga: Rp.15.000"); break;
                case 4: Console.WriteLine("Anda memilih Bakso beranak. Harga: Rp.20.000"); break;
                default: Console.WriteLine("Maaf menu yang anda inginkan tidak tersedia di sini!"); break;
            }
        }
    }
}
