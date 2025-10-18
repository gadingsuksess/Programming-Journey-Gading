using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._8_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka : ");
            int angka = int.Parse(Console.ReadLine());

            if(angka > 0)
            {
                Console.WriteLine("Angka {0} adalah angka positif", angka);
            }
            else if(angka < 0)
            {
                Console.WriteLine("Angka {0} adalah angka negatif", angka);
            }
            else
            {
                Console.WriteLine("Angka Nol.");
            }
        }
    }
}
