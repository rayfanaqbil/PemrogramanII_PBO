using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220044
{
    internal class Polymorphism
    {
    }

    class kendaraan
    {
        public virtual void Suara()
        {
            Console.WriteLine("Suara Kendaraan Adalah");
        }

    }

    class motor : kendaraan
    {
        public override void Suara()
        {
            Console.WriteLine("Suara Motor Adalah : Ngenggggggg!");
        }
    }

    class mobil : kendaraan
    {
        public override void Suara()
        {
            Console.WriteLine("Suara Mobil Adalah : Brummmmmmm");
        }
    }

}
