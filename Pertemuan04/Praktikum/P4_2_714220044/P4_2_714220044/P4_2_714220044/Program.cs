using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class Inheritance
            Console.WriteLine("Inheritance");
            Laptop komponen1 = new Lenovo();
            Console.WriteLine(komponen1.Merek);
            Console.WriteLine(komponen1.GPU);
            komponen1.Ram1();
            Console.WriteLine(komponen1.Procesor);
            Console.WriteLine(komponen1.HDD);

            Console.WriteLine();

            //Class Polymorphism
            Console.WriteLine("Polymorphism");
            kendaraan bmw = new mobil();
            bmw.Suara();
            kendaraan R15 = new motor();
            R15.Suara();

            Console.WriteLine();

            //Class FieldProperty
            Console.WriteLine("Field & Property");
            orang manusia = new orang();
            manusia.nama = "Rayfan";
            manusia.Umur = 30;
            Console.WriteLine("Informasi Orang");
            Console.WriteLine("nama: {0}", manusia.nama);
            Console.WriteLine("Umur: {0}",manusia.Umur);

            Console.WriteLine();

            //Constructor
            Console.WriteLine("Constructor:");
            Kucing meow = new Kucing("Garfield", "4 kaki","Jantan", 20);
            Console.WriteLine(meow.nama);
            Console.WriteLine(meow.kaki);
            Console.WriteLine(meow.jeniskelamin);
            Console.WriteLine(meow.umur);

            Console.WriteLine();


        }

    }
}
