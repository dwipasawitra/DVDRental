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
    public partial class frmMasterPelanggan : Form
    {
        public frmMasterPelanggan()
        {            
            InitializeComponent();            
        }
        DataTable pelanggan = new DataTable();
        DataTable pencarian = new DataTable();
        private void frmMasterPelanggan_Load(object sender, EventArgs e)
        {            
            pelanggan = Program.conn.ExecuteDataTable("SELECT * FROM member");
            dgPelanggan.DataSource = pelanggan;
            dgPelanggan.ReadOnly = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgPelanggan.CurrentCellAddress.Y;
            string delete = "DELETE FROM member WHERE kodemember = '"+ pelanggan.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            pelanggan = Program.conn.ExecuteDataTable("SELECT * FROM member");
            dgPelanggan.DataSource = pelanggan;
        }

        private void dgPelanggan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (pelanggan.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
            }
        }

        private void dgPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            lblNamaPelanggan.Text = pelanggan.Rows[y].ItemArray[1].ToString();
            lblIdentitas.Text = "Identitas : " + pelanggan.Rows[y].ItemArray[3].ToString();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmTambahPelanggan formTambahPelanggan = new frmTambahPelanggan();
            formTambahPelanggan.ShowDialog(this);
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            int y = dgPelanggan.CurrentCellAddress.Y;
            frmTambahPelanggan formTambahPelanggan = new frmTambahPelanggan(pelanggan.Rows[y].ItemArray[0].ToString());
            formTambahPelanggan.ShowDialog(this);
        }

        private void btnMuatUlang_Click(object sender, EventArgs e)
        {
            pelanggan = Program.conn.ExecuteDataTable("SELECT * FROM member");
            dgPelanggan.DataSource = pelanggan;
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            pencarian = Program.conn.ExecuteDataTable("SELECT * FROM member WHERE namamember like '%"+txtPencarian.Text+"%' OR kodemember like '%"+txtPencarian.Text+"%'");
            if (pencarian.Rows.Count > 0)
            {
                //MessageBox.Show("berhasil");
                dgPelanggan.DataSource = pencarian;
            }
            //MessageBox.Show(pencarian.Rows.Count.ToString());
        }
    }
}
