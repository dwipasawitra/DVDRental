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
            this.txtJudul = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHargaSewa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHargaDenda = new System.Windows.Forms.Label();
            this.txtHargaSewa = new System.Windows.Forms.TextBox();
            this.txtHargaDenda = new System.Windows.Forms.TextBox();
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
            this.lblKode.Location = new System.Drawing.Point(7, 60);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(69, 13);
            this.lblKode.TabIndex = 1;
            this.lblKode.Text = "Kode Koleksi";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(89, 57);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(111, 20);
            this.txtKode.TabIndex = 2;
            this.txtKode.TextChanged += new System.EventHandler(this.txtKode_TextChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(44, 82);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(32, 13);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Judul";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(89, 82);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(196, 20);
            this.txtJudul.TabIndex = 4;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(26, 107);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(50, 13);
            this.lblDeskripsi.TabIndex = 5;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(89, 107);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(196, 65);
            this.txtDeskripsi.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(26, 181);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 7;
            this.lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(89, 178);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(126, 21);
            this.cmbKategori.TabIndex = 8;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(219, 175);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(71, 36);
            this.btnKategori.TabIndex = 9;
            this.btnKategori.Text = "Atur Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(41, 206);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(31, 13);
            this.lblJenis.TabIndex = 10;
            this.lblJenis.Text = "Jenis";
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(89, 203);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(74, 21);
            this.cmbJenis.TabIndex = 11;
            // 
            // lblCoverArt
            // 
            this.lblCoverArt.AutoSize = true;
            this.lblCoverArt.Location = new System.Drawing.Point(20, 287);
            this.lblCoverArt.Name = "lblCoverArt";
            this.lblCoverArt.Size = new System.Drawing.Size(51, 13);
            this.lblCoverArt.TabIndex = 12;
            this.lblCoverArt.Text = "Cover Art";
            // 
            // txtCoverArt
            // 
            this.txtCoverArt.Location = new System.Drawing.Point(89, 284);
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
            this.picCoverArt.Location = new System.Drawing.Point(89, 310);
            this.picCoverArt.Name = "picCoverArt";
            this.picCoverArt.Size = new System.Drawing.Size(126, 156);
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
            this.btnTambahkan.Click += new System.EventHandler(this.btnTambahkan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(72, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(72, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(72, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(72, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "informasi ini dibutuhkan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(73, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "*";
            // 
            // lblHargaSewa
            // 
            this.lblHargaSewa.AutoSize = true;
            this.lblHargaSewa.Location = new System.Drawing.Point(8, 233);
            this.lblHargaSewa.Name = "lblHargaSewa";
            this.lblHargaSewa.Size = new System.Drawing.Size(66, 13);
            this.lblHargaSewa.TabIndex = 24;
            this.lblHargaSewa.Text = "Harga Sewa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(73, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "*";
            // 
            // lblHargaDenda
            // 
            this.lblHargaDenda.AutoSize = true;
            this.lblHargaDenda.Location = new System.Drawing.Point(3, 259);
            this.lblHargaDenda.Name = "lblHargaDenda";
            this.lblHargaDenda.Size = new System.Drawing.Size(71, 13);
            this.lblHargaDenda.TabIndex = 27;
            this.lblHargaDenda.Text = "Harga Denda";
            // 
            // txtHargaSewa
            // 
            this.txtHargaSewa.Location = new System.Drawing.Point(89, 230);
            this.txtHargaSewa.Name = "txtHargaSewa";
            this.txtHargaSewa.Size = new System.Drawing.Size(93, 20);
            this.txtHargaSewa.TabIndex = 32;
            this.txtHargaSewa.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // txtHargaDenda
            // 
            this.txtHargaDenda.Location = new System.Drawing.Point(89, 256);
            this.txtHargaDenda.Name = "txtHargaDenda";
            this.txtHargaDenda.Size = new System.Drawing.Size(93, 20);
            this.txtHargaDenda.TabIndex = 33;
            this.txtHargaDenda.TextChanged += new System.EventHandler(this.validateTextInteger);
            // 
            // frmTambahKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 486);
            this.Controls.Add(this.txtHargaDenda);
            this.Controls.Add(this.txtHargaSewa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblHargaDenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHargaSewa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.txtJudul);
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
        private System.Windows.Forms.TextBox txtJudul;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHargaSewa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHargaDenda;
        private System.Windows.Forms.TextBox txtHargaSewa;
        private System.Windows.Forms.TextBox txtHargaDenda;
    }
}