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
    public partial class frmLaporanNota : Form
    {
        DataTable dataNota;
        private const int MODE_NOTA_PENYEWAAN = 0;
        private const int MODE_NOTA_PENGEMBALIAN = 1;

        public frmLaporanNota()
        {
            InitializeComponent();
        }

        private void frmLaporanNota_Load(object sender, EventArgs e)
        {
            
        }

        private void tampilkanLaporanNota(string noNota)
        {
            DataTable detailNota;
            int modeNota;

            ReportParameter namaToko = new ReportParameter("NamaToko", Program.setting.namaJasa);
            ReportParameter alamatToko = new ReportParameter("AlamatToko", Program.setting.alamatJasa);
            ReportParameter noNotaParam = new ReportParameter("noNota", noNota);
            ReportParameter namaMember, tglTransaksi, tglKembali, tglRealisasiKembali, keterlambatan, pesanBawah, jenisNota, jenisHarga = null;
            DateTime dtTglTransaksi, dtTglKembali, dtTglRealisasiKembali;
            string strTglTransaksi, strTglKembali, strTglRealisasiKembali, strKeterlambatan = "";
            strTglRealisasiKembali = "";
            TimeSpan tsKeterlambatan;
            
            // Ambil data Nota untuk noNota yang dipilih
            try
            {
                detailNota = Program.conn.ExecuteDataTable("SELECT TglTransaksi, TglKembali, TglRealisasiKembali, Member.NamaMember FROM Nota INNER JOIN Member ON Nota.KodeMember = Member.KodeMember WHERE NoNota='" + noNota + "'");
                namaMember = new ReportParameter("namaMember", detailNota.Rows[0].ItemArray[3].ToString());

                dtTglTransaksi = DateTime.Parse(detailNota.Rows[0].ItemArray[0].ToString());
                strTglTransaksi = dtTglTransaksi.Day.ToString("00") + "/" + dtTglTransaksi.Month.ToString("00") + "/" + dtTglTransaksi.Year.ToString("00");

                dtTglKembali = DateTime.Parse(detailNota.Rows[0].ItemArray[1].ToString());
                strTglKembali = dtTglKembali.Day.ToString("00") + "/" + dtTglTransaksi.Month.ToString("00") + "/" + dtTglTransaksi.Year.ToString("00");

                if(detailNota.Rows[0].ItemArray[2] != null)
                {
                    dtTglRealisasiKembali = DateTime.Parse(detailNota.Rows[0].ItemArray[2].ToString());
                    strTglRealisasiKembali = dtTglRealisasiKembali.Day.ToString("00") + "/" + dtTglTransaksi.Month.ToString("00") + "/" + dtTglTransaksi.Year.ToString("00");
                    modeNota = MODE_NOTA_PENYEWAAN;
                    tsKeterlambatan = dtTglRealisasiKembali - dtTglKembali;
                    strKeterlambatan  = tsKeterlambatan.Days.ToString() + " hari";

                }
                else
                {
                    modeNota = MODE_NOTA_PENGEMBALIAN;
                }

                // TODO: This line of code loads data into the 'dsRentalin.QueryNota' table. You can move, or remove it, as needed.
                this.QueryNotaTableAdapter.Fill(this.dsRentalin.QueryNota, noNota);
                reportviewNota.LocalReport.SetParameters(namaToko);
                reportviewNota.LocalReport.SetParameters(alamatToko);
                reportviewNota.LocalReport.SetParameters(noNotaParam);
                reportviewNota.LocalReport.SetParameters(namaMember);
                switch(modeNota)
                {
                    case MODE_NOTA_PENYEWAAN:
                        jenisNota = new ReportParameter("jenisNota", "PENYEWAAN");
                        tglTransaksi = new ReportParameter("tglTransaksi", strTglTransaksi);
                        tglKembali = new ReportParameter("tglKembali", strTglKembali);
                        tglRealisasiKembali = new ReportParameter("tglRealisasiKembali", "-");
                        jenisHarga = new ReportParameter("jenisHarga", "Sewa");
                        keterlambatan = new ReportParameter("keterlambatan", "-");
                        pesanBawah = new ReportParameter("pesanBawah", "Terima kasih telah menyewa di rental kami. Semoga semuanya menyenangkan! Harap kembalikan tepat waktu ya :)");
                        reportviewNota.LocalReport.SetParameters(jenisNota);
                        reportviewNota.LocalReport.SetParameters(tglTransaksi);
                        reportviewNota.LocalReport.SetParameters(tglKembali);
                        reportviewNota.LocalReport.SetParameters(pesanBawah);
                        reportviewNota.LocalReport.SetParameters(jenisHarga);
                        this.reportviewNota.RefreshReport();
                        
                        
                        break;
                    case MODE_NOTA_PENGEMBALIAN:
                        jenisNota = new ReportParameter("jenisNota", "PENGEMBALIAN");
                        tglTransaksi = new ReportParameter("tglTransaksi", strTglTransaksi);
                        tglKembali = new ReportParameter("tglKembali", strTglKembali);
                        tglRealisasiKembali = new ReportParameter("tglRealisasiKembali", strTglRealisasiKembali);
                        jenisHarga = new ReportParameter("jenisHarga", "Denda");
                        keterlambatan = new ReportParameter("keterlambatan", strKeterlambatan);
                        pesanBawah = new ReportParameter("pesanBawah", "Terima kasih telah menyewa di rental kami. Semoga semuanya menyenangkan!");
                        reportviewNota.LocalReport.SetParameters(jenisNota);
                        reportviewNota.LocalReport.SetParameters(tglTransaksi);
                        reportviewNota.LocalReport.SetParameters(tglKembali);
                        reportviewNota.LocalReport.SetParameters(pesanBawah);
                        reportviewNota.LocalReport.SetParameters(jenisHarga);
                        this.reportviewNota.RefreshReport();
                        break;
                }


               
            }
            
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void updateDataNota()
        {
            // Tanpa argumen, ambil data nota hari ini
            string tglOracleHariIni = Program.convertTglkeOracle(DateTime.Now);

            cmbNoNota.Items.Clear();
            dataNota = Program.conn.ExecuteDataTable("SELECT NoNota FROM Nota WHERE TglTransaksi='" + tglOracleHariIni + "'");
            for (int i = 0; i < dataNota.Rows.Count; i++)
            {
                cmbNoNota.Items.Add(dataNota.Rows[i].ItemArray[0]);
            }

        }

        private void updateDataNota(DateTime dtInput)
        {
            // Tanpa argumen, ambil data nota hari ini
            string tglOracle = Program.convertTglkeOracle(dtInput);

            cmbNoNota.Items.Clear();
            dataNota = Program.conn.ExecuteDataTable("SELECT NoNota FROM Nota WHERE TglTransaksi='" + tglOracle + "'");
            for (int i = 0; i < dataNota.Rows.Count; i++)
            {
                cmbNoNota.Items.Add(dataNota.Rows[i].ItemArray[0]);
            }

        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            updateDataNota(dtpTanggal.Value);
        }

        private void cmbNoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            tampilkanLaporanNota(cmbNoNota.Text);
        }

       
    }
}
