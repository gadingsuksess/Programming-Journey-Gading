using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2Fungsi_Gading_XPPLG1
{
    internal class Program
    {
        static void sapanama(string nama)
        {
            Console.WriteLine("Halo, " + nama);
            Console.WriteLine("Semangat belajar C# hari ini!");
        }
        static void Main (string[] args)
        {
            Console.Write("Masukkan nama Anda : ");
            string namasiswa = Console.ReadLine();
            sapanama(namasiswa); // Memanggil fungsi dengan argumen
        }
    }
}
