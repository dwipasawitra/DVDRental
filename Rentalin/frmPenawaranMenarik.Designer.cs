namespace Rentalin
{
    partial class frmPenawaranMenarik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPenawaranMenarik));
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.dgPenawaranMenarik = new System.Windows.Forms.DataGridView();
            this.gbPengaturan = new System.Windows.Forms.GroupBox();
            this.dtpTanggalSelesai = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalSelesai = new System.Windows.Forms.Label();
            this.dtpTanggalMulai = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalMulai = new System.Windows.Forms.Label();
            this.lbPersen = new System.Windows.Forms.Label();
            this.nmrDiskon = new System.Windows.Forms.NumericUpDown();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnTambahModifikasi = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenawaranMenarik)).BeginInit();
            this.gbPengaturan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Silver;
            this.pnlInfo.Controls.Add(this.btnHapus);
            this.pnlInfo.Controls.Add(this.btnBaru);
            this.pnlInfo.Controls.Add(this.lblDeskripsi);
            this.pnlInfo.Controls.Add(this.lblJudul);
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(693, 96);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(17, 38);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(450, 39);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = resources.GetString("lblDeskripsi.Text");
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(348, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Pengaturan Penawaran Menarik";
            // 
            // dgPenawaranMenarik
            // 
            this.dgPenawaranMenarik.AllowUserToAddRows = false;
            this.dgPenawaranMenarik.AllowUserToDeleteRows = false;
            this.dgPenawaranMenarik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPenawaranMenarik.Location = new System.Drawing.Point(17, 102);
            this.dgPenawaranMenarik.Name = "dgPenawaranMenarik";
            this.dgPenawaranMenarik.ReadOnly = true;
            this.dgPenawaranMenarik.Size = new System.Drawing.Size(484, 234);
            this.dgPenawaranMenarik.TabIndex = 1;
            this.dgPenawaranMenarik.SelectionChanged += new System.EventHandler(this.dgPenawaranMenarik_SelectionChanged);
            // 
            // gbPengaturan
            // 
            this.gbPengaturan.Controls.Add(this.dtpTanggalSelesai);
            this.gbPengaturan.Controls.Add(this.lblTanggalSelesai);
            this.gbPengaturan.Controls.Add(this.dtpTanggalMulai);
            this.gbPengaturan.Controls.Add(this.lblTanggalMulai);
            this.gbPengaturan.Controls.Add(this.lbPersen);
            this.gbPengaturan.Controls.Add(this.nmrDiskon);
            this.gbPengaturan.Controls.Add(this.lblDiskon);
            this.gbPengaturan.Controls.Add(this.txtNama);
            this.gbPengaturan.Controls.Add(this.lblNama);
            this.gbPengaturan.Controls.Add(this.btnTambahModifikasi);
            this.gbPengaturan.Location = new System.Drawing.Point(507, 102);
            this.gbPengaturan.Name = "gbPengaturan";
            this.gbPengaturan.Size = new System.Drawing.Size(175, 233);
            this.gbPengaturan.TabIndex = 2;
            this.gbPengaturan.TabStop = false;
            this.gbPengaturan.Text = "Pengaturan";
            // 
            // dtpTanggalSelesai
            // 
            this.dtpTanggalSelesai.Location = new System.Drawing.Point(6, 145);
            this.dtpTanggalSelesai.Name = "dtpTanggalSelesai";
            this.dtpTanggalSelesai.Size = new System.Drawing.Size(160, 20);
            this.dtpTanggalSelesai.TabIndex = 9;
            // 
            // lblTanggalSelesai
            // 
            this.lblTanggalSelesai.AutoSize = true;
            this.lblTanggalSelesai.Location = new System.Drawing.Point(3, 129);
            this.lblTanggalSelesai.Name = "lblTanggalSelesai";
            this.lblTanggalSelesai.Size = new System.Drawing.Size(74, 13);
            this.lblTanggalSelesai.TabIndex = 8;
            this.lblTanggalSelesai.Text = "Tanggal Mulai";
            // 
            // dtpTanggalMulai
            // 
            this.dtpTanggalMulai.Location = new System.Drawing.Point(6, 104);
            this.dtpTanggalMulai.Name = "dtpTanggalMulai";
            this.dtpTanggalMulai.Size = new System.Drawing.Size(160, 20);
            this.dtpTanggalMulai.TabIndex = 7;
            // 
            // lblTanggalMulai
            // 
            this.lblTanggalMulai.AutoSize = true;
            this.lblTanggalMulai.Location = new System.Drawing.Point(6, 88);
            this.lblTanggalMulai.Name = "lblTanggalMulai";
            this.lblTanggalMulai.Size = new System.Drawing.Size(74, 13);
            this.lblTanggalMulai.TabIndex = 6;
            this.lblTanggalMulai.Text = "Tanggal Mulai";
            // 
            // lbPersen
            // 
            this.lbPersen.AutoSize = true;
            this.lbPersen.Location = new System.Drawing.Point(154, 64);
            this.lbPersen.Name = "lbPersen";
            this.lbPersen.Size = new System.Drawing.Size(15, 13);
            this.lbPersen.TabIndex = 5;
            this.lbPersen.Text = "%";
            // 
            // nmrDiskon
            // 
            this.nmrDiskon.Location = new System.Drawing.Point(88, 62);
            this.nmrDiskon.Name = "nmrDiskon";
            this.nmrDiskon.Size = new System.Drawing.Size(60, 20);
            this.nmrDiskon.TabIndex = 4;
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Location = new System.Drawing.Point(6, 64);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(40, 13);
            this.lblDiskon.TabIndex = 3;
            this.lblDiskon.Text = "Diskon";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(6, 37);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(163, 20);
            this.txtNama.TabIndex = 2;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(6, 20);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(133, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Penawaran Menarik";
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
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(520, 12);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(153, 32);
            this.btnBaru.TabIndex = 2;
            this.btnBaru.Text = "Penawaran Menarik Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(520, 54);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(152, 31);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Penawaran Menarik";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // frmPenawaranMenarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 348);
            this.Controls.Add(this.gbPengaturan);
            this.Controls.Add(this.dgPenawaranMenarik);
            this.Controls.Add(this.pnlInfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPenawaranMenarik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Pengaturan Penawaran Menarik";
            this.Load += new System.EventHandler(this.frmPenawaranMenarik_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenawaranMenarik)).EndInit();
            this.gbPengaturan.ResumeLayout(false);
            this.gbPengaturan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiskon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.DataGridView dgPenawaranMenarik;
        private System.Windows.Forms.GroupBox gbPengaturan;
        private System.Windows.Forms.DateTimePicker dtpTanggalSelesai;
        private System.Windows.Forms.Label lblTanggalSelesai;
        private System.Windows.Forms.DateTimePicker dtpTanggalMulai;
        private System.Windows.Forms.Label lblTanggalMulai;
        private System.Windows.Forms.Label lbPersen;
        private System.Windows.Forms.NumericUpDown nmrDiskon;
        private System.Windows.Forms.Label lblDiskon;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnTambahModifikasi;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.Button btnHapus;
    }
}