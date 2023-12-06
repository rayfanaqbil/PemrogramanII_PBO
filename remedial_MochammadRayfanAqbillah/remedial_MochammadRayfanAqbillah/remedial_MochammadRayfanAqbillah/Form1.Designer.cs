namespace remedial_MochammadRayfanAqbillah
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAkademik = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.rdLaki = new System.Windows.Forms.RadioButton();
            this.cbProgramStudi = new System.Windows.Forms.ComboBox();
            this.groupBoxKuri = new System.Windows.Forms.GroupBox();
            this.rbKurikulum2006 = new System.Windows.Forms.RadioButton();
            this.rdKurikulumDeka = new System.Windows.Forms.RadioButton();
            this.rdKurikulum2013 = new System.Windows.Forms.RadioButton();
            this.groupBoxKuliah = new System.Windows.Forms.GroupBox();
            this.cbrantaipasok = new System.Windows.Forms.CheckBox();
            this.cbsistem = new System.Windows.Forms.CheckBox();
            this.cbkomputer = new System.Windows.Forms.CheckBox();
            this.cblogistik = new System.Windows.Forms.CheckBox();
            this.cbpkn = new System.Windows.Forms.CheckBox();
            this.cbagama = new System.Windows.Forms.CheckBox();
            this.cbfisika = new System.Windows.Forms.CheckBox();
            this.cbpbo3 = new System.Windows.Forms.CheckBox();
            this.cbpbo2 = new System.Windows.Forms.CheckBox();
            this.cbpbo1 = new System.Windows.Forms.CheckBox();
            this.cbmtk = new System.Windows.Forms.CheckBox();
            this.cbpbo4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdPerempuan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pilihMataKuliah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxKuri.SuspendLayout();
            this.groupBoxKuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // boxNIM
            // 
            this.boxNIM.Location = new System.Drawing.Point(132, 60);
            this.boxNIM.Name = "boxNIM";
            this.boxNIM.Size = new System.Drawing.Size(203, 20);
            this.boxNIM.TabIndex = 0;
            this.boxNIM.TextChanged += new System.EventHandler(this.boxNIM_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(132, 99);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(203, 20);
            this.txtNama.TabIndex = 1;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtAkademik
            // 
            this.txtAkademik.Location = new System.Drawing.Point(548, 99);
            this.txtAkademik.Name = "txtAkademik";
            this.txtAkademik.Size = new System.Drawing.Size(199, 20);
            this.txtAkademik.TabIndex = 2;
            this.txtAkademik.TextChanged += new System.EventHandler(this.txtAkademik_TextChanged);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(132, 185);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(203, 66);
            this.txtAlamat.TabIndex = 3;
            this.txtAlamat.TextChanged += new System.EventHandler(this.txtAlamat_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(548, 140);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(199, 20);
            this.txtSemester.TabIndex = 4;
            this.txtSemester.TextChanged += new System.EventHandler(this.txtSemester_TextChanged);
            // 
            // rdLaki
            // 
            this.rdLaki.AutoSize = true;
            this.rdLaki.Location = new System.Drawing.Point(132, 138);
            this.rdLaki.Name = "rdLaki";
            this.rdLaki.Size = new System.Drawing.Size(68, 17);
            this.rdLaki.TabIndex = 5;
            this.rdLaki.TabStop = true;
            this.rdLaki.Text = "Laki-Laki";
            this.rdLaki.UseVisualStyleBackColor = true;
            // 
            // cbProgramStudi
            // 
            this.cbProgramStudi.FormattingEnabled = true;
            this.cbProgramStudi.Items.AddRange(new object[] {
            "D4 - Teknik Informatika",
            "D3 - Teknik Informatika"});
            this.cbProgramStudi.Location = new System.Drawing.Point(548, 60);
            this.cbProgramStudi.Name = "cbProgramStudi";
            this.cbProgramStudi.Size = new System.Drawing.Size(199, 21);
            this.cbProgramStudi.TabIndex = 6;
            this.cbProgramStudi.TextChanged += new System.EventHandler(this.cbProgramStudi_TextChanged);
            // 
            // groupBoxKuri
            // 
            this.groupBoxKuri.Controls.Add(this.rbKurikulum2006);
            this.groupBoxKuri.Controls.Add(this.rdKurikulumDeka);
            this.groupBoxKuri.Controls.Add(this.rdKurikulum2013);
            this.groupBoxKuri.Location = new System.Drawing.Point(39, 305);
            this.groupBoxKuri.Name = "groupBoxKuri";
            this.groupBoxKuri.Size = new System.Drawing.Size(193, 146);
            this.groupBoxKuri.TabIndex = 7;
            this.groupBoxKuri.TabStop = false;
            this.groupBoxKuri.Text = "Kurikulum Pilihan";
            // 
            // rbKurikulum2006
            // 
            this.rbKurikulum2006.AutoSize = true;
            this.rbKurikulum2006.Location = new System.Drawing.Point(6, 19);
            this.rbKurikulum2006.Name = "rbKurikulum2006";
            this.rbKurikulum2006.Size = new System.Drawing.Size(98, 17);
            this.rbKurikulum2006.TabIndex = 0;
            this.rbKurikulum2006.TabStop = true;
            this.rbKurikulum2006.Text = "Kurikulum 2006";
            this.rbKurikulum2006.UseVisualStyleBackColor = true;
            this.rbKurikulum2006.CheckedChanged += new System.EventHandler(this.rbKurikulum2006_CheckedChanged);
            // 
            // rdKurikulumDeka
            // 
            this.rdKurikulumDeka.AutoSize = true;
            this.rdKurikulumDeka.Location = new System.Drawing.Point(6, 85);
            this.rdKurikulumDeka.Name = "rdKurikulumDeka";
            this.rdKurikulumDeka.Size = new System.Drawing.Size(116, 17);
            this.rdKurikulumDeka.TabIndex = 20;
            this.rdKurikulumDeka.TabStop = true;
            this.rdKurikulumDeka.Text = "Kurikulum Merdeka";
            this.rdKurikulumDeka.UseVisualStyleBackColor = true;
            this.rdKurikulumDeka.CheckedChanged += new System.EventHandler(this.rdKurikulumDeka_CheckedChanged);
            // 
            // rdKurikulum2013
            // 
            this.rdKurikulum2013.AutoSize = true;
            this.rdKurikulum2013.Location = new System.Drawing.Point(6, 52);
            this.rdKurikulum2013.Name = "rdKurikulum2013";
            this.rdKurikulum2013.Size = new System.Drawing.Size(98, 17);
            this.rdKurikulum2013.TabIndex = 19;
            this.rdKurikulum2013.TabStop = true;
            this.rdKurikulum2013.Text = "Kurikulum 2013";
            this.rdKurikulum2013.UseVisualStyleBackColor = true;
            this.rdKurikulum2013.CheckedChanged += new System.EventHandler(this.rdKurikulum2013_CheckedChanged);
            // 
            // groupBoxKuliah
            // 
            this.groupBoxKuliah.Controls.Add(this.cbrantaipasok);
            this.groupBoxKuliah.Controls.Add(this.cbsistem);
            this.groupBoxKuliah.Controls.Add(this.cbkomputer);
            this.groupBoxKuliah.Controls.Add(this.cblogistik);
            this.groupBoxKuliah.Controls.Add(this.cbpkn);
            this.groupBoxKuliah.Controls.Add(this.cbagama);
            this.groupBoxKuliah.Controls.Add(this.cbfisika);
            this.groupBoxKuliah.Controls.Add(this.cbpbo3);
            this.groupBoxKuliah.Controls.Add(this.cbpbo2);
            this.groupBoxKuliah.Controls.Add(this.cbpbo1);
            this.groupBoxKuliah.Controls.Add(this.cbmtk);
            this.groupBoxKuliah.Controls.Add(this.cbpbo4);
            this.groupBoxKuliah.Location = new System.Drawing.Point(328, 305);
            this.groupBoxKuliah.Name = "groupBoxKuliah";
            this.groupBoxKuliah.Size = new System.Drawing.Size(503, 146);
            this.groupBoxKuliah.TabIndex = 8;
            this.groupBoxKuliah.TabStop = false;
            this.groupBoxKuliah.Text = "Mata Kuliah Pilihan";
            // 
            // cbrantaipasok
            // 
            this.cbrantaipasok.AutoSize = true;
            this.cbrantaipasok.Location = new System.Drawing.Point(324, 123);
            this.cbrantaipasok.Name = "cbrantaipasok";
            this.cbrantaipasok.Size = new System.Drawing.Size(148, 17);
            this.cbrantaipasok.TabIndex = 25;
            this.cbrantaipasok.Text = "Manajemen Rantai Pasok";
            this.cbrantaipasok.UseVisualStyleBackColor = true;
            // 
            // cbsistem
            // 
            this.cbsistem.AutoSize = true;
            this.cbsistem.Location = new System.Drawing.Point(324, 86);
            this.cbsistem.Name = "cbsistem";
            this.cbsistem.Size = new System.Drawing.Size(96, 17);
            this.cbsistem.TabIndex = 24;
            this.cbsistem.Text = "Sistem Operasi";
            this.cbsistem.UseVisualStyleBackColor = true;
            // 
            // cbkomputer
            // 
            this.cbkomputer.AutoSize = true;
            this.cbkomputer.Location = new System.Drawing.Point(324, 52);
            this.cbkomputer.Name = "cbkomputer";
            this.cbkomputer.Size = new System.Drawing.Size(114, 17);
            this.cbkomputer.TabIndex = 23;
            this.cbkomputer.Text = "Jaringan Komputer";
            this.cbkomputer.UseVisualStyleBackColor = true;
            // 
            // cblogistik
            // 
            this.cblogistik.AutoSize = true;
            this.cblogistik.Location = new System.Drawing.Point(324, 19);
            this.cblogistik.Name = "cblogistik";
            this.cblogistik.Size = new System.Drawing.Size(120, 17);
            this.cblogistik.TabIndex = 22;
            this.cblogistik.Text = "Penngantar Logistik";
            this.cblogistik.UseVisualStyleBackColor = true;
            // 
            // cbpkn
            // 
            this.cbpkn.AutoSize = true;
            this.cbpkn.Location = new System.Drawing.Point(144, 123);
            this.cbpkn.Name = "cbpkn";
            this.cbpkn.Size = new System.Drawing.Size(169, 17);
            this.cbpkn.TabIndex = 21;
            this.cbpkn.Text = "Pendidikan Kewarganegaraan";
            this.cbpkn.UseVisualStyleBackColor = true;
            // 
            // cbagama
            // 
            this.cbagama.AutoSize = true;
            this.cbagama.Location = new System.Drawing.Point(144, 85);
            this.cbagama.Name = "cbagama";
            this.cbagama.Size = new System.Drawing.Size(115, 17);
            this.cbagama.TabIndex = 20;
            this.cbagama.Text = "Pendidikan Agama";
            this.cbagama.UseVisualStyleBackColor = true;
            // 
            // cbfisika
            // 
            this.cbfisika.AutoSize = true;
            this.cbfisika.Location = new System.Drawing.Point(144, 52);
            this.cbfisika.Name = "cbfisika";
            this.cbfisika.Size = new System.Drawing.Size(53, 17);
            this.cbfisika.TabIndex = 19;
            this.cbfisika.Text = "Fisika";
            this.cbfisika.UseVisualStyleBackColor = true;
            // 
            // cbpbo3
            // 
            this.cbpbo3.AutoSize = true;
            this.cbpbo3.Location = new System.Drawing.Point(7, 123);
            this.cbpbo3.Name = "cbpbo3";
            this.cbpbo3.Size = new System.Drawing.Size(100, 17);
            this.cbpbo3.TabIndex = 3;
            this.cbpbo3.Text = "Pemrograman 3";
            this.cbpbo3.UseVisualStyleBackColor = true;
            // 
            // cbpbo2
            // 
            this.cbpbo2.AutoSize = true;
            this.cbpbo2.Location = new System.Drawing.Point(7, 85);
            this.cbpbo2.Name = "cbpbo2";
            this.cbpbo2.Size = new System.Drawing.Size(97, 17);
            this.cbpbo2.TabIndex = 2;
            this.cbpbo2.Text = "Pemograman 2";
            this.cbpbo2.UseVisualStyleBackColor = true;
            // 
            // cbpbo1
            // 
            this.cbpbo1.AutoSize = true;
            this.cbpbo1.Location = new System.Drawing.Point(7, 52);
            this.cbpbo1.Name = "cbpbo1";
            this.cbpbo1.Size = new System.Drawing.Size(97, 17);
            this.cbpbo1.TabIndex = 1;
            this.cbpbo1.Text = "Pemograman 1";
            this.cbpbo1.UseVisualStyleBackColor = true;
            // 
            // cbmtk
            // 
            this.cbmtk.AutoSize = true;
            this.cbmtk.Location = new System.Drawing.Point(7, 19);
            this.cbmtk.Name = "cbmtk";
            this.cbmtk.Size = new System.Drawing.Size(81, 17);
            this.cbmtk.TabIndex = 0;
            this.cbmtk.Text = "Matematika";
            this.cbmtk.UseVisualStyleBackColor = true;
            // 
            // cbpbo4
            // 
            this.cbpbo4.AutoSize = true;
            this.cbpbo4.Location = new System.Drawing.Point(144, 19);
            this.cbpbo4.Name = "cbpbo4";
            this.cbpbo4.Size = new System.Drawing.Size(97, 17);
            this.cbpbo4.TabIndex = 9;
            this.cbpbo4.Text = "Pemograman 4";
            this.cbpbo4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alamat";
            // 
            // rdPerempuan
            // 
            this.rdPerempuan.AutoSize = true;
            this.rdPerempuan.Location = new System.Drawing.Point(223, 138);
            this.rdPerempuan.Name = "rdPerempuan";
            this.rdPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdPerempuan.TabIndex = 14;
            this.rdPerempuan.TabStop = true;
            this.rdPerempuan.Text = "Perempuan";
            this.rdPerempuan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "PILIHAN MATA KULIAH MASAHAISWA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Semester";
            // 
            // pilihMataKuliah
            // 
            this.pilihMataKuliah.Location = new System.Drawing.Point(620, 219);
            this.pilihMataKuliah.Name = "pilihMataKuliah";
            this.pilihMataKuliah.Size = new System.Drawing.Size(127, 32);
            this.pilihMataKuliah.TabIndex = 19;
            this.pilihMataKuliah.Text = "Pilih Mata Kuliah";
            this.pilihMataKuliah.UseVisualStyleBackColor = true;
            this.pilihMataKuliah.Click += new System.EventHandler(this.pilihMataKuliah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(223, 515);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 31);
            this.btnSimpan.TabIndex = 20;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(384, 515);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(129, 31);
            this.btnBatal.TabIndex = 21;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 592);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.pilihMataKuliah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdPerempuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxKuliah);
            this.Controls.Add(this.groupBoxKuri);
            this.Controls.Add(this.cbProgramStudi);
            this.Controls.Add(this.rdLaki);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtAkademik);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.boxNIM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKuri.ResumeLayout(false);
            this.groupBoxKuri.PerformLayout();
            this.groupBoxKuliah.ResumeLayout(false);
            this.groupBoxKuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAkademik;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.RadioButton rdLaki;
        private System.Windows.Forms.ComboBox cbProgramStudi;
        private System.Windows.Forms.GroupBox groupBoxKuri;
        private System.Windows.Forms.GroupBox groupBoxKuliah;
        private System.Windows.Forms.CheckBox cbpbo4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdPerempuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdKurikulum2013;
        private System.Windows.Forms.RadioButton rdKurikulumDeka;
        private System.Windows.Forms.RadioButton rbKurikulum2006;
        private System.Windows.Forms.CheckBox cbpbo3;
        private System.Windows.Forms.CheckBox cbpbo2;
        private System.Windows.Forms.CheckBox cbpbo1;
        private System.Windows.Forms.CheckBox cbmtk;
        private System.Windows.Forms.CheckBox cbrantaipasok;
        private System.Windows.Forms.CheckBox cbsistem;
        private System.Windows.Forms.CheckBox cbkomputer;
        private System.Windows.Forms.CheckBox cblogistik;
        private System.Windows.Forms.CheckBox cbpkn;
        private System.Windows.Forms.CheckBox cbagama;
        private System.Windows.Forms.CheckBox cbfisika;
        private System.Windows.Forms.Button pilihMataKuliah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}

