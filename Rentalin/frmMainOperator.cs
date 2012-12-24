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
    public partial class frmMainOperator : Form
    {
        public frmMainOperator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMainOperator_Load(object sender, EventArgs e)
        {
            //menampilkan tanggal
            
            // cek kewenangan
            if (Program.role.masterPelanggan == false)
                btnMasterPelanggan.Enabled = false;
            if (Program.role.masterKoleksi == false)
                btnMasterKoleksi.Enabled = false;
            if (Program.role.masterStok == false)
                btnMasterStok.Enabled = false;

        }

        private void btnMasterPelanggan_Click(object sender, EventArgs e)
        {
            new frmMasterPelanggan();
        }

        private void btnMasterKoleksi_Click(object sender, EventArgs e)
        {
            new frmMasterKoleksi();
        }

        private void btnMasterStok_Click(object sender, EventArgs e)
        {
            new frmMasterStok();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            new frmTransaksiPeminjaman();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            new frmTransaksiPengembalian();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdmin();
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.session.logout();
            new frmLogin();
            Close();
        }
    }
}
