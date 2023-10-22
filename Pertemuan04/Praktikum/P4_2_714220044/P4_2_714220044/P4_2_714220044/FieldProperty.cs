using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220044
{
    internal class FieldProperty
    {
    }
        public class orang
    {
        public string nama;
        private int umur;

        public int Umur
        {
            get { return umur; }
            set
            {
                if (value >= 0)
                    umur = value;
            }
        }
    }

}
