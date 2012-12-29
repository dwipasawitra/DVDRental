namespace Rentalin
{
    partial class frmTambahKoleksi
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
            this.lblTambahKoleksi = new System.Windows.Forms.Label();
            this.lblKodeMember = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.lblNamaMember = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblJenisIdentitas = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnTambahkan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHargaSewa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTambahKoleksi
            // 
            this.lblTambahKoleksi.AutoSize = true;
            this.lblTambahKoleksi.Location = new System.Drawing.Point(12, 9);
            this.lblTambahKoleksi.Name = "lblTambahKoleksi";
            this.lblTambahKoleksi.Size = new System.Drawing.Size(186, 26);
            this.lblTambahKoleksi.TabIndex = 0;
            this.lblTambahKoleksi.Text = "Silahkan mengisi detail koleksi terbaru\r\nyang ingin ditambahkan";
            // 
            // lblKodeMember
            // 
            this.lblKodeMember.AutoSize = true;
            this.lblKodeMember.Location = new System.Drawing.Point(8, 60);
            this.lblKodeMember.Name = "lblKodeMember";
            this.lblKodeMember.Size = new System.Drawing.Size(73, 13);
            this.lblKodeMember.TabIndex = 1;
            this.lblKodeMember.Text = "Kode Member";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(95, 57);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(196, 20);
            this.txtKode.TabIndex = 2;
            this.txtKode.TextChanged += new System.EventHandler(this.txtKode_TextChanged);
            // 
            // lblNamaMember
            // 
            this.lblNamaMember.AutoSize = true;
            this.lblNamaMember.Location = new System.Drawing.Point(5, 82);
            this.lblNamaMember.Name = "lblNamaMember";
            this.lblNamaMember.Size = new System.Drawing.Size(76, 13);
            this.lblNamaMember.TabIndex = 3;
            this.lblNamaMember.Text = "Nama Member";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(95, 82);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(196, 20);
            this.txtJudul.TabIndex = 4;
            // 
            // lblJenisIdentitas
            // 
            this.lblJenisIdentitas.AutoSize = true;
            this.lblJenisIdentitas.Location = new System.Drawing.Point(7, 111);
            this.lblJenisIdentitas.Name = "lblJenisIdentitas";
            this.lblJenisIdentitas.Size = new System.Drawing.Size(74, 13);
            this.lblJenisIdentitas.TabIndex = 7;
            this.lblJenisIdentitas.Text = "Jenis Identitas";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(95, 108);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(126, 21);
            this.cmbKategori.TabIndex = 8;
            // 
            // btnTambahkan
            // 
            this.btnTambahkan.Location = new System.Drawing.Point(219, 9);
            this.btnTambahkan.Name = "btnTambahkan";
            this.btnTambahkan.Size = new System.Drawing.Size(77, 26);
            this.btnTambahkan.TabIndex = 16;
            this.btnTambahkan.Text = "Tambahkan";
            this.btnTambahkan.UseVisualStyleBackColor = true;
            this.btnTambahkan.Click += new System.EventHandler(this.btnTambahkan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(78, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(78, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "informasi ini dibutuhkan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(79, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "*";
            // 
            // lblHargaSewa
            // 
            this.lblHargaSewa.AutoSize = true;
            this.lblHargaSewa.Location = new System.Drawing.Point(3, 141);
            this.lblHargaSewa.Name = "lblHargaSewa";
            this.lblHargaSewa.Size = new System.Drawing.Size(81, 13);
            this.lblHargaSewa.TabIndex = 24;
            this.lblHargaSewa.Text = "Nomor Identitas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 27;
            // 
            // frmTambahKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 226);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHargaSewa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambahkan);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblJenisIdentitas);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.lblNamaMember);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblKodeMember);
            this.Controls.Add(this.lblTambahKoleksi);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmTambahKoleksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Pelanggan";
            this.Load += new System.EventHandler(this.frmTambahKoleksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTambahKoleksi;
        private System.Windows.Forms.Label lblKodeMember;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNamaMember;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label lblJenisIdentitas;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnTambahkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHargaSewa;
        private System.Windows.Forms.TextBox textBox1;
    }
}