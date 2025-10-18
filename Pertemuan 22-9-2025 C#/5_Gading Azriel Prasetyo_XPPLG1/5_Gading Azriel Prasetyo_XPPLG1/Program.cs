using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INPUT BIODATA SISWA ===");
            Console.WriteLine("NAMA SISWA      : ");
            string nama = Console.ReadLine();
            Console.WriteLine("KELAS           : ");
            string kelas = Console.ReadLine();
            Console.WriteLine("JENIS KELAMIN   :");
            string jk = Console.ReadLine();
            Console.WriteLine("JURUSAN         :");
            string jur = Console.ReadLine();
            Console.WriteLine("=========================");
            Console.WriteLine("=== BIODATA SISWA ===");
            Console.WriteLine($"Nama Siswa     : {nama}");
            Console.WriteLine($"Kelas          : {kelas}");
            Console.WriteLine($"Jenis Kelamin  : {jk}");
            Console.WriteLine($"Jurusan        : {jur}");
            Console.WriteLine("========================");

        }
    }
}
