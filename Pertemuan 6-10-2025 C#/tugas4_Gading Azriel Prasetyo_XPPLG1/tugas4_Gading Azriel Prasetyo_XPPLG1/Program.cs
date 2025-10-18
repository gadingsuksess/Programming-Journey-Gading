using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas4_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM INPUT JAM ===");
            Console.Write("Input jam ( 0-23 ) : ");
            int jam = int.Parse(Console.ReadLine());

            if (jam >= 6 && jam <= 11) 
            {
                Console.WriteLine("Selamat Pagi");
            }
            else if (jam >= 12 && jam <= 15)
            {
                Console.WriteLine("Selamat siang");
            }
            else if (jam >= 16 && jam <= 18)
            {
                Console.WriteLine("Selamat sore");
            }
            else if (jam >= 19 && jam <= 23 || jam >= 0 && jam <= 5)
            {
                Console.WriteLine("Selamat malam");
            }
            else
            {
                Console.WriteLine("Angka tidak valid");
            }
                

        }
    }
}
