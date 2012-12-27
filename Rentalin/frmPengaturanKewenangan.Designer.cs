namespace Rentalin
{
    partial class frmPengaturanKewenangan
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.listKewenangan = new System.Windows.Forms.ListBox();
            this.lblDaftar = new System.Windows.Forms.Label();
            this.gbDetailKewenangan = new System.Windows.Forms.GroupBox();
            this.cmbJendelaPertama = new System.Windows.Forms.ComboBox();
            this.lblJendelaPertama = new System.Windows.Forms.Label();
            this.chkPenawaranMenarik = new System.Windows.Forms.CheckBox();
            this.chkPengaturanPengguna = new System.Windows.Forms.CheckBox();
            this.chkPengaturanKewenangan = new System.Windows.Forms.CheckBox();
            this.chkPengaturanSistem = new System.Windows.Forms.CheckBox();
            this.chkHallOfFame = new System.Windows.Forms.CheckBox();
            this.chkLaporanKeuangan = new System.Windows.Forms.CheckBox();
            this.chkLaporanTransaksi = new System.Windows.Forms.CheckBox();
            this.chkLaporanNota = new System.Windows.Forms.CheckBox();
            this.chkTransaksi = new System.Windows.Forms.CheckBox();
            this.chkMasterStok = new System.Windows.Forms.CheckBox();
            this.chkMasterKoleksi = new System.Windows.Forms.CheckBox();
            this.chkMasterPelanggan = new System.Windows.Forms.CheckBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtNamaKewenanganBaru = new System.Windows.Forms.TextBox();
            this.btnTambahKewenanganBaru = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.gbDetailKewenangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-1, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(575, 62);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(13, 35);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(267, 13);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar kewenangan pengguna disini";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(11, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(226, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Kewenangan";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(306, 65);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 21);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Kewenangan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // listKewenangan
            // 
            this.listKewenangan.FormattingEnabled = true;
            this.listKewenangan.Location = new System.Drawing.Point(11, 92);
            this.listKewenangan.Name = "listKewenangan";
            this.listKewenangan.Size = new System.Drawing.Size(544, 95);
            this.listKewenangan.TabIndex = 2;
            this.listKewenangan.SelectedIndexChanged += new System.EventHandler(this.listKewenangan_SelectedIndexChanged);
            // 
            // lblDaftar
            // 
            this.lblDaftar.AutoSize = true;
            this.lblDaftar.Location = new System.Drawing.Point(12, 72);
            this.lblDaftar.Name = "lblDaftar";
            this.lblDaftar.Size = new System.Drawing.Size(102, 13);
            this.lblDaftar.TabIndex = 3;
            this.lblDaftar.Text = "Daftar Kewenangan";
            // 
            // gbDetailKewenangan
            // 
            this.gbDetailKewenangan.Controls.Add(this.cmbJendelaPertama);
            this.gbDetailKewenangan.Controls.Add(this.lblJendelaPertama);
            this.gbDetailKewenangan.Controls.Add(this.chkPenawaranMenarik);
            this.gbDetailKewenangan.Controls.Add(this.chkPengaturanPengguna);
            this.gbDetailKewenangan.Controls.Add(this.chkPengaturanKewenangan);
            this.gbDetailKewenangan.Controls.Add(this.chkPengaturanSistem);
            this.gbDetailKewenangan.Controls.Add(this.chkHallOfFame);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanKeuangan);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanTransaksi);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanNota);
            this.gbDetailKewenangan.Controls.Add(this.chkTransaksi);
            this.gbDetailKewenangan.Controls.Add(this.chkMasterStok);
            this.gbDetailKewenangan.Controls.Add(this.chkMasterKoleksi);
            this.gbDetailKewenangan.Controls.Add(this.chkMasterPelanggan);
            this.gbDetailKewenangan.Location = new System.Drawing.Point(16, 200);
            this.gbDetailKewenangan.Name = "gbDetailKewenangan";
            this.gbDetailKewenangan.Size = new System.Drawing.Size(539, 147);
            this.gbDetailKewenangan.TabIndex = 7;
            this.gbDetailKewenangan.TabStop = false;
            this.gbDetailKewenangan.Text = "Detail Kewenangan";
            this.gbDetailKewenangan.Enter += new System.EventHandler(this.gbDetailKewenangan_Enter);
            // 
            // cmbJendelaPertama
            // 
            this.cmbJendelaPertama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJendelaPertama.FormattingEnabled = true;
            this.cmbJendelaPertama.Items.AddRange(new object[] {
            "Jendela Operator",
            "Jendela Admin"});
            this.cmbJendelaPertama.Location = new System.Drawing.Point(166, 118);
            this.cmbJendelaPertama.Name = "cmbJendelaPertama";
            this.cmbJendelaPertama.Size = new System.Drawing.Size(328, 21);
            this.cmbJendelaPertama.TabIndex = 19;
            this.cmbJendelaPertama.SelectedIndexChanged += new System.EventHandler(this.cmbJendelaPertama_SelectedIndexChanged);
            // 
            // lblJendelaPertama
            // 
            this.lblJendelaPertama.AutoSize = true;
            this.lblJendelaPertama.Location = new System.Drawing.Point(6, 121);
            this.lblJendelaPertama.Name = "lblJendelaPertama";
            this.lblJendelaPertama.Size = new System.Drawing.Size(154, 13);
            this.lblJendelaPertama.TabIndex = 18;
            this.lblJendelaPertama.Text = "Jendela Pertama Setelah Login";
            // 
            // chkPenawaranMenarik
            // 
            this.chkPenawaranMenarik.AutoSize = true;
            this.chkPenawaranMenarik.Location = new System.Drawing.Point(315, 88);
            this.chkPenawaranMenarik.Name = "chkPenawaranMenarik";
            this.chkPenawaranMenarik.Size = new System.Drawing.Size(179, 17);
            this.chkPenawaranMenarik.TabIndex = 17;
            this.chkPenawaranMenarik.Text = "Pengaturan Penawaran Menarik";
            this.chkPenawaranMenarik.UseVisualStyleBackColor = true;
            this.chkPenawaranMenarik.CheckedChanged += new System.EventHandler(this.chkPenawaranMenarik_CheckedChanged);
            // 
            // chkPengaturanPengguna
            // 
            this.chkPengaturanPengguna.AutoSize = true;
            this.chkPengaturanPengguna.Location = new System.Drawing.Point(315, 65);
            this.chkPengaturanPengguna.Name = "chkPengaturanPengguna";
            this.chkPengaturanPengguna.Size = new System.Drawing.Size(133, 17);
            this.chkPengaturanPengguna.TabIndex = 17;
            this.chkPengaturanPengguna.Text = "Pengaturan Pengguna";
            this.chkPengaturanPengguna.UseVisualStyleBackColor = true;
            this.chkPengaturanPengguna.CheckedChanged += new System.EventHandler(this.chkPengaturanPengguna_CheckedChanged);
            // 
            // chkPengaturanKewenangan
            // 
            this.chkPengaturanKewenangan.AutoSize = true;
            this.chkPengaturanKewenangan.Location = new System.Drawing.Point(315, 42);
            this.chkPengaturanKewenangan.Name = "chkPengaturanKewenangan";
            this.chkPengaturanKewenangan.Size = new System.Drawing.Size(147, 17);
            this.chkPengaturanKewenangan.TabIndex = 16;
            this.chkPengaturanKewenangan.Text = "Pengaturan Kewenangan";
            this.chkPengaturanKewenangan.UseVisualStyleBackColor = true;
            this.chkPengaturanKewenangan.CheckedChanged += new System.EventHandler(this.chkPengaturanKewenangan_CheckedChanged);
            // 
            // chkPengaturanSistem
            // 
            this.chkPengaturanSistem.AutoSize = true;
            this.chkPengaturanSistem.Location = new System.Drawing.Point(315, 19);
            this.chkPengaturanSistem.Name = "chkPengaturanSistem";
            this.chkPengaturanSistem.Size = new System.Drawing.Size(115, 17);
            this.chkPengaturanSistem.TabIndex = 15;
            this.chkPengaturanSistem.Text = "Pengaturan Sistem";
            this.chkPengaturanSistem.UseVisualStyleBackColor = true;
            this.chkPengaturanSistem.CheckedChanged += new System.EventHandler(this.chkPengaturanSistem_CheckedChanged);
            // 
            // chkHallOfFame
            // 
            this.chkHallOfFame.AutoSize = true;
            this.chkHallOfFame.Location = new System.Drawing.Point(168, 88);
            this.chkHallOfFame.Name = "chkHallOfFame";
            this.chkHallOfFame.Size = new System.Drawing.Size(85, 17);
            this.chkHallOfFame.TabIndex = 14;
            this.chkHallOfFame.Text = "Hall of Fame";
            this.chkHallOfFame.UseVisualStyleBackColor = true;
            this.chkHallOfFame.CheckedChanged += new System.EventHandler(this.chkHallOfFame_CheckedChanged);
            // 
            // chkLaporanKeuangan
            // 
            this.chkLaporanKeuangan.AutoSize = true;
            this.chkLaporanKeuangan.Location = new System.Drawing.Point(168, 65);
            this.chkLaporanKeuangan.Name = "chkLaporanKeuangan";
            this.chkLaporanKeuangan.Size = new System.Drawing.Size(117, 17);
            this.chkLaporanKeuangan.TabIndex = 14;
            this.chkLaporanKeuangan.Text = "Laporan Keuangan";
            this.chkLaporanKeuangan.UseVisualStyleBackColor = true;
            this.chkLaporanKeuangan.CheckedChanged += new System.EventHandler(this.chkLaporanKeuangan_CheckedChanged);
            // 
            // chkLaporanTransaksi
            // 
            this.chkLaporanTransaksi.AutoSize = true;
            this.chkLaporanTransaksi.Location = new System.Drawing.Point(168, 42);
            this.chkLaporanTransaksi.Name = "chkLaporanTransaksi";
            this.chkLaporanTransaksi.Size = new System.Drawing.Size(114, 17);
            this.chkLaporanTransaksi.TabIndex = 13;
            this.chkLaporanTransaksi.Text = "Laporan Transaksi";
            this.chkLaporanTransaksi.UseVisualStyleBackColor = true;
            this.chkLaporanTransaksi.CheckedChanged += new System.EventHandler(this.chkLaporanTransaksi_CheckedChanged);
            // 
            // chkLaporanNota
            // 
            this.chkLaporanNota.AutoSize = true;
            this.chkLaporanNota.Location = new System.Drawing.Point(168, 19);
            this.chkLaporanNota.Name = "chkLaporanNota";
            this.chkLaporanNota.Size = new System.Drawing.Size(91, 17);
            this.chkLaporanNota.TabIndex = 12;
            this.chkLaporanNota.Text = "Laporan Nota";
            this.chkLaporanNota.UseVisualStyleBackColor = true;
            this.chkLaporanNota.CheckedChanged += new System.EventHandler(this.chkLaporanNota_CheckedChanged);
            // 
            // chkTransaksi
            // 
            this.chkTransaksi.AutoSize = true;
            this.chkTransaksi.Location = new System.Drawing.Point(6, 88);
            this.chkTransaksi.Name = "chkTransaksi";
            this.chkTransaksi.Size = new System.Drawing.Size(72, 17);
            this.chkTransaksi.TabIndex = 11;
            this.chkTransaksi.Text = "Transaksi";
            this.chkTransaksi.UseVisualStyleBackColor = true;
            this.chkTransaksi.CheckedChanged += new System.EventHandler(this.chkTransaksi_CheckedChanged);
            // 
            // chkMasterStok
            // 
            this.chkMasterStok.AutoSize = true;
            this.chkMasterStok.Location = new System.Drawing.Point(6, 65);
            this.chkMasterStok.Name = "chkMasterStok";
            this.chkMasterStok.Size = new System.Drawing.Size(83, 17);
            this.chkMasterStok.TabIndex = 10;
            this.chkMasterStok.Text = "Master Stok";
            this.chkMasterStok.UseVisualStyleBackColor = true;
            this.chkMasterStok.CheckedChanged += new System.EventHandler(this.chkMasterStok_CheckedChanged);
            // 
            // chkMasterKoleksi
            // 
            this.chkMasterKoleksi.AutoSize = true;
            this.chkMasterKoleksi.Location = new System.Drawing.Point(6, 42);
            this.chkMasterKoleksi.Name = "chkMasterKoleksi";
            this.chkMasterKoleksi.Size = new System.Drawing.Size(95, 17);
            this.chkMasterKoleksi.TabIndex = 9;
            this.chkMasterKoleksi.Text = "Master Koleksi";
            this.chkMasterKoleksi.UseVisualStyleBackColor = true;
            this.chkMasterKoleksi.CheckedChanged += new System.EventHandler(this.chkMasterKoleksi_CheckedChanged);
            // 
            // chkMasterPelanggan
            // 
            this.chkMasterPelanggan.AutoSize = true;
            this.chkMasterPelanggan.Location = new System.Drawing.Point(6, 19);
            this.chkMasterPelanggan.Name = "chkMasterPelanggan";
            this.chkMasterPelanggan.Size = new System.Drawing.Size(112, 17);
            this.chkMasterPelanggan.TabIndex = 0;
            this.chkMasterPelanggan.Text = "Master Pelanggan";
            this.chkMasterPelanggan.UseVisualStyleBackColor = true;
            this.chkMasterPelanggan.CheckedChanged += new System.EventHandler(this.chkMasterPelanggan_CheckedChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(434, 65);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(121, 21);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus Kewenangan";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtNamaKewenanganBaru
            // 
            this.txtNamaKewenanganBaru.Location = new System.Drawing.Point(307, 65);
            this.txtNamaKewenanganBaru.Name = "txtNamaKewenanganBaru";
            this.txtNamaKewenanganBaru.Size = new System.Drawing.Size(157, 20);
            this.txtNamaKewenanganBaru.TabIndex = 9;
            this.txtNamaKewenanganBaru.Visible = false;
            // 
            // btnTambahKewenanganBaru
            // 
            this.btnTambahKewenanganBaru.Location = new System.Drawing.Point(470, 63);
            this.btnTambahKewenanganBaru.Name = "btnTambahKewenanganBaru";
            this.btnTambahKewenanganBaru.Size = new System.Drawing.Size(85, 23);
            this.btnTambahKewenanganBaru.TabIndex = 10;
            this.btnTambahKewenanganBaru.Text = "Tambah";
            this.btnTambahKewenanganBaru.UseVisualStyleBackColor = true;
            this.btnTambahKewenanganBaru.Visible = false;
            this.btnTambahKewenanganBaru.Click += new System.EventHandler(this.btnTambahKewenanganBaru_Click);
            // 
            // frmPengaturanKewenangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.btnTambahKewenanganBaru);
            this.Controls.Add(this.txtNamaKewenanganBaru);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.gbDetailKewenangan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblDaftar);
            this.Controls.Add(this.listKewenangan);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPengaturanKewenangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Pengaturan Kewenangan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPengaturanKewenangan_FormClosed);
            this.Load += new System.EventHandler(this.frmPengaturanKewenangan_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.gbDetailKewenangan.ResumeLayout(false);
            this.gbDetailKewenangan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ListBox listKewenangan;
        private System.Windows.Forms.Label lblDaftar;
        private System.Windows.Forms.GroupBox gbDetailKewenangan;
        private System.Windows.Forms.CheckBox chkHallOfFame;
        private System.Windows.Forms.CheckBox chkLaporanKeuangan;
        private System.Windows.Forms.CheckBox chkLaporanTransaksi;
        private System.Windows.Forms.CheckBox chkLaporanNota;
        private System.Windows.Forms.CheckBox chkTransaksi;
        private System.Windows.Forms.CheckBox chkMasterStok;
        private System.Windows.Forms.CheckBox chkMasterKoleksi;
        private System.Windows.Forms.CheckBox chkMasterPelanggan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.CheckBox chkPenawaranMenarik;
        private System.Windows.Forms.CheckBox chkPengaturanPengguna;
        private System.Windows.Forms.CheckBox chkPengaturanKewenangan;
        private System.Windows.Forms.CheckBox chkPengaturanSistem;
        private System.Windows.Forms.ComboBox cmbJendelaPertama;
        private System.Windows.Forms.Label lblJendelaPertama;
        private System.Windows.Forms.TextBox txtNamaKewenanganBaru;
        private System.Windows.Forms.Button btnTambahKewenanganBaru;
    }
}