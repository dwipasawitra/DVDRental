namespace Rentalin
{
    partial class frmMasterKoleksi
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnHistori = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnModifikasi = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.pbCoverArt = new System.Windows.Forms.PictureBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.dgKoleksi = new System.Windows.Forms.DataGridView();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKoleksi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-6, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(562, 104);
            this.pnlInfo.TabIndex = 3;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(114, 51);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(300, 26);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur koleksi judul film, serial, dan konten lainnya\r\nMelalui jendela" +
                " ini";
            // 
            // picInfo
            // 
            this.picInfo.Image = global::Rentalin.Properties.Resources.disc1;
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
            this.lblInfo.Location = new System.Drawing.Point(112, 26);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(168, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Koleksi";
            // 
            // btnTambah
            // 
            this.btnTambah.ForeColor = System.Drawing.Color.Black;
            this.btnTambah.Location = new System.Drawing.Point(12, 107);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(110, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah Koleksi";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(128, 110);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(428, 20);
            this.txtPencarian.TabIndex = 9;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // btnHistori
            // 
            this.btnHistori.Location = new System.Drawing.Point(6, 427);
            this.btnHistori.Name = "btnHistori";
            this.btnHistori.Size = new System.Drawing.Size(218, 28);
            this.btnHistori.TabIndex = 9;
            this.btnHistori.Text = "Lihat Stok";
            this.btnHistori.UseVisualStyleBackColor = true;
            this.btnHistori.Click += new System.EventHandler(this.btnHistori_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(6, 393);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(218, 28);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus Koleksi";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnModifikasi
            // 
            this.btnModifikasi.Location = new System.Drawing.Point(6, 362);
            this.btnModifikasi.Name = "btnModifikasi";
            this.btnModifikasi.Size = new System.Drawing.Size(218, 25);
            this.btnModifikasi.TabIndex = 7;
            this.btnModifikasi.Text = "Modifikasi Koleksi";
            this.btnModifikasi.UseVisualStyleBackColor = true;
            this.btnModifikasi.Click += new System.EventHandler(this.btnModifikasi_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlDetail.Controls.Add(this.txtDeskripsi);
            this.pnlDetail.Controls.Add(this.pbCoverArt);
            this.pnlDetail.Controls.Add(this.lblGenre);
            this.pnlDetail.Controls.Add(this.lblJudul);
            this.pnlDetail.Controls.Add(this.btnHistori);
            this.pnlDetail.Controls.Add(this.btnHapus);
            this.pnlDetail.Controls.Add(this.btnModifikasi);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Location = new System.Drawing.Point(562, -1);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(238, 469);
            this.pnlDetail.TabIndex = 5;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDeskripsi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDeskripsi.Location = new System.Drawing.Point(6, 182);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(218, 174);
            this.txtDeskripsi.TabIndex = 14;
            // 
            // pbCoverArt
            // 
            this.pbCoverArt.Location = new System.Drawing.Point(71, 33);
            this.pbCoverArt.Name = "pbCoverArt";
            this.pbCoverArt.Size = new System.Drawing.Size(92, 112);
            this.pbCoverArt.TabIndex = 13;
            this.pbCoverArt.TabStop = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(3, 166);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(3, 148);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(74, 15);
            this.lblJudul.TabIndex = 11;
            this.lblJudul.Text = "Judul Film";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.ForeColor = System.Drawing.Color.Black;
            this.lblDetail.Location = new System.Drawing.Point(68, 1);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(103, 18);
            this.lblDetail.TabIndex = 10;
            this.lblDetail.Text = "Detil Koleksi";
            // 
            // dgKoleksi
            // 
            this.dgKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKoleksi.Location = new System.Drawing.Point(8, 135);
            this.dgKoleksi.Name = "dgKoleksi";
            this.dgKoleksi.Size = new System.Drawing.Size(548, 333);
            this.dgKoleksi.TabIndex = 4;
            this.dgKoleksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKoleksi_CellContentClick);
            this.dgKoleksi.SelectionChanged += new System.EventHandler(this.dgKoleksi_SelectionChanged);
            // 
            // frmMasterKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 469);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.dgKoleksi);
            this.Name = "frmMasterKoleksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN - Master Koleksi";
            this.Load += new System.EventHandler(this.frmMasterKoleksi_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKoleksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnHistori;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnModifikasi;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.DataGridView dgKoleksi;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbCoverArt;
        private System.Windows.Forms.TextBox txtDeskripsi;

    }
}