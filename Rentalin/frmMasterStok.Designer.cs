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
            this.lblPencarian = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.btnModifikasi = new System.Windows.Forms.Button();
            this.dgStokKoleksi = new System.Windows.Forms.DataGridView();
            this.pnlKoleksiDIpilih = new System.Windows.Forms.Panel();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnPilihKoleksi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDipilih = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStokKoleksi)).BeginInit();
            this.pnlKoleksiDIpilih.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(43, 374);
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
            this.pnlInfo.Controls.Add(this.lblPencarian);
            this.pnlInfo.Controls.Add(this.txtPencarian);
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-1, 5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(491, 122);
            this.pnlInfo.TabIndex = 3;
            // 
            // lblPencarian
            // 
            this.lblPencarian.AutoSize = true;
            this.lblPencarian.Location = new System.Drawing.Point(116, 78);
            this.lblPencarian.Name = "lblPencarian";
            this.lblPencarian.Size = new System.Drawing.Size(50, 13);
            this.lblPencarian.TabIndex = 8;
            this.lblPencarian.Text = "Cari Stok";
            this.lblPencarian.Click += new System.EventHandler(this.lblPencarian_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(119, 94);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(349, 20);
            this.txtPencarian.TabIndex = 7;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(116, 38);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(357, 26);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar stok berdasarkan koleksi yang sudah ditentukan\r\nPada jen" +
                "dela ini";
            this.lblInfoDetail.Click += new System.EventHandler(this.lblInfoDetail_Click);
            // 
            // picInfo
            // 
            this.picInfo.Image = global::Rentalin.Properties.Resources.consumer;
            this.picInfo.Location = new System.Drawing.Point(26, 13);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(82, 86);
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(114, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(138, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Stok";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(43, 125);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 28);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Stok";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(43, 408);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(121, 28);
            this.btnHistori.TabIndex = 9;
            this.btnHistori.Text = "Histori Penyewaan";
            this.btnHistori.UseVisualStyleBackColor = true;
            // 
            // btnModifikasi
            // 
            this.btnModifikasi.Location = new System.Drawing.Point(43, 340);
            this.btnModifikasi.Name = "btnModifikasi";
            this.btnModifikasi.Size = new System.Drawing.Size(121, 28);
            this.btnModifikasi.TabIndex = 7;
            this.btnModifikasi.Text = "Modifikasi Stok";
            this.btnModifikasi.UseVisualStyleBackColor = true;
            // 
            // dgStokKoleksi
            // 
            this.dgStokKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStokKoleksi.Location = new System.Drawing.Point(13, 132);
            this.dgStokKoleksi.Name = "dgStokKoleksi";
            this.dgStokKoleksi.Size = new System.Drawing.Size(477, 329);
            this.dgStokKoleksi.TabIndex = 4;
            // 
            // pnlKoleksiDIpilih
            // 
            this.pnlKoleksiDIpilih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
            this.pnlKoleksiDIpilih.Controls.Add(this.lblGenre);
            this.pnlKoleksiDIpilih.Controls.Add(this.lblJudul);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnHistori);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnPilihKoleksi);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnTambah);
            this.pnlKoleksiDIpilih.Controls.Add(this.textBox1);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnHapus);
            this.pnlKoleksiDIpilih.Controls.Add(this.lblDipilih);
            this.pnlKoleksiDIpilih.Controls.Add(this.btnModifikasi);
            this.pnlKoleksiDIpilih.ForeColor = System.Drawing.Color.White;
            this.pnlKoleksiDIpilih.Location = new System.Drawing.Point(496, 7);
            this.pnlKoleksiDIpilih.Name = "pnlKoleksiDIpilih";
            this.pnlKoleksiDIpilih.Size = new System.Drawing.Size(211, 454);
            this.pnlKoleksiDIpilih.TabIndex = 9;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(4, 105);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 13);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Bollywood";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(4, 92);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(178, 13);
            this.lblJudul.TabIndex = 13;
            this.lblJudul.Text = "Dilwale Dulhania Le Jayengge";
            // 
            // btnPilihKoleksi
            // 
            this.btnPilihKoleksi.Location = new System.Drawing.Point(43, 35);
            this.btnPilihKoleksi.Name = "btnPilihKoleksi";
            this.btnPilihKoleksi.Size = new System.Drawing.Size(121, 28);
            this.btnPilihKoleksi.TabIndex = 10;
            this.btnPilihKoleksi.Text = "Pilih Koleksi";
            this.btnPilihKoleksi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblDipilih
            // 
            this.lblDipilih.AutoSize = true;
            this.lblDipilih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipilih.Location = new System.Drawing.Point(3, 11);
            this.lblDipilih.Name = "lblDipilih";
            this.lblDipilih.Size = new System.Drawing.Size(118, 13);
            this.lblDipilih.TabIndex = 0;
            this.lblDipilih.Text = "Koleksi yang Dipilih";
            // 
            // frmMasterStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 479);
            this.Controls.Add(this.pnlKoleksiDIpilih);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.dgStokKoleksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMasterStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Master Stok";
            this.Load += new System.EventHandler(this.frmMasterStok_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStokKoleksi)).EndInit();
            this.pnlKoleksiDIpilih.ResumeLayout(false);
            this.pnlKoleksiDIpilih.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblPencarian;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.Button btnModifikasi;
        private System.Windows.Forms.DataGridView dgStokKoleksi;
        private System.Windows.Forms.Panel pnlKoleksiDIpilih;
        private System.Windows.Forms.Button btnPilihKoleksi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDipilih;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJudul;
    }
}