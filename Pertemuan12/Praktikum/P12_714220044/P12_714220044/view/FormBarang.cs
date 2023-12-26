using P10_714220044.controller;
using P10_714220044.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714220044.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;
        public FormBarang()
        {
            InitializeComponent();
            DataBarang.CellFormatting += DataBarang_CellFormatting;
        }

        public void Tampil()
        {

            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama_Barang";
            DataBarang.Columns[2].HeaderText = "Haga";


        }

        public void ResetForm()
        {
            tbNamaBarang.Text = "";
            tbHarga.Text = "";
            tbCariData.Text = "";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
            DataBarang.CellFormatting += DataBarang_CellFormatting;
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNamaBarang.Text) || (tbNamaBarang.Text).All(Char.IsNumber) || string.IsNullOrEmpty(tbHarga.Text) || (tbHarga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;
                barang.Insert(m_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNamaBarang.Text) || (tbNamaBarang.Text).All(Char.IsNumber) || string.IsNullOrEmpty(tbHarga.Text) || (tbHarga.Text).All(Char.IsLetter))
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = tbNamaBarang.Text;
                m_barang.Harga = tbHarga.Text;
                barang.Update(m_barang, id_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal harga))
                {

                    e.Value = "Rp " + harga.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
