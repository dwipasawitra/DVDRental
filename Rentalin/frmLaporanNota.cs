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
    public partial class frmLaporanNota : Form
    {
        DataTable dataNota;
        public frmLaporanNota()
        {
            InitializeComponent();
        }

        private void frmLaporanNota_Load(object sender, EventArgs e)
        {
            
        }

        private void tampilkanLaporanNota(string noNota)
        {
            // TODO: This line of code loads data into the 'dsRentalin.QueryNota' table. You can move, or remove it, as needed.
            this.QueryNotaTableAdapter.Fill(this.dsRentalin.QueryNota, noNota);
            this.reportviewNota.RefreshReport();
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
