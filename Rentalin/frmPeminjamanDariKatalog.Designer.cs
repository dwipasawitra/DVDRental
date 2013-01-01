namespace Rentalin
{
    partial class frmPeminjamanDariKatalog
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
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.listBoxPemesan = new System.Windows.Forms.ListBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnMuatUlang = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(14, 35);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(307, 26);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Silahkan pilih antrian pesanan berikut untuk kemudian diproses \r\ndi dalam transak" +
                "si peminjaman.";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(217, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Antrian Pemesanan";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Navy;
            this.pnlInfo.Controls.Add(this.btnMuatUlang);
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(530, 75);
            this.pnlInfo.TabIndex = 4;
            // 
            // lblNamaPeminjam
            // 
            this.lblNamaPeminjam.AutoSize = true;
            this.lblNamaPeminjam.Location = new System.Drawing.Point(12, 77);
            this.lblNamaPeminjam.Name = "lblNamaPeminjam";
            this.lblNamaPeminjam.Size = new System.Drawing.Size(231, 13);
            this.lblNamaPeminjam.TabIndex = 5;
            this.lblNamaPeminjam.Text = "Nama Peminjam yang memesan melalui Katalog";
            // 
            // listBoxPemesan
            // 
            this.listBoxPemesan.FormattingEnabled = true;
            this.listBoxPemesan.Location = new System.Drawing.Point(16, 97);
            this.listBoxPemesan.Name = "listBoxPemesan";
            this.listBoxPemesan.Size = new System.Drawing.Size(494, 186);
            this.listBoxPemesan.TabIndex = 6;
            this.listBoxPemesan.SelectedIndexChanged += new System.EventHandler(this.listBoxPemesan_SelectedIndexChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(378, 291);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(132, 23);
            this.btnProses.TabIndex = 7;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(17, 291);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(132, 23);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnMuatUlang
            // 
            this.btnMuatUlang.ForeColor = System.Drawing.Color.Black;
            this.btnMuatUlang.Location = new System.Drawing.Point(378, 30);
            this.btnMuatUlang.Name = "btnMuatUlang";
            this.btnMuatUlang.Size = new System.Drawing.Size(132, 23);
            this.btnMuatUlang.TabIndex = 9;
            this.btnMuatUlang.Text = "Muat Ulang";
            this.btnMuatUlang.UseVisualStyleBackColor = true;
            this.btnMuatUlang.Click += new System.EventHandler(this.btnMuatUlang_Click);
            // 
            // frmPeminjamanDariKatalog
            // 
            this.AcceptButton = this.btnProses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 326);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.listBoxPemesan);
            this.Controls.Add(this.lblNamaPeminjam);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeminjamanDariKatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Antrian Pesanan Peminjaman";
            this.Load += new System.EventHandler(this.frmPeminjamanDariKatalog_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblNamaPeminjam;
        private System.Windows.Forms.ListBox listBoxPemesan;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnMuatUlang;
    }
}