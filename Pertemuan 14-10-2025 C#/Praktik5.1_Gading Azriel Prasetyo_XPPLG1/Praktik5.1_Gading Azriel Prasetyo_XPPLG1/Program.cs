using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik5._1_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array dengan 5 elemen tipe data string
            string[] siswa = new string[5];

            // Mengisi elemen array
            siswa[0] = "Gading";
            siswa[1] = "Roichan";
            siswa[2] = "Arya";
            siswa[3] = "Fadhil";
            siswa[4] = "Noval";

            // Menampilkan isi array tanpa perulangan
            Console.WriteLine("Daftar Nama Siswa : ");
            Console.WriteLine("Siswa Ke-1 : " + siswa[0]);
            Console.WriteLine("Siswa Ke-2 : " + siswa[1]);
            Console.WriteLine("Siswa Ke-3 : " + siswa[2]);
            Console.WriteLine("Siswa Ke-4 : " + siswa[3]);
            Console.WriteLine("Siswa Ke-5 : " + siswa[4]);


        }
    }
}
