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
            this.lblPencarian = new System.Windows.Forms.Label();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnModifikasi = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnHistori = new System.Windows.Forms.Button();
            this.dgPelanggan = new System.Windows.Forms.DataGridView();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPelanggan)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlInfo.Controls.Add(this.lblPencarian);
            this.pnlInfo.Controls.Add(this.txtPencarian);
            this.pnlInfo.Controls.Add(this.btnTambah);
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, 2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(673, 106);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblPencarian
            // 
            this.lblPencarian.AutoSize = true;
            this.lblPencarian.Location = new System.Drawing.Point(116, 63);
            this.lblPencarian.Name = "lblPencarian";
            this.lblPencarian.Size = new System.Drawing.Size(79, 13);
            this.lblPencarian.TabIndex = 8;
            this.lblPencarian.Text = "Cari Pelanggan";
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(119, 79);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(349, 20);
            this.txtPencarian.TabIndex = 7;
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(527, 23);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(121, 28);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Pelanggan";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(116, 38);
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
            this.lblInfo.Location = new System.Drawing.Point(114, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Pelanggan";
            // 
            // btnModifikasi
            // 
            this.btnModifikasi.Location = new System.Drawing.Point(11, 76);
            this.btnModifikasi.Name = "btnModifikasi";
            this.btnModifikasi.Size = new System.Drawing.Size(121, 28);
            this.btnModifikasi.TabIndex = 7;
            this.btnModifikasi.Text = "Modifikasi Pelanggan";
            this.btnModifikasi.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(11, 109);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(121, 28);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus Pelanggan";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(11, 143);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(121, 28);
            this.btnHistori.TabIndex = 9;
            this.btnHistori.Text = "Histori Penyewaan";
            this.btnHistori.UseVisualStyleBackColor = true;
            // 
            // dgPelanggan
            // 
            this.dgPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPelanggan.Location = new System.Drawing.Point(14, 140);
            this.dgPelanggan.Name = "dgPelanggan";
            this.dgPelanggan.Size = new System.Drawing.Size(454, 329);
            this.dgPelanggan.TabIndex = 1;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
            this.pnlDetail.Controls.Add(this.btnHistori);
            this.pnlDetail.Controls.Add(this.lblAlamat);
            this.pnlDetail.Controls.Add(this.btnHapus);
            this.pnlDetail.Controls.Add(this.lblNamaPelanggan);
            this.pnlDetail.Controls.Add(this.btnModifikasi);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Location = new System.Drawing.Point(474, 141);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(185, 341);
            this.pnlDetail.TabIndex = 2;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.ForeColor = System.Drawing.Color.White;
            this.lblAlamat.Location = new System.Drawing.Point(8, 48);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(53, 13);
            this.lblAlamat.TabIndex = 12;
            this.lblAlamat.Text = "Identitas :";
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.ForeColor = System.Drawing.Color.White;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(8, 35);
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
            this.lblDetail.Location = new System.Drawing.Point(8, 3);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(125, 18);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "Detil Pelanggan";
            // 
            // frmMasterPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 479);
            this.Controls.Add(this.pnlDetail);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPencarian;
        private System.Windows.Forms.TextBox txtPencarian;
    }
}