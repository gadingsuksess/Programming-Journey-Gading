using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._6_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai anda : ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 75)
            {
                Console.WriteLine("Wow nilai kamu {0}, selamat kamu lulus dari ujian ini! ",nilai);
            }
            else
            {
                Console.WriteLine("Yah nilai kamu {0} jadinya tidak lulus deh, tetapi gak papa ayo belajar lebih giat dan semangat lagi agar bisa mendapatkan nilai yang lebih baik lagi! ",nilai);
            }
        }
    }
}
