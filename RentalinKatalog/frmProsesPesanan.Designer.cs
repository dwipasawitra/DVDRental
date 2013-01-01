namespace RentalinKatalog
{
    partial class frmProsesPesanan
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnBatalkanPesanan = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.listBoxPelanggan = new System.Windows.Forms.ListBox();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Moccasin;
            this.pnlInfo.Controls.Add(this.lblDeskripsi);
            this.pnlInfo.Controls.Add(this.lblJudul);
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(313, 313);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(161, 24);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Proses Pesanan";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(16, 56);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(283, 216);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Untuk memproses pesanan,\r\nsilahkan ketik kode member atau\r\nnama Anda sebagai memb" +
                "er di\r\nrental kami.\r\n\r\nJika belum menjadi member,\r\nharap mendaftarkan diri\r\nterl" +
                "ebih dahulu kepada\r\npetugas kami :)";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(554, 257);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(199, 42);
            this.btnProses.TabIndex = 1;
            this.btnProses.Text = "Proses Pesanan";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnBatalkanPesanan
            // 
            this.btnBatalkanPesanan.Location = new System.Drawing.Point(335, 257);
            this.btnBatalkanPesanan.Name = "btnBatalkanPesanan";
            this.btnBatalkanPesanan.Size = new System.Drawing.Size(199, 42);
            this.btnBatalkanPesanan.TabIndex = 2;
            this.btnBatalkanPesanan.Text = "Batalkan Pesanan";
            this.btnBatalkanPesanan.UseVisualStyleBackColor = true;
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(335, 9);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(418, 29);
            this.txtPencarian.TabIndex = 3;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // listBoxPelanggan
            // 
            this.listBoxPelanggan.FormattingEnabled = true;
            this.listBoxPelanggan.ItemHeight = 24;
            this.listBoxPelanggan.Location = new System.Drawing.Point(335, 51);
            this.listBoxPelanggan.Name = "listBoxPelanggan";
            this.listBoxPelanggan.Size = new System.Drawing.Size(417, 196);
            this.listBoxPelanggan.TabIndex = 4;
            // 
            // frmProsesPesanan
            // 
            this.AcceptButton = this.btnProses;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 311);
            this.Controls.Add(this.listBoxPelanggan);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnBatalkanPesanan);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.pnlInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "frmProsesPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proses Pesanan";
            this.Load += new System.EventHandler(this.frmProsesPesanan_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnBatalkanPesanan;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.ListBox listBoxPelanggan;
    }
}