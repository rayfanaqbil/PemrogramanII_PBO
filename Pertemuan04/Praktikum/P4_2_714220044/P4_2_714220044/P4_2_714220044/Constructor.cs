using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220044
{
    public class Kucing
    {   
        public string nama;
        public int kaki;
        public string jeniskelamin;
        public string warnabulu;
        public int umur;

        public Kucing()
        {
            this.nama = "Mikey";
            this.kaki = 2;
            this.jeniskelamin = "";
            this.warnabulu = "red";
            this.umur = 15;
        }

        public Kucing(string nama, int kaki, string jeniskelamin, string warnabulu, int umur)
        {
            this.nama = nama;
            this.kaki = kaki;
            this.jeniskelamin = jeniskelamin;
            this.warnabulu = warnabulu;
            this.umur = umur;
        }
    }
}

































































































