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
    public partial class frmHallOfFame : Form
    {
        DataTable pelangganTerbanyak;
        DataTable judulTerbanyak;

        public frmHallOfFame()
        {
            InitializeComponent();
        }

        private void emptyLabel()
        {
            lblNamaMember1.Text = "";
            lblNamaMember2.Text = "";
            lblNamaMember3.Text = "";
            lblNamaMember4.Text = "";
            lblNamaMember5.Text = "";

            lblJumlahPeminjam1.Text = "";
            lblJumlahPeminjam2.Text = "";
            lblJumlahPeminjam3.Text = "";
            lblJumlahPeminjam4.Text = "";
            lblJumlahPeminjam5.Text = "";

            lblJudul1.Text = "";
            lblJudul2.Text = "";
            lblJudul3.Text = "";
            lblJudul4.Text = "";
            lblJudul5.Text = "";

            lblGenre1.Text = "";
            lblGenre2.Text = "";
            lblGenre3.Text = "";
            lblGenre4.Text = "";
            lblGenre5.Text = "";

            lblJumlahJudul1.Text = "";
            lblJumlahJudul2.Text = "";
            lblJumlahJudul3.Text = "";
            lblJumlahJudul4.Text = "";
            lblJumlahJudul5.Text = "";
        }

        private void loadData()
        {
            int month = cmbBulan.SelectedIndex + 1;
            int year = Int16.Parse(cmbTahun.Text);
            emptyLabel();

            string blnTanggal = month.ToString("00") + year.ToString("0000");

            // Berdasarkan bulan dan tahun
            // Ambil 5 besar pelanggan terbanyak meminjam
            pelangganTerbanyak = Program.conn.ExecuteDataTable("SELECT member.kodemember, member.namamember, count(nota.nonota) as jumlah "
                                                                + "FROM member INNER JOIN nota ON member.kodemember = nota.kodemember "
                                                                + "WHERE to_char(nota.tgltransaksi, 'MMYYYY')='" + blnTanggal + "' "
                                                                + "GROUP BY member.kodemember, member.namamember "
                                                                + "ORDER BY jumlah DESC ");

            if(pelangganTerbanyak.Rows.Count >= 1)
            {
                lblNamaMember1.Text = pelangganTerbanyak.Rows[0].ItemArray[1].ToString();
                lblJumlahPeminjam1.Text = pelangganTerbanyak.Rows[0].ItemArray[2].ToString();
            }

            if(pelangganTerbanyak.Rows.Count >= 2)
            {
                lblNamaMember2.Text = pelangganTerbanyak.Rows[1].ItemArray[1].ToString();
                lblJumlahPeminjam2.Text = pelangganTerbanyak.Rows[1].ItemArray[2].ToString();
            }

            if(pelangganTerbanyak.Rows.Count >= 3)
            {
                lblNamaMember3.Text = pelangganTerbanyak.Rows[2].ItemArray[1].ToString();
                lblJumlahPeminjam3.Text = pelangganTerbanyak.Rows[2].ItemArray[2].ToString();
            }

            if(pelangganTerbanyak.Rows.Count >= 4)
            {
                lblNamaMember4.Text = pelangganTerbanyak.Rows[3].ItemArray[1].ToString();
                lblJumlahPeminjam4.Text = pelangganTerbanyak.Rows[3].ItemArray[2].ToString();
            }

            if(pelangganTerbanyak.Rows.Count >= 5)
            {
                lblNamaMember5.Text = pelangganTerbanyak.Rows[4].ItemArray[1].ToString();
                lblJumlahPeminjam5.Text = pelangganTerbanyak.Rows[4].ItemArray[2].ToString();
            }

            // Ambil 5 besar judul yang banyak terpinjam
            judulTerbanyak = Program.conn.ExecuteDataTable("SELECT koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori, count(dipinjam.kodedipinjam) as jumlah "
                                                                + "FROM stokkoleksi INNER JOIN dipinjam ON dipinjam.kodestok = stokkoleksi.kodestok INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi INNER JOIN nota ON dipinjam.nonota = nota.nonota INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori "
                                                                + "WHERE to_char(nota.tgltransaksi, 'MMYYYY')='" + blnTanggal + "' "
                                                                + "GROUP BY koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori "
                                                                + "ORDER BY jumlah DESC ");

            if (judulTerbanyak.Rows.Count >= 1)
            {
                lblJudul1.Text = judulTerbanyak.Rows[0].ItemArray[1].ToString();
                lblGenre1.Text = judulTerbanyak.Rows[0].ItemArray[2].ToString();
                lblJumlahJudul1.Text = judulTerbanyak.Rows[0].ItemArray[3].ToString();
                 // Ambil Coverart untuk judul nomor #1
                DataTable gambarJuara = Program.conn.ExecuteDataTable("SELECT coverart FROM koleksi WHERE kodekoleksi='" + judulTerbanyak.Rows[0].ItemArray[0].ToString() + "'");
                byte[] blobImageJuara;
                if(picJuara.Image != null)
                {
                    picJuara.Image.Dispose();
                    picJuara.Image = null;
                }
                if (!Convert.IsDBNull(gambarJuara.Rows[0].ItemArray[0]))
                {
                    blobImageJuara = (byte[])gambarJuara.Rows[0].ItemArray[0];
                    Program.displayBlobImage(blobImageJuara);
                    picJuara.Image = Image.FromFile(Program.IMAGE_FILE_TEMPORARY);
                    picJuara.Refresh();
                }
                
            }

            if (judulTerbanyak.Rows.Count >= 2)
            {
                lblJudul2.Text = judulTerbanyak.Rows[1].ItemArray[1].ToString();
                lblGenre2.Text = judulTerbanyak.Rows[1].ItemArray[2].ToString();
                lblJumlahJudul2.Text = judulTerbanyak.Rows[0].ItemArray[3].ToString();
            }

            if (judulTerbanyak.Rows.Count >= 3)
            {
                lblJudul3.Text = judulTerbanyak.Rows[2].ItemArray[1].ToString();
                lblGenre3.Text = judulTerbanyak.Rows[2].ItemArray[2].ToString();
                lblJumlahJudul3.Text = judulTerbanyak.Rows[0].ItemArray[3].ToString();
            }

            if (judulTerbanyak.Rows.Count >= 4)
            {
                lblJudul4.Text = judulTerbanyak.Rows[3].ItemArray[1].ToString();
                lblGenre4.Text = judulTerbanyak.Rows[3].ItemArray[2].ToString();
                lblJumlahJudul4.Text = judulTerbanyak.Rows[0].ItemArray[3].ToString();
            }

            if (judulTerbanyak.Rows.Count >= 5)
            {
                lblJudul5.Text = judulTerbanyak.Rows[4].ItemArray[1].ToString();
                lblGenre5.Text = judulTerbanyak.Rows[4].ItemArray[2].ToString();
                lblJumlahJudul5.Text = judulTerbanyak.Rows[0].ItemArray[3].ToString();
            }

           
        }
        private void frmHallOfFame_Load(object sender, EventArgs e)
        {
            // Isi tahun pada combobox tahun
            cmbTahun.Items.Clear();
            int tahunsekarang = DateTime.Now.Year;
            for (int i = -10; i <= 10; i++)
            {
                cmbTahun.Items.Add(tahunsekarang - i);
            }

            // Pilih tahun dan bulan sekarang
            cmbTahun.Text = tahunsekarang.ToString();
            cmbBulan.SelectedIndex = DateTime.Now.Month - 1;

            // Load data
            loadData();

        }

        private void pnlJudulTerbanyakDipinjam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cmbTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmHallOfFame_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hilangkan gambar
            picJuara.Image = null;
            picJuara.Dispose();
        }
    }
}
