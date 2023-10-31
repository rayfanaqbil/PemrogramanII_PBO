namespace P5_4_714220044
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.JenisKelamin1 = new System.Windows.Forms.ComboBox();
            this.DateTimetgl = new System.Windows.Forms.DateTimePicker();
            this.GroupKelas = new System.Windows.Forms.GroupBox();
            this.ckVokal = new System.Windows.Forms.CheckBox();
            this.ckBiola = new System.Windows.Forms.CheckBox();
            this.ckDrum = new System.Windows.Forms.CheckBox();
            this.ckGitar = new System.Windows.Forms.CheckBox();
            this.ckPiano = new System.Windows.Forms.CheckBox();
            this.ckSaxophone = new System.Windows.Forms.CheckBox();
            this.ckKomposer = new System.Windows.Forms.CheckBox();
            this.ckKonduktor = new System.Windows.Forms.CheckBox();
            this.GroupJadwal = new System.Windows.Forms.GroupBox();
            this.rdSeninRabu = new System.Windows.Forms.RadioButton();
            this.rdSelasaKamis = new System.Windows.Forms.RadioButton();
            this.rdSabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rdMinggu = new System.Windows.Forms.RadioButton();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupKelas.SuspendLayout();
            this.GroupJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(332, 56);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 3;
            // 
            // JenisKelamin1
            // 
            this.JenisKelamin1.FormattingEnabled = true;
            this.JenisKelamin1.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.JenisKelamin1.Location = new System.Drawing.Point(332, 90);
            this.JenisKelamin1.Name = "JenisKelamin1";
            this.JenisKelamin1.Size = new System.Drawing.Size(200, 21);
            this.JenisKelamin1.TabIndex = 4;
            // 
            // DateTimetgl
            // 
            this.DateTimetgl.Location = new System.Drawing.Point(332, 125);
            this.DateTimetgl.Name = "DateTimetgl";
            this.DateTimetgl.Size = new System.Drawing.Size(200, 20);
            this.DateTimetgl.TabIndex = 5;
            // 
            // GroupKelas
            // 
            this.GroupKelas.Controls.Add(this.ckVokal);
            this.GroupKelas.Controls.Add(this.ckBiola);
            this.GroupKelas.Controls.Add(this.ckDrum);
            this.GroupKelas.Controls.Add(this.ckGitar);
            this.GroupKelas.Controls.Add(this.ckPiano);
            this.GroupKelas.Controls.Add(this.ckSaxophone);
            this.GroupKelas.Controls.Add(this.ckKomposer);
            this.GroupKelas.Controls.Add(this.ckKonduktor);
            this.GroupKelas.Location = new System.Drawing.Point(66, 191);
            this.GroupKelas.Name = "GroupKelas";
            this.GroupKelas.Size = new System.Drawing.Size(302, 181);
            this.GroupKelas.TabIndex = 6;
            this.GroupKelas.TabStop = false;
            this.GroupKelas.Text = "Pilihan Kelas";
            // 
            // ckVokal
            // 
            this.ckVokal.AutoSize = true;
            this.ckVokal.Location = new System.Drawing.Point(150, 101);
            this.ckVokal.Name = "ckVokal";
            this.ckVokal.Size = new System.Drawing.Size(53, 17);
            this.ckVokal.TabIndex = 5;
            this.ckVokal.Text = "Vokal";
            this.ckVokal.UseVisualStyleBackColor = true;
            // 
            // ckBiola
            // 
            this.ckBiola.AutoSize = true;
            this.ckBiola.Location = new System.Drawing.Point(18, 30);
            this.ckBiola.Name = "ckBiola";
            this.ckBiola.Size = new System.Drawing.Size(49, 17);
            this.ckBiola.TabIndex = 0;
            this.ckBiola.Text = "Biola";
            this.ckBiola.UseVisualStyleBackColor = true;
            // 
            // ckDrum
            // 
            this.ckDrum.AutoSize = true;
            this.ckDrum.Location = new System.Drawing.Point(150, 64);
            this.ckDrum.Name = "ckDrum";
            this.ckDrum.Size = new System.Drawing.Size(51, 17);
            this.ckDrum.TabIndex = 4;
            this.ckDrum.Text = "Drum";
            this.ckDrum.UseVisualStyleBackColor = true;
            // 
            // ckGitar
            // 
            this.ckGitar.AutoSize = true;
            this.ckGitar.Location = new System.Drawing.Point(18, 64);
            this.ckGitar.Name = "ckGitar";
            this.ckGitar.Size = new System.Drawing.Size(48, 17);
            this.ckGitar.TabIndex = 1;
            this.ckGitar.Text = "Gitar";
            this.ckGitar.UseVisualStyleBackColor = true;
            // 
            // ckPiano
            // 
            this.ckPiano.AutoSize = true;
            this.ckPiano.Location = new System.Drawing.Point(150, 30);
            this.ckPiano.Name = "ckPiano";
            this.ckPiano.Size = new System.Drawing.Size(53, 17);
            this.ckPiano.TabIndex = 3;
            this.ckPiano.Text = "Piano";
            this.ckPiano.UseVisualStyleBackColor = true;
            // 
            // ckSaxophone
            // 
            this.ckSaxophone.AutoSize = true;
            this.ckSaxophone.Location = new System.Drawing.Point(18, 101);
            this.ckSaxophone.Name = "ckSaxophone";
            this.ckSaxophone.Size = new System.Drawing.Size(80, 17);
            this.ckSaxophone.TabIndex = 2;
            this.ckSaxophone.Text = "Saxophone";
            this.ckSaxophone.UseVisualStyleBackColor = true;
            // 
            // ckKomposer
            // 
            this.ckKomposer.AutoSize = true;
            this.ckKomposer.Location = new System.Drawing.Point(150, 142);
            this.ckKomposer.Name = "ckKomposer";
            this.ckKomposer.Size = new System.Drawing.Size(73, 17);
            this.ckKomposer.TabIndex = 10;
            this.ckKomposer.Text = "Komposer";
            this.ckKomposer.UseVisualStyleBackColor = true;
            // 
            // ckKonduktor
            // 
            this.ckKonduktor.AutoSize = true;
            this.ckKonduktor.Location = new System.Drawing.Point(18, 142);
            this.ckKonduktor.Name = "ckKonduktor";
            this.ckKonduktor.Size = new System.Drawing.Size(75, 17);
            this.ckKonduktor.TabIndex = 9;
            this.ckKonduktor.Text = "Konduktor";
            this.ckKonduktor.UseVisualStyleBackColor = true;
            // 
            // GroupJadwal
            // 
            this.GroupJadwal.Controls.Add(this.rdSeninRabu);
            this.GroupJadwal.Controls.Add(this.rdSelasaKamis);
            this.GroupJadwal.Controls.Add(this.rdMinggu);
            this.GroupJadwal.Controls.Add(this.rdSabtuMinggu);
            this.GroupJadwal.Location = new System.Drawing.Point(406, 191);
            this.GroupJadwal.Name = "GroupJadwal";
            this.GroupJadwal.Size = new System.Drawing.Size(298, 181);
            this.GroupJadwal.TabIndex = 7;
            this.GroupJadwal.TabStop = false;
            this.GroupJadwal.Text = "Pilihan Jadwal";
            // 
            // rdSeninRabu
            // 
            this.rdSeninRabu.AutoSize = true;
            this.rdSeninRabu.Location = new System.Drawing.Point(16, 30);
            this.rdSeninRabu.Name = "rdSeninRabu";
            this.rdSeninRabu.Size = new System.Drawing.Size(153, 17);
            this.rdSeninRabu.TabIndex = 0;
            this.rdSeninRabu.TabStop = true;
            this.rdSeninRabu.Text = "Senin & Rabu, 14.00 - 16.00";
            this.rdSeninRabu.UseVisualStyleBackColor = true;
            // 
            // rdSelasaKamis
            // 
            this.rdSelasaKamis.AutoSize = true;
            this.rdSelasaKamis.Location = new System.Drawing.Point(16, 64);
            this.rdSelasaKamis.Name = "rdSelasaKamis";
            this.rdSelasaKamis.Size = new System.Drawing.Size(160, 17);
            this.rdSelasaKamis.TabIndex = 1;
            this.rdSelasaKamis.TabStop = true;
            this.rdSelasaKamis.Text = "Selasa & Kamis, 14.00 - 16.00";
            this.rdSelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rdSabtuMinggu
            // 
            this.rdSabtuMinggu.AutoSize = true;
            this.rdSabtuMinggu.Location = new System.Drawing.Point(16, 101);
            this.rdSabtuMinggu.Name = "rdSabtuMinggu";
            this.rdSabtuMinggu.Size = new System.Drawing.Size(163, 17);
            this.rdSabtuMinggu.TabIndex = 2;
            this.rdSabtuMinggu.TabStop = true;
            this.rdSabtuMinggu.Text = "Sabtu & Minggu, 09.00 - 11.00";
            this.rdSabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // rdMinggu
            // 
            this.rdMinggu.AutoSize = true;
            this.rdMinggu.Location = new System.Drawing.Point(16, 141);
            this.rdMinggu.Name = "rdMinggu";
            this.rdMinggu.Size = new System.Drawing.Size(129, 17);
            this.rdMinggu.TabIndex = 8;
            this.rdMinggu.TabStop = true;
            this.rdMinggu.Text = "Minggu, 13.00 - 17.00";
            this.rdMinggu.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(332, 405);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 11;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(439, 405);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 12;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Form Pedaftaran";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.GroupJadwal);
            this.Controls.Add(this.GroupKelas);
            this.Controls.Add(this.DateTimetgl);
            this.Controls.Add(this.JenisKelamin1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupKelas.ResumeLayout(false);
            this.GroupKelas.PerformLayout();
            this.GroupJadwal.ResumeLayout(false);
            this.GroupJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox JenisKelamin1;
        private System.Windows.Forms.DateTimePicker DateTimetgl;
        private System.Windows.Forms.GroupBox GroupKelas;
        private System.Windows.Forms.RadioButton rdSabtuMinggu;
        private System.Windows.Forms.RadioButton rdSelasaKamis;
        private System.Windows.Forms.RadioButton rdMinggu;
        private System.Windows.Forms.RadioButton rdSeninRabu;
        private System.Windows.Forms.GroupBox GroupJadwal;
        private System.Windows.Forms.CheckBox ckVokal;
        private System.Windows.Forms.CheckBox ckDrum;
        private System.Windows.Forms.CheckBox ckPiano;
        private System.Windows.Forms.CheckBox ckSaxophone;
        private System.Windows.Forms.CheckBox ckGitar;
        private System.Windows.Forms.CheckBox ckBiola;
        private System.Windows.Forms.CheckBox ckKonduktor;
        private System.Windows.Forms.CheckBox ckKomposer;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label4;
    }
}

