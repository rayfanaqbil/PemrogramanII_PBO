using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Huruf tidak boleh ");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul! ");

                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh Huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Input tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");

                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epCorrect.SetError(txtEmail, "Betul");
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");

            }
            else
            {
                epCorrect.SetError(txtEmail, "");
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Format Email salah!\nContoh: a@b.c ");
            }
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Input kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {

            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Benar");
                    epCorrect.SetError(txtAngka2, "Benar");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWarning.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah");
                    epWrong.SetError(txtAngka2, "Input salah");
                }
            }

            else if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input jangan kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Input  tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Input tidak boleh kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka1, "Input hanya boleh angka");
                epWarning.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }
        }

     
        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngka1.Text, out int Angka1) && int.TryParse(txtAngka2.Text, out int Angka2))
            {
                if (Angka1 > Angka2)
                {
                    epCorrect.SetError(txtAngka1, "Betul");
                    epCorrect.SetError(txtAngka2, "Betul");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 < Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "Angka 1 lebih kecil dari angka 2");
                    epWarning.SetError(txtAngka2, "Angka 1 lebih kecil dari angka 2");
                    epWrong.SetError(txtAngka1, "");
                    epWrong.SetError(txtAngka2, "");
                }
                else if (Angka1 == Angka2)
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Angka 1 sama dengan angka 2");
                    epWrong.SetError(txtAngka2, "Angka 1 sama dengan angka 2");
                }
                else
                {
                    epCorrect.SetError(txtAngka1, "");
                    epCorrect.SetError(txtAngka2, "");
                    epWarning.SetError(txtAngka1, "");
                    epWarning.SetError(txtAngka2, "");
                    epWrong.SetError(txtAngka1, "Input salah");
                    epWrong.SetError(txtAngka2, "Input salah");
                }
            }

            else if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka1, "Input kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else if (txtAngka1.Text == "" && txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "Inputan tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");

                epWarning.SetError(txtAngka1, "Inputan tidak boleh kosong");
                epWrong.SetError(txtAngka1, "");
                epCorrect.SetError(txtAngka1, "");
            }

            else
            {
                epWrong.SetError(txtAngka2, "Input hanya boleh angka");
                epWarning.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }

        }
    }
}
