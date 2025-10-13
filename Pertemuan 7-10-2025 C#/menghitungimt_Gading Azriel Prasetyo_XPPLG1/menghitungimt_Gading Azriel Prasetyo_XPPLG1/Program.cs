using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menghitungimt_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("=== PROGRAM MENGHITUNG INDEKS MASSA TUBUH (IMT) ===");
            Console.Write("Masukkan berat badan (kg) anda : ");
            double bb = double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi badan (meter)  : ");
            double tb = double.Parse(Console.ReadLine());
            double imt = bb/(tb*tb);
            Console.WriteLine("Indeks Massa Tubuh (IMT) Anda = " + imt.ToString("N2"));

            if (imt < 18.5)
            {
                Console.WriteLine("Kategori : Berat badan kurus ");
            }
            else if (imt >= 18.5 && imt <= 24.9 )
            {
                Console.WriteLine("Kategori : Berat badan normal ");
            }
            else if (imt >= 25 && imt <= 29.9 )
            {
                Console.WriteLine("Kategori : Berat badan kelebihan berat badan ");
            }
            else
            {
                Console.WriteLine("Kategori : Berat badan obesitas ");
            }

            Console.WriteLine("TERIMAKASIH TELAH MENGGUNAKAN PROGRAM INI !");
        }
    }
}
