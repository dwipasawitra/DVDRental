namespace Rentalin
{
    partial class frmPengaturan
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
            this.gbBiayaSewa = new System.Windows.Forms.GroupBox();
            this.chkSewaPerItem = new System.Windows.Forms.CheckBox();
            this.chkSewaPerKategori = new System.Windows.Forms.CheckBox();
            this.lblSewaInfo = new System.Windows.Forms.Label();
            this.gbDenda = new System.Windows.Forms.GroupBox();
            this.chkDendaPerItem = new System.Windows.Forms.CheckBox();
            this.chkDendaPerKategori = new System.Windows.Forms.CheckBox();
            this.lblDendaInfo = new System.Windows.Forms.Label();
            this.lblInfoTambahan = new System.Windows.Forms.Label();
            this.gbDasar = new System.Windows.Forms.GroupBox();
            this.txtNamaPemilik = new System.Windows.Forms.TextBox();
            this.lblNamaPemilik = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNamaJasa = new System.Windows.Forms.TextBox();
            this.lblNamaJasa = new System.Windows.Forms.Label();
            this.btnTerapkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.gbLamaPenyewaan = new System.Windows.Forms.GroupBox();
            this.txtJumlahHari = new System.Windows.Forms.TextBox();
            this.lblJumlahHari = new System.Windows.Forms.Label();
            this.rbHariBebas = new System.Windows.Forms.RadioButton();
            this.rbHariDitetapkan = new System.Windows.Forms.RadioButton();
            this.gbJumlahSewa = new System.Windows.Forms.GroupBox();
            this.txtJumlahJudul = new System.Windows.Forms.TextBox();
            this.lblJumlahJudul = new System.Windows.Forms.Label();
            this.rbBebasJudul = new System.Windows.Forms.RadioButton();
            this.rbTetapJudul = new System.Windows.Forms.RadioButton();
            this.gbBiayaSewa.SuspendLayout();
            this.gbDenda.SuspendLayout();
            this.gbDasar.SuspendLayout();
            this.gbLamaPenyewaan.SuspendLayout();
            this.gbJumlahSewa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBiayaSewa
            // 
            this.gbBiayaSewa.Controls.Add(this.chkSewaPerItem);
            this.gbBiayaSewa.Controls.Add(this.chkSewaPerKategori);
            this.gbBiayaSewa.Controls.Add(this.lblSewaInfo);
            this.gbBiayaSewa.Location = new System.Drawing.Point(12, 133);
            this.gbBiayaSewa.Name = "gbBiayaSewa";
            this.gbBiayaSewa.Size = new System.Drawing.Size(258, 108);
            this.gbBiayaSewa.TabIndex = 0;
            this.gbBiayaSewa.TabStop = false;
            this.gbBiayaSewa.Text = "Skema Biaya Sewa";
            // 
            // chkSewaPerItem
            // 
            this.chkSewaPerItem.AutoSize = true;
            this.chkSewaPerItem.Location = new System.Drawing.Point(9, 78);
            this.chkSewaPerItem.Name = "chkSewaPerItem";
            this.chkSewaPerItem.Size = new System.Drawing.Size(170, 17);
            this.chkSewaPerItem.TabIndex = 2;
            this.chkSewaPerItem.Text = "Gunakan Biaya Sewa per Item";
            this.chkSewaPerItem.UseVisualStyleBackColor = true;
            // 
            // chkSewaPerKategori
            // 
            this.chkSewaPerKategori.AutoSize = true;
            this.chkSewaPerKategori.Location = new System.Drawing.Point(9, 55);
            this.chkSewaPerKategori.Name = "chkSewaPerKategori";
            this.chkSewaPerKategori.Size = new System.Drawing.Size(189, 17);
            this.chkSewaPerKategori.TabIndex = 1;
            this.chkSewaPerKategori.Text = "Gunakan Biaya Sewa per Kategori";
            this.chkSewaPerKategori.UseVisualStyleBackColor = true;
            // 
            // lblSewaInfo
            // 
            this.lblSewaInfo.AutoSize = true;
            this.lblSewaInfo.Location = new System.Drawing.Point(6, 28);
            this.lblSewaInfo.Name = "lblSewaInfo";
            this.lblSewaInfo.Size = new System.Drawing.Size(207, 13);
            this.lblSewaInfo.TabIndex = 0;
            this.lblSewaInfo.Text = "Silahkan atur skema biaya sewa berikut ini";
            // 
            // gbDenda
            // 
            this.gbDenda.Controls.Add(this.chkDendaPerItem);
            this.gbDenda.Controls.Add(this.chkDendaPerKategori);
            this.gbDenda.Controls.Add(this.lblDendaInfo);
            this.gbDenda.Location = new System.Drawing.Point(12, 247);
            this.gbDenda.Name = "gbDenda";
            this.gbDenda.Size = new System.Drawing.Size(258, 108);
            this.gbDenda.TabIndex = 1;
            this.gbDenda.TabStop = false;
            this.gbDenda.Text = "Skema Biaya Denda";
            // 
            // chkDendaPerItem
            // 
            this.chkDendaPerItem.AutoSize = true;
            this.chkDendaPerItem.Location = new System.Drawing.Point(9, 78);
            this.chkDendaPerItem.Name = "chkDendaPerItem";
            this.chkDendaPerItem.Size = new System.Drawing.Size(170, 17);
            this.chkDendaPerItem.TabIndex = 2;
            this.chkDendaPerItem.Text = "Gunakan Biaya Sewa per Item";
            this.chkDendaPerItem.UseVisualStyleBackColor = true;
            // 
            // chkDendaPerKategori
            // 
            this.chkDendaPerKategori.AutoSize = true;
            this.chkDendaPerKategori.Location = new System.Drawing.Point(9, 55);
            this.chkDendaPerKategori.Name = "chkDendaPerKategori";
            this.chkDendaPerKategori.Size = new System.Drawing.Size(189, 17);
            this.chkDendaPerKategori.TabIndex = 1;
            this.chkDendaPerKategori.Text = "Gunakan Biaya Sewa per Kategori";
            this.chkDendaPerKategori.UseVisualStyleBackColor = true;
            // 
            // lblDendaInfo
            // 
            this.lblDendaInfo.AutoSize = true;
            this.lblDendaInfo.Location = new System.Drawing.Point(6, 28);
            this.lblDendaInfo.Name = "lblDendaInfo";
            this.lblDendaInfo.Size = new System.Drawing.Size(207, 13);
            this.lblDendaInfo.TabIndex = 0;
            this.lblDendaInfo.Text = "Silahkan atur skema biaya sewa berikut ini";
            // 
            // lblInfoTambahan
            // 
            this.lblInfoTambahan.AutoSize = true;
            this.lblInfoTambahan.Location = new System.Drawing.Point(9, 365);
            this.lblInfoTambahan.Name = "lblInfoTambahan";
            this.lblInfoTambahan.Size = new System.Drawing.Size(264, 52);
            this.lblInfoTambahan.TabIndex = 2;
            this.lblInfoTambahan.Text = "PETUNJUK: Jika tidak ada skema biaya sewa/denda \r\ndipilih,maka sewa/denda akan gr" +
                "atis. Jika kedua-\r\nduanya dipilih, maka skema biaya/sewa \r\nadalah biaya per kate" +
                "gori + biaya per item";
            // 
            // gbDasar
            // 
            this.gbDasar.Controls.Add(this.txtNamaPemilik);
            this.gbDasar.Controls.Add(this.lblNamaPemilik);
            this.gbDasar.Controls.Add(this.txtAlamat);
            this.gbDasar.Controls.Add(this.lblAlamat);
            this.gbDasar.Controls.Add(this.txtNamaJasa);
            this.gbDasar.Controls.Add(this.lblNamaJasa);
            this.gbDasar.Location = new System.Drawing.Point(12, 4);
            this.gbDasar.Name = "gbDasar";
            this.gbDasar.Size = new System.Drawing.Size(503, 123);
            this.gbDasar.TabIndex = 3;
            this.gbDasar.TabStop = false;
            this.gbDasar.Text = "Pengaturan Dasar";
            // 
            // txtNamaPemilik
            // 
            this.txtNamaPemilik.Location = new System.Drawing.Point(83, 77);
            this.txtNamaPemilik.Name = "txtNamaPemilik";
            this.txtNamaPemilik.Size = new System.Drawing.Size(225, 20);
            this.txtNamaPemilik.TabIndex = 5;
            // 
            // lblNamaPemilik
            // 
            this.lblNamaPemilik.AutoSize = true;
            this.lblNamaPemilik.Location = new System.Drawing.Point(6, 80);
            this.lblNamaPemilik.Name = "lblNamaPemilik";
            this.lblNamaPemilik.Size = new System.Drawing.Size(71, 13);
            this.lblNamaPemilik.TabIndex = 4;
            this.lblNamaPemilik.Text = "Nama Pemilik";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(83, 51);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(405, 20);
            this.txtAlamat.TabIndex = 3;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(6, 54);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtNamaJasa
            // 
            this.txtNamaJasa.Location = new System.Drawing.Point(83, 25);
            this.txtNamaJasa.Name = "txtNamaJasa";
            this.txtNamaJasa.Size = new System.Drawing.Size(225, 20);
            this.txtNamaJasa.TabIndex = 1;
            // 
            // lblNamaJasa
            // 
            this.lblNamaJasa.AutoSize = true;
            this.lblNamaJasa.Location = new System.Drawing.Point(6, 28);
            this.lblNamaJasa.Name = "lblNamaJasa";
            this.lblNamaJasa.Size = new System.Drawing.Size(60, 13);
            this.lblNamaJasa.TabIndex = 0;
            this.lblNamaJasa.Text = "Nama Jasa";
            // 
            // btnTerapkan
            // 
            this.btnTerapkan.Location = new System.Drawing.Point(353, 420);
            this.btnTerapkan.Name = "btnTerapkan";
            this.btnTerapkan.Size = new System.Drawing.Size(75, 23);
            this.btnTerapkan.TabIndex = 4;
            this.btnTerapkan.Text = "Terapkan";
            this.btnTerapkan.UseVisualStyleBackColor = true;
            this.btnTerapkan.Click += new System.EventHandler(this.btnTerapkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(434, 420);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // gbLamaPenyewaan
            // 
            this.gbLamaPenyewaan.Controls.Add(this.txtJumlahHari);
            this.gbLamaPenyewaan.Controls.Add(this.lblJumlahHari);
            this.gbLamaPenyewaan.Controls.Add(this.rbHariBebas);
            this.gbLamaPenyewaan.Controls.Add(this.rbHariDitetapkan);
            this.gbLamaPenyewaan.Location = new System.Drawing.Point(283, 138);
            this.gbLamaPenyewaan.Name = "gbLamaPenyewaan";
            this.gbLamaPenyewaan.Size = new System.Drawing.Size(232, 102);
            this.gbLamaPenyewaan.TabIndex = 6;
            this.gbLamaPenyewaan.TabStop = false;
            this.gbLamaPenyewaan.Text = "Lama Penyewaan";
            // 
            // txtJumlahHari
            // 
            this.txtJumlahHari.Location = new System.Drawing.Point(180, 67);
            this.txtJumlahHari.Name = "txtJumlahHari";
            this.txtJumlahHari.Size = new System.Drawing.Size(37, 20);
            this.txtJumlahHari.TabIndex = 9;
            // 
            // lblJumlahHari
            // 
            this.lblJumlahHari.AutoSize = true;
            this.lblJumlahHari.Location = new System.Drawing.Point(113, 70);
            this.lblJumlahHari.Name = "lblJumlahHari";
            this.lblJumlahHari.Size = new System.Drawing.Size(60, 13);
            this.lblJumlahHari.TabIndex = 8;
            this.lblJumlahHari.Text = "Jumlah hari";
            // 
            // rbHariBebas
            // 
            this.rbHariBebas.AutoSize = true;
            this.rbHariBebas.Location = new System.Drawing.Point(6, 44);
            this.rbHariBebas.Name = "rbHariBebas";
            this.rbHariBebas.Size = new System.Drawing.Size(211, 17);
            this.rbHariBebas.TabIndex = 7;
            this.rbHariBebas.TabStop = true;
            this.rbHariBebas.Text = "Bisa bebas dengan batasan sekian hari";
            this.rbHariBebas.UseVisualStyleBackColor = true;
            // 
            // rbHariDitetapkan
            // 
            this.rbHariDitetapkan.AutoSize = true;
            this.rbHariDitetapkan.Location = new System.Drawing.Point(6, 21);
            this.rbHariDitetapkan.Name = "rbHariDitetapkan";
            this.rbHariDitetapkan.Size = new System.Drawing.Size(143, 17);
            this.rbHariDitetapkan.TabIndex = 0;
            this.rbHariDitetapkan.TabStop = true;
            this.rbHariDitetapkan.Text = "Tetap selama sekian hari";
            this.rbHariDitetapkan.UseVisualStyleBackColor = true;
            // 
            // gbJumlahSewa
            // 
            this.gbJumlahSewa.Controls.Add(this.txtJumlahJudul);
            this.gbJumlahSewa.Controls.Add(this.lblJumlahJudul);
            this.gbJumlahSewa.Controls.Add(this.rbBebasJudul);
            this.gbJumlahSewa.Controls.Add(this.rbTetapJudul);
            this.gbJumlahSewa.Location = new System.Drawing.Point(281, 253);
            this.gbJumlahSewa.Name = "gbJumlahSewa";
            this.gbJumlahSewa.Size = new System.Drawing.Size(232, 102);
            this.gbJumlahSewa.TabIndex = 7;
            this.gbJumlahSewa.TabStop = false;
            this.gbJumlahSewa.Text = "Jumlah Judul per Transaksi";
            // 
            // txtJumlahJudul
            // 
            this.txtJumlahJudul.Location = new System.Drawing.Point(180, 67);
            this.txtJumlahJudul.Name = "txtJumlahJudul";
            this.txtJumlahJudul.Size = new System.Drawing.Size(37, 20);
            this.txtJumlahJudul.TabIndex = 9;
            // 
            // lblJumlahJudul
            // 
            this.lblJumlahJudul.AutoSize = true;
            this.lblJumlahJudul.Location = new System.Drawing.Point(113, 70);
            this.lblJumlahJudul.Name = "lblJumlahJudul";
            this.lblJumlahJudul.Size = new System.Drawing.Size(68, 13);
            this.lblJumlahJudul.TabIndex = 8;
            this.lblJumlahJudul.Text = "Jumlah Judul";
            // 
            // rbBebasJudul
            // 
            this.rbBebasJudul.AutoSize = true;
            this.rbBebasJudul.Location = new System.Drawing.Point(6, 44);
            this.rbBebasJudul.Name = "rbBebasJudul";
            this.rbBebasJudul.Size = new System.Drawing.Size(55, 17);
            this.rbBebasJudul.TabIndex = 7;
            this.rbBebasJudul.TabStop = true;
            this.rbBebasJudul.Text = "Bebas";
            this.rbBebasJudul.UseVisualStyleBackColor = true;
            // 
            // rbTetapJudul
            // 
            this.rbTetapJudul.AutoSize = true;
            this.rbTetapJudul.Location = new System.Drawing.Point(6, 21);
            this.rbTetapJudul.Name = "rbTetapJudul";
            this.rbTetapJudul.Size = new System.Drawing.Size(161, 17);
            this.rbTetapJudul.TabIndex = 0;
            this.rbTetapJudul.TabStop = true;
            this.rbTetapJudul.Text = "Tetap sebanyak sekian judul";
            this.rbTetapJudul.UseVisualStyleBackColor = true;
            // 
            // frmPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 449);
            this.Controls.Add(this.gbJumlahSewa);
            this.Controls.Add(this.gbLamaPenyewaan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTerapkan);
            this.Controls.Add(this.gbDasar);
            this.Controls.Add(this.lblInfoTambahan);
            this.Controls.Add(this.gbDenda);
            this.Controls.Add(this.gbBiayaSewa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPengaturan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan";
            this.Load += new System.EventHandler(this.frmPengaturan_Load);
            this.gbBiayaSewa.ResumeLayout(false);
            this.gbBiayaSewa.PerformLayout();
            this.gbDenda.ResumeLayout(false);
            this.gbDenda.PerformLayout();
            this.gbDasar.ResumeLayout(false);
            this.gbDasar.PerformLayout();
            this.gbLamaPenyewaan.ResumeLayout(false);
            this.gbLamaPenyewaan.PerformLayout();
            this.gbJumlahSewa.ResumeLayout(false);
            this.gbJumlahSewa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBiayaSewa;
        private System.Windows.Forms.CheckBox chkSewaPerItem;
        private System.Windows.Forms.CheckBox chkSewaPerKategori;
        private System.Windows.Forms.Label lblSewaInfo;
        private System.Windows.Forms.GroupBox gbDenda;
        private System.Windows.Forms.CheckBox chkDendaPerItem;
        private System.Windows.Forms.CheckBox chkDendaPerKategori;
        private System.Windows.Forms.Label lblDendaInfo;
        private System.Windows.Forms.Label lblInfoTambahan;
        private System.Windows.Forms.GroupBox gbDasar;
        private System.Windows.Forms.TextBox txtNamaPemilik;
        private System.Windows.Forms.Label lblNamaPemilik;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtNamaJasa;
        private System.Windows.Forms.Label lblNamaJasa;
        private System.Windows.Forms.Button btnTerapkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox gbLamaPenyewaan;
        private System.Windows.Forms.TextBox txtJumlahHari;
        private System.Windows.Forms.Label lblJumlahHari;
        private System.Windows.Forms.RadioButton rbHariBebas;
        private System.Windows.Forms.RadioButton rbHariDitetapkan;
        private System.Windows.Forms.GroupBox gbJumlahSewa;
        private System.Windows.Forms.TextBox txtJumlahJudul;
        private System.Windows.Forms.Label lblJumlahJudul;
        private System.Windows.Forms.RadioButton rbBebasJudul;
        private System.Windows.Forms.RadioButton rbTetapJudul;
    }
}