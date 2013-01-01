﻿namespace Rentalin
{
    partial class frmLaporanKeuangan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaporanKeuangan));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.rbPerBulan = new System.Windows.Forms.RadioButton();
            this.rbPerMinggu = new System.Windows.Forms.RadioButton();
            this.rbPerTanggal = new System.Windows.Forms.RadioButton();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.reportviewKeuangan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRentalin = new Rentalin.dsRentalin();
            this.LaporanKeuanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaporanKeuanganTableAdapter = new Rentalin.dsRentalinTableAdapters.LaporanKeuanganTableAdapter();
            this.rbPerTahun = new System.Windows.Forms.RadioButton();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRentalin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanKeuanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Green;
            this.pnlInfo.Controls.Add(this.rbPerTahun);
            this.pnlInfo.Controls.Add(this.rbPerBulan);
            this.pnlInfo.Controls.Add(this.rbPerMinggu);
            this.pnlInfo.Controls.Add(this.rbPerTanggal);
            this.pnlInfo.Controls.Add(this.dtpTanggal);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(1, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(238, 420);
            this.pnlInfo.TabIndex = 11;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // rbPerBulan
            // 
            this.rbPerBulan.AutoSize = true;
            this.rbPerBulan.Location = new System.Drawing.Point(8, 275);
            this.rbPerBulan.Name = "rbPerBulan";
            this.rbPerBulan.Size = new System.Drawing.Size(175, 30);
            this.rbPerBulan.TabIndex = 7;
            this.rbPerBulan.Text = "Tampilkan transaksi pada bulan\r\ndari tanggal tersebut";
            this.rbPerBulan.UseVisualStyleBackColor = true;
            this.rbPerBulan.CheckedChanged += new System.EventHandler(this.rbPerBulan_CheckedChanged);
            // 
            // rbPerMinggu
            // 
            this.rbPerMinggu.AutoSize = true;
            this.rbPerMinggu.Location = new System.Drawing.Point(8, 238);
            this.rbPerMinggu.Name = "rbPerMinggu";
            this.rbPerMinggu.Size = new System.Drawing.Size(186, 30);
            this.rbPerMinggu.TabIndex = 6;
            this.rbPerMinggu.Text = "Tampilkan transaksi pada minggu \r\ndari tanggal tersebut";
            this.rbPerMinggu.UseVisualStyleBackColor = true;
            this.rbPerMinggu.CheckedChanged += new System.EventHandler(this.rbPerMinggu_CheckedChanged);
            // 
            // rbPerTanggal
            // 
            this.rbPerTanggal.AutoSize = true;
            this.rbPerTanggal.Checked = true;
            this.rbPerTanggal.Location = new System.Drawing.Point(8, 215);
            this.rbPerTanggal.Name = "rbPerTanggal";
            this.rbPerTanggal.Size = new System.Drawing.Size(198, 17);
            this.rbPerTanggal.TabIndex = 5;
            this.rbPerTanggal.TabStop = true;
            this.rbPerTanggal.Text = "Tampilkan transaksi tanggal tersebut";
            this.rbPerTanggal.UseVisualStyleBackColor = true;
            this.rbPerTanggal.CheckedChanged += new System.EventHandler(this.rbPerTanggal_CheckedChanged);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(8, 178);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(218, 20);
            this.dtpTanggal.TabIndex = 4;
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 104);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 50);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Laporan\r\nKeuangan";
            // 
            // reportviewKeuangan
            // 
            reportDataSource5.Name = "dsLaporanKeuangan";
            reportDataSource5.Value = this.LaporanKeuanganBindingSource;
            this.reportviewKeuangan.LocalReport.DataSources.Add(reportDataSource5);
            this.reportviewKeuangan.LocalReport.ReportEmbeddedResource = "Rentalin.rptLaporanKeuangan.rdlc";
            this.reportviewKeuangan.Location = new System.Drawing.Point(245, 7);
            this.reportviewKeuangan.Name = "reportviewKeuangan";
            this.reportviewKeuangan.Size = new System.Drawing.Size(720, 416);
            this.reportviewKeuangan.TabIndex = 10;
            // 
            // dsRentalin
            // 
            this.dsRentalin.DataSetName = "dsRentalin";
            this.dsRentalin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LaporanKeuanganBindingSource
            // 
            this.LaporanKeuanganBindingSource.DataMember = "LaporanKeuangan";
            this.LaporanKeuanganBindingSource.DataSource = this.dsRentalin;
            // 
            // LaporanKeuanganTableAdapter
            // 
            this.LaporanKeuanganTableAdapter.ClearBeforeFill = true;
            // 
            // rbPerTahun
            // 
            this.rbPerTahun.AutoSize = true;
            this.rbPerTahun.Location = new System.Drawing.Point(8, 311);
            this.rbPerTahun.Name = "rbPerTahun";
            this.rbPerTahun.Size = new System.Drawing.Size(176, 30);
            this.rbPerTahun.TabIndex = 8;
            this.rbPerTahun.Text = "Tampilkan transaksi pada tahun\r\ndari tanggal tersebut";
            this.rbPerTahun.UseVisualStyleBackColor = true;
            this.rbPerTahun.CheckedChanged += new System.EventHandler(this.rbPerTahun_CheckedChanged);
            // 
            // frmLaporanKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 426);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.reportviewKeuangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLaporanKeuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Laporan Keuangan";
            this.Load += new System.EventHandler(this.frmLaporanKeuangan_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRentalin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanKeuanganBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RadioButton rbPerBulan;
        private System.Windows.Forms.RadioButton rbPerMinggu;
        private System.Windows.Forms.RadioButton rbPerTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private Microsoft.Reporting.WinForms.ReportViewer reportviewKeuangan;
        private System.Windows.Forms.BindingSource LaporanKeuanganBindingSource;
        private dsRentalin dsRentalin;
        private dsRentalinTableAdapters.LaporanKeuanganTableAdapter LaporanKeuanganTableAdapter;
        private System.Windows.Forms.RadioButton rbPerTahun;
    }
}