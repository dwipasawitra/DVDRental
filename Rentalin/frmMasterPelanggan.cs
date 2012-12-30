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

        private void frmMasterPelanggan_Load(object sender, EventArgs e)
        {
            muatUlangData();
            dgPelanggan.ReadOnly = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgPelanggan.CurrentCellAddress.Y;
            string delete = "DELETE FROM member WHERE kodemember = '"+ pelanggan.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);

            muatUlangData();
            txtPencarian.Text = "";
        }

        private void dgPelanggan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (pelanggan.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            frmTambahPelanggan formTambahPelanggan = new frmTambahPelanggan();
            formTambahPelanggan.ShowDialog(this);
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            int y = dgPelanggan.CurrentCellAddress.Y;
            frmTambahPelanggan formTambahPelanggan = new frmTambahPelanggan(dgPelanggan.Rows[y].Cells[0].Value.ToString());
            formTambahPelanggan.ShowDialog(this);
        }

        private void btnMuatUlang_Click(object sender, EventArgs e)
        {
            muatUlangData();
            txtPencarian.Text = "";
        }

        private void btnHistori_Click(object sender, EventArgs e)
        {
            int y = dgPelanggan.CurrentCellAddress.Y;
            if (y >= 0 && y < pelanggan.Rows.Count)
            {
                frmHistoryPenyewaan formHistoryPenyewaan = new frmHistoryPenyewaan(dgPelanggan.Rows[y].Cells[0].Value.ToString(), 1);
                formHistoryPenyewaan.ShowDialog(this);
            }
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            // Lakukan filter ulang data member
            cariData(txtPencarian.Text);
            
        }

        private void dgPelanggan_SelectionChanged(object sender, EventArgs e)
        {
            // Jika ada satu sel dipilih dan tidak melebih batas, maka tampilkan detail keterangan pada panel yang tersdia
            if (dgPelanggan.SelectedCells.Count == 1)
            {
                if (dgPelanggan.SelectedCells[0].RowIndex < pelanggan.Rows.Count)
                {
                    int y = dgPelanggan.SelectedCells[0].RowIndex;
                    lblNamaPelanggan.Text = dgPelanggan.Rows[y].Cells[1].Value.ToString();
                    lblIdentitas.Text = dgPelanggan.Rows[y].Cells[3].Value.ToString() + " (" + pelanggan.Rows[y].ItemArray[2].ToString() + ")";
                }
            }
        }

        private void muatUlangData()
        {
            // Definisikan data member dan nama kolomnya
            pelanggan = Program.conn.ExecuteDataTable("SELECT kodemember, namamember, jenisidentitas.jenis, nomoridentitas FROM member INNER JOIN jenisidentitas ON member.jenisidentitas = jenisidentitas.id");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";
            pelanggan.Columns[2].ColumnName = "Jenis identitas";
            pelanggan.Columns[3].ColumnName = "Nomor Identitas";

            // Masukkan ke dalam grid
            dgPelanggan.DataSource = pelanggan;
        }

        private void cariData(string yangdicari)
        {
            pelanggan = Program.conn.ExecuteDataTable("SELECT * FROM member WHERE namamember like '%" + txtPencarian.Text + "%' OR kodemember like '%" + txtPencarian.Text + "%'");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";
            pelanggan.Columns[2].ColumnName = "Jenis identitas";
            pelanggan.Columns[3].ColumnName = "Nomor Identitas";

            // Masukkan ke dalam grid
            dgPelanggan.DataSource = pelanggan;
        }

      

    }
}
