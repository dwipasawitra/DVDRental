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
    public partial class frmMasterStok : Form
    {
        DataTable stok = new DataTable();
        DataTable pencarian = new DataTable();
        DataTable info = new DataTable();
        public int mode;
        public int modify;
        public frmMasterStok()
        {
            InitializeComponent();
            mode = 0;
            //stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi");
            //dgStokKoleksi.DataSource = stok;
            //dgStokKoleksi.ReadOnly = true;
            //MessageBox.Show("no string");
        }        

        public frmMasterStok(string kodeKoleksi)
        {
            InitializeComponent();
            mode = 1;
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+kodeKoleksi+"'");
            dgStokKoleksi.DataSource = stok;
            dgStokKoleksi.ReadOnly = true;
            btnPilihKoleksi.Enabled = false;
            txtPilihKoleksi.Enabled = false;
            //MessageBox.Show("string");
        }

        

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgStokKoleksi.CurrentCellAddress.Y;
            string delete = "DELETE FROM stokkoleksi WHERE kodestok = '" + stok.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            stok.Rows[rows].Delete();
        }

        private void lblInfoDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblPencarian_Click(object sender, EventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            pencarian = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodestok like '%" + txtPencarian.Text + "%' OR kodekoleksi like '%" + txtPencarian.Text + "%'");// OR kondisi =" + txtPencarian.Text + " OR status = " + txtPencarian.Text + " OR harga like = " + txtPencarian.Text + "");// OR tglbeli like '%" + txtPencarian.Text + "%'");
            if (pencarian.Rows.Count > 0)
            {
                //MessageBox.Show("berhasil");
                dgStokKoleksi.DataSource = pencarian;
            }
        }

        private void frmMasterStok_Load(object sender, EventArgs e)
        {
            info = Program.conn.ExecuteDataTable("SELECT stokkoleksi.kodestok, stokkoleksi.kodekoleksi, koleksi.namaitem, stokkoleksi.kondisi, stokkoleksi.status, stokkoleksi.harga, stokkoleksi.tglbeli, genre.namakategori FROM stokkoleksi INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori;");        
        }

        private void dgStokKoleksi_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (stok.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            //mode = 0;
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            //mode = 1;
        }

        private void dgStokKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            btnModifikasi.Enabled = true;
            int i, idx = info.Rows.Count;
            for(i=0;i<idx;i++)
            {
                if (dgStokKoleksi.Rows[i].Cells[1].Value.ToString() == info.Rows[i].ItemArray[1].ToString())
                {
                    lblJudul.Text = info.Rows[i].ItemArray[2].ToString();
                    lblGenre.Text = info.Rows[i].ItemArray[7].ToString();
                    break;
                }
            }
        }

        private void btnPilihKoleksi_Click(object sender, EventArgs e)
        {
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+txtPencarian.Text+"'");
            if (stok.Rows.Count > 1)
            {
                dgStokKoleksi.DataSource = stok;
            }
            else
            {
                txtPencarian.ResetText();
                MessageBox.Show("Kode Koleksi tidak ada");
            }
            
        }

        

        
    }
}
