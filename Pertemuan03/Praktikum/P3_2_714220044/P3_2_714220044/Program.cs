﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Masukan Nilai N: ");
            N = int.Parse(Console.ReadLine());

            if (N >= 1 || N < 10)
            {
                Console.WriteLine("ANAK AYAM TURUN {0}", N);

                for (int i = N; i >= 1; i--)
                {
                    if (i == 1)
                        break;
                    {
                        Console.WriteLine("ANAK AYAM TURUNLAH {0}, MATI SATU TINGALLAH {1},", i, i - 1);
                    }
                }

                Console.WriteLine("Anak ayam turunlah 1, Mati satu tinggallah induknya");
            }
            else if (N > 10 || N < 1)
            {
                Console.WriteLine("Nilai Tidak Boleh Dibawah 0 atau diatas 10");
            }
            else
            {
                Console.WriteLine("Masukanlah Nilai Yang benar ");
            }
        }
    }
}
        
