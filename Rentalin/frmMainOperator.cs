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
            
            // cek kewenangan            
            if (Program.role.masterPelanggan == false)
                btnMasterPelanggan.Enabled = false;
            if (Program.role.masterKoleksi == false)
                btnMasterKoleksi.Enabled = false;
            if (Program.role.masterStok == false)
                btnMasterStok.Enabled = false;
            //lblUserName.Text = Program.session.getNamaOperator();

        }

        private void btnMasterPelanggan_Click(object sender, EventArgs e)
        {
            frmMasterPelanggan formMasterPelanggan = new frmMasterPelanggan();
            formMasterPelanggan.Show();
            //Close();
        }

        private void btnMasterKoleksi_Click(object sender, EventArgs e)
        {
            frmMasterKoleksi formMasterKoleksi = new frmMasterKoleksi();
            formMasterKoleksi.Show();
            //Close();
        }

        private void btnMasterStok_Click(object sender, EventArgs e)
        {
            frmMasterStok formMasterStok = new frmMasterStok();
            formMasterStok.Show();
            //Close();
        }
               
        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            frmTransaksiPengembalian formTransaksiPengembalian = new frmTransaksiPengembalian();
            formTransaksiPengembalian.Show();
            //Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin formAdmin = new frmAdmin();
            formAdmin.Show();
            //Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.session.logout();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            Close();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            frmTransaksiPeminjaman formTransaksiPeminjaman = new frmTransaksiPeminjaman();
            formTransaksiPeminjaman.Show();
        }

        private void tmrWaktu_Tick(object sender, EventArgs e)
        {
            string detik = DateTime.Now.Second.ToString();
            string menit = DateTime.Now.Minute.ToString();
            string jam = DateTime.Now.Hour.ToString();
            string hari = DateTime.Now.DayOfWeek.ToString();
            string tanggal = DateTime.Now.Day.ToString();
            string bulan = DateTime.Now.Month.ToString();
            string tahun = DateTime.Now.Year.ToString();
            if (hari == "Sunday")
                hari = "Minggu";
            else if (hari == "Monday")
                hari = "Senin";
            else if (hari == "Tuesday")
                hari = "Selasa";
            else if (hari == "Wednesday")
                hari = "Rabu";
            else if (hari == "Thursday")
                hari = "Kamis";
            else if (hari == "Friday")
                hari = "Jum'at";
            else if (hari == "Saturday")
                hari = "Sabtu";
            if (detik == "0")
                detik = "00";
            else if (detik == "1")
                detik = "01";
            else if (detik == "2")
                detik = "02";
            else if (detik == "3")
                detik = "03";
            else if (detik == "4")
                detik = "04";
            else if (detik == "5")
                detik = "05";
            else if (detik == "6")
                detik = "06";
            else if (detik == "7")
                detik = "07";
            else if (detik == "8")
                detik = "08";
            else if (detik == "9")
                detik = "09";

            lblDate.Text = hari + ", " + tanggal + "-" + bulan + "-" + tahun;
            lblTime.Text = jam + ":" + menit + ":" + detik;
        }

        

        
    }
}
