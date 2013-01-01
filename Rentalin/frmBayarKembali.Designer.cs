namespace Rentalin
{
    partial class frmBayarKembali
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKembali = new System.Windows.Forms.MaskedTextBox();
            this.lblKembaliInfo = new System.Windows.Forms.Label();
            this.txtUangDibayar = new System.Windows.Forms.MaskedTextBox();
            this.lblUangDibayarInfo = new System.Windows.Forms.Label();
            this.lblBayar = new System.Windows.Forms.Label();
            this.lblBayarInfo = new System.Windows.Forms.Label();
            this.lblNoNota = new System.Windows.Forms.Label();
            this.lblNoNotaInfo = new System.Windows.Forms.Label();
            this.btnSetuju = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtKembali);
            this.panel1.Controls.Add(this.lblKembaliInfo);
            this.panel1.Controls.Add(this.txtUangDibayar);
            this.panel1.Controls.Add(this.lblUangDibayarInfo);
            this.panel1.Controls.Add(this.lblBayar);
            this.panel1.Controls.Add(this.lblBayarInfo);
            this.panel1.Controls.Add(this.lblNoNota);
            this.panel1.Controls.Add(this.lblNoNotaInfo);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 297);
            this.panel1.TabIndex = 0;
            // 
            // txtKembali
            // 
            this.txtKembali.Enabled = false;
            this.txtKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembali.Location = new System.Drawing.Point(12, 208);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(258, 31);
            this.txtKembali.TabIndex = 7;
            // 
            // lblKembaliInfo
            // 
            this.lblKembaliInfo.AutoSize = true;
            this.lblKembaliInfo.Location = new System.Drawing.Point(9, 192);
            this.lblKembaliInfo.Name = "lblKembaliInfo";
            this.lblKembaliInfo.Size = new System.Drawing.Size(73, 13);
            this.lblKembaliInfo.TabIndex = 6;
            this.lblKembaliInfo.Text = "Uang Kembali";
            // 
            // txtUangDibayar
            // 
            this.txtUangDibayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUangDibayar.Location = new System.Drawing.Point(12, 146);
            this.txtUangDibayar.Name = "txtUangDibayar";
            this.txtUangDibayar.Size = new System.Drawing.Size(258, 31);
            this.txtUangDibayar.TabIndex = 5;
            this.txtUangDibayar.TextChanged += new System.EventHandler(this.txtUangDibayar_TextChanged);
            this.txtUangDibayar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUangDibayar_KeyDown);
            // 
            // lblUangDibayarInfo
            // 
            this.lblUangDibayarInfo.AutoSize = true;
            this.lblUangDibayarInfo.Location = new System.Drawing.Point(9, 130);
            this.lblUangDibayarInfo.Name = "lblUangDibayarInfo";
            this.lblUangDibayarInfo.Size = new System.Drawing.Size(70, 13);
            this.lblUangDibayarInfo.TabIndex = 4;
            this.lblUangDibayarInfo.Text = "Uang dibayar";
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBayar.Location = new System.Drawing.Point(7, 79);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(129, 25);
            this.lblBayar.TabIndex = 3;
            this.lblBayar.Text = "Rp. 3.500,-";
            // 
            // lblBayarInfo
            // 
            this.lblBayarInfo.AutoSize = true;
            this.lblBayarInfo.Location = new System.Drawing.Point(9, 66);
            this.lblBayarInfo.Name = "lblBayarInfo";
            this.lblBayarInfo.Size = new System.Drawing.Size(100, 13);
            this.lblBayarInfo.TabIndex = 2;
            this.lblBayarInfo.Text = "Biaya Sewa/Denda";
            // 
            // lblNoNota
            // 
            this.lblNoNota.AutoSize = true;
            this.lblNoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoNota.Location = new System.Drawing.Point(7, 22);
            this.lblNoNota.Name = "lblNoNota";
            this.lblNoNota.Size = new System.Drawing.Size(169, 25);
            this.lblNoNota.TabIndex = 1;
            this.lblNoNota.Text = "ABCDEFGHIJK";
            // 
            // lblNoNotaInfo
            // 
            this.lblNoNotaInfo.AutoSize = true;
            this.lblNoNotaInfo.Location = new System.Drawing.Point(9, 9);
            this.lblNoNotaInfo.Name = "lblNoNotaInfo";
            this.lblNoNotaInfo.Size = new System.Drawing.Size(64, 13);
            this.lblNoNotaInfo.TabIndex = 0;
            this.lblNoNotaInfo.Text = "Nomor Nota";
            // 
            // btnSetuju
            // 
            this.btnSetuju.Location = new System.Drawing.Point(2, 303);
            this.btnSetuju.Name = "btnSetuju";
            this.btnSetuju.Size = new System.Drawing.Size(146, 45);
            this.btnSetuju.TabIndex = 1;
            this.btnSetuju.Text = "SETUJU TRANSAKSI!";
            this.btnSetuju.UseVisualStyleBackColor = true;
            this.btnSetuju.Click += new System.EventHandler(this.btnSetuju_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(152, 303);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(146, 45);
            this.btnBatal.TabIndex = 2;
            this.btnBatal.Text = "BATAL TRANSAKSI!";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // frmBayarKembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSetuju);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBayarKembali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBayarKembali_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtKembali;
        private System.Windows.Forms.Label lblKembaliInfo;
        private System.Windows.Forms.MaskedTextBox txtUangDibayar;
        private System.Windows.Forms.Label lblUangDibayarInfo;
        private System.Windows.Forms.Label lblBayar;
        private System.Windows.Forms.Label lblBayarInfo;
        private System.Windows.Forms.Label lblNoNota;
        private System.Windows.Forms.Label lblNoNotaInfo;
        private System.Windows.Forms.Button btnSetuju;
        private System.Windows.Forms.Button btnBatal;
    }
}