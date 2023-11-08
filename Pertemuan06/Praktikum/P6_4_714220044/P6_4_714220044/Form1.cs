using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P6_4_714220044
{
    public partial class FormPendaftaranM : Form
    {
        public FormPendaftaranM()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Isnama = txtNama.Text;
            string IsUpDown = UpDownTiket.Value.ToString();
            string IsCbKelamin = cbBoxKelamin.GetItemText(cbBoxKelamin.SelectedItem);
            string IsEmail = txtEmail.Text;
            string IsPonsel = txtPonsel.Text;
            string IsKonfirm1 = txtKonfirmasi1.Text;
            string IsKonfirm2 = txtKonfirmasi2.Text;

            if (Isnama != "" && IsUpDown != "" && IsCbKelamin != "" && Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$") && IsKonfirm1.All(Char.IsUpper) && IsKonfirm1 == "KONFIRMASI" && IsKonfirm2.All(Char.IsLower) && IsKonfirm2 == "konfirmasi")
            {
       
                if (IsPonsel.Length >= 10 && IsPonsel.Length <= 12 && IsPonsel.All(char.IsDigit))
                {
                    MessageBox.Show("Nama: " + Isnama + "\nJumlah Tiket: " + IsUpDown + "\nJenis Kelamin : " + IsCbKelamin + "\nEmail : " + IsEmail + "\nNomer Ponsel : " + IsPonsel, "Data Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Perbaiki Form Box Nomor Ponsel", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Perbaiki Form Box", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epCorrect.SetError(txtNama, "");
                epWarning.SetError(txtNama, "Box harus di isi, Tidak boleh kosong");
                epWrong.SetError(txtNama, ""); ;
            }
            else
            {
                if ((txtNama.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(txtNama, "benar");
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                }
                else
                {
                    epCorrect.SetError(txtNama, "");
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "Box hanya boleh berisi karakter huruf");
                }
            }
        }

        private void UpDownTiket_Leave(object sender, EventArgs e)
        {
            int tiket = (int)UpDownTiket.Value;

            if (tiket > 0 && tiket <= 5)
            {
                epCorrect.SetError(UpDownTiket, "benar");
                epWarning.SetError(UpDownTiket, "");
                epWrong.SetError(UpDownTiket, "");
            }
            else if (tiket > 5)
            {
                epCorrect.SetError(UpDownTiket, "");
                epWarning.SetError(UpDownTiket, "Tiket tidak boleh lebih dari 5");
                epWrong.SetError(UpDownTiket, "");
            }
            else if (tiket == 0)
            {
                epCorrect.SetError(UpDownTiket, "");
                epWarning.SetError(UpDownTiket, "Tiket tidak boleh 0");
                epWrong.SetError(UpDownTiket, "");
            }
        }

        private void cbBoxKelamin_Leave(object sender, EventArgs e)
        {
            if (cbBoxKelamin.SelectedItem != null)
            {
                string pilihJenisKelamin = cbBoxKelamin.SelectedItem.ToString();
                epCorrect.SetError(cbBoxKelamin, "Correct");
                epWarning.SetError(cbBoxKelamin, "");
                epWrong.SetError(cbBoxKelamin, "");


                if (pilihJenisKelamin == "Laki-Laki" || pilihJenisKelamin == "Perempuan")
                {

                }
            }
            else
            {
                epCorrect.SetError(cbBoxKelamin, "");
                epWarning.SetError(cbBoxKelamin, "pilih salah satu jenis kelamin");
                epWrong.SetError(cbBoxKelamin, "");
            }
        }

            private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epCorrect.SetError(txtEmail, "Correct");
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
            }
            else
            {
                epCorrect.SetError(txtEmail, "");
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Format email salah!, Example : mancingmania@gmail.com");
            }
            if (txtEmail.Text == "")
            {
                epCorrect.SetError(txtEmail, "");
                epWarning.SetError(txtEmail, "Box wajib diisi!");
                epWrong.SetError(txtEmail, "");
            }
        }

        private void txtPonsel_Leave(object sender, EventArgs e)
        {
            string ponsel = txtPonsel.Text;

            if (ponsel.Length >= 10 && ponsel.Length <= 12)
            {
                epCorrect.SetError(txtPonsel, "Correct");
                epWarning.SetError(txtPonsel, "");
                epWrong.SetError(txtPonsel, "");
            }
            else if (ponsel.Length < 10)
            {
                epCorrect.SetError(txtPonsel, "");
                epWarning.SetError(txtPonsel, "Nomor ponsel terlalu pendek. Harus memiliki minimal 10 karakter.");
                epWrong.SetError(txtPonsel, "");
            }
            else if (ponsel.Length > 12)
            {
                epCorrect.SetError(txtPonsel, "");
                epWarning.SetError(txtPonsel, "Nomor ponsel terlalu panjang. Maksimal 12 karakter.");
                epWrong.SetError(txtPonsel, "");
            }
        }


        private void txtKonfirmasi1_Leave(object sender, EventArgs e)
        {
            if ((txtKonfirmasi1.Text).All(Char.IsUpper) && (txtKonfirmasi1.Text == "KONFIRMASI"))
            {
                epCorrect.SetError(txtKonfirmasi1, "Betul!");
                epWarning.SetError(txtKonfirmasi1, "");
                epWrong.SetError(txtKonfirmasi1, "");
            }
            if ((txtKonfirmasi1.Text).Any(Char.IsLower))
            {
                epCorrect.SetError(txtKonfirmasi1 ,"");
                epWarning.SetError(txtKonfirmasi1, "");
                epWrong.SetError(txtKonfirmasi1, "Huruf harus besar atau Upercase 'KONFRIMASI");
            }

            if ((txtKonfirmasi1.Text == ""))
            {
                epCorrect.SetError(txtKonfirmasi1, "");
                epWarning.SetError(txtKonfirmasi1, "Huruf tidak boleh kosong!");
                epWrong.SetError(txtKonfirmasi1, "");
            }
        }

        private void txtKonfirmasi2_Leave(object sender, EventArgs e)
        {
            if ((txtKonfirmasi2.Text).All(Char.IsLower) && (txtKonfirmasi2.Text == "konfirmasi"))
            {
                epCorrect.SetError(txtKonfirmasi2, "Betul!");
                epWarning.SetError(txtKonfirmasi2, "");
                epWrong.SetError(txtKonfirmasi2, "");
            }
            if ((txtKonfirmasi2.Text).Any(Char.IsUpper))
            {
                epCorrect.SetError(txtKonfirmasi2, "");
                epWarning.SetError(txtKonfirmasi2, "");
                epWrong.SetError(txtKonfirmasi2, "Pakai huruf kecil lowercase dan kata 'daftar'");
            }

            if ((txtKonfirmasi2.Text == ""))
            {
                epCorrect.SetError(txtKonfirmasi2, "");
                epWarning.SetError(txtKonfirmasi2, "Huruf jangan Kosong");
                epWrong.SetError(txtKonfirmasi2, "");
            }
        }

        private void FormPendaftaranM_Load(object sender, EventArgs e)
        {

        }
        }
    }
