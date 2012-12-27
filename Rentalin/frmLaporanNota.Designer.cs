namespace Rentalin
{
    partial class frmLaporanNota
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportviewNota = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kalendarNota = new System.Windows.Forms.MonthCalendar();
            this.cmbNoNota = new System.Windows.Forms.ComboBox();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Teal;
            this.pnlInfo.Controls.Add(this.cmbNoNota);
            this.pnlInfo.Controls.Add(this.kalendarNota);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(220, 420);
            this.pnlInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 104);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pada jendela ini, Anda\r\ndapat menampilkan daftar\r\nnota transaksi yang dilakukan\r\n" +
                "oleh seorang pelanggan pada tanggal\r\ntertentu.\r\n\r\nSilahkan pilih tanggal, besert" +
                "a nomor nota\r\nyang ingin ditampilkan.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan\r\nNota";
            // 
            // reportviewNota
            // 
            this.reportviewNota.Location = new System.Drawing.Point(226, 4);
            this.reportviewNota.Name = "reportviewNota";
            this.reportviewNota.Size = new System.Drawing.Size(628, 420);
            this.reportviewNota.TabIndex = 1;
            this.reportviewNota.Load += new System.EventHandler(this.reportviewNota_Load);
            // 
            // kalendarNota
            // 
            this.kalendarNota.Location = new System.Drawing.Point(18, 192);
            this.kalendarNota.Name = "kalendarNota";
            this.kalendarNota.TabIndex = 2;
            // 
            // cmbNoNota
            // 
            this.cmbNoNota.FormattingEnabled = true;
            this.cmbNoNota.Location = new System.Drawing.Point(18, 367);
            this.cmbNoNota.Name = "cmbNoNota";
            this.cmbNoNota.Size = new System.Drawing.Size(185, 21);
            this.cmbNoNota.TabIndex = 3;
            // 
            // frmLaporanNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 436);
            this.Controls.Add(this.reportviewNota);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLaporanNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Laporan Nota";
            this.Load += new System.EventHandler(this.frmLaporanNota_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportviewNota;
        private System.Windows.Forms.ComboBox cmbNoNota;
        private System.Windows.Forms.MonthCalendar kalendarNota;
    }
}