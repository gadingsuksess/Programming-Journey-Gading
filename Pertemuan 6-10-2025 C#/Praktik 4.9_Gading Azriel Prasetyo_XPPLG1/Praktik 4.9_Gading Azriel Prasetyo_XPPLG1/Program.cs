using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._9_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur anda : ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("Tiket Gratis!");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("Harga tiket: Rp. 20.000");
            }
            else if (umur <= 60)
            {
                Console.WriteLine("Harga tiket: Rp. 50.000");
            }
            else
            {
                Console.WriteLine("Harga tiket: Rp. 30.000 (Diskon spesial untuk lansia)");
            }
        }
    }
}
