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
            this.dgPencarianPelanggan = new System.Windows.Forms.DataGridView();
            this.txtCariPelanggan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarianPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPencarianPelanggan
            // 
            this.dgPencarianPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPencarianPelanggan.Location = new System.Drawing.Point(9, 36);
            this.dgPencarianPelanggan.Name = "dgPencarianPelanggan";
            this.dgPencarianPelanggan.Size = new System.Drawing.Size(389, 319);
            this.dgPencarianPelanggan.TabIndex = 0;
            // 
            // txtCariPelanggan
            // 
            this.txtCariPelanggan.Location = new System.Drawing.Point(212, 10);
            this.txtCariPelanggan.Name = "txtCariPelanggan";
            this.txtCariPelanggan.Size = new System.Drawing.Size(185, 20);
            this.txtCariPelanggan.TabIndex = 1;
            this.txtCariPelanggan.TextChanged += new System.EventHandler(this.txtCariPelanggan_TextChanged);
            this.txtCariPelanggan.Enter += new System.EventHandler(this.txtCariPelanggan_Enter);
            this.txtCariPelanggan.Leave += new System.EventHandler(this.txtCariPelanggan_Leave);
            // 
            // frmPeminjamanCariPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 367);
            this.Controls.Add(this.txtCariPelanggan);
            this.Controls.Add(this.dgPencarianPelanggan);
            this.Name = "frmPeminjamanCariPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Pelanggan";
            this.Load += new System.EventHandler(this.frmPeminjamanCariPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarianPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPencarianPelanggan;
        private System.Windows.Forms.TextBox txtCariPelanggan;
    }
}