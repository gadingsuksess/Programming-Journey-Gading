using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Fungsi_Hitung_Luas_Gading
{
    internal class Program
    {
        static double hitungluas(double panjang, double lebar) 
        {
            double luas = panjang * lebar;
            return luas;
        }
        static void Main(string[] args) 
        {
            Console.Write("Masukkan panjang : ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar   : ");
            double l = Convert.ToDouble(Console.ReadLine());

            double hasil = hitungluas(p, l);
            Console.WriteLine("Luas persegi panjang adalah : " + hasil);
        }
            
    }
}
