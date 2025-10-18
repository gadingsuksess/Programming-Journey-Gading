using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM INPUT NAMA ===");
            Console.Write("Tuliskan nama kamu:");
            string nama = Console.ReadLine();
            Console.WriteLine("Hi, {0} selamat datang!", nama);
        }
    }
}
