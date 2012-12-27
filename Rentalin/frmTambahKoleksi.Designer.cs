namespace Rentalin
{
    partial class frmTambahKoleksi
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
            this.lblTambahKoleksi = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnKategori = new System.Windows.Forms.Button();
            this.lblJenis = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.lblCoverArt = new System.Windows.Forms.Label();
            this.txtCoverArt = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picCoverArt = new System.Windows.Forms.PictureBox();
            this.btnTambahkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTambahKoleksi
            // 
            this.lblTambahKoleksi.AutoSize = true;
            this.lblTambahKoleksi.Location = new System.Drawing.Point(12, 9);
            this.lblTambahKoleksi.Name = "lblTambahKoleksi";
            this.lblTambahKoleksi.Size = new System.Drawing.Size(186, 26);
            this.lblTambahKoleksi.TabIndex = 0;
            this.lblTambahKoleksi.Text = "Silahkan mengisi detail koleksi terbaru\r\nyang ingin ditambahkan";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(12, 60);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(69, 13);
            this.lblKode.TabIndex = 1;
            this.lblKode.Text = "Kode Koleksi";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(87, 57);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(111, 20);
            this.txtKode.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(49, 87);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(32, 13);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Judul";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(31, 109);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(50, 13);
            this.lblDeskripsi.TabIndex = 5;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(87, 111);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(196, 100);
            this.txtDeskripsi.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(31, 223);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(87, 220);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(126, 21);
            this.cmbKategori.TabIndex = 8;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(219, 217);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(71, 36);
            this.btnKategori.TabIndex = 9;
            this.btnKategori.Text = "Atur Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(46, 257);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(31, 13);
            this.lblJenis.TabIndex = 10;
            this.lblJenis.Text = "Jenis";
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(87, 254);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(74, 21);
            this.cmbJenis.TabIndex = 11;
            // 
            // lblCoverArt
            // 
            this.lblCoverArt.AutoSize = true;
            this.lblCoverArt.Location = new System.Drawing.Point(26, 287);
            this.lblCoverArt.Name = "lblCoverArt";
            this.lblCoverArt.Size = new System.Drawing.Size(51, 13);
            this.lblCoverArt.TabIndex = 12;
            this.lblCoverArt.Text = "Cover Art";
            // 
            // txtCoverArt
            // 
            this.txtCoverArt.Location = new System.Drawing.Point(87, 284);
            this.txtCoverArt.Name = "txtCoverArt";
            this.txtCoverArt.Size = new System.Drawing.Size(111, 20);
            this.txtCoverArt.TabIndex = 13;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(204, 284);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 20);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Telusuri..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // picCoverArt
            // 
            this.picCoverArt.Location = new System.Drawing.Point(87, 310);
            this.picCoverArt.Name = "picCoverArt";
            this.picCoverArt.Size = new System.Drawing.Size(126, 161);
            this.picCoverArt.TabIndex = 15;
            this.picCoverArt.TabStop = false;
            // 
            // btnTambahkan
            // 
            this.btnTambahkan.Location = new System.Drawing.Point(219, 9);
            this.btnTambahkan.Name = "btnTambahkan";
            this.btnTambahkan.Size = new System.Drawing.Size(77, 26);
            this.btnTambahkan.TabIndex = 16;
            this.btnTambahkan.Text = "Tambahkan";
            this.btnTambahkan.UseVisualStyleBackColor = true;
            // 
            // frmTambahKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 486);
            this.Controls.Add(this.btnTambahkan);
            this.Controls.Add(this.picCoverArt);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCoverArt);
            this.Controls.Add(this.lblCoverArt);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.lblTambahKoleksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmTambahKoleksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Koleksi";
            this.Load += new System.EventHandler(this.frmTambahKoleksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTambahKoleksi;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label lblCoverArt;
        private System.Windows.Forms.TextBox txtCoverArt;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picCoverArt;
        private System.Windows.Forms.Button btnTambahkan;
    }
}