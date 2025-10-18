using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_if_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka : ");
            int angka = int.Parse(Console.ReadLine());

            if (angka > 100) 
            {
                Console.WriteLine("angka {0} lebih besar dari angka 100", angka);
            }
            else if (angka == 100)
            {
                Console.WriteLine("angka {0} sama dengan angka 100",angka);
            }
            else
            {
                Console.WriteLine("angka {0} lebih kecil dari angka 100", angka);
            }
        }
    }
}
