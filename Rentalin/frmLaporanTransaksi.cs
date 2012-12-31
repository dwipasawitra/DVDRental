using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Rentalin
{
    public partial class frmLaporanTransaksi : Form
    {
        private const int LAPTRANSAKSI_MODE_HARIAN = 0;
        private const int LAPTRANSAKSI_MODE_MINGGUAN = 1;
        private const int LAPTRANSAKSI_MODE_BULANAN = 2;

        public frmLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void frmLaporanTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRentalin.QueryTransaksi' table. You can move, or remove it, as needed.
            muatLaporanTransaksi(DateTime.Now, LAPTRANSAKSI_MODE_HARIAN);

        }

        private void muatLaporanTransaksi(DateTime dtTanggal, int mode)
        {
            // Atur parameter report (masih percobaan)
            ReportParameter namaToko = new ReportParameter("namaToko", Program.setting.namaJasa);
            ReportParameter alamatToko = new ReportParameter("alamatToko", Program.setting.alamatJasa);
            ReportParameter jenisLaporanTransaksi = null;
          
            // Convert tanggal ke bentuk "Oracle-friendly"
           string tglDipilih = Program.convertTglkeOracle(dtTanggal);

            switch (mode)
            {
                case LAPTRANSAKSI_MODE_HARIAN:
                    jenisLaporanTransaksi = new ReportParameter("jenisLaporanTransaksi", "HARIAN");
                    this.QueryTransaksiTableAdapter.FillByDate(this.dsRentalin.QueryTransaksi, tglDipilih);
                    break;
                case LAPTRANSAKSI_MODE_MINGGUAN:
                    jenisLaporanTransaksi = new ReportParameter("jenisLaporanTransaksi", "MINGGUAN");
                    this.QueryTransaksiTableAdapter.FillByWeek(this.dsRentalin.QueryTransaksi, dtTanggal);
                    break;
                case LAPTRANSAKSI_MODE_BULANAN:
                    jenisLaporanTransaksi = new ReportParameter("jenisLaporanTransaksi", "TAHUNAN");
                    this.QueryTransaksiTableAdapter.FillByMonth(this.dsRentalin.QueryTransaksi, dtTanggal);
                    break;
            }

            //this.reportviewNota.
            reportviewTransaksi.LocalReport.SetParameters(namaToko);
            reportviewTransaksi.LocalReport.SetParameters(alamatToko);
            reportviewTransaksi.LocalReport.SetParameters(jenisLaporanTransaksi);
            reportviewTransaksi.RefreshReport();
        }

        private void rbLaporanCek()
        {
            // Catat tanggal dari dtpTanggal;
            DateTime dtTanggalDipilih = dtpTanggal.Value;

            // Cek setiap radio button yang terpasang
            if (rbPerTanggal.Checked)
            {
                muatLaporanTransaksi(dtTanggalDipilih, LAPTRANSAKSI_MODE_HARIAN);
            }
            else if (rbPerMinggu.Checked)
            {
                muatLaporanTransaksi(dtTanggalDipilih, LAPTRANSAKSI_MODE_MINGGUAN);
            }
            else if (rbPerBulan.Checked)
            {
                muatLaporanTransaksi(dtTanggalDipilih, LAPTRANSAKSI_MODE_BULANAN);
            }

        }
        private void rbPerTanggal_CheckedChanged(object sender, EventArgs e)
        {
            rbLaporanCek();
        }

        private void rbPerMinggu_CheckedChanged(object sender, EventArgs e)
        {
            rbLaporanCek();
        }

        private void rbPerBulan_CheckedChanged(object sender, EventArgs e)
        {
            rbLaporanCek();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            rbLaporanCek();
        }
    }
}
