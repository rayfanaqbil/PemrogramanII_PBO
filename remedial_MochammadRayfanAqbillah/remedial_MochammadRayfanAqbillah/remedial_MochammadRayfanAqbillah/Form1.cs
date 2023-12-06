using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace remedial_MochammadRayfanAqbillah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Size Form awal mula di buka
            this.Size = new Size(889, 324);
            groupBoxKuliah.Enabled = false;
        }


        //Validasi textbox NIM
        private void boxNIM_TextChanged(object sender, EventArgs e)
        {
            if (boxNIM.Text == "")
            {
                epCorrect.SetError(boxNIM, "");
                epWarning.SetError(boxNIM, "NIM tidak boleh kosong, tidak boleh kosong!");
                epWrong.SetError(boxNIM, "");
            }
            else
            {
                if ((boxNIM.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(boxNIM, "NIM Benar!");
                    epWarning.SetError(boxNIM, "");
                    epWrong.SetError(boxNIM, "");
                }

                else if ((boxNIM.Text).All(Char.IsLetter))
                {
                    epCorrect.SetError(boxNIM, "");
                    epWarning.SetError(boxNIM, "");
                    epWrong.SetError(boxNIM, "NIM harus berupa huruf angka!");
                }
            }
        }

        //Validasi Textbox Nama
        private void txtNama_TextChanged(object sender, EventArgs e)
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
                    epWrong.SetError(txtNama, "Box harus di isi huruf");
                }
            }
        }

        //Validasi Textbox Akademik
        private void txtAkademik_TextChanged(object sender, EventArgs e)
        {
            if (txtAkademik.Text == "")
            {
                epWarning.SetError(txtAkademik, "Textbox Tahun Akademik tidak boleh kosong!");
                epWrong.SetError(txtAkademik, "");
                epCorrect.SetError(txtAkademik, "");
            }
            else
            {
                if (Regex.IsMatch(txtAkademik.Text, @"^\d{4}/\d{4}$"))

                {
                    epCorrect.SetError(txtAkademik, "Correct");
                    epWarning.SetError(txtAkademik, "");
                    epWrong.SetError(txtAkademik, "");
                }
                else
                {
                    epWrong.SetError(txtAkademik, "Format Tahun Akademik salah!\nContoh: 2022/2023 ");
                    epWarning.SetError(txtAkademik, "");
                    epCorrect.SetError(txtAkademik, "");
                }
            }
        }

        //Validasi Textbox ProgramStudi
        private void cbProgramStudi_TextChanged(object sender, EventArgs e)
        {
            if (cbProgramStudi.SelectedItem != null)
            {
                string pilihProgramStudi = cbProgramStudi.SelectedItem.ToString();
                epCorrect.SetError(cbProgramStudi, "Correct");
                epWarning.SetError(cbProgramStudi, "");
                epWrong.SetError(cbProgramStudi, "");


                if (pilihProgramStudi == "D3 - Teknik Informatika" || pilihProgramStudi == "D4 - Teknik Informatika")
                {

                }
            }
            else
            {
                epCorrect.SetError(cbProgramStudi, "");
                epWarning.SetError(cbProgramStudi, "pilih salah satu Program Studi");
                epWrong.SetError(cbProgramStudi, "");
            }
        }

        //Validasi Textbos Semester
        private void txtSemester_TextChanged(object sender, EventArgs e)
        {
            if (txtSemester.Text == "")
            {
                epWrong.SetError(txtSemester, "");
                epWarning.SetError(txtSemester, "textbox semester tidak boleh kosong, Harus di isi!");
                epCorrect.SetError(txtSemester, "");
            }
            else
            {
                if ((txtSemester.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtSemester, "textbox Semester benar!");
                    epWarning.SetError(txtSemester, "");
                    epWrong.SetError(txtSemester, "");
                }

                else if ((txtSemester.Text).All(Char.IsLetter))
                {
                    epWrong.SetError(txtSemester, "Semester harus berupa angka");
                    epCorrect.SetError(txtSemester, "");
                    epWarning.SetError(txtSemester, "");
                }
            }
        }

        //Validasi Textbox Alamat
        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            string alamatText = txtAlamat.Text;

            if (string.IsNullOrWhiteSpace(alamatText))
            {
                epWarning.SetError(txtAlamat, "Textbox Alamat tidak boleh kosong!");
                epCorrect.SetError(txtAlamat, "");
                epWrong.SetError(txtAlamat, "");
            }

            else
            {
                epCorrect.SetError(txtAlamat, "Benar!");
                epWarning.SetError(txtAlamat, "");
                epWrong.SetError(txtAlamat, "");
            }
        }

        // Validasi Button pilih mata kuliah
        private void pilihMataKuliah_Click(object sender, EventArgs e)
        {
            string Ismatakuliah = "";


            if (string.IsNullOrEmpty(boxNIM.Text))
            {
                Ismatakuliah += "NIM belom di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(boxNIM.Text, @"^\d+$"))
            {
                Ismatakuliah += "NIM salah. \n";
            }

            if (string.IsNullOrEmpty(txtNama.Text))
            {
                Ismatakuliah += "Nama belom di isi. \n";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtNama.Text, "^[a-zA-Z]+$"))
            {
                Ismatakuliah += "Nama salah. \n";
            }

            if (rdLaki.Checked == false && rdPerempuan.Checked == false)
            {
                Ismatakuliah += "Jenis kelamin belom di isi. \n";
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                Ismatakuliah += "Alamat belom di isi. \n";
            }

            if (string.IsNullOrEmpty(cbProgramStudi.Text))
            {
                Ismatakuliah += "Program studi belom di isi. \n";
            }

            if (string.IsNullOrEmpty(txtAkademik.Text))
            {
                Ismatakuliah += "Tahun akademik belum di isi. \n";
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                Ismatakuliah += "Format tahun akademik salah. \n";
            }

            if (string.IsNullOrEmpty(txtSemester.Text))
            {
                Ismatakuliah += "Semester belum di isi. \n";
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtSemester.Text, @"^[1-8]{1}$"))
            {
                Ismatakuliah += "Semester salah. \n";
            }

            if (!string.IsNullOrEmpty(Ismatakuliah))
            {
                MessageBox.Show(Ismatakuliah, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {



                if (string.IsNullOrEmpty(Ismatakuliah))
                {
                    MessageBox.Show("Lengkap", "Informasi Data Sumbmit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Jika Validasi Form Semula berhasil maka akan menampilkan tampilan bagian bawah
                    this.Size = new Size(889, 652);
                    groupBoxKuliah.Enabled = true;
                }
            }
        }

        //Radio button Kurikulum 2006
        private void rbKurikulum2006_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxKuliah.Enabled = true;
            cbmtk.Enabled = true; cbmtk.Checked = false;
            cbpbo1.Enabled = true; cbpbo1.Checked = false;
            cbpbo2.Enabled = true; cbpbo2.Checked = false;
            cbpbo3.Enabled = true; cbpbo3.Checked = false;
            cbpbo4.Enabled = true; cbpbo4.Checked = false;
            cbfisika.Enabled = true; cbfisika.Checked = false;
            cbagama.Enabled = true; cbagama.Checked = false;
            cbpkn.Enabled = true; cbpkn.Checked = false;
            cbkomputer.Enabled = true; cbkomputer.Checked = false;
            cbsistem.Enabled = true; cbsistem.Checked = false;
            cblogistik.Enabled = false; cblogistik.Checked = false;
            cbrantaipasok.Enabled = false; cbrantaipasok.Checked = false;

        }

        //Radio Button kurikulum 2013
        private void rdKurikulum2013_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxKuliah.Enabled = true;
            cbmtk.Enabled = true; cbmtk.Checked = false;
            cbpbo1.Enabled = true; cbpbo1.Checked = false;
            cbpbo2.Enabled = true; cbpbo2.Checked = false;
            cbpbo3.Enabled = true; cbpbo3.Checked = false;
            cbpbo4.Enabled = true; cbpbo4.Checked = false;
            cbfisika.Enabled = false; cbfisika.Checked = false;
            cbagama.Enabled = true; cbagama.Checked = false;
            cbpkn.Enabled = false; cbpkn.Checked = false;
            cbkomputer.Enabled = true; cbkomputer.Checked = false;
            cbsistem.Enabled = true; cbsistem.Checked = false;
            cblogistik.Enabled = true; cblogistik.Checked = false;
            cbrantaipasok.Enabled = true; cbrantaipasok.Checked = false;
        }

        //Radio Button kurikulum merdeka
        private void rdKurikulumDeka_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxKuliah.Enabled = true;
            cbmtk.Enabled = false; cbmtk.Checked = false;
            cbpbo1.Enabled = true; cbpbo1.Checked = false;
            cbpbo2.Enabled = true; cbpbo2.Checked = false;
            cbpbo3.Enabled = true; cbpbo3.Checked = false;
            cbpbo4.Enabled = true; cbpbo4.Checked = false;
            cbfisika.Enabled = false; cbfisika.Checked = false;
            cbagama.Enabled = true; cbagama.Checked = false;
            cbpkn.Enabled = true; cbpkn.Checked = false;
            cbkomputer.Enabled = true; cbkomputer.Checked = false;
            cbsistem.Enabled = true; cbsistem.Checked = false;
            cblogistik.Enabled = false; cblogistik.Checked = false;
            cbrantaipasok.Enabled = true; cbrantaipasok.Checked = false;
        }



        //Validasi Buttin Simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string IsJenisKelamin = "";
            string Iskurikulum = "";
            string Ismatakuliah = "";

            if (rbKurikulum2006.Checked)
            {
                Iskurikulum = "Kurikulum 2006";
            }
            else if (rdKurikulum2013.Checked)
            {
                Iskurikulum = "Kurikulum 2013";
            }
            else if (rdKurikulumDeka.Checked)
            {
                Iskurikulum = "Kurikulum Merdeka";
            }

            if (cbmtk.Checked)
            {
                Ismatakuliah += "Matematika, ";
            }
            if (cbpbo1.Checked)
            {
                Ismatakuliah += "Pemrograman 1, ";
            }
            if (cbpbo2.Checked)
            {
                Ismatakuliah += "Pemrograman 2, ";
            }
            if (cbpbo3.Checked)
            {
                Ismatakuliah += "Pemrograman 3, ";
            }
            if (cbpbo4.Checked)
            {
                Ismatakuliah += "Pemrograman4, ";
            }
            if (cbfisika.Checked)
            {
                Ismatakuliah += "Fisika, ";
            }
            if (cbagama.Checked)
            {
                Ismatakuliah += "Pendidikan Agama, ";
            }
            if (cbpkn.Checked)
            {
                Ismatakuliah += "Pendidikan Kewarganegaraan, ";
            }
            if (cblogistik.Checked)
            {
                Ismatakuliah += "Pengantar Logistik, ";
            }
            if (cbkomputer.Checked)
            {
                Ismatakuliah += "Jaringan Komputer, ";
            }
            if (cbsistem.Checked)
            {
                Ismatakuliah += "Sistem Operasi, ";
            }
            if (cbrantaipasok.Checked)
            {
                Ismatakuliah += "Manajemen Rantai Pasok, ";
            }

            if (rdLaki.Checked)
            {
                IsJenisKelamin = "Laki - Laki";
            }
            else if (rdPerempuan.Checked)
            {
                IsJenisKelamin = "Perempuan";
            }
            if (!rbKurikulum2006.Checked && !rdKurikulum2013.Checked && !rdKurikulumDeka.Checked)
            {
                MessageBox.Show("Kurikulum wajib di isi.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!cbmtk.Checked && !cbpbo1.Checked && !cbpbo2.Checked && !cbpbo3.Checked &&
                !cbpbo4.Checked && !cbfisika.Checked && !cbagama.Checked && !cbpkn.Checked &&
                !cblogistik.Checked && !cbkomputer.Checked && !cbsistem.Checked && !cbrantaipasok.Checked)
            {
                MessageBox.Show("Pilih setidaknya satu mata kuliah.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("NIM: " + boxNIM.Text + "\nNama: " + txtNama.Text + "\nJenis Kelamin: " + IsJenisKelamin + "\nAlamat: " + txtAlamat.Text + "\nProgram Studi: " + cbProgramStudi.Text + "\nTahun Akademik: " + txtAkademik.Text + "\nSemester: " + txtSemester.Text + "\n=======================================" +
                               "\nKurikulum: " + Iskurikulum + "\nMata Kuliah: " + Ismatakuliah, "Informasi Data Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
    
            


    //Validasi Button Batal/reset
    private void btnBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }
            this.Size = new Size(889, 324);
            groupBoxKuliah.Enabled = false;



            cbmtk.Checked = false;
            cbpbo1.Checked = false;
            cbpbo2.Checked = false;
            cbpbo3.Checked = false;
            cbpbo4.Checked = false;
            cbpbo4.Checked = false;
            cbfisika.Checked = false;
            cbagama.Checked = false;
            cbpkn.Checked = false;
            cblogistik.Checked = false;
            cbkomputer.Checked = false;
            cbsistem.Checked = false;
            cbrantaipasok.Checked = false;
            rdLaki.Checked = false;
            rdPerempuan.Checked = false;
            groupBoxKuliah.Enabled = false;
            groupBoxKuri.Enabled = true;
            rbKurikulum2006.Checked = false;
            rdKurikulum2013.Checked = false;
            rdKurikulumDeka.Checked = false;



            MessageBox.Show("Form telah direset ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
 }

            
 

