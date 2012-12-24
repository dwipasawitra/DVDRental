namespace Rentalin
{
    partial class frmLogin
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
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblNamaLayanan = new System.Windows.Forms.Label();
            this.lblAlamatLayanan = new System.Windows.Forms.Label();
            this.picDisc = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(1, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 128);
            this.panel1.TabIndex = 0;
            // 
            // picUser
            // 
            this.picUser.Image = global::Rentalin.Properties.Resources.user;
            this.picUser.Location = new System.Drawing.Point(102, 3);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(103, 122);
            this.picUser.TabIndex = 4;
            this.picUser.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = global::Rentalin.Properties.Resources.arrowright;
            this.btnLogin.Location = new System.Drawing.Point(493, 15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 100);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(221, 36);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(92, 21);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(114, 31);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Rentalin";
            // 
            // lblNamaLayanan
            // 
            this.lblNamaLayanan.AutoSize = true;
            this.lblNamaLayanan.Location = new System.Drawing.Point(98, 52);
            this.lblNamaLayanan.Name = "lblNamaLayanan";
            this.lblNamaLayanan.Size = new System.Drawing.Size(62, 13);
            this.lblNamaLayanan.TabIndex = 2;
            this.lblNamaLayanan.Text = "HMTC Disc";
            // 
            // lblAlamatLayanan
            // 
            this.lblAlamatLayanan.AutoSize = true;
            this.lblAlamatLayanan.Location = new System.Drawing.Point(98, 65);
            this.lblAlamatLayanan.Name = "lblAlamatLayanan";
            this.lblAlamatLayanan.Size = new System.Drawing.Size(170, 13);
            this.lblAlamatLayanan.TabIndex = 3;
            this.lblAlamatLayanan.Text = "Jalan Teknik Kimia, ITS, Surabaya";
            // 
            // picDisc
            // 
            this.picDisc.Image = global::Rentalin.Properties.Resources.disc;
            this.picDisc.Location = new System.Drawing.Point(12, 11);
            this.picDisc.Name = "picDisc";
            this.picDisc.Size = new System.Drawing.Size(85, 87);
            this.picDisc.TabIndex = 4;
            this.picDisc.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 60);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 330);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picDisc);
            this.Controls.Add(this.lblAlamatLayanan);
            this.Controls.Add(this.lblNamaLayanan);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblNamaLayanan;
        private System.Windows.Forms.Label lblAlamatLayanan;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picDisc;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}