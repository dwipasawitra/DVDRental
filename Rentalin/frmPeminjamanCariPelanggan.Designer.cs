namespace Rentalin
{
    partial class frmPeminjamanCariPelanggan
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
            this.txtCariPelanggan = new System.Windows.Forms.TextBox();
            this.btnPilih = new System.Windows.Forms.Button();
            this.listBoxPelanggan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCariPelanggan
            // 
            this.txtCariPelanggan.Location = new System.Drawing.Point(12, 10);
            this.txtCariPelanggan.Name = "txtCariPelanggan";
            this.txtCariPelanggan.Size = new System.Drawing.Size(323, 20);
            this.txtCariPelanggan.TabIndex = 1;
            this.txtCariPelanggan.TextChanged += new System.EventHandler(this.txtCariPelanggan_TextChanged);
            this.txtCariPelanggan.Enter += new System.EventHandler(this.txtCariPelanggan_Enter);
            this.txtCariPelanggan.Leave += new System.EventHandler(this.txtCariPelanggan_Leave);
            // 
            // btnPilih
            // 
            this.btnPilih.Location = new System.Drawing.Point(341, 10);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(57, 20);
            this.btnPilih.TabIndex = 2;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // listBoxPelanggan
            // 
            this.listBoxPelanggan.FormattingEnabled = true;
            this.listBoxPelanggan.Location = new System.Drawing.Point(13, 33);
            this.listBoxPelanggan.Name = "listBoxPelanggan";
            this.listBoxPelanggan.Size = new System.Drawing.Size(384, 316);
            this.listBoxPelanggan.TabIndex = 3;
            // 
            // frmPeminjamanCariPelanggan
            // 
            this.AcceptButton = this.btnPilih;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 361);
            this.Controls.Add(this.listBoxPelanggan);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.txtCariPelanggan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPeminjamanCariPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Pelanggan";
            this.Load += new System.EventHandler(this.frmPeminjamanCariPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariPelanggan;
        private System.Windows.Forms.Button btnPilih;
        private System.Windows.Forms.ListBox listBoxPelanggan;
    }
}