using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentalinKatalog
{
    public partial class frmMain : Form
    {
        private const int MAX_TOP_KOLEKSI = 10;
        bool sedangMemesan = false;
        bool animateBlink = false;
        string yangDicari = "";
        int idxTopKoleksi = 0;
        string kodeTopKoleksi = "";

        DataTable judulTerbanyak;
        DataTable dataKoleksi;

        private void updateKoleksi()
        {
            // Jika tidak ada sesuatu yang dicari, maka tampilkan data
            if(yangDicari == "")
            {
                dataKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, jeniskeping.jenis " +
                                                            "from koleksi, genre, jeniskeping where genre.kodekategori = koleksi.kodekategori AND koleksi.jenis = jeniskeping.id");
            }
            else
            {
                dataKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, jeniskeping.jenis " +
                                                            "from koleksi, genre where genre.kodekategori = koleksi.kodekategori AND koleksi.jenis = jeniskeping.id AND (kodekoleksi like '%" + yangDicari + "%' OR namaitem like '%" + yangDicari + "%')");
            }
            // Atur judul kolom 
            dataKoleksi.Columns[0].ColumnName = "Kode Koleksi";
            dataKoleksi.Columns[1].ColumnName = "Judul";
            dataKoleksi.Columns[2].ColumnName = "Kategori";
            dataKoleksi.Columns[3].ColumnName = "Jenis Keping";
       

            // Update isi data grid
            dgKoleksi.DataSource = dataKoleksi;
            
         


        }

        private void updateTopKoleksi()
        {
            try
            {
                // Ambil judul terbanyak berdasarkan orang meminjam
                judulTerbanyak = Program.conn.ExecuteDataTable("SELECT koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori, jeniskeping.jenis, count(dipinjam.kodedipinjam) as jumlah "
                                                                    + "FROM stokkoleksi INNER JOIN dipinjam ON dipinjam.kodestok = stokkoleksi.kodestok INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi INNER JOIN nota ON dipinjam.nonota = nota.nonota INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori INNER JOIN jeniskeping ON koleksi.jenis = jeniskeping.id "
                                                                    + "GROUP BY koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori, jeniskeping.jenis "
                                                                    + "ORDER BY jumlah DESC ");
                // Muat informasi utama
                kodeTopKoleksi = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[0].ToString();
                lblJudulTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[1].ToString();
                lblGenreTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[2].ToString();
                lblJenisKepingTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[3].ToString();
                
                

                // Muat gambar blob dan  deskripsi
                DataTable blobTable = Program.conn.ExecuteDataTable("SELECT coverart, dekripsiitem FROM koleksi WHERE KodeKoleksi='" + kodeTopKoleksi + "'");

                try
                {
                    if (picTopKoleksiTerbaik.Image != null)
                    {
                        picTopKoleksiTerbaik.Image.Dispose();
                        picTopKoleksiTerbaik.Image = null;
                    }

                    // Convert coverart ke gambar
                    if (!Convert.IsDBNull(blobTable.Rows[0].ItemArray[0]))
                    {
                        

                        byte[] blob = (byte[])blobTable.Rows[0].ItemArray[0];
                        Program.displayBlobImage(blob, "topkoleksi");

                        // Tampilkan gambar
                        picTopKoleksiTerbaik.Image = Image.FromFile("topkoleksi");
                        picTopKoleksiTerbaik.SizeMode = PictureBoxSizeMode.StretchImage;
                        picTopKoleksiTerbaik.Refresh();
                    }
                    lblDeskripsiTop.Text = blobTable.Rows[idxTopKoleksi].ItemArray[1].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                return;
            }

        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Ambil data Nama dan Alamat
            lblNamaLayanan.Text = Program.setting.namaJasa;
            lblAlamatLayanan.Text = Program.setting.alamatJasa;

            // Update data koleksi dan top koleksi
            updateKoleksi();
            updateTopKoleksi();
        }

        private void tmrWaktu_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string day = DateTime.Now.Day.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string year = DateTime.Now.Year.ToString("0000");

            lblDate.Text = day + "/" + month + "/" + year;
            if (animateBlink)
            {
                animateBlink = false;
                lblTime.Text = hour + " " + minute;
            }
            else
            {
                animateBlink = true;
                lblTime.Text = hour + ":" + minute;
            }
        }

        private void tmrScrollingText_Tick(object sender, EventArgs e)
        {
            int len = lblScrollingText.Text.Length;
            lblScrollingText.Text = lblScrollingText.Text.Substring(1, len - 1) + lblScrollingText.Text.Substring(0, 1);
        }

        private void btnLihatDaftarJudul_Click(object sender, EventArgs e)
        {
            

        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }

        private void dgKoleksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgKoleksi.SelectedCells.Count == 1)
            {
                if (dgKoleksi.SelectedCells[0].RowIndex >= 0 && dgKoleksi.SelectedCells[0].RowIndex < dataKoleksi.Rows.Count)
                {

                    int idx = dgKoleksi.SelectedCells[0].RowIndex;
                    showDataDetail(idx);
                }

            }
        }

        private void showDataDetail(int index)
        {

            // Tampilkan nama judul dan genre
            lblJudulKoleksi.Text = dataKoleksi.Rows[index].ItemArray[1].ToString();
            lblGenreKoleksi.Text = dataKoleksi.Rows[index].ItemArray[2].ToString();
            lblJenisKepingKoleksi.Text = dataKoleksi.Rows[index].ItemArray[3].ToString();

            // Ambil deskripsi dan BLOB gambar dari database
            string kodeKoleksi = dataKoleksi.Rows[index].ItemArray[0].ToString();
            DataTable infoJudul;
            infoJudul = Program.conn.ExecuteDataTable("SELECT dekripsiitem, coverart FROM koleksi WHERE KodeKoleksi='" + kodeKoleksi + "'");

            // Kosongkan gambar
            if (picDetailKoleksi.Image != null)
            {
                picDetailKoleksi.Image.Dispose();
                picDetailKoleksi.Image = null;
            }

            try
            {
                // Convert coverart ke gambar
                if (!Convert.IsDBNull(infoJudul.Rows[0].ItemArray[1]))
                {
                    byte[] blob = (byte[])infoJudul.Rows[0].ItemArray[1];
                    Program.displayBlobImage(blob, kodeKoleksi);

                    // Tampilkan gambar
                    picDetailKoleksi.Image = Image.FromFile(kodeKoleksi);
                    picDetailKoleksi.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDetailKoleksi.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tampilkan teks pada deskripsi
            lblDeskripsiKoleksi.Text = infoJudul.Rows[0].ItemArray[0].ToString();
            
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            if (txtPencarian.Text != "Pencarian...")
            {
                yangDicari = txtPencarian.Text;
                updateKoleksi();
            }
        }

        private void txtPencarian_Enter(object sender, EventArgs e)
        {
            if (txtPencarian.Text == "Pencarian...")
                txtPencarian.Text = "";
        }

        private void txtPencarian_Leave(object sender, EventArgs e)
        {
            if (txtPencarian.Text == "")
                txtPencarian.Text = "Pencarian...";
        }

        private void dgKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tmrTopKoleksi_Tick(object sender, EventArgs e)
        {
            if (judulTerbanyak.Rows.Count < MAX_TOP_KOLEKSI)
            {
                idxTopKoleksi += idxTopKoleksi % judulTerbanyak.Rows.Count;
            }
            else
            {
                idxTopKoleksi += idxTopKoleksi % MAX_TOP_KOLEKSI;
            }

            updateTopKoleksi();
        }

        private void tabDepan_Click(object sender, EventArgs e)
        {

        }

      
       

        
    }
}
