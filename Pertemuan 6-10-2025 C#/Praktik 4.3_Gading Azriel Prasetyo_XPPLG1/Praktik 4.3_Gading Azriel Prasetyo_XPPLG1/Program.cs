using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._3_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai ujian : ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Selamat, anda lulus! ");
            }
        }
    }
}
