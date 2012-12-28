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
    public partial class frmMasterKoleksi : Form
    {
        public frmMasterKoleksi()
        {
            InitializeComponent();
        }
        
        DataTable koleksi = new DataTable();

        private void tampilanAwal()
        {
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            dgKoleksi.DataSource = koleksi;
            dgKoleksi.ReadOnly = true;
        }

        private void frmMasterKoleksi_Load(object sender, EventArgs e)
        {
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, biayasewafilm, biayadendafilm from koleksi, genre where genre.kodekategori = koleksi.kodekategori");
            tampilanAwal();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgKoleksi.CurrentCellAddress.Y;
            //menghapus data
            string delete = "DELETE FROM stokkoleksi WHERE kodekoleksi = '" + koleksi.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            delete = "DELETE FROM koleksi WHERE kodekoleksi = '" + koleksi.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            koleksi.Rows[rows].Delete();
        }

        private void dgKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            lblJudul.Text = koleksi.Rows[y].ItemArray[1].ToString();
            lblGenre.Text = koleksi.Rows[y].ItemArray[2].ToString();
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {
            frmMasterStok formMasterStok = new frmMasterStok(koleksi.Rows[dgKoleksi.CurrentCellAddress.Y].ItemArray[0].ToString());
            formMasterStok.ShowDialog(this);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmTambahKoleksi formTambahKoleksi = new frmTambahKoleksi();
            formTambahKoleksi.ShowDialog(this);
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            int y = dgKoleksi.CurrentCellAddress.Y;
            frmTambahKoleksi formTambahKoleksi = new frmTambahKoleksi(koleksi.Rows[y].ItemArray[0].ToString());
            formTambahKoleksi.ShowDialog(this);
        }
        
    }
}
