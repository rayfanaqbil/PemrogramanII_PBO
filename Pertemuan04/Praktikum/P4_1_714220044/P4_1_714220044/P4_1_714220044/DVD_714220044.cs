using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220044
{
    public class DVD_714220044 : Product_714220044
    {
        protected string _duration;

        public DVD_714220044(string title, string duration)
        {
            this.MyTitle = title;
            this.Mytype = "DVD";
            this._duration = duration;

            Console.WriteLine("DVD concstructor called");

        }

        public string Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }
    }
}



