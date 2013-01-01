using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace Rentalin
{
    public partial class frmLaporanKeuangan : Form
    {


        public frmLaporanKeuangan()
        {
            InitializeComponent();
        }


        private void viewLaporan()
        {
            DateTime dtHariDipilih = dtpTanggal.Value;
            CultureInfo infoKultur = CultureInfo.CurrentCulture;

            
            ReportParameter namaToko, alamatToko, jenisLaporanKeuangan, satuanLaporanKeuangan, variabelSatuan = null;
            namaToko = new ReportParameter("namaToko", Program.setting.namaJasa);
            alamatToko = new ReportParameter("alamatToko", Program.setting.alamatJasa);
            reportviewKeuangan.LocalReport.SetParameters(namaToko);
            reportviewKeuangan.LocalReport.SetParameters(alamatToko);

            // Pilihan tergantung radiobutton mana yang dipilih
            if (rbPerTanggal.Checked == true)
            {
                
                string strTglDipilih = dtHariDipilih.Day.ToString("00") + "/" + dtHariDipilih.Month.ToString("00") + "/" + dtHariDipilih.Year.ToString("0000");
                jenisLaporanKeuangan = new ReportParameter("jenisLaporanKeuangan", "HARIAN");
                satuanLaporanKeuangan = new ReportParameter("satuanLaporanKeuangan", "Tanggal");
                variabelSatuan = new ReportParameter("variabelSatuan", strTglDipilih);

                reportviewKeuangan.LocalReport.SetParameters(jenisLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(satuanLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(variabelSatuan);

                LaporanKeuanganTableAdapter.FillByDate(this.dsRentalin.LaporanKeuangan, dtpTanggal.Value);
                reportviewKeuangan.RefreshReport();

              
            }
            else if (rbPerMinggu.Checked == true)
            {
                // Ambil tanggal pertama dari minggu yang dipilih
                DateTime dtHariIni = dtpTanggal.Value;
                DateTime dtHariAwalMinggu = dtHariIni.AddDays(-(int)dtHariIni.DayOfWeek);
                DateTime dtHariAkhirMinggu = dtHariIni.AddDays(7 - (int)dtHariIni.DayOfWeek);

                string strTglAwal = dtHariAwalMinggu.Day.ToString("00") + "/" + dtHariAwalMinggu.Month.ToString("00") + "/" + dtHariAwalMinggu.Year.ToString("0000");
                string strTglAkhir = dtHariAkhirMinggu.Day.ToString("00") + "/" + dtHariAkhirMinggu.Month.ToString("00") + "/" + dtHariAkhirMinggu.Year.ToString("0000");

                jenisLaporanKeuangan = new ReportParameter("jenisLaporanKeuangan", "MINGGUAN");
                satuanLaporanKeuangan = new ReportParameter("satuanLaporanKeuangan", "Tanggal");
                variabelSatuan = new ReportParameter("variabelSatuan", strTglAwal + " sampai " + strTglAkhir);

                reportviewKeuangan.LocalReport.SetParameters(jenisLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(satuanLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(variabelSatuan);

                LaporanKeuanganTableAdapter.FillByWeek(this.dsRentalin.LaporanKeuangan, dtpTanggal.Value);
                reportviewKeuangan.RefreshReport();
               
                
            }
            else if (rbPerBulan.Checked == true)
            {
                

                string strBulanDipilih = infoKultur.DateTimeFormat.GetMonthName(dtpTanggal.Value.Month) + " tahun " + dtpTanggal.Value.Year;

                jenisLaporanKeuangan = new ReportParameter("jenisLaporanKeuangan", "BULANAN");
                satuanLaporanKeuangan = new ReportParameter("satuanLaporanKeuangan", "Bulan");
                variabelSatuan = new ReportParameter("variabelSatuan", strBulanDipilih);

                reportviewKeuangan.LocalReport.SetParameters(jenisLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(satuanLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(variabelSatuan);

                LaporanKeuanganTableAdapter.FillByMonth(this.dsRentalin.LaporanKeuangan, dtpTanggal.Value);
                reportviewKeuangan.RefreshReport();
            }
            else if (rbPerTahun.Checked == true)
            {
                string strTahunDipilih = dtpTanggal.Value.Year.ToString("0000");

                jenisLaporanKeuangan = new ReportParameter("jenisLaporanKeuangan", "TAHUNAN");
                satuanLaporanKeuangan = new ReportParameter("satuanLaporanKeuangan", "Tahun");
                variabelSatuan = new ReportParameter("variabelSatuan", strTahunDipilih);

                reportviewKeuangan.LocalReport.SetParameters(jenisLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(satuanLaporanKeuangan);
                reportviewKeuangan.LocalReport.SetParameters(variabelSatuan);

                LaporanKeuanganTableAdapter.FillByYear(this.dsRentalin.LaporanKeuangan, dtpTanggal.Value);
                reportviewKeuangan.RefreshReport();
            }
        }
       
        private void rbPerTanggal_CheckedChanged(object sender, EventArgs e)
        {
            viewLaporan();
        }

        private void frmLaporanKeuangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRentalin.LaporanKeuangan' table. You can move, or remove it, as needed.
            viewLaporan();

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbPerMinggu_CheckedChanged(object sender, EventArgs e)
        {
            viewLaporan();
        }

        private void rbPerBulan_CheckedChanged(object sender, EventArgs e)
        {
            viewLaporan();
        }

        private void rbPerTahun_CheckedChanged(object sender, EventArgs e)
        {
            viewLaporan();
        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            viewLaporan();
        }
    }
}
