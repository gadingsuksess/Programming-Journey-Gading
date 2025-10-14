using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencariluas_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program mencari luas ===");
            Console.WriteLine("1. Mencari luas permukaan kubus ");
            Console.WriteLine("2. Mencari volume kubus ");
            Console.WriteLine("3. Mencari luas permukaan balok ");
            Console.WriteLine("4. Mencari volume balok ");
            Console.Write("Ketik salah satu angka dari (1-4) untuk mengeksekusi tugas : ");
            double x = double.Parse(Console.ReadLine());

            switch (x)
            {
                case 1: 
                    Console.Write("Masukkan sisi kubus : ");
                    double s1 = double.Parse(Console.ReadLine());
                    double lk = (s1 * s1) * 6;
                    Console.Write("Jawaban : " + lk.ToString("N2"));break;
                case 2: 
                    Console.Write("Masukkan sisi kubus : ");
                    double s2 = double.Parse(Console.ReadLine());
                    double vk = (s2 * s2 * s2); 
                    Console.Write("Jawaban : " + vk.ToString("N2"));break;
                case 3: 
                    Console.Write("Masukkan panjang balok : ");
                    double p = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan lebar balok   : ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan tinggi balok   : ");
                    double t = double.Parse(Console.ReadLine());
                    double lb = (p * l) + (p * t) + (l * t)*2;
                    Console.Write("Jawaban : " + lb.ToString("N2"));break;
                case 4:
                    Console.Write("Masukkan panjang balok : ");
                    double p1 = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan lebar balok   : ");
                    double l1 = double.Parse(Console.ReadLine());
                    Console.Write("Masukkan tinggi balok  : ");
                    double t1 = double.Parse(Console.ReadLine());
                    double vb = (p1 * l1 * t1);
                    Console.Write("Jawaban : " + vb.ToString("N2"));break;
                default: Console.WriteLine("Angka tidak valid! "); break;




            }
            



           


        }
    }
}
