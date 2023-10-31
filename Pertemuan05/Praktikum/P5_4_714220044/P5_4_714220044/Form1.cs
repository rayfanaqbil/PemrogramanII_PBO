using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
           
            string GroupKelas = "";
            string GroupJadwal = "";
            string JenisKelamin2 = JenisKelamin1.GetItemText(JenisKelamin1.SelectedItem);
            DateTime tanggallahir = DateTimetgl.Value;
            string tanggalLahir1 = tanggallahir.ToString(   "dd MMMM yyyy");

            if (ckBiola.Checked)
            {
                GroupKelas = "Biola, ";
            }
            if (ckGitar.Checked)
            {
                GroupKelas = "Gitar, ";
            }
            if (ckSaxophone.Checked)
            {
                GroupKelas = "Saxophone, ";
            }
            if (ckKonduktor.Checked)
            {
                GroupKelas = "Konduktor, ";
            }
            if (ckPiano.Checked)
            {
                GroupKelas  = "Piano, ";
            }
            if (ckDrum.Checked)
            {
                GroupKelas += "Drum, ";
            }
            if (ckVokal.Checked)
            {
                GroupKelas += "Vokal, ";
            }
            if (ckKomposer.Checked)
            {
                GroupKelas = "Komposer";
            }
            if (!string.IsNullOrEmpty(GroupKelas))
            {
                GroupKelas = GroupKelas.TrimEnd(' ', ',');
            }

            if (rdSeninRabu.Checked)
            {
                GroupJadwal = "Senin & Rabu, 14.00 - 16.00";
            }

            if (rdSelasaKamis.Checked)
            {
                GroupJadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rdSabtuMinggu.Checked)
            {
                GroupJadwal = "Sabtu & Minggu, 14.00 - 16.00";
            }
            else if (rdMinggu.Checked)
            {
                GroupJadwal = "Minggu, 09.00 - 11.00";
            }
            
            if (GroupKelas != "" && GroupJadwal != "")
            {
                MessageBox.Show("Nama : " + txtNama.Text + "\nJenis Kelamin : " + JenisKelamin2 + "\nTanggal Lahir : " + tanggalLahir1 + "\nPilihan Kelas : " + GroupKelas + "\nPilihan Jadwal : " + GroupJadwal, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtNama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( JenisKelamin2 == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( GroupKelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( GroupJadwal == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
