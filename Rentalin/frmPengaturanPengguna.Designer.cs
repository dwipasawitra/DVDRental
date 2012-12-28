namespace Rentalin
{
    partial class frmPengaturanPengguna
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.listPengguna = new System.Windows.Forms.ListBox();
            this.pnlPengaturanPengguna = new System.Windows.Forms.Panel();
            this.btnHapusPengguna = new System.Windows.Forms.Button();
            this.lblInfoPengubahan = new System.Windows.Forms.Label();
            this.cmbKewenangan = new System.Windows.Forms.ComboBox();
            this.lblKewenangan = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNamaLengkap = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.btnUbahPassword = new System.Windows.Forms.Button();
            this.lblNamaPengguna = new System.Windows.Forms.Label();
            this.lblDaftarPenggunaInfo = new System.Windows.Forms.Label();
            this.btnTambahPengguna = new System.Windows.Forms.Button();
            this.txtNamaPenggunaBaru = new System.Windows.Forms.TextBox();
            this.pnlInfo.SuspendLayout();
            this.pnlPengaturanPengguna.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-1, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(575, 62);
            this.pnlInfo.TabIndex = 2;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(13, 35);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(429, 13);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan mengatur daftar pengguna aplikasi disini beserta password dan kewenangan" +
                "nya";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(11, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(197, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Master Pengguna";
            // 
            // listPengguna
            // 
            this.listPengguna.FormattingEnabled = true;
            this.listPengguna.Location = new System.Drawing.Point(12, 93);
            this.listPengguna.Name = "listPengguna";
            this.listPengguna.Size = new System.Drawing.Size(339, 238);
            this.listPengguna.TabIndex = 3;
            this.listPengguna.SelectedIndexChanged += new System.EventHandler(this.listPengguna_SelectedIndexChanged);
            // 
            // pnlPengaturanPengguna
            // 
            this.pnlPengaturanPengguna.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlPengaturanPengguna.Controls.Add(this.txtNamaPenggunaBaru);
            this.pnlPengaturanPengguna.Controls.Add(this.btnHapusPengguna);
            this.pnlPengaturanPengguna.Controls.Add(this.lblInfoPengubahan);
            this.pnlPengaturanPengguna.Controls.Add(this.cmbKewenangan);
            this.pnlPengaturanPengguna.Controls.Add(this.lblKewenangan);
            this.pnlPengaturanPengguna.Controls.Add(this.lblPassword);
            this.pnlPengaturanPengguna.Controls.Add(this.txtPassword);
            this.pnlPengaturanPengguna.Controls.Add(this.lblNamaLengkap);
            this.pnlPengaturanPengguna.Controls.Add(this.txtNamaLengkap);
            this.pnlPengaturanPengguna.Controls.Add(this.btnUbahPassword);
            this.pnlPengaturanPengguna.Controls.Add(this.lblNamaPengguna);
            this.pnlPengaturanPengguna.ForeColor = System.Drawing.Color.Black;
            this.pnlPengaturanPengguna.Location = new System.Drawing.Point(360, 71);
            this.pnlPengaturanPengguna.Name = "pnlPengaturanPengguna";
            this.pnlPengaturanPengguna.Size = new System.Drawing.Size(213, 271);
            this.pnlPengaturanPengguna.TabIndex = 4;
            // 
            // btnHapusPengguna
            // 
            this.btnHapusPengguna.Location = new System.Drawing.Point(21, 233);
            this.btnHapusPengguna.Name = "btnHapusPengguna";
            this.btnHapusPengguna.Size = new System.Drawing.Size(178, 23);
            this.btnHapusPengguna.TabIndex = 9;
            this.btnHapusPengguna.Text = "Hapus Pengguna";
            this.btnHapusPengguna.UseVisualStyleBackColor = true;
            this.btnHapusPengguna.Click += new System.EventHandler(this.btnHapusPengguna_Click);
            // 
            // lblInfoPengubahan
            // 
            this.lblInfoPengubahan.AutoSize = true;
            this.lblInfoPengubahan.Location = new System.Drawing.Point(18, 196);
            this.lblInfoPengubahan.Name = "lblInfoPengubahan";
            this.lblInfoPengubahan.Size = new System.Drawing.Size(169, 26);
            this.lblInfoPengubahan.TabIndex = 8;
            this.lblInfoPengubahan.Text = "CATATAN! Pengaturan baru akan\r\nlangsung diterapkan!";
            // 
            // cmbKewenangan
            // 
            this.cmbKewenangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKewenangan.FormattingEnabled = true;
            this.cmbKewenangan.Location = new System.Drawing.Point(18, 172);
            this.cmbKewenangan.Name = "cmbKewenangan";
            this.cmbKewenangan.Size = new System.Drawing.Size(181, 21);
            this.cmbKewenangan.TabIndex = 7;
            this.cmbKewenangan.SelectedIndexChanged += new System.EventHandler(this.cmbKewenangan_SelectedIndexChanged);
            // 
            // lblKewenangan
            // 
            this.lblKewenangan.AutoSize = true;
            this.lblKewenangan.Location = new System.Drawing.Point(18, 156);
            this.lblKewenangan.Name = "lblKewenangan";
            this.lblKewenangan.Size = new System.Drawing.Size(70, 13);
            this.lblKewenangan.TabIndex = 6;
            this.lblKewenangan.Text = "Kewenangan";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(18, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "passwordpasswordpassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNamaLengkap
            // 
            this.lblNamaLengkap.AutoSize = true;
            this.lblNamaLengkap.Location = new System.Drawing.Point(16, 41);
            this.lblNamaLengkap.Name = "lblNamaLengkap";
            this.lblNamaLengkap.Size = new System.Drawing.Size(80, 13);
            this.lblNamaLengkap.TabIndex = 3;
            this.lblNamaLengkap.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Location = new System.Drawing.Point(18, 60);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(181, 20);
            this.txtNamaLengkap.TabIndex = 2;
            // 
            // btnUbahPassword
            // 
            this.btnUbahPassword.ForeColor = System.Drawing.Color.Black;
            this.btnUbahPassword.Location = new System.Drawing.Point(18, 122);
            this.btnUbahPassword.Name = "btnUbahPassword";
            this.btnUbahPassword.Size = new System.Drawing.Size(181, 23);
            this.btnUbahPassword.TabIndex = 1;
            this.btnUbahPassword.Text = "Ubah Password";
            this.btnUbahPassword.UseVisualStyleBackColor = true;
            this.btnUbahPassword.Click += new System.EventHandler(this.btnUbahPassword_Click);
            // 
            // lblNamaPengguna
            // 
            this.lblNamaPengguna.AutoSize = true;
            this.lblNamaPengguna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPengguna.Location = new System.Drawing.Point(13, 11);
            this.lblNamaPengguna.Name = "lblNamaPengguna";
            this.lblNamaPengguna.Size = new System.Drawing.Size(59, 25);
            this.lblNamaPengguna.TabIndex = 0;
            this.lblNamaPengguna.Text = "Bejo";
            // 
            // lblDaftarPenggunaInfo
            // 
            this.lblDaftarPenggunaInfo.AutoSize = true;
            this.lblDaftarPenggunaInfo.Location = new System.Drawing.Point(12, 71);
            this.lblDaftarPenggunaInfo.Name = "lblDaftarPenggunaInfo";
            this.lblDaftarPenggunaInfo.Size = new System.Drawing.Size(88, 13);
            this.lblDaftarPenggunaInfo.TabIndex = 5;
            this.lblDaftarPenggunaInfo.Text = "Daftar Pengguna";
            // 
            // btnTambahPengguna
            // 
            this.btnTambahPengguna.Location = new System.Drawing.Point(231, 67);
            this.btnTambahPengguna.Name = "btnTambahPengguna";
            this.btnTambahPengguna.Size = new System.Drawing.Size(120, 23);
            this.btnTambahPengguna.TabIndex = 6;
            this.btnTambahPengguna.Text = "Tambah Pengguna";
            this.btnTambahPengguna.UseVisualStyleBackColor = true;
            this.btnTambahPengguna.Click += new System.EventHandler(this.btnTambahPengguna_Click);
            // 
            // txtNamaPenggunaBaru
            // 
            this.txtNamaPenggunaBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPenggunaBaru.Location = new System.Drawing.Point(18, 9);
            this.txtNamaPenggunaBaru.Name = "txtNamaPenggunaBaru";
            this.txtNamaPenggunaBaru.Size = new System.Drawing.Size(181, 29);
            this.txtNamaPenggunaBaru.TabIndex = 10;
            this.txtNamaPenggunaBaru.Visible = false;
            this.txtNamaPenggunaBaru.Enter += new System.EventHandler(this.txtNamaPenggunaBaru_Enter);
            // 
            // frmPengaturanPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 339);
            this.Controls.Add(this.btnTambahPengguna);
            this.Controls.Add(this.lblDaftarPenggunaInfo);
            this.Controls.Add(this.pnlPengaturanPengguna);
            this.Controls.Add(this.listPengguna);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPengaturanPengguna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Pengaturan Pengguna";
            this.Load += new System.EventHandler(this.frmPengaturanPengguna_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlPengaturanPengguna.ResumeLayout(false);
            this.pnlPengaturanPengguna.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox listPengguna;
        private System.Windows.Forms.Panel pnlPengaturanPengguna;
        private System.Windows.Forms.Label lblNamaPengguna;
        private System.Windows.Forms.Label lblDaftarPenggunaInfo;
        private System.Windows.Forms.ComboBox cmbKewenangan;
        private System.Windows.Forms.Label lblKewenangan;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNamaLengkap;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Button btnUbahPassword;
        private System.Windows.Forms.Button btnTambahPengguna;
        private System.Windows.Forms.Label lblInfoPengubahan;
        private System.Windows.Forms.Button btnHapusPengguna;
        private System.Windows.Forms.TextBox txtNamaPenggunaBaru;
    }
}