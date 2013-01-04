using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rentalin
{
    public partial class frmPeminjamanCariPelanggan : Form
    {
        DataTable pelanggan;
        public string kodePelangganDipilih = "";

        public frmPeminjamanCariPelanggan()
        {
            InitializeComponent();
        }

        private void muatUlangData()
        {
            // Definisikan data member dan nama kolomnya
            pelanggan = Program.conn.ExecuteDataTable("SELECT kodemember, namamember FROM member");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";
            

            // Masukkan ke dalam grid
            refreshListBox();
        }

        private void cariData(string yangdicari)
        {
            pelanggan = Program.conn.ExecuteDataTable("SELECT kodemember, namamember FROM member WHERE upper(namamember) like '%" + txtCariPelanggan.Text.ToUpper() + "%' OR upper(kodemember) like '%" + txtCariPelanggan.Text.ToUpper() + "%'");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";
          

            // Masukkan ke dalam grid
            refreshListBox();
        }

        private void refreshListBox()
        {
            listBoxPelanggan.Items.Clear();
            for(int i = 0; i < pelanggan.Rows.Count; i++)
            {
                listBoxPelanggan.Items.Add(pelanggan.Rows[i].ItemArray[1].ToString());
            }
        }

        private void frmPeminjamanCariPelanggan_Load(object sender, EventArgs e)
        {
            txtCariPelanggan.Focus();
        }

        private void txtCariPelanggan_Leave(object sender, EventArgs e)
        {
            if (txtCariPelanggan.Text == "")
                txtCariPelanggan.Text = "Cari";            
        }

        private void txtCariPelanggan_Enter(object sender, EventArgs e)
        {
            if (txtCariPelanggan.Text == "Cari")
                txtCariPelanggan.Text = "";
        }

        private void txtCariPelanggan_TextChanged(object sender, EventArgs e)
        {
           cariData(txtCariPelanggan.Text);
            
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
           try
           {
               kodePelangganDipilih = pelanggan.Rows[listBoxPelanggan.SelectedIndex].ItemArray[0].ToString();
               Close();
           }
           catch
           {
               // Nope
           }
           
        }
    }
}
