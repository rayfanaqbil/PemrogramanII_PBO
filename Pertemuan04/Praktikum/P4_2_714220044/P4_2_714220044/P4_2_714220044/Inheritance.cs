using P4_2_714220044;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220044
{
    internal class Inheritance
    {
    }

    public class Laptop
    {
        public string Merek {  get; set; }
        public string GPU { get; set; }
        public string Procesor { get; set; }

        public string HDD {  get; set; }

        public void Ram3()
        {
            Console.WriteLine("16 GB");
        }
        public void Ram1()
        {
            Console.WriteLine("8 GB");
        }
    }
}

    class Lenovo : Laptop
{
    public Lenovo()
    {
        Merek = "Lenovo";
        GPU = "Nvidia 750 Ti";
        Procesor = "Intel core i5";
        HDD = "1TB";

    }

    public void Ram()
    {
        Console.WriteLine("4 GB");
    }



}
