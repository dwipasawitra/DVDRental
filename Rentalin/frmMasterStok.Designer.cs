namespace Rentalin
{
    partial class frmMasterStok
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.btnModifikasi = new System.Windows.Forms.Button();
            this.dgStokKoleksi = new System.Windows.Forms.DataGridView();
            this.pnlKoleksiDIpilih = new System.Windows.Forms.Panel();
            this.btnCariKoleksi = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPilihKoleksi = new System.Windows.Forms.Button();
            this.txtPilihKoleksi = new System.Windows.Forms.TextBox();
            this.lblDipilih = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.txtKodeStok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.dtpTglBeli = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.lblKondisiInfo = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStokKoleksi)).BeginInit();
            this.pnlKoleksiDIpilih.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Location = new System.Drawing.Point(43, 383);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(121, 28);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus Stok";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-1, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(491, 88);
            this.pnlInfo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentalin.Properties.Resources.db;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(95, 42);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(384, 39);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar stok berdasarkan koleksi yang sudah ditentukan pada\r\nkot" +
                "ak teks Koleksi yang dipilih. Anda dapat menambah stok atau memodifikasi\r\nstok y" +
                "ang sudah ada.";
            this.lblInfoDetail.Click += new System.EventHandler(this.lblInfoDetail_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(93, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(138, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Stok";
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(141, 95);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(349, 20);
            this.txtPencarian.TabIndex = 7;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(13, 94);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 22);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Stok";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHistori
            // 
            this.btnHistori.ForeColor = System.Drawing.Color.Black;
            this.btnHistori.Location = new System.Drawing.Point(43, 417);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(121, 28);
            this.btnHistori.TabIndex = 9;
            this.btnHistori.Text = "Histori Penyewaan";
            this.btnHistori.UseVisualStyleBackColor = true;
            // 
            // btnModifikasi
            // 
            this.btnModifikasi.ForeColor = System.Drawing.Color.Black;
            this.btnModifikasi.Location = new System.Drawing.Point(43, 348);
            this.btnModifikasi.Name = "btnModifikasi";
            this.btnModifikasi.Size = new System.Drawing.Size(121, 28);
            this.btnModifikasi.TabIndex = 7;
            this.btnModifikasi.Text = "Modifikasi Stok";
            this.btnModifikasi.UseVisualStyleBackColor = true;
            this.btnModifikasi.Click += new System.EventHandler(this.btnModifikasi_Click);
            // 
            // dgStokKoleksi
            // 
            this.dgStokKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStokKoleksi.Location = new System.Drawing.Point(12, 122);
            this.dgStokKoleksi.Name = "dgStokKoleksi";
            this.dgStokKoleksi.Size = new System.Drawing.Size(478, 339);
            this.dgStokKoleksi.TabIndex = 4;
            this.dgStokKoleksi.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgStokKoleksi_RowsRemoved);
            this.dgStokKoleksi.SelectionChanged += new System.EventHandler(this.dgStokKoleksi_SelectionChanged);
            // 
            // pnlKoleksiDIpilih
            // 
            this.pnlKoleksiDIpilih.BackColor = System.Drawing.Color.Moccasin;
            this.pnlKoleksiDIpilih.Controls.Add(this.btnCariKoleksi);
            this.pnlKoleksiDIpilih.Controls.Add(this.lblGenre);
            this.pnlKoleksiDIpilih.Controls.Add(this.lblJudul);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnHistori);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnPilihKoleksi);
            this.pnlKoleksiDIpilih.Controls.Add(this.txtPilihKoleksi);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnHapus);
            this.pnlKoleksiDIpilih.Controls.Add(this.lblDipilih);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnModifikasi);
            this.pnlKoleksiDIpilih.ForeColor = System.Drawing.Color.White;
            this.pnlKoleksiDIpilih.Location = new System.Drawing.Point(496, 0);
            this.pnlKoleksiDIpilih.Name = "pnlKoleksiDIpilih";
            this.pnlKoleksiDIpilih.Size = new System.Drawing.Size(211, 461);
            this.pnlKoleksiDIpilih.TabIndex = 9;
            // 
            // btnCariKoleksi
            // 
            this.btnCariKoleksi.ForeColor = System.Drawing.Color.Black;
            this.btnCariKoleksi.Location = new System.Drawing.Point(6, 52);
            this.btnCariKoleksi.Name = "btnCariKoleksi";
            this.btnCariKoleksi.Size = new System.Drawing.Size(87, 28);
            this.btnCariKoleksi.TabIndex = 15;
            this.btnCariKoleksi.Text = "Cari Koleksi";
            this.btnCariKoleksi.UseVisualStyleBackColor = true;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(4, 105);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 13);
            this.lblGenre.TabIndex = 14;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(4, 92);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(0, 13);
            this.lblJudul.TabIndex = 13;
            // 
            // btnPilihKoleksi
            // 
            this.btnPilihKoleksi.ForeColor = System.Drawing.Color.Black;
            this.btnPilihKoleksi.Location = new System.Drawing.Point(107, 52);
            this.btnPilihKoleksi.Name = "btnPilihKoleksi";
            this.btnPilihKoleksi.Size = new System.Drawing.Size(87, 28);
            this.btnPilihKoleksi.TabIndex = 10;
            this.btnPilihKoleksi.Text = "Pilih Koleksi";
            this.btnPilihKoleksi.UseVisualStyleBackColor = true;
            this.btnPilihKoleksi.Click += new System.EventHandler(this.btnPilihKoleksi_Click);
            // 
            // txtPilihKoleksi
            // 
            this.txtPilihKoleksi.Location = new System.Drawing.Point(6, 26);
            this.txtPilihKoleksi.Name = "txtPilihKoleksi";
            this.txtPilihKoleksi.Size = new System.Drawing.Size(188, 20);
            this.txtPilihKoleksi.TabIndex = 1;
            this.txtPilihKoleksi.TextChanged += new System.EventHandler(this.txtPilihKoleksi_TextChanged);
            this.txtPilihKoleksi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPilihKoleksi_KeyDown);
            // 
            // lblDipilih
            // 
            this.lblDipilih.AutoSize = true;
            this.lblDipilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipilih.ForeColor = System.Drawing.Color.Black;
            this.lblDipilih.Location = new System.Drawing.Point(3, 10);
            this.lblDipilih.Name = "lblDipilih";
            this.lblDipilih.Size = new System.Drawing.Size(118, 13);
            this.lblDipilih.TabIndex = 0;
            this.lblDipilih.Text = "Koleksi yang Dipilih";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btnPerbarui);
            this.panel1.Controls.Add(this.txtKodeStok);
            this.panel1.Controls.Add(this.txtHarga);
            this.panel1.Controls.Add(this.dtpTglBeli);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.cmbKondisi);
            this.panel1.Controls.Add(this.lblStatusInfo);
            this.panel1.Controls.Add(this.lblKondisiInfo);
            this.panel1.Location = new System.Drawing.Point(496, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 160);
            this.panel1.TabIndex = 28;
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.ForeColor = System.Drawing.Color.Black;
            this.btnPerbarui.Location = new System.Drawing.Point(41, 118);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(120, 25);
            this.btnPerbarui.TabIndex = 27;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // txtKodeStok
            // 
            this.txtKodeStok.Location = new System.Drawing.Point(7, 14);
            this.txtKodeStok.Name = "txtKodeStok";
            this.txtKodeStok.Size = new System.Drawing.Size(188, 20);
            this.txtKodeStok.TabIndex = 26;
            this.txtKodeStok.Text = "Kode Stok";
            this.txtKodeStok.Enter += new System.EventHandler(this.txtKodeStok_Enter);
            this.txtKodeStok.Leave += new System.EventHandler(this.txtKodeStok_Leave);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(7, 93);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(188, 20);
            this.txtHarga.TabIndex = 25;
            this.txtHarga.Text = "Harga Pembelian";
            this.txtHarga.Enter += new System.EventHandler(this.txtHarga_Enter);
            this.txtHarga.Leave += new System.EventHandler(this.txtHarga_Leave);
            // 
            // dtpTglBeli
            // 
            this.dtpTglBeli.Location = new System.Drawing.Point(7, 67);
            this.dtpTglBeli.Name = "dtpTglBeli";
            this.dtpTglBeli.Size = new System.Drawing.Size(188, 20);
            this.dtpTglBeli.TabIndex = 24;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(149, 42);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(46, 21);
            this.cmbStatus.TabIndex = 23;
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Location = new System.Drawing.Point(48, 42);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(46, 21);
            this.cmbKondisi.TabIndex = 22;
            // 
            // lblStatusInfo
            // 
            this.lblStatusInfo.AutoSize = true;
            this.lblStatusInfo.Location = new System.Drawing.Point(109, 45);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(37, 13);
            this.lblStatusInfo.TabIndex = 21;
            this.lblStatusInfo.Text = "Status";
            // 
            // lblKondisiInfo
            // 
            this.lblKondisiInfo.AutoSize = true;
            this.lblKondisiInfo.Location = new System.Drawing.Point(5, 45);
            this.lblKondisiInfo.Name = "lblKondisiInfo";
            this.lblKondisiInfo.Size = new System.Drawing.Size(41, 13);
            this.lblKondisiInfo.TabIndex = 20;
            this.lblKondisiInfo.Text = "Kondisi";
            // 
            // frmMasterStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlKoleksiDIpilih);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dgStokKoleksi);
            this.Controls.Add(this.btnTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMasterStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Master Stok";
            this.Load += new System.EventHandler(this.frmMasterStok_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStokKoleksi)).EndInit();
            this.pnlKoleksiDIpilih.ResumeLayout(false);
            this.pnlKoleksiDIpilih.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.Button btnModifikasi;
        private System.Windows.Forms.DataGridView dgStokKoleksi;
        private System.Windows.Forms.Panel pnlKoleksiDIpilih;
        private System.Windows.Forms.Button btnPilihKoleksi;
        private System.Windows.Forms.TextBox txtPilihKoleksi;
        private System.Windows.Forms.Label lblDipilih;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Label lblKondisiInfo;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.DateTimePicker dtpTglBeli;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.TextBox txtKodeStok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCariKoleksi;
    }
}