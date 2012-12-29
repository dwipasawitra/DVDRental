namespace Rentalin
{
    partial class frmPeminjamanCariJudul
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
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.dgPencarian = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSewa = new System.Windows.Forms.Label();
            this.lblSewaInfo = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDenda = new System.Windows.Forms.Label();
            this.lblHargaDendaInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarian)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPencarian
            // 
            this.txtPencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPencarian.Location = new System.Drawing.Point(270, 8);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(206, 21);
            this.txtPencarian.TabIndex = 0;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // dgPencarian
            // 
            this.dgPencarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPencarian.Location = new System.Drawing.Point(12, 34);
            this.dgPencarian.Name = "dgPencarian";
            this.dgPencarian.Size = new System.Drawing.Size(464, 333);
            this.dgPencarian.TabIndex = 1;
            this.dgPencarian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPencarian_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.lblDenda);
            this.panel1.Controls.Add(this.lblHargaDendaInfo);
            this.panel1.Controls.Add(this.lblSewa);
            this.panel1.Controls.Add(this.lblSewaInfo);
            this.panel1.Controls.Add(this.pbCover);
            this.panel1.Controls.Add(this.lblGenre);
            this.panel1.Controls.Add(this.lblJudul);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(482, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 333);
            this.panel1.TabIndex = 2;
            // 
            // lblSewa
            // 
            this.lblSewa.AutoSize = true;
            this.lblSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSewa.ForeColor = System.Drawing.Color.White;
            this.lblSewa.Location = new System.Drawing.Point(18, 88);
            this.lblSewa.Name = "lblSewa";
            this.lblSewa.Size = new System.Drawing.Size(14, 15);
            this.lblSewa.TabIndex = 5;
            this.lblSewa.Text = "0";
            // 
            // lblSewaInfo
            // 
            this.lblSewaInfo.AutoSize = true;
            this.lblSewaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSewaInfo.ForeColor = System.Drawing.Color.White;
            this.lblSewaInfo.Location = new System.Drawing.Point(18, 70);
            this.lblSewaInfo.Name = "lblSewaInfo";
            this.lblSewaInfo.Size = new System.Drawing.Size(142, 15);
            this.lblSewaInfo.TabIndex = 4;
            this.lblSewaInfo.Text = "Harga Sewa Per Hari";
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(30, 157);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(130, 154);
            this.pbCover.TabIndex = 3;
            this.pbCover.TabStop = false;
            this.pbCover.Click += new System.EventHandler(this.pbCover_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(18, 41);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 15);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(18, 23);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(74, 15);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul Film";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Item";
            // 
            // lblDenda
            // 
            this.lblDenda.AutoSize = true;
            this.lblDenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenda.ForeColor = System.Drawing.Color.White;
            this.lblDenda.Location = new System.Drawing.Point(18, 130);
            this.lblDenda.Name = "lblDenda";
            this.lblDenda.Size = new System.Drawing.Size(14, 15);
            this.lblDenda.TabIndex = 7;
            this.lblDenda.Text = "0";
            // 
            // lblHargaDendaInfo
            // 
            this.lblHargaDendaInfo.AutoSize = true;
            this.lblHargaDendaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaDendaInfo.ForeColor = System.Drawing.Color.White;
            this.lblHargaDendaInfo.Location = new System.Drawing.Point(18, 112);
            this.lblHargaDendaInfo.Name = "lblHargaDendaInfo";
            this.lblHargaDendaInfo.Size = new System.Drawing.Size(149, 15);
            this.lblHargaDendaInfo.TabIndex = 6;
            this.lblHargaDendaInfo.Text = "Harga Denda Per Hari";
            // 
            // frmPeminjamanCariJudul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(699, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPencarian);
            this.Controls.Add(this.txtPencarian);
            this.MaximizeBox = false;
            this.Name = "frmPeminjamanCariJudul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeminjamanCariJudul";
            this.Load += new System.EventHandler(this.frmPeminjamanCariJudul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarian)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.DataGridView dgPencarian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblSewa;
        private System.Windows.Forms.Label lblSewaInfo;
        private System.Windows.Forms.Label lblDenda;
        private System.Windows.Forms.Label lblHargaDendaInfo;
    }
}