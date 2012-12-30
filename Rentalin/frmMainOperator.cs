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
        bool blinker = false;
        DataTable dtTransaksiStat, dtJudulDipinjamStat;

        /* ISENG BY WIRAMA */
      

        private void tmrScrollingText_Tick(object sender, EventArgs e)
        {
            int len = lblScrollText.Text.Length;
            lblScrollText.Text = lblScrollText.Text.Substring(1, len -1) + lblScrollText.Text.Substring(0, 1);
            
        }



        /* AKHIR KEISENGANNYA */

        public frmMainOperator()
        {
            InitializeComponent();
        }

        private void updatePenawaranSpesial()
        {
            Program.so.updateSpecialOffer();
            if (Program.so.isSpecialOffer())
            {
                lblPenawaranSpesialInfo.Visible = true;
                lblPenawaranSpesial.Visible = true;
                lblPenawaranSpesial.Text = Program.so.getSpecialOfferName();
                tmrBlinkingPenawaranSpesial.Enabled = true;
            }
            else
            {
                lblPenawaranSpesialInfo.Visible = false;
                lblPenawaranSpesial.Visible = false;
                lblPenawaranSpesial.Text = "";
                tmrBlinkingPenawaranSpesial.Enabled = false;
            }
        }
        private void updateStatistik()
        {
            // Ambil tanggal hari ini dalam bentuk string (Oracle Friendly)
            string tglHariIniOracleFriendly = Program.convertTglkeOracle(DateTime.Now);
            string tglHariIni = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            

            // Statistik transaksi
            // Harian
            dtTransaksiStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Nota WHERE tgltransaksi='" + tglHariIniOracleFriendly + "'");
            txtTransaksiHarian.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();

            // Mingguan
            dtTransaksiStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Nota WHERE to_char(tgltransaksi, 'WWYYYY')="
                                                            + "to_char(date '" + tglHariIni + "', 'WWYYYY')");
            txtTransaksiMingguan.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();

            // Bulanan
            dtTransaksiStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Nota WHERE to_char(tgltransaksi, 'MMYYYY')="
                                                            + "to_char(date '" + tglHariIni + "', 'MMYYYY')");
            txtTransaksiBulanan.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();


            // Statistik judul dipinjam
            // Harian
            dtJudulDipinjamStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Dipinjam INNER JOIN Nota ON dipinjam.nonota = nota.nonota WHERE tgltransaksi='" + tglHariIniOracleFriendly + "'");
            txtJudulDipinjamHarian.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();

            // Mingguan
            dtJudulDipinjamStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Dipinjam INNER JOIN Nota ON dipinjam.nonota = nota.nonota WHERE to_char(tgltransaksi, 'WWYYYY')="
                                                            + "to_char(date '" + tglHariIni + "', 'WWYYYY')");
            txtJudulDipinjamMingguan.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();

            // Bulanan
            dtJudulDipinjamStat = Program.conn.ExecuteDataTable("SELECT count(*) FROM Dipinjam INNER JOIN Nota ON dipinjam.nonota = nota.nonota WHERE to_char(tgltransaksi, 'MMYYYY')="
                                                            + "to_char(date '" + tglHariIni + "', 'MMYYYY')");
            txtJudulDipinjamBulanan.Text = dtTransaksiStat.Rows[0].ItemArray[0].ToString();

        }
        private void frmMainOperator_Load(object sender, EventArgs e)
        {
            // Muat nama toko dan alamatnya
            lblNamaLayanan.Text = Program.setting.namaJasa;
            lblAlamatLayanan.Text = Program.setting.alamatJasa;

            // cek kewenangan            
            if (Program.role.masterPelanggan == false)
                btnMasterPelanggan.Enabled = false;
            if (Program.role.masterKoleksi == false)
                btnMasterKoleksi.Enabled = false;
            if (Program.role.masterStok == false)
                btnMasterStok.Enabled = false;
            if (Program.role.transaksi == false)
            {
                btnPeminjaman.Enabled = false;
                btnPengembalian.Enabled = false;
            }
            if (Program.role.laporanPerTransaksi == false)
            {
                btnLaporanNota.Enabled = false;
            }
            if(Program.role.laporanTransaksi == false)
            {
                btnLaporanTransaksi.Enabled = false;
            }
            if (Program.role.laporanKeuangan == false)
            {
                btnLaporanKeuangan.Enabled = false;
            }
            if (Program.role.halloffame == false)
            {
                btnHallofFame.Enabled = false;
            }

            // Ganti nama user
            lblUserName.Text = Program.session.getNamaUser();

            // Update statistik
            updateStatistik();

            // Update penawaran spesial
            updatePenawaranSpesial();

        }

        private void btnMasterPelanggan_Click(object sender, EventArgs e)
        {
            frmMasterPelanggan formMasterPelanggan = new frmMasterPelanggan();
            formMasterPelanggan.ShowDialog(this);
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
            formMasterStok.ShowDialog(this);
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
            // Ubah jendela pertama ke jendela Admin
            Program.role.jendelaPertama = userRole.JENDELA_PERTAMA_ADMIN;
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.session.logout();
            this.Close();
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
            if (blinker)
            {
                lblTime.Text = jam + ":" + menit + ":" + detik;
                blinker = false;
            }
            else
            {
                lblTime.Text = jam + " " + menit + " " + detik;
                blinker = true;
            }
        }   

        private void btnHallofFame_Click(object sender, EventArgs e)
        {
            frmHallOfFame form = new frmHallOfFame();
            form.ShowDialog(this);
        }

        private void tmrStatistik_Tick(object sender, EventArgs e)
        {
            lblMemutakhirkan.Visible = true;
            updateStatistik();
            lblMemutakhirkan.Visible = false;

            // Sekalian nitip
            updatePenawaranSpesial();
        }

        private void tmrBlinkingPenawaranSpesial_Tick(object sender, EventArgs e)
        {
            if (lblPenawaranSpesial.Visible)
            {
                lblPenawaranSpesial.Visible = false;
                lblPenawaranSpesialInfo.Visible = false;
            }

            else
            {
                lblPenawaranSpesial.Visible = true;
                lblPenawaranSpesialInfo.Visible = true;
            }
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

        private void btnLaporanKeuangan_Click(object sender, EventArgs e)
        {
            frmLaporanKeuangan form = new frmLaporanKeuangan();
            form.ShowDialog(this);
        }

       

        

        
    }
}
