using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanfor_Gading_Azriel_Prasetyo_XPPLG1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Perkalian 5 ===");
            int kali;
            for (int i = 1; i <= 10; i++)
            {
                kali = i * 5;
                Console.WriteLine(" 5 * " + i + " = " +kali);
            }
        }
    }
}
