namespace Rentalin
{
    partial class frmChatPelanggan
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
            this.components = new System.ComponentModel.Container();
            this.listChat = new System.Windows.Forms.ListBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnKirim = new System.Windows.Forms.Button();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.tmrChat = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.Location = new System.Drawing.Point(3, 1);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(595, 394);
            this.listChat.TabIndex = 0;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(87, 400);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(434, 20);
            this.txtChat.TabIndex = 1;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(524, 400);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(73, 20);
            this.btnKirim.TabIndex = 2;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.Location = new System.Drawing.Point(3, 401);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(78, 19);
            this.btnBersihkan.TabIndex = 3;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = true;
            this.btnBersihkan.Click += new System.EventHandler(this.btnBersihkan_Click);
            // 
            // tmrChat
            // 
            this.tmrChat.Enabled = true;
            this.tmrChat.Interval = 1000;
            this.tmrChat.Tick += new System.EventHandler(this.tmrChat_Tick);
            // 
            // frmChatPelanggan
            // 
            this.AcceptButton = this.btnKirim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 423);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.listChat);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChatPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Pelanggan";
            this.Load += new System.EventHandler(this.frmChatPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Timer tmrChat;
    }
}