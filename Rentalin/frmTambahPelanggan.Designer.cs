namespace Rentalin
{
    partial class frmTambahPelanggan
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
            this.btnTambahkan = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblKodeMember = new System.Windows.Forms.Label();
            this.txtKodeMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJenisIdentitas = new System.Windows.Forms.ComboBox();
            this.txtNamaMember = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomorIdentitas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomorIdentitas = new System.Windows.Forms.TextBox();
            this.lblIJenisIdentitas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTambahkan
            // 
            this.btnTambahkan.Location = new System.Drawing.Point(195, 10);
            this.btnTambahkan.Name = "btnTambahkan";
            this.btnTambahkan.Size = new System.Drawing.Size(79, 31);
            this.btnTambahkan.TabIndex = 0;
            this.btnTambahkan.Text = "Tambahkan";
            this.btnTambahkan.UseVisualStyleBackColor = true;
            this.btnTambahkan.Click += new System.EventHandler(this.btnTambahkan_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 7);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // lblKodeMember
            // 
            this.lblKodeMember.AutoSize = true;
            this.lblKodeMember.Location = new System.Drawing.Point(8, 52);
            this.lblKodeMember.Name = "lblKodeMember";
            this.lblKodeMember.Size = new System.Drawing.Size(73, 13);
            this.lblKodeMember.TabIndex = 2;
            this.lblKodeMember.Text = "Kode Member";
            // 
            // txtKodeMember
            // 
            this.txtKodeMember.Location = new System.Drawing.Point(95, 50);
            this.txtKodeMember.Name = "txtKodeMember";
            this.txtKodeMember.Size = new System.Drawing.Size(177, 20);
            this.txtKodeMember.TabIndex = 3;
            this.txtKodeMember.TextChanged += new System.EventHandler(this.txtKodeMember_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "*";
            // 
            // cmbJenisIdentitas
            // 
            this.cmbJenisIdentitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisIdentitas.FormattingEnabled = true;
            this.cmbJenisIdentitas.Location = new System.Drawing.Point(95, 102);
            this.cmbJenisIdentitas.Name = "cmbJenisIdentitas";
            this.cmbJenisIdentitas.Size = new System.Drawing.Size(123, 21);
            this.cmbJenisIdentitas.TabIndex = 8;
            // 
            // txtNamaMember
            // 
            this.txtNamaMember.Location = new System.Drawing.Point(95, 76);
            this.txtNamaMember.Name = "txtNamaMember";
            this.txtNamaMember.Size = new System.Drawing.Size(177, 20);
            this.txtNamaMember.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(82, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Member";
            // 
            // lblNomorIdentitas
            // 
            this.lblNomorIdentitas.AutoSize = true;
            this.lblNomorIdentitas.Location = new System.Drawing.Point(7, 131);
            this.lblNomorIdentitas.Name = "lblNomorIdentitas";
            this.lblNomorIdentitas.Size = new System.Drawing.Size(81, 13);
            this.lblNomorIdentitas.TabIndex = 9;
            this.lblNomorIdentitas.Text = "Nomor Identitas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(83, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // txtNomorIdentitas
            // 
            this.txtNomorIdentitas.Location = new System.Drawing.Point(95, 129);
            this.txtNomorIdentitas.Name = "txtNomorIdentitas";
            this.txtNomorIdentitas.Size = new System.Drawing.Size(177, 20);
            this.txtNomorIdentitas.TabIndex = 10;
            // 
            // lblIJenisIdentitas
            // 
            this.lblIJenisIdentitas.AutoSize = true;
            this.lblIJenisIdentitas.Location = new System.Drawing.Point(6, 105);
            this.lblIJenisIdentitas.Name = "lblIJenisIdentitas";
            this.lblIJenisIdentitas.Size = new System.Drawing.Size(74, 13);
            this.lblIJenisIdentitas.TabIndex = 12;
            this.lblIJenisIdentitas.Text = "Jenis Identitas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(83, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Informasi ini dibutuhkan";
            // 
            // frmTambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJenisIdentitas);
            this.Controls.Add(this.lblIJenisIdentitas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKodeMember);
            this.Controls.Add(this.txtNamaMember);
            this.Controls.Add(this.txtNomorIdentitas);
            this.Controls.Add(this.lblNomorIdentitas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKodeMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnTambahkan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTambahPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Pelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambahkan;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblKodeMember;
        private System.Windows.Forms.TextBox txtKodeMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJenisIdentitas;
        private System.Windows.Forms.TextBox txtNamaMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomorIdentitas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomorIdentitas;
        private System.Windows.Forms.Label lblIJenisIdentitas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}