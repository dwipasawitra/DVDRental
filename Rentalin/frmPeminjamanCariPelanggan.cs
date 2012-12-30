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
        public frmPeminjamanCariPelanggan()
        {
            InitializeComponent();
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
            if (txtCariPelanggan.Text != "")
            dgPencarianPelanggan.DataSource = Program.conn.ExecuteDataTable("SELECT * FROM member WHERE kodemember like '%" + txtCariPelanggan.Text + "%' OR namamember like '%" + txtCariPelanggan.Text + "%'");
        }
    }
}
