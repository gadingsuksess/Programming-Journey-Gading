using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_array_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ns = new string[3];
            string[] k = new string[3];
            char[] jk = new char[3];

            Console.Write("Masukkan nama siswa ke-1     : ");
            ns[0] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P) : ");
            jk[0] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas siswa         : ");
            k[0] = Console.ReadLine() ;

            Console.WriteLine("---------------------------------------");

            Console.Write("Masukkan nama siswa ke-2     : ");
            ns[1] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P) : ");
            jk[1] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas siswa         : ");
            k[1] = Console.ReadLine();

            Console.WriteLine("---------------------------------------");

            Console.Write("Masukkan nama siswa ke-3     : ");
            ns[2] = Console.ReadLine();
            Console.Write("Masukkan jenis kelamin (L/P) : ");
            jk[2] = char.Parse(Console.ReadLine());
            Console.Write("Masukkan kelas siswa         : ");
            k[2] = Console.ReadLine();

            Console.WriteLine("\n=== DATA SISWA ===");
            Console.WriteLine("Nama Siswa : " + ns[0] + " | Jenis Kelamin : " + jk[0] + " | Kelas : " + k[0]);
            Console.WriteLine("Nama Siswa : " + ns[1] + " | Jenis Kelamin : " + jk[1] + " | Kelas : " + k[1]);
            Console.WriteLine("Nama Siswa : " + ns[2] + " | Jenis Kelamin : " + jk[2] + " | Kelas : " + k[2]);
        }
    }
}
