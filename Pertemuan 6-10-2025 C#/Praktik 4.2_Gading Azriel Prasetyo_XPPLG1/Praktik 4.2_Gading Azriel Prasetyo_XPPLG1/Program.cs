using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._2_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur anda : ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 0) 
            {
                Console.WriteLine("Anda sudah cukup umur untuk membuat KTP. ");
            }
        }
    }
}
