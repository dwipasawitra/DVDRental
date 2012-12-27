namespace Rentalin
{
    partial class frmMasterKategori
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnTambahModifikasi = new System.Windows.Forms.Button();
            this.dgKategori = new System.Windows.Forms.DataGridView();
            this.btnBaru = new System.Windows.Forms.Button();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.gbPengaturan = new System.Windows.Forms.GroupBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblKodeKategori = new System.Windows.Forms.Label();
            this.txtDendaPerKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHargaPerKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategori)).BeginInit();
            this.gbPengaturan.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(3, 54);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(163, 20);
            this.txtNama.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(3, 37);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(77, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Kategori";
            // 
            // btnTambahModifikasi
            // 
            this.btnTambahModifikasi.Location = new System.Drawing.Point(6, 192);
            this.btnTambahModifikasi.Name = "btnTambahModifikasi";
            this.btnTambahModifikasi.Size = new System.Drawing.Size(163, 30);
            this.btnTambahModifikasi.TabIndex = 0;
            this.btnTambahModifikasi.Text = "Modifikasi";
            this.btnTambahModifikasi.UseVisualStyleBackColor = true;
            this.btnTambahModifikasi.Click += new System.EventHandler(this.btnTambahModifikasi_Click);
            // 
            // dgKategori
            // 
            this.dgKategori.AllowUserToAddRows = false;
            this.dgKategori.AllowUserToDeleteRows = false;
            this.dgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKategori.Location = new System.Drawing.Point(16, 102);
            this.dgKategori.Name = "dgKategori";
            this.dgKategori.ReadOnly = true;
            this.dgKategori.Size = new System.Drawing.Size(303, 234);
            this.dgKategori.TabIndex = 4;
            this.dgKategori.SelectionChanged += new System.EventHandler(this.dgPenawaranMenarik_SelectionChanged);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(342, 28);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(153, 32);
            this.btnBaru.TabIndex = 2;
            this.btnBaru.Text = "Kategori Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(17, 38);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(231, 39);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Melalui jendela ini, Anda dapat mengatur\r\nkategori judul yang tersedia beserta pe" +
                "ngaturan\r\nbiaya sewa atau biaya dendanya.";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(179, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Master Kategori";
            // 
            // gbPengaturan
            // 
            this.gbPengaturan.Controls.Add(this.txtKode);
            this.gbPengaturan.Controls.Add(this.lblKodeKategori);
            this.gbPengaturan.Controls.Add(this.txtDendaPerKategori);
            this.gbPengaturan.Controls.Add(this.label2);
            this.gbPengaturan.Controls.Add(this.txtHargaPerKategori);
            this.gbPengaturan.Controls.Add(this.label1);
            this.gbPengaturan.Controls.Add(this.txtNama);
            this.gbPengaturan.Controls.Add(this.lblNama);
            this.gbPengaturan.Controls.Add(this.btnTambahModifikasi);
            this.gbPengaturan.Location = new System.Drawing.Point(325, 103);
            this.gbPengaturan.Name = "gbPengaturan";
            this.gbPengaturan.Size = new System.Drawing.Size(175, 233);
            this.gbPengaturan.TabIndex = 5;
            this.gbPengaturan.TabStop = false;
            this.gbPengaturan.Text = "Pengaturan";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(44, 14);
            this.txtKode.MaxLength = 4;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(51, 20);
            this.txtKode.TabIndex = 7;
            // 
            // lblKodeKategori
            // 
            this.lblKodeKategori.AutoSize = true;
            this.lblKodeKategori.Location = new System.Drawing.Point(3, 17);
            this.lblKodeKategori.Name = "lblKodeKategori";
            this.lblKodeKategori.Size = new System.Drawing.Size(32, 13);
            this.lblKodeKategori.TabIndex = 6;
            this.lblKodeKategori.Text = "Kode";
            // 
            // txtDendaPerKategori
            // 
            this.txtDendaPerKategori.Location = new System.Drawing.Point(3, 132);
            this.txtDendaPerKategori.Name = "txtDendaPerKategori";
            this.txtDendaPerKategori.Size = new System.Drawing.Size(163, 20);
            this.txtDendaPerKategori.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Denda Per Kategori";
            // 
            // txtHargaPerKategori
            // 
            this.txtHargaPerKategori.Location = new System.Drawing.Point(3, 93);
            this.txtHargaPerKategori.Name = "txtHargaPerKategori";
            this.txtHargaPerKategori.Size = new System.Drawing.Size(163, 20);
            this.txtHargaPerKategori.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harga Per Kategori";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlInfo.Controls.Add(this.btnBaru);
            this.pnlInfo.Controls.Add(this.lblDeskripsi);
            this.pnlInfo.Controls.Add(this.lblJudul);
            this.pnlInfo.Location = new System.Drawing.Point(-1, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(512, 96);
            this.pnlInfo.TabIndex = 3;
            // 
            // frmMasterKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 346);
            this.Controls.Add(this.dgKategori);
            this.Controls.Add(this.gbPengaturan);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMasterKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Kategori";
            this.Load += new System.EventHandler(this.frmMasterKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKategori)).EndInit();
            this.gbPengaturan.ResumeLayout(false);
            this.gbPengaturan.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnTambahModifikasi;
        private System.Windows.Forms.DataGridView dgKategori;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox gbPengaturan;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TextBox txtDendaPerKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHargaPerKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblKodeKategori;
    }
}