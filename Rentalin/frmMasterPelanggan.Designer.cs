namespace Rentalin
{
    partial class frmMasterPelanggan
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
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnModifikasi = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.dgPelanggan = new System.Windows.Forms.DataGridView();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnMuatUlang = new System.Windows.Forms.Button();
            this.lblIdentitas = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPelanggan)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, 2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(468, 106);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(116, 61);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(328, 13);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar pelanggan penyewaan di dalam jendela ini";
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
            this.lblInfo.Location = new System.Drawing.Point(114, 36);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Pelanggan";
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(134, 118);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(334, 20);
            this.txtPencarian.TabIndex = 7;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(12, 118);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(116, 20);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Pelanggan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnModifikasi
            // 
            this.btnModifikasi.Location = new System.Drawing.Point(13, 319);
            this.btnModifikasi.Name = "btnModifikasi";
            this.btnModifikasi.Size = new System.Drawing.Size(172, 28);
            this.btnModifikasi.TabIndex = 7;
            this.btnModifikasi.Text = "Modifikasi Pelanggan";
            this.btnModifikasi.UseVisualStyleBackColor = true;
            this.btnModifikasi.Click += new System.EventHandler(this.btnModifikasi_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(13, 352);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(172, 28);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus Pelanggan";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(13, 386);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(172, 28);
            this.btnHistori.TabIndex = 9;
            this.btnHistori.Text = "Histori Penyewaan";
            this.btnHistori.UseVisualStyleBackColor = true;
            this.btnHistori.Click += new System.EventHandler(this.btnHistori_Click);
            // 
            // dgPelanggan
            // 
            this.dgPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPelanggan.Location = new System.Drawing.Point(12, 149);
            this.dgPelanggan.Name = "dgPelanggan";
            this.dgPelanggan.Size = new System.Drawing.Size(456, 320);
            this.dgPelanggan.TabIndex = 1;
            this.dgPelanggan.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgPelanggan_RowsRemoved);
            this.dgPelanggan.SelectionChanged += new System.EventHandler(this.dgPelanggan_SelectionChanged);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.Indigo;
            this.pnlDetail.Controls.Add(this.pictureBox1);
            this.pnlDetail.Controls.Add(this.btnMuatUlang);
            this.pnlDetail.Controls.Add(this.btnHistori);
            this.pnlDetail.Controls.Add(this.lblIdentitas);
            this.pnlDetail.Controls.Add(this.btnHapus);
            this.pnlDetail.Controls.Add(this.lblNamaPelanggan);
            this.pnlDetail.Controls.Add(this.btnModifikasi);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Location = new System.Drawing.Point(474, 2);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(199, 467);
            this.pnlDetail.TabIndex = 2;
            // 
            // btnMuatUlang
            // 
            this.btnMuatUlang.Location = new System.Drawing.Point(13, 420);
            this.btnMuatUlang.Name = "btnMuatUlang";
            this.btnMuatUlang.Size = new System.Drawing.Size(173, 32);
            this.btnMuatUlang.TabIndex = 13;
            this.btnMuatUlang.Text = "Muat Ulang";
            this.btnMuatUlang.UseVisualStyleBackColor = true;
            this.btnMuatUlang.Click += new System.EventHandler(this.btnMuatUlang_Click);
            // 
            // lblIdentitas
            // 
            this.lblIdentitas.AutoSize = true;
            this.lblIdentitas.ForeColor = System.Drawing.Color.White;
            this.lblIdentitas.Location = new System.Drawing.Point(10, 160);
            this.lblIdentitas.Name = "lblIdentitas";
            this.lblIdentitas.Size = new System.Drawing.Size(53, 13);
            this.lblIdentitas.TabIndex = 12;
            this.lblIdentitas.Text = "Identitas :";
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.ForeColor = System.Drawing.Color.White;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(10, 147);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(89, 13);
            this.lblNamaPelanggan.TabIndex = 11;
            this.lblNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.White;
            this.lblDetail.Location = new System.Drawing.Point(10, 115);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(125, 18);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "Detil Pelanggan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rentalin.Properties.Resources.consumer;
            this.pictureBox1.Location = new System.Drawing.Point(53, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 86);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmMasterPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 479);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.dgPelanggan);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMasterPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentalin -- Master Pelanggan";
            this.Load += new System.EventHandler(this.frmMasterPelanggan_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPelanggan)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnModifikasi;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.DataGridView dgPelanggan;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblIdentitas;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnMuatUlang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}