﻿namespace Rentalin
{
    partial class frmLaporanTransaksi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaporanTransaksi));
            this.reportviewNota = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rbPerTanggal = new System.Windows.Forms.RadioButton();
            this.rbPerMinggu = new System.Windows.Forms.RadioButton();
            this.rbPerBulan = new System.Windows.Forms.RadioButton();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportviewNota
            // 
            reportDataSource1.Name = "dsQueryNota";
            reportDataSource1.Value = null;
            this.reportviewNota.LocalReport.DataSources.Add(reportDataSource1);
            this.reportviewNota.LocalReport.ReportEmbeddedResource = "Rentalin.rptLaporanNota.rdlc";
            this.reportviewNota.Location = new System.Drawing.Point(257, 8);
            this.reportviewNota.Name = "reportviewNota";
            this.reportviewNota.Size = new System.Drawing.Size(707, 416);
            this.reportviewNota.TabIndex = 6;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlInfo.Controls.Add(this.rbPerBulan);
            this.pnlInfo.Controls.Add(this.rbPerMinggu);
            this.pnlInfo.Controls.Add(this.rbPerTanggal);
            this.pnlInfo.Controls.Add(this.dateTimePicker1);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(251, 420);
            this.pnlInfo.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(13, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(115, 50);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Laporan\r\nTransaksi";
            // 
            // rbPerTanggal
            // 
            this.rbPerTanggal.AutoSize = true;
            this.rbPerTanggal.Location = new System.Drawing.Point(18, 215);
            this.rbPerTanggal.Name = "rbPerTanggal";
            this.rbPerTanggal.Size = new System.Drawing.Size(198, 17);
            this.rbPerTanggal.TabIndex = 5;
            this.rbPerTanggal.TabStop = true;
            this.rbPerTanggal.Text = "Tampilkan transaksi tanggal tersebut";
            this.rbPerTanggal.UseVisualStyleBackColor = true;
            // 
            // rbPerMinggu
            // 
            this.rbPerMinggu.AutoSize = true;
            this.rbPerMinggu.Location = new System.Drawing.Point(18, 238);
            this.rbPerMinggu.Name = "rbPerMinggu";
            this.rbPerMinggu.Size = new System.Drawing.Size(186, 30);
            this.rbPerMinggu.TabIndex = 6;
            this.rbPerMinggu.TabStop = true;
            this.rbPerMinggu.Text = "Tampilkan transaksi pada minggu \r\ndari tanggal tersebut";
            this.rbPerMinggu.UseVisualStyleBackColor = true;
            // 
            // rbPerBulan
            // 
            this.rbPerBulan.AutoSize = true;
            this.rbPerBulan.Location = new System.Drawing.Point(18, 275);
            this.rbPerBulan.Name = "rbPerBulan";
            this.rbPerBulan.Size = new System.Drawing.Size(175, 30);
            this.rbPerBulan.TabIndex = 7;
            this.rbPerBulan.TabStop = true;
            this.rbPerBulan.Text = "Tampilkan transaksi pada bulan\r\ndari tanggal tersebut";
            this.rbPerBulan.UseVisualStyleBackColor = true;
            // 
            // frmLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.reportviewNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLaporanTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Laporan Transaksi";
            this.Load += new System.EventHandler(this.frmLaporanTransaksi_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportviewNota;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.RadioButton rbPerBulan;
        private System.Windows.Forms.RadioButton rbPerMinggu;
        private System.Windows.Forms.RadioButton rbPerTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;

    }
}