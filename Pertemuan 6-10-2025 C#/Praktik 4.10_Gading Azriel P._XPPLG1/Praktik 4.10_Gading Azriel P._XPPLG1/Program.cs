using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._10_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka ( 1-7 ) : ");
            int hari = int.Parse(Console.ReadLine());

            switch (hari)
            {
                case 1: Console.WriteLine("Hari Senin"); break;
                case 2: Console.WriteLine("Hari Selasa"); break;
                case 3: Console.WriteLine("Hari Rabu"); break;
                case 4: Console.WriteLine("Hari Kamis"); break;
                case 5: Console.WriteLine("Hari Jum'at"); break;
                case 6: Console.WriteLine("Hari Sabtu"); break;
                case 7: Console.WriteLine("Hari Minggu"); break;
                default: Console.WriteLine("Input tidak valid"); break;

            }
        }
    }
}
