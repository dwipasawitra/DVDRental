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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void lblLogedInAs_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Ubah  jendela pertama ke jendela operator
            Program.role.jendelaPertama = userRole.JENDELA_PERTAMA_OPERATOR;

            Program.session.logout();
            Close();
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            // Buka Form Pengaturan
            frmPengaturan form = new frmPengaturan();
            form.ShowDialog(this);
        }

        private void btnKewenangan_Click(object sender, EventArgs e)
        {
            // Buka form pengaturan kewenangan
            frmPengaturanKewenangan form = new frmPengaturanKewenangan();
            form.ShowDialog(this);
            terapkanKewenangan();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // Set kewenangan dan nama user
            lblRole.Text = Program.role.getRoleName();
            lblUserName.Text = Program.session.getNamaUser();

            // Set tombol mana saja yang bisa dipilih, tergantung wewenang user
            terapkanKewenangan();
        }

        private void terapkanKewenangan()
        {
            // Pengaturan sistem
            if (Program.role.pengaturanSistem)
            {
                btnPengaturan.Enabled = true;
                lblPengaturanInfo.Enabled = true;
            }
            else
            {
                btnPengaturan.Enabled = false;
                lblPengaturanInfo.Enabled = false;
            }

            // Pengaturan kewenangan
            if (Program.role.pengaturanKewenangan)
            {
                btnKewenangan.Enabled = true;
                lblKewenanganInfo.Enabled = true;
            }
            else
            {
                btnKewenangan.Enabled = false;
                lblKewenanganInfo.Enabled = false;
            }

            // Pengaturan pengguna
            if (Program.role.pengaturanPengguna)
            {
                btnPengguna.Enabled = true;
                lblPenggunaInfo.Enabled = true;
            }
            else
            {
                btnPengguna.Enabled = false;
                lblPenggunaInfo.Enabled = false;
            }
            
            // Pengaturan Penawaran Menarik
            if (Program.role.pengaturanPenawaranMenarik)
            {
                btnSO.Enabled = true;
                lblSOinfo.Enabled = true;
            }
            else
            {
                btnSO.Enabled = false;
                lblSOinfo.Enabled = false;
            }

            // Laporan Nota
            if (Program.role.laporanPerTransaksi)
            {
                btnLaporanNota.Enabled = true;
                lblLaporanNotaInfo.Enabled = true;
            }
            else
            {
                btnLaporanNota.Enabled = false;
                lblLaporanNotaInfo.Enabled = false;
            }


            // Laporan Transaksi
            if (Program.role.laporanTransaksi)
            {
                btnLaporanTransaksi.Enabled = true;
                lblLaporanTransaksiInfo.Enabled = true;
            }
            else
            {
                btnLaporanTransaksi.Enabled = false;
                lblLaporanTransaksiInfo.Enabled = false;
            }

            // Laporan Keuangan
            if (Program.role.laporanKeuangan)
            {
                btnLaporanKeuangan.Enabled = true;
                lblLaporanKeuanganInfo.Enabled = true;
            }
            else
            {
                btnLaporanKeuangan.Enabled = false;
                lblLaporanKeuanganInfo.Enabled = false;
            }
        }

        private void btnLaporanKoleksi_Click(object sender, EventArgs e)
        {

        }

        private void lblLaporakKoleksiInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            frmPengaturanPengguna form = new frmPengaturanPengguna();
            form.ShowDialog(this);
        }

        private void btnLaporanNota_Click(object sender, EventArgs e)
        {
            frmLaporanNota form = new frmLaporanNota();
            form.ShowDialog(this);
        }

        private void btnLaporanTransaksi_Click(object sender, EventArgs e)
        {
            frmLaporanTransaksi form = new frmLaporanTransaksi();
            form.ShowDialog(this);
        }

        private void btnMenuOperator_Click(object sender, EventArgs e)
        {
            // Ubah jendela pertama ke jendela Admin
            Program.role.jendelaPertama = userRole.JENDELA_PERTAMA_OPERATOR;
            Close();
        }

        private void btnLaporanKeuangan_Click(object sender, EventArgs e)
        {
            frmLaporanKeuangan form = new frmLaporanKeuangan();
            form.ShowDialog(this);
        }
    }
}
