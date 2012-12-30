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

        private void updateKoleksi()
        {
           
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, biayasewafilm, biayadendafilm from koleksi, genre where genre.kodekategori = koleksi.kodekategori");
           
            // Atur judul kolom 
            koleksi.Columns[0].ColumnName = "Kode Koleksi";
            koleksi.Columns[1].ColumnName = "Judul";
            koleksi.Columns[2].ColumnName = "Kategori";
            koleksi.Columns[3].ColumnName = "Biaya Sewa";
            koleksi.Columns[4].ColumnName = "Biaya Denda";
            
            
        }

        private void cariKoleksi(string arg)
        {
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, biayasewafilm, biayadendafilm from koleksi, genre where genre.kodekategori = koleksi.kodekategori AND (kodekoleksi like '%" + arg + "%' OR namaitem like '%" + arg + "%')");

            // Atur judul kolom 
            koleksi.Columns[0].ColumnName = "Kode Koleksi";
            koleksi.Columns[1].ColumnName = "Judul";
            koleksi.Columns[2].ColumnName = "Kategori";
            koleksi.Columns[3].ColumnName = "Biaya Sewa";
            koleksi.Columns[4].ColumnName = "Biaya Denda";
        }
        private void tampilanAwal()
        {
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            dgKoleksi.DataSource = koleksi;
            dgKoleksi.ReadOnly = true;
        }

        private void frmMasterKoleksi_Load(object sender, EventArgs e)
        {
            updateKoleksi();
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
            // Kosongkan gambar agar tidak konflik
            if (pbCoverArt.Image != null)
            {
                pbCoverArt.Image.Dispose();
            }

            int y = dgKoleksi.CurrentCellAddress.Y;
            frmTambahKoleksi formTambahKoleksi = new frmTambahKoleksi(koleksi.Rows[y].ItemArray[0].ToString());
            formTambahKoleksi.ShowDialog();
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            cariKoleksi(txtPencarian.Text);
            dgKoleksi.DataSource = koleksi;
        }

        private void dgKoleksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgKoleksi.SelectedCells.Count == 1)
            {
                if (dgKoleksi.SelectedCells[0].RowIndex >= 0 && dgKoleksi.SelectedCells[0].RowIndex < koleksi.Rows.Count)
                {

                    int idx = dgKoleksi.SelectedCells[0].RowIndex;
                    showDataDetail(idx);
                }

            }
        }

        private void showDataDetail(int index)
        {

            // Tampilkan nama judul dan genre
            lblJudul.Text = koleksi.Rows[index].ItemArray[1].ToString();
            lblGenre.Text = koleksi.Rows[index].ItemArray[2].ToString();

            // Ambil deskripsi dan BLOB gambar dari database
            string kodeKoleksi = koleksi.Rows[index].ItemArray[0].ToString();
            DataTable infoJudul;
            infoJudul = Program.conn.ExecuteDataTable("SELECT dekripsiitem, coverart FROM koleksi WHERE KodeKoleksi='" + kodeKoleksi + "'");

            // Kosongkan gambar
            if (pbCoverArt.Image != null)
            {
                pbCoverArt.Image.Dispose();
                pbCoverArt.Image = null;
            }

            try
            {
                // Convert coverart ke gambar
                if (!Convert.IsDBNull(infoJudul.Rows[0].ItemArray[1]))
                {
                    byte[] blob = (byte[])infoJudul.Rows[0].ItemArray[1];
                    Program.displayBlobImage(blob);

                    // Tampilkan gambar
                    pbCoverArt.Image = Image.FromFile(Program.IMAGE_FILE_TEMPORARY);
                    pbCoverArt.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbCoverArt.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tampilkan teks pada deskripsi
            txtDeskripsi.Text = infoJudul.Rows[0].ItemArray[0].ToString();
        }

        private void dgKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}
