using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_4._7_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai anda : ");
            int nilai = int.Parse(Console.ReadLine());

            if(nilai >= 90)
            {
                Console.WriteLine("Predikat nilai: A");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Predikat nilai: B");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Predikat nilai: C");
            }
            else 
            {
                Console.WriteLine("Predikat nilai: D");
            }

        }
    }
}
