namespace Rentalin
{
    partial class frmAdmin
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
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleInfo = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.lblLogedInAs = new System.Windows.Forms.Label();
            this.lblInfoJudul = new System.Windows.Forms.Label();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.lblPengaturanInfo = new System.Windows.Forms.Label();
            this.lblKewenanganInfo = new System.Windows.Forms.Label();
            this.btnKewenangan = new System.Windows.Forms.Button();
            this.lblPenggunaInfo = new System.Windows.Forms.Label();
            this.btnPengguna = new System.Windows.Forms.Button();
            this.lblSOinfo = new System.Windows.Forms.Label();
            this.btnSO = new System.Windows.Forms.Button();
            this.lblLaporanNotaInfo = new System.Windows.Forms.Label();
            this.btnLaporanNota = new System.Windows.Forms.Button();
            this.lblLaporanTransaksiInfo = new System.Windows.Forms.Label();
            this.btnLaporanTransaksi = new System.Windows.Forms.Button();
            this.lblLaporanKeuanganInfo = new System.Windows.Forms.Label();
            this.btnLaporanKeuangan = new System.Windows.Forms.Button();
            this.lblMenuOperatorInfo = new System.Windows.Forms.Label();
            this.btnMenuOperator = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlInfo.Controls.Add(this.lblRole);
            this.pnlInfo.Controls.Add(this.lblRoleInfo);
            this.pnlInfo.Controls.Add(this.btnLogout);
            this.pnlInfo.Controls.Add(this.lblUserName);
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.lblLogedInAs);
            this.pnlInfo.Controls.Add(this.lblInfoJudul);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(708, 76);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(321, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(55, 13);
            this.lblRole.TabIndex = 21;
            this.lblRole.Text = "Superuser";
            // 
            // lblRoleInfo
            // 
            this.lblRoleInfo.AutoSize = true;
            this.lblRoleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleInfo.Location = new System.Drawing.Point(321, 15);
            this.lblRoleInfo.Name = "lblRoleInfo";
            this.lblRoleInfo.Size = new System.Drawing.Size(80, 13);
            this.lblRoleInfo.TabIndex = 20;
            this.lblRoleInfo.Text = "Kewenangan";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(627, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 38);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(539, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 24);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "Bejo";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.Location = new System.Drawing.Point(13, 30);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(262, 26);
            this.lblInfoDetail.TabIndex = 1;
            this.lblInfoDetail.Text = "Anda sedang berada di menu Administrator.\r\nSilahkan membuka menu yang diinginkan " +
                "di bawah ini";
            // 
            // lblLogedInAs
            // 
            this.lblLogedInAs.AutoSize = true;
            this.lblLogedInAs.Location = new System.Drawing.Point(540, 15);
            this.lblLogedInAs.Name = "lblLogedInAs";
            this.lblLogedInAs.Size = new System.Drawing.Size(79, 13);
            this.lblLogedInAs.TabIndex = 17;
            this.lblLogedInAs.Text = "Masuk sebagai";
            this.lblLogedInAs.Click += new System.EventHandler(this.lblLogedInAs_Click);
            // 
            // lblInfoJudul
            // 
            this.lblInfoJudul.AutoSize = true;
            this.lblInfoJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJudul.Location = new System.Drawing.Point(12, 10);
            this.lblInfoJudul.Name = "lblInfoJudul";
            this.lblInfoJudul.Size = new System.Drawing.Size(165, 20);
            this.lblInfoJudul.TabIndex = 0;
            this.lblInfoJudul.Text = "Menu Administrator";
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.Location = new System.Drawing.Point(189, 91);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(126, 26);
            this.btnPengaturan.TabIndex = 1;
            this.btnPengaturan.Text = "Pengaturan Sistem";
            this.btnPengaturan.UseVisualStyleBackColor = true;
            this.btnPengaturan.Click += new System.EventHandler(this.btnPengaturan_Click);
            // 
            // lblPengaturanInfo
            // 
            this.lblPengaturanInfo.AutoSize = true;
            this.lblPengaturanInfo.Location = new System.Drawing.Point(321, 91);
            this.lblPengaturanInfo.Name = "lblPengaturanInfo";
            this.lblPengaturanInfo.Size = new System.Drawing.Size(253, 26);
            this.lblPengaturanInfo.TabIndex = 2;
            this.lblPengaturanInfo.Text = "Lakukan pengaturan terhadap bagaimana\r\nsistem biaya sewa, denda, pengaturan info " +
                "rental, dll";
            // 
            // lblKewenanganInfo
            // 
            this.lblKewenanganInfo.AutoSize = true;
            this.lblKewenanganInfo.Location = new System.Drawing.Point(321, 129);
            this.lblKewenanganInfo.Name = "lblKewenanganInfo";
            this.lblKewenanganInfo.Size = new System.Drawing.Size(255, 26);
            this.lblKewenanganInfo.TabIndex = 4;
            this.lblKewenanganInfo.Text = "Atur kewenangan apa saja yang ada di dalam sistem\r\nbeserta bagaimana kewenangan t" +
                "ersebut berjalan.";
            // 
            // btnKewenangan
            // 
            this.btnKewenangan.Location = new System.Drawing.Point(189, 123);
            this.btnKewenangan.Name = "btnKewenangan";
            this.btnKewenangan.Size = new System.Drawing.Size(126, 38);
            this.btnKewenangan.TabIndex = 3;
            this.btnKewenangan.Text = "Pengaturan Kewenangan";
            this.btnKewenangan.UseVisualStyleBackColor = true;
            this.btnKewenangan.Click += new System.EventHandler(this.btnKewenangan_Click);
            // 
            // lblPenggunaInfo
            // 
            this.lblPenggunaInfo.AutoSize = true;
            this.lblPenggunaInfo.Location = new System.Drawing.Point(321, 165);
            this.lblPenggunaInfo.Name = "lblPenggunaInfo";
            this.lblPenggunaInfo.Size = new System.Drawing.Size(215, 13);
            this.lblPenggunaInfo.TabIndex = 6;
            this.lblPenggunaInfo.Text = "Atur akun pengguna yang terdapat di sistem";
            // 
            // btnPengguna
            // 
            this.btnPengguna.Location = new System.Drawing.Point(189, 165);
            this.btnPengguna.Name = "btnPengguna";
            this.btnPengguna.Size = new System.Drawing.Size(126, 26);
            this.btnPengguna.TabIndex = 5;
            this.btnPengguna.Text = "Pengaturan Pengguna";
            this.btnPengguna.UseVisualStyleBackColor = true;
            this.btnPengguna.Click += new System.EventHandler(this.btnPengguna_Click);
            // 
            // lblSOinfo
            // 
            this.lblSOinfo.AutoSize = true;
            this.lblSOinfo.Location = new System.Drawing.Point(321, 197);
            this.lblSOinfo.Name = "lblSOinfo";
            this.lblSOinfo.Size = new System.Drawing.Size(219, 26);
            this.lblSOinfo.TabIndex = 8;
            this.lblSOinfo.Text = "Atur diskon apa saja yang yang terdapat\r\npada sistem persewaan pada waktu tertent" +
                "u.";
            // 
            // btnSO
            // 
            this.btnSO.Location = new System.Drawing.Point(189, 197);
            this.btnSO.Name = "btnSO";
            this.btnSO.Size = new System.Drawing.Size(126, 37);
            this.btnSO.TabIndex = 7;
            this.btnSO.Text = "Atur Penawaran Menarik";
            this.btnSO.UseVisualStyleBackColor = true;
            // 
            // lblLaporanNotaInfo
            // 
            this.lblLaporanNotaInfo.AutoSize = true;
            this.lblLaporanNotaInfo.Location = new System.Drawing.Point(321, 240);
            this.lblLaporanNotaInfo.Name = "lblLaporanNotaInfo";
            this.lblLaporanNotaInfo.Size = new System.Drawing.Size(263, 13);
            this.lblLaporanNotaInfo.TabIndex = 10;
            this.lblLaporanNotaInfo.Text = "Lihat laporan nota transaksi untuk salah satu transaksi";
            // 
            // btnLaporanNota
            // 
            this.btnLaporanNota.Location = new System.Drawing.Point(189, 240);
            this.btnLaporanNota.Name = "btnLaporanNota";
            this.btnLaporanNota.Size = new System.Drawing.Size(126, 26);
            this.btnLaporanNota.TabIndex = 9;
            this.btnLaporanNota.Text = "Laporan Nota";
            this.btnLaporanNota.UseVisualStyleBackColor = true;
            this.btnLaporanNota.Click += new System.EventHandler(this.btnLaporanNota_Click);
            // 
            // lblLaporanTransaksiInfo
            // 
            this.lblLaporanTransaksiInfo.AutoSize = true;
            this.lblLaporanTransaksiInfo.Location = new System.Drawing.Point(321, 272);
            this.lblLaporanTransaksiInfo.Name = "lblLaporanTransaksiInfo";
            this.lblLaporanTransaksiInfo.Size = new System.Drawing.Size(249, 26);
            this.lblLaporanTransaksiInfo.TabIndex = 12;
            this.lblLaporanTransaksiInfo.Text = "Lihat daftar Transaksi untuk rentang waktu tertentu\r\n(Mingguan, Bulanan, Tahunan)" +
                "";
            // 
            // btnLaporanTransaksi
            // 
            this.btnLaporanTransaksi.Location = new System.Drawing.Point(189, 272);
            this.btnLaporanTransaksi.Name = "btnLaporanTransaksi";
            this.btnLaporanTransaksi.Size = new System.Drawing.Size(126, 26);
            this.btnLaporanTransaksi.TabIndex = 11;
            this.btnLaporanTransaksi.Text = "Laporan Transaksi";
            this.btnLaporanTransaksi.UseVisualStyleBackColor = true;
            this.btnLaporanTransaksi.Click += new System.EventHandler(this.btnLaporanTransaksi_Click);
            // 
            // lblLaporanKeuanganInfo
            // 
            this.lblLaporanKeuanganInfo.AutoSize = true;
            this.lblLaporanKeuanganInfo.Location = new System.Drawing.Point(321, 304);
            this.lblLaporanKeuanganInfo.Name = "lblLaporanKeuanganInfo";
            this.lblLaporanKeuanganInfo.Size = new System.Drawing.Size(263, 26);
            this.lblLaporanKeuanganInfo.TabIndex = 16;
            this.lblLaporanKeuanganInfo.Text = "Lihat laporan pemasukan atau pengeluaran jasa rental\r\ndalam suatu hari, minggu da" +
                "n bulan tertentu";
            // 
            // btnLaporanKeuangan
            // 
            this.btnLaporanKeuangan.Location = new System.Drawing.Point(189, 304);
            this.btnLaporanKeuangan.Name = "btnLaporanKeuangan";
            this.btnLaporanKeuangan.Size = new System.Drawing.Size(126, 26);
            this.btnLaporanKeuangan.TabIndex = 15;
            this.btnLaporanKeuangan.Text = "Laporan Keuangan";
            this.btnLaporanKeuangan.UseVisualStyleBackColor = true;
            // 
            // lblMenuOperatorInfo
            // 
            this.lblMenuOperatorInfo.AutoSize = true;
            this.lblMenuOperatorInfo.Location = new System.Drawing.Point(321, 336);
            this.lblMenuOperatorInfo.Name = "lblMenuOperatorInfo";
            this.lblMenuOperatorInfo.Size = new System.Drawing.Size(135, 13);
            this.lblMenuOperatorInfo.TabIndex = 18;
            this.lblMenuOperatorInfo.Text = "Buka menu utama operator";
            // 
            // btnMenuOperator
            // 
            this.btnMenuOperator.Location = new System.Drawing.Point(189, 336);
            this.btnMenuOperator.Name = "btnMenuOperator";
            this.btnMenuOperator.Size = new System.Drawing.Size(126, 26);
            this.btnMenuOperator.TabIndex = 17;
            this.btnMenuOperator.Text = "Menu Operator";
            this.btnMenuOperator.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 370);
            this.Controls.Add(this.lblMenuOperatorInfo);
            this.Controls.Add(this.btnMenuOperator);
            this.Controls.Add(this.lblLaporanKeuanganInfo);
            this.Controls.Add(this.btnLaporanKeuangan);
            this.Controls.Add(this.lblLaporanTransaksiInfo);
            this.Controls.Add(this.btnLaporanTransaksi);
            this.Controls.Add(this.lblLaporanNotaInfo);
            this.Controls.Add(this.btnLaporanNota);
            this.Controls.Add(this.lblSOinfo);
            this.Controls.Add(this.btnSO);
            this.Controls.Add(this.lblPenggunaInfo);
            this.Controls.Add(this.btnPengguna);
            this.Controls.Add(this.lblKewenanganInfo);
            this.Controls.Add(this.btnKewenangan);
            this.Controls.Add(this.lblPengaturanInfo);
            this.Controls.Add(this.btnPengaturan);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Menu [ADMIN]";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfoJudul;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLogedInAs;
        private System.Windows.Forms.Button btnPengaturan;
        private System.Windows.Forms.Label lblPengaturanInfo;
        private System.Windows.Forms.Label lblKewenanganInfo;
        private System.Windows.Forms.Button btnKewenangan;
        private System.Windows.Forms.Label lblPenggunaInfo;
        private System.Windows.Forms.Button btnPengguna;
        private System.Windows.Forms.Label lblSOinfo;
        private System.Windows.Forms.Button btnSO;
        private System.Windows.Forms.Label lblLaporanNotaInfo;
        private System.Windows.Forms.Button btnLaporanNota;
        private System.Windows.Forms.Label lblLaporanTransaksiInfo;
        private System.Windows.Forms.Button btnLaporanTransaksi;
        private System.Windows.Forms.Label lblLaporanKeuanganInfo;
        private System.Windows.Forms.Button btnLaporanKeuangan;
        private System.Windows.Forms.Label lblMenuOperatorInfo;
        private System.Windows.Forms.Button btnMenuOperator;
    }
}