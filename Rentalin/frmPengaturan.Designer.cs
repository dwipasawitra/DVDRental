namespace Rentalin
{
    partial class frmPengaturan
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
            this.gbBiayaSewa = new System.Windows.Forms.GroupBox();
            this.lblSewaInfo = new System.Windows.Forms.Label();
            this.chkSewaPerKategori = new System.Windows.Forms.CheckBox();
            this.chkSewaPerItem = new System.Windows.Forms.CheckBox();
            this.gbDenda = new System.Windows.Forms.GroupBox();
            this.chkDendaPerItem = new System.Windows.Forms.CheckBox();
            this.chkDendaPerKategori = new System.Windows.Forms.CheckBox();
            this.lblDendaInfo = new System.Windows.Forms.Label();
            this.lblInfoTambahan = new System.Windows.Forms.Label();
            this.gbDasar = new System.Windows.Forms.GroupBox();
            this.lblNamaJasa = new System.Windows.Forms.Label();
            this.txtNamaJasa = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtNamaPemilik = new System.Windows.Forms.TextBox();
            this.lblNamaPemilik = new System.Windows.Forms.Label();
            this.btnTerapkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.gbBiayaSewa.SuspendLayout();
            this.gbDenda.SuspendLayout();
            this.gbDasar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBiayaSewa
            // 
            this.gbBiayaSewa.Controls.Add(this.chkSewaPerItem);
            this.gbBiayaSewa.Controls.Add(this.chkSewaPerKategori);
            this.gbBiayaSewa.Controls.Add(this.lblSewaInfo);
            this.gbBiayaSewa.Location = new System.Drawing.Point(12, 133);
            this.gbBiayaSewa.Name = "gbBiayaSewa";
            this.gbBiayaSewa.Size = new System.Drawing.Size(440, 108);
            this.gbBiayaSewa.TabIndex = 0;
            this.gbBiayaSewa.TabStop = false;
            this.gbBiayaSewa.Text = "Skema Biaya Sewa";
            // 
            // lblSewaInfo
            // 
            this.lblSewaInfo.AutoSize = true;
            this.lblSewaInfo.Location = new System.Drawing.Point(6, 28);
            this.lblSewaInfo.Name = "lblSewaInfo";
            this.lblSewaInfo.Size = new System.Drawing.Size(207, 13);
            this.lblSewaInfo.TabIndex = 0;
            this.lblSewaInfo.Text = "Silahkan atur skema biaya sewa berikut ini";
            // 
            // chkSewaPerKategori
            // 
            this.chkSewaPerKategori.AutoSize = true;
            this.chkSewaPerKategori.Location = new System.Drawing.Point(9, 55);
            this.chkSewaPerKategori.Name = "chkSewaPerKategori";
            this.chkSewaPerKategori.Size = new System.Drawing.Size(189, 17);
            this.chkSewaPerKategori.TabIndex = 1;
            this.chkSewaPerKategori.Text = "Gunakan Biaya Sewa per Kategori";
            this.chkSewaPerKategori.UseVisualStyleBackColor = true;
            // 
            // chkSewaPerItem
            // 
            this.chkSewaPerItem.AutoSize = true;
            this.chkSewaPerItem.Location = new System.Drawing.Point(9, 78);
            this.chkSewaPerItem.Name = "chkSewaPerItem";
            this.chkSewaPerItem.Size = new System.Drawing.Size(170, 17);
            this.chkSewaPerItem.TabIndex = 2;
            this.chkSewaPerItem.Text = "Gunakan Biaya Sewa per Item";
            this.chkSewaPerItem.UseVisualStyleBackColor = true;
            // 
            // gbDenda
            // 
            this.gbDenda.Controls.Add(this.chkDendaPerItem);
            this.gbDenda.Controls.Add(this.chkDendaPerKategori);
            this.gbDenda.Controls.Add(this.lblDendaInfo);
            this.gbDenda.Location = new System.Drawing.Point(12, 247);
            this.gbDenda.Name = "gbDenda";
            this.gbDenda.Size = new System.Drawing.Size(440, 108);
            this.gbDenda.TabIndex = 1;
            this.gbDenda.TabStop = false;
            this.gbDenda.Text = "Skema Biaya Denda";
            // 
            // chkDendaPerItem
            // 
            this.chkDendaPerItem.AutoSize = true;
            this.chkDendaPerItem.Location = new System.Drawing.Point(9, 78);
            this.chkDendaPerItem.Name = "chkDendaPerItem";
            this.chkDendaPerItem.Size = new System.Drawing.Size(170, 17);
            this.chkDendaPerItem.TabIndex = 2;
            this.chkDendaPerItem.Text = "Gunakan Biaya Sewa per Item";
            this.chkDendaPerItem.UseVisualStyleBackColor = true;
            // 
            // chkDendaPerKategori
            // 
            this.chkDendaPerKategori.AutoSize = true;
            this.chkDendaPerKategori.Location = new System.Drawing.Point(9, 55);
            this.chkDendaPerKategori.Name = "chkDendaPerKategori";
            this.chkDendaPerKategori.Size = new System.Drawing.Size(189, 17);
            this.chkDendaPerKategori.TabIndex = 1;
            this.chkDendaPerKategori.Text = "Gunakan Biaya Sewa per Kategori";
            this.chkDendaPerKategori.UseVisualStyleBackColor = true;
            // 
            // lblDendaInfo
            // 
            this.lblDendaInfo.AutoSize = true;
            this.lblDendaInfo.Location = new System.Drawing.Point(6, 28);
            this.lblDendaInfo.Name = "lblDendaInfo";
            this.lblDendaInfo.Size = new System.Drawing.Size(207, 13);
            this.lblDendaInfo.TabIndex = 0;
            this.lblDendaInfo.Text = "Silahkan atur skema biaya sewa berikut ini";
            // 
            // lblInfoTambahan
            // 
            this.lblInfoTambahan.AutoSize = true;
            this.lblInfoTambahan.Location = new System.Drawing.Point(9, 371);
            this.lblInfoTambahan.Name = "lblInfoTambahan";
            this.lblInfoTambahan.Size = new System.Drawing.Size(449, 26);
            this.lblInfoTambahan.TabIndex = 2;
            this.lblInfoTambahan.Text = "PETUNJUK: Jika tidak ada skema biaya sewa/denda dipilih, maka sewa/denda akan gra" +
                "tis.\r\nJika kedua-duanya dipilih, maka skema biaya/sewa adalah biaya per kategori" +
                " + biaya per item";
            // 
            // gbDasar
            // 
            this.gbDasar.Controls.Add(this.txtNamaPemilik);
            this.gbDasar.Controls.Add(this.lblNamaPemilik);
            this.gbDasar.Controls.Add(this.txtAlamat);
            this.gbDasar.Controls.Add(this.lblAlamat);
            this.gbDasar.Controls.Add(this.txtNamaJasa);
            this.gbDasar.Controls.Add(this.lblNamaJasa);
            this.gbDasar.Location = new System.Drawing.Point(12, 4);
            this.gbDasar.Name = "gbDasar";
            this.gbDasar.Size = new System.Drawing.Size(440, 123);
            this.gbDasar.TabIndex = 3;
            this.gbDasar.TabStop = false;
            this.gbDasar.Text = "Pengaturan Dasar";
            // 
            // lblNamaJasa
            // 
            this.lblNamaJasa.AutoSize = true;
            this.lblNamaJasa.Location = new System.Drawing.Point(6, 28);
            this.lblNamaJasa.Name = "lblNamaJasa";
            this.lblNamaJasa.Size = new System.Drawing.Size(60, 13);
            this.lblNamaJasa.TabIndex = 0;
            this.lblNamaJasa.Text = "Nama Jasa";
            // 
            // txtNamaJasa
            // 
            this.txtNamaJasa.Location = new System.Drawing.Point(83, 25);
            this.txtNamaJasa.Name = "txtNamaJasa";
            this.txtNamaJasa.Size = new System.Drawing.Size(332, 20);
            this.txtNamaJasa.TabIndex = 1;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(83, 51);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(332, 20);
            this.txtAlamat.TabIndex = 3;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(6, 54);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtNamaPemilik
            // 
            this.txtNamaPemilik.Location = new System.Drawing.Point(83, 77);
            this.txtNamaPemilik.Name = "txtNamaPemilik";
            this.txtNamaPemilik.Size = new System.Drawing.Size(332, 20);
            this.txtNamaPemilik.TabIndex = 5;
            // 
            // lblNamaPemilik
            // 
            this.lblNamaPemilik.AutoSize = true;
            this.lblNamaPemilik.Location = new System.Drawing.Point(6, 80);
            this.lblNamaPemilik.Name = "lblNamaPemilik";
            this.lblNamaPemilik.Size = new System.Drawing.Size(71, 13);
            this.lblNamaPemilik.TabIndex = 4;
            this.lblNamaPemilik.Text = "Nama Pemilik";
            // 
            // btnTerapkan
            // 
            this.btnTerapkan.Location = new System.Drawing.Point(296, 420);
            this.btnTerapkan.Name = "btnTerapkan";
            this.btnTerapkan.Size = new System.Drawing.Size(75, 23);
            this.btnTerapkan.TabIndex = 4;
            this.btnTerapkan.Text = "Terapkan";
            this.btnTerapkan.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(377, 420);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // frmPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 451);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTerapkan);
            this.Controls.Add(this.gbDasar);
            this.Controls.Add(this.lblInfoTambahan);
            this.Controls.Add(this.gbDenda);
            this.Controls.Add(this.gbBiayaSewa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPengaturan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan";
            this.gbBiayaSewa.ResumeLayout(false);
            this.gbBiayaSewa.PerformLayout();
            this.gbDenda.ResumeLayout(false);
            this.gbDenda.PerformLayout();
            this.gbDasar.ResumeLayout(false);
            this.gbDasar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBiayaSewa;
        private System.Windows.Forms.CheckBox chkSewaPerItem;
        private System.Windows.Forms.CheckBox chkSewaPerKategori;
        private System.Windows.Forms.Label lblSewaInfo;
        private System.Windows.Forms.GroupBox gbDenda;
        private System.Windows.Forms.CheckBox chkDendaPerItem;
        private System.Windows.Forms.CheckBox chkDendaPerKategori;
        private System.Windows.Forms.Label lblDendaInfo;
        private System.Windows.Forms.Label lblInfoTambahan;
        private System.Windows.Forms.GroupBox gbDasar;
        private System.Windows.Forms.TextBox txtNamaPemilik;
        private System.Windows.Forms.Label lblNamaPemilik;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtNamaJasa;
        private System.Windows.Forms.Label lblNamaJasa;
        private System.Windows.Forms.Button btnTerapkan;
        private System.Windows.Forms.Button btnBatal;
    }
}