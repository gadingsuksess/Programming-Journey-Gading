using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Decrement
            Console.Write("Masukkan angka : ");
            int x = Convert.ToInt32(Console.ReadLine());
            x--;
            Console.WriteLine("Setelah x-- : " + x);

            Console.Write("Masukkan angka lain : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nilai awal : " + y);
            Console.WriteLine("Nilai --y : " + (--y));
        }
    }
}
