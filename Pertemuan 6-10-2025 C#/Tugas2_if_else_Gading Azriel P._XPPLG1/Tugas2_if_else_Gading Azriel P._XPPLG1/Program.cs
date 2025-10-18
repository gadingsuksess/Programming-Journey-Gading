using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_if_else_Gading_Azriel_P._XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program umur anda sudah termasuk lansia atau belum ===");
            Console.Write("Masukkan umur anda : ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 60)
            {
                Console.WriteLine("Umur {0} tahun, anda sudah memasuki lansia", umur);
            }
            else
            {
                Console.WriteLine("Umur {0} tahun merupakan umur bukan lansia", umur);
            }
        }
    }
}
