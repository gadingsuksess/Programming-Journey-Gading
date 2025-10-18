using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIODATA DIRI SENDIRI ===");
            Console.Write("Nama Lengkap          :");
            string nl = Console.ReadLine();
            Console.Write("Nama Panggilan        :");
            string np = Console.ReadLine();
            Console.Write("Jenis kelamin         :");
            string jk = Console.ReadLine();
            Console.Write("Agama                 :");
            string ag = Console.ReadLine();
            Console.Write("Umur                  :");
            string umr = Console.ReadLine();
            Console.Write("Kelas                 :");
            string kl = Console.ReadLine();
            Console.Write("Jurusan               :");
            string jr = Console.ReadLine();
            Console.Write("Alamat                :");
            string alm = Console.ReadLine();
            Console.Write("Hobi                  :");
            string hb = Console.ReadLine();
            Console.Write("Cita cita             :");
            string ct = Console.ReadLine();
            Console.WriteLine("=================================");
            Console.WriteLine("=== BIODATA DIRI SENDIRI");
            Console.WriteLine($"Nama Lenkap          : {nl}");
            Console.WriteLine($"Nama Panggilan       : {np}");
            Console.WriteLine($"Jenis Kelamin        : {jk}");
            Console.WriteLine($"Agama                : {ag}");
            Console.WriteLine($"Umur                 : {umr}");
            Console.WriteLine($"Kelas                : {kl}");
            Console.WriteLine($"Jurusan              : {jr}");
            Console.WriteLine($"Alamat               : {alm}");
            Console.WriteLine($"Hobi                 : {hb}");
            Console.WriteLine($"Cita cita            : {ct}");
        }
    }
}
