using MySql.Data.MySqlClient;
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
    public partial class FormTransaksiBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        string id_transaksi;
        M_transaksi_barang m_transaksi_barang = new M_transaksi_barang();
        M_barang m_barang = new M_barang();

        public void Tampil()
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, i.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang i ON (t.id_barang = i.id_barang)");
            DataTransaksi.Columns[0].HeaderText = "ID";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "QTY";
            DataTransaksi.Columns[5].HeaderText = "Total Harga";
        }

        public void ResetForm()
        {
            cbBarang.Text = "";
            tbBarang.Text = "";
            tbHargaBarang.Text = "";
            tbQty.Text = "";
            tbTotal.Text = "";
            tbCariData.Text = "";
        }

        public FormTransaksiBarang()
        {
            InitializeComponent();
            tbBarang.ReadOnly = true;
            tbBarang.Enabled = false;
            tbHargaBarang.Enabled = false;
            tbHargaBarang.ReadOnly = true;
            tbTotal.Enabled = false;
            tbTotal.ReadOnly = true;

            LoadIdBarang();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void AmbilDataBarang(int IdBarang)
        {
            koneksi.OpenConnection();

            string query = $"SELECT nama_barang, harga FROM t_barang WHERE id_barang = {IdBarang}";
            MySqlDataReader reader = koneksi.reader(query);

            if (reader.Read())
            {
                tbBarang.Text = reader["nama_barang"].ToString();
                tbHargaBarang.Text = reader["harga"].ToString();
            }

            reader.Close();
            koneksi.CloseConnection();
        }

        private void TotalHarga()
        {
            if (double.TryParse(tbQty.Text, out double qty_barang) && double.TryParse(tbHargaBarang.Text.Replace(".", ""), out double harga_barang))
            {
                double totals = qty_barang * harga_barang;

                string formattedTotal = string.Format("{0:#,##0}", totals);

                tbTotal.Text = formattedTotal;
            }
        }

        public void LoadIdBarang()
        {
            koneksi.OpenConnection();

            string query = "SELECT id_barang FROM t_barang";
            object dataTable = koneksi.ShowData(query);

            cbBarang.DisplayMember = "id_barang";
            cbBarang.ValueMember = "id_barang";
            cbBarang.DataSource = dataTable;

            koneksi.CloseConnection();
        }


        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, b.id_barang, nama_barang, harga, qty, total FROM t_transaksi t JOIN t_barang b ON (t.id_barang = b.id_barang) WHERE id_transaksi LIKE '%' '" + tbCariData.Text + "' '%' OR t.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR b.id_barang LIKE '%' '" + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' OR harga LIKE '%' '" + tbCariData.Text + "' '%' OR qty LIKE '%' '" + tbCariData.Text + "' '%' OR total LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbBarang.Text == "" || tbBarang.Text == "" || tbHargaBarang.Text == "" || tbQty.Text == "" || tbTotal.Text == "" || cbBarang.Text.Any(Char.IsLetter) || tbQty.Text.Any(Char.IsLetter) || cbBarang.SelectedItem == null)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = cbBarang.Text;
                m_transaksi_barang.Qty = tbQty.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksi_barang.Total = numericTotal.ToString();
                }

                transaksi.Insert(m_transaksi_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (cbBarang.Text != "" || tbBarang.Text != "" || tbHargaBarang.Text != "" || tbQty.Text != "" || tbTotal.Text != "" || !cbBarang.Text.Any(Char.IsLetter) || !tbQty.Text.Any(Char.IsLetter) || cbBarang.SelectedItem != null)
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = cbBarang.Text;
                m_transaksi_barang.Qty = tbQty.Text;

                string formattedTotal = tbTotal.Text.Replace("Rp ", "").Replace(",", "");
                if (double.TryParse(formattedTotal, out double numericTotal))
                {
                    m_transaksi_barang.Total = numericTotal.ToString();
                }

                transaksi.Update(m_transaksi_barang, id_transaksi);
                ResetForm();
                Tampil();
            }
            else
            {
                MessageBox.Show("Isi data dengan benar sebelum diperbarui!", "Terjadi Kesalahan Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                transaksi.Delete(id_transaksi);
                ResetForm();
                Tampil();
            }
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbHargaBarang.Text = DataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbQty.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void DataTransaksi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 5) // Kolom harga dan total
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal harga))
                {
                    e.Value = "Rp " + harga.ToString("N0", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                    e.FormattingApplied = true;
                }
            }
        }

        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            TotalHarga();
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarang.SelectedValue != null)
            {
                int selectIdBarang;
                if (int.TryParse(cbBarang.SelectedValue.ToString(), out selectIdBarang))
                {
                    AmbilDataBarang(selectIdBarang);
                }
            }
        }
    }
}


