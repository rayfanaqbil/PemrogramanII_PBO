using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220044
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Masukan Angka : ");

                Console.WriteLine("===Masukan Angka kesatu === ");
                int angka1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("===Masukkan angka kedua=== ");
                int angka2 = Convert.ToInt32(Console.ReadLine());

                int Tambah = angka1 + angka2;
                int Kurang = angka1 - angka2;
                int Kali = angka1 * angka2;
                float Bagi = (float)angka1 / angka2;

                Console.WriteLine("Hasil Pertambahan: " + Tambah);
                Console.WriteLine("Hasil Pengurangan: " + Kurang);
                Console.WriteLine("Hasil Perkalian: " + Kali);
                Console.WriteLine("Hasil Pembagian: " + Bagi);
                
            }
    }
}
