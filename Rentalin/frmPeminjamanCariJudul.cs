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
    public partial class frmPeminjamanCariJudul : Form
    {
        public frmPeminjamanCariJudul()
        {
            InitializeComponent();
        }

        DataTable koleksi = new DataTable();
        public string kodeDipilih;

        private void updateKoleksi()
        {

            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori from koleksi, genre where genre.kodekategori = koleksi.kodekategori");

            // Atur judul kolom 
            koleksi.Columns[0].ColumnName = "Kode Koleksi";
            koleksi.Columns[1].ColumnName = "Judul";
            koleksi.Columns[2].ColumnName = "Kategori";
          
            dgPencarian.DataSource = koleksi;
            dgPencarian.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgPencarian.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgPencarian.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

        }

        private void cariKoleksi(string arg)
        {
            arg = Program.escapeQuoteSQL(arg);
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori from koleksi, genre where genre.kodekategori = koleksi.kodekategori AND (upper(kodekoleksi) like '%" + arg.ToUpper() + "%' OR upper(namaitem) like '%" + arg.ToUpper() + "%')");

            // Atur judul kolom 
            koleksi.Columns[0].ColumnName = "Kode Koleksi";
            koleksi.Columns[1].ColumnName = "Judul";
            koleksi.Columns[2].ColumnName = "Kategori";
      
            dgPencarian.DataSource = koleksi;
            dgPencarian.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgPencarian.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgPencarian.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
           
          
        }

        private void frmPeminjamanCariJudul_Load(object sender, EventArgs e)
        {
            updateKoleksi();
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            cariKoleksi(txtPencarian.Text);
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (dgPencarian.SelectedCells.Count > 0)
            {
                kodeDipilih = koleksi.Rows[dgPencarian.SelectedCells[0].RowIndex].ItemArray[0].ToString();
                Close();
            }
        }

        private void txtPencarian_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

      

       

            


    }
}
