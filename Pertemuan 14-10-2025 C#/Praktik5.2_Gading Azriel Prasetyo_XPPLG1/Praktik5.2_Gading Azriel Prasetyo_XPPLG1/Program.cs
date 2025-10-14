using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._2_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array integer dengan 5 elemen
            int[] angka = new int[5];

            // Input elemen array dari keyboard
            Console.Write("Masukkan nilai ke-1 : ");
            angka[0] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ke-2 : ");
            angka[1] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ke-3 : ");
            angka[2] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ke-4 : ");
            angka[3] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ke-5 : ");
            angka[4] = int.Parse(Console.ReadLine());

            // Menampilkan isi array tanpa perulangan
            Console.WriteLine("\nData yang anda masukkan : ");
            Console.WriteLine("Nilai Ke-1 : " + angka[0]);
            Console.WriteLine("Nilai Ke-2 : " + angka[1]);
            Console.WriteLine("Nilai Ke-3 : " + angka[2]);
            Console.WriteLine("Nilai Ke-4 : " + angka[3]);
            Console.WriteLine("Nilai Ke-5 : " + angka[4]);
        }
    }
}
