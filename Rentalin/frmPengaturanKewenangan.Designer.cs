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
            this.chkPenawaranMenarik = new System.Windows.Forms.CheckBox();
            this.chkPengaturanPengguna = new System.Windows.Forms.CheckBox();
            this.chkPengaturanKewenangan = new System.Windows.Forms.CheckBox();
            this.chkPengaturanSistem = new System.Windows.Forms.CheckBox();
            this.chkLaporanKeuangan = new System.Windows.Forms.CheckBox();
            this.chkLaporanKoleksi = new System.Windows.Forms.CheckBox();
            this.chkLaporanMember = new System.Windows.Forms.CheckBox();
            this.chkLaporanTransaksi = new System.Windows.Forms.CheckBox();
            this.chkTransaksi = new System.Windows.Forms.CheckBox();
            this.chkMasterStok = new System.Windows.Forms.CheckBox();
            this.chkMasterKoleksi = new System.Windows.Forms.CheckBox();
            this.chkMasterPelanggan = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblJendelaPertama = new System.Windows.Forms.Label();
            this.cmbJendelaPertama = new System.Windows.Forms.ComboBox();
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
            this.lblInfoDetail.Size = new System.Drawing.Size(328, 13);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar pelanggan penyewaan di dalam jendela ini";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(11, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Pelanggan";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(306, 65);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 21);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Kewenangan";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // listKewenangan
            // 
            this.listKewenangan.FormattingEnabled = true;
            this.listKewenangan.Location = new System.Drawing.Point(11, 92);
            this.listKewenangan.Name = "listKewenangan";
            this.listKewenangan.Size = new System.Drawing.Size(544, 95);
            this.listKewenangan.TabIndex = 2;
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
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanKeuangan);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanKoleksi);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanMember);
            this.gbDetailKewenangan.Controls.Add(this.chkLaporanTransaksi);
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
            // 
            // chkLaporanKeuangan
            // 
            this.chkLaporanKeuangan.AutoSize = true;
            this.chkLaporanKeuangan.Location = new System.Drawing.Point(168, 88);
            this.chkLaporanKeuangan.Name = "chkLaporanKeuangan";
            this.chkLaporanKeuangan.Size = new System.Drawing.Size(117, 17);
            this.chkLaporanKeuangan.TabIndex = 14;
            this.chkLaporanKeuangan.Text = "Laporan Keuangan";
            this.chkLaporanKeuangan.UseVisualStyleBackColor = true;
            // 
            // chkLaporanKoleksi
            // 
            this.chkLaporanKoleksi.AutoSize = true;
            this.chkLaporanKoleksi.Location = new System.Drawing.Point(168, 65);
            this.chkLaporanKoleksi.Name = "chkLaporanKoleksi";
            this.chkLaporanKoleksi.Size = new System.Drawing.Size(102, 17);
            this.chkLaporanKoleksi.TabIndex = 14;
            this.chkLaporanKoleksi.Text = "Laporan Koleksi";
            this.chkLaporanKoleksi.UseVisualStyleBackColor = true;
            // 
            // chkLaporanMember
            // 
            this.chkLaporanMember.AutoSize = true;
            this.chkLaporanMember.Location = new System.Drawing.Point(168, 42);
            this.chkLaporanMember.Name = "chkLaporanMember";
            this.chkLaporanMember.Size = new System.Drawing.Size(106, 17);
            this.chkLaporanMember.TabIndex = 13;
            this.chkLaporanMember.Text = "Laporan Member";
            this.chkLaporanMember.UseVisualStyleBackColor = true;
            // 
            // chkLaporanTransaksi
            // 
            this.chkLaporanTransaksi.AutoSize = true;
            this.chkLaporanTransaksi.Location = new System.Drawing.Point(168, 19);
            this.chkLaporanTransaksi.Name = "chkLaporanTransaksi";
            this.chkLaporanTransaksi.Size = new System.Drawing.Size(114, 17);
            this.chkLaporanTransaksi.TabIndex = 12;
            this.chkLaporanTransaksi.Text = "Laporan Transaksi";
            this.chkLaporanTransaksi.UseVisualStyleBackColor = true;
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hapus Kewenangan";
            this.button1.UseVisualStyleBackColor = true;
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
            // cmbJendelaPertama
            // 
            this.cmbJendelaPertama.FormattingEnabled = true;
            this.cmbJendelaPertama.Location = new System.Drawing.Point(166, 118);
            this.cmbJendelaPertama.Name = "cmbJendelaPertama";
            this.cmbJendelaPertama.Size = new System.Drawing.Size(351, 21);
            this.cmbJendelaPertama.TabIndex = 19;
            // 
            // frmPengaturanKewenangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.CheckBox chkLaporanKeuangan;
        private System.Windows.Forms.CheckBox chkLaporanKoleksi;
        private System.Windows.Forms.CheckBox chkLaporanMember;
        private System.Windows.Forms.CheckBox chkLaporanTransaksi;
        private System.Windows.Forms.CheckBox chkTransaksi;
        private System.Windows.Forms.CheckBox chkMasterStok;
        private System.Windows.Forms.CheckBox chkMasterKoleksi;
        private System.Windows.Forms.CheckBox chkMasterPelanggan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkPenawaranMenarik;
        private System.Windows.Forms.CheckBox chkPengaturanPengguna;
        private System.Windows.Forms.CheckBox chkPengaturanKewenangan;
        private System.Windows.Forms.CheckBox chkPengaturanSistem;
        private System.Windows.Forms.ComboBox cmbJendelaPertama;
        private System.Windows.Forms.Label lblJendelaPertama;
    }
}