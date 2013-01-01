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
            this.btnPilih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarian)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPencarian
            // 
            this.txtPencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPencarian.Location = new System.Drawing.Point(12, 8);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(589, 21);
            this.txtPencarian.TabIndex = 0;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
        
            // 
            // dgPencarian
            // 
            this.dgPencarian.AllowUserToAddRows = false;
            this.dgPencarian.AllowUserToDeleteRows = false;
            this.dgPencarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPencarian.Location = new System.Drawing.Point(12, 34);
            this.dgPencarian.MultiSelect = false;
            this.dgPencarian.Name = "dgPencarian";
            this.dgPencarian.ReadOnly = true;
            this.dgPencarian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPencarian.Size = new System.Drawing.Size(675, 333);
            this.dgPencarian.TabIndex = 1;
            // 
            // btnPilih
            // 
            this.btnPilih.Location = new System.Drawing.Point(607, 5);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(80, 23);
            this.btnPilih.TabIndex = 2;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // frmPeminjamanCariJudul
            // 
            this.AcceptButton = this.btnPilih;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(699, 379);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.dgPencarian);
            this.Controls.Add(this.txtPencarian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPeminjamanCariJudul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Judul";
            this.Load += new System.EventHandler(this.frmPeminjamanCariJudul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPencarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.DataGridView dgPencarian;
        private System.Windows.Forms.Button btnPilih;
    }
}