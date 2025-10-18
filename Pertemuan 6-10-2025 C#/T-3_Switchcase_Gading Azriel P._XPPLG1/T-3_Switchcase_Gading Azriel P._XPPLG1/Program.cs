using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_3_Switchcase_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Masukkan angka anatara (1-5) : ");
            int warna = int.Parse(Console.ReadLine());

            switch (warna)
            {
                case 1: Console.WriteLine("Merah"); break;
                case 2: Console.WriteLine("Biru"); break;
                case 3: Console.WriteLine("Hijau"); break;
                case 4: Console.WriteLine("Kuning"); break;
                case 5: Console.WriteLine("Hitam"); break;
                default: Console.WriteLine("Angka tidak valid! "); break;
            }
        }
    }
}
