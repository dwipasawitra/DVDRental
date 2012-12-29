namespace Rentalin
{
    partial class frmHallOfFame
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
            this.pnlPelangganTerbanyakMeminjam = new System.Windows.Forms.Panel();
            this.pnlJudulTerbanyakDipinjam = new System.Windows.Forms.Panel();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblNamaMember1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlamatMember1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHallOfFame = new System.Windows.Forms.Label();
            this.cmbPilihan = new System.Windows.Forms.ComboBox();
            this.lblBulan = new System.Windows.Forms.Label();
            this.pnlPelangganTerbanyakMeminjam.SuspendLayout();
            this.pnlJudulTerbanyakDipinjam.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPelangganTerbanyakMeminjam
            // 
            this.pnlPelangganTerbanyakMeminjam.BackColor = System.Drawing.Color.Gold;
            this.pnlPelangganTerbanyakMeminjam.Controls.Add(this.lblAlamatMember1);
            this.pnlPelangganTerbanyakMeminjam.Controls.Add(this.lblNamaMember1);
            this.pnlPelangganTerbanyakMeminjam.Controls.Add(this.lblInfo1);
            this.pnlPelangganTerbanyakMeminjam.Location = new System.Drawing.Point(21, 53);
            this.pnlPelangganTerbanyakMeminjam.Name = "pnlPelangganTerbanyakMeminjam";
            this.pnlPelangganTerbanyakMeminjam.Size = new System.Drawing.Size(333, 361);
            this.pnlPelangganTerbanyakMeminjam.TabIndex = 0;
            // 
            // pnlJudulTerbanyakDipinjam
            // 
            this.pnlJudulTerbanyakDipinjam.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlJudulTerbanyakDipinjam.Controls.Add(this.label1);
            this.pnlJudulTerbanyakDipinjam.Controls.Add(this.lblInfo2);
            this.pnlJudulTerbanyakDipinjam.Location = new System.Drawing.Point(385, 53);
            this.pnlJudulTerbanyakDipinjam.Name = "pnlJudulTerbanyakDipinjam";
            this.pnlJudulTerbanyakDipinjam.Size = new System.Drawing.Size(333, 361);
            this.pnlJudulTerbanyakDipinjam.TabIndex = 1;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(52, 11);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(220, 48);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Pelanggan dengan\r\npeminjaman terbanyak";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(68, 11);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(185, 48);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "Judul yang\r\nterbanyak dipinjam";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNamaMember1
            // 
            this.lblNamaMember1.AutoSize = true;
            this.lblNamaMember1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaMember1.Location = new System.Drawing.Point(52, 78);
            this.lblNamaMember1.Name = "lblNamaMember1";
            this.lblNamaMember1.Size = new System.Drawing.Size(223, 24);
            this.lblNamaMember1.TabIndex = 1;
            this.lblNamaMember1.Text = "Putu Wiramaswara Widya";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harry Potter: The Sorceror Stone";
            // 
            // lblAlamatMember1
            // 
            this.lblAlamatMember1.AutoSize = true;
            this.lblAlamatMember1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamatMember1.Location = new System.Drawing.Point(42, 102);
            this.lblAlamatMember1.Name = "lblAlamatMember1";
            this.lblAlamatMember1.Size = new System.Drawing.Size(243, 20);
            this.lblAlamatMember1.TabIndex = 2;
            this.lblAlamatMember1.Text = "Jalan Wisma Permai Tengah ii-34";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Azure;
            this.pnlHeader.Controls.Add(this.lblBulan);
            this.pnlHeader.Controls.Add(this.cmbPilihan);
            this.pnlHeader.Controls.Add(this.lblHallOfFame);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(740, 42);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHallOfFame
            // 
            this.lblHallOfFame.AutoSize = true;
            this.lblHallOfFame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallOfFame.Location = new System.Drawing.Point(17, 9);
            this.lblHallOfFame.Name = "lblHallOfFame";
            this.lblHallOfFame.Size = new System.Drawing.Size(137, 20);
            this.lblHallOfFame.TabIndex = 0;
            this.lblHallOfFame.Text = "HALL OF FAME";
            // 
            // cmbPilihan
            // 
            this.cmbPilihan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPilihan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPilihan.FormattingEnabled = true;
            this.cmbPilihan.Items.AddRange(new object[] {
            "Januari,",
            "Februari,",
            "Maret,",
            "April,",
            "Mei,",
            "Juni,",
            "Juli,",
            "Agustus,",
            "September,",
            "Oktober,",
            "November,",
            "Desember"});
            this.cmbPilihan.Location = new System.Drawing.Point(544, 9);
            this.cmbPilihan.Name = "cmbPilihan";
            this.cmbPilihan.Size = new System.Drawing.Size(174, 28);
            this.cmbPilihan.TabIndex = 1;
            // 
            // lblBulan
            // 
            this.lblBulan.AutoSize = true;
            this.lblBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulan.Location = new System.Drawing.Point(488, 13);
            this.lblBulan.Name = "lblBulan";
            this.lblBulan.Size = new System.Drawing.Size(50, 18);
            this.lblBulan.TabIndex = 2;
            this.lblBulan.Text = "Bulan";
            // 
            // frmHallOfFame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 411);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlJudulTerbanyakDipinjam);
            this.Controls.Add(this.pnlPelangganTerbanyakMeminjam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHallOfFame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Hall Of Fame";
            this.pnlPelangganTerbanyakMeminjam.ResumeLayout(false);
            this.pnlPelangganTerbanyakMeminjam.PerformLayout();
            this.pnlJudulTerbanyakDipinjam.ResumeLayout(false);
            this.pnlJudulTerbanyakDipinjam.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPelangganTerbanyakMeminjam;
        private System.Windows.Forms.Label lblAlamatMember1;
        private System.Windows.Forms.Label lblNamaMember1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Panel pnlJudulTerbanyakDipinjam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBulan;
        private System.Windows.Forms.ComboBox cmbPilihan;
        private System.Windows.Forms.Label lblHallOfFame;
    }
}