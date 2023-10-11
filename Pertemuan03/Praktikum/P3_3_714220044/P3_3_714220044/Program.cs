using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("MENU PERSEGI PANJANG");
                Console.WriteLine("1. Hitung Luas ");
                Console.WriteLine("2. Hitung Keliling ");

                Console.Write("Menu Pilihan : ");
                int menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine("Menghitung Luas Persegi Panjang");
                    Console.Write("Masukan Panjang :");
                    int panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Lebar :");
                    int lebar = Convert.ToInt32(Console.ReadLine());

                    int luas = panjang * lebar;
                    Console.WriteLine("Luas Persegi Panjang = {0}", luas);
                }
                else if (menu == 2)
                {
                    Console.WriteLine("Menghitung Keliling Persegi Panjang");
                    Console.Write("Masukan Panjang :");
                    int panjang = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukan Lebar :");
                    int lebar = Convert.ToInt32(Console.ReadLine());

                    int keliling = 2* (panjang + lebar);
                    Console.WriteLine("Keliling Persegi Panjang = {0} ", keliling);
                }
                else
                {
                    Console.WriteLine("Menu tidak ada!");
                }
                Console.Write("\nIngin mengulang kembali (Y/N)");
            }
            while (Console.ReadLine() == "Y");
        }
        
    
    }
}
