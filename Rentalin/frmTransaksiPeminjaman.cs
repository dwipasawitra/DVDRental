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
    public partial class frmTransaksiPeminjaman : Form
    {
        public frmTransaksiPeminjaman()
        {
            InitializeComponent();
        }
        public class peminjaman
        {
            private string kodeJudul, judulFilm, kodeStok;
            private int sewaPerHari, dendaPerHari;
            public peminjaman(string kode_judul, string judul_film, string kode_stok, int sewa, int denda)
            {
                kodeJudul = kode_judul;
                judulFilm = judul_film;
                kodeStok = kode_stok;
                sewaPerHari = sewa;
                dendaPerHari = denda;
            }
            public string Kode_Judul
            {
                get { return kodeJudul; }
            }
            public string Judul_Film
            {
                get { return judulFilm; }
            }
            public string Kode_Stok
            {
                get { return kodeStok; }
            }
            public int Sewa_Per_Hari
            {
                get { return sewaPerHari; }
            }
            public int Denda_Per_Hari
            {
                get { return dendaPerHari; }
            }
        }
        List<peminjaman> Peminjaman = new List<peminjaman>();
        DataTable koleksi = new DataTable();
        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void frmTransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            //menset label sewa dan denda per hari
            dgPeminjaman.DataSource = Peminjaman;
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, kodekategori, namaitem, biayasewafilm, biayadendafilm FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int i, idx = koleksi.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                if (txtTambahJudul.Text == koleksi.Rows[i].ItemArray[0].ToString())
                {
                    //add list;
                    MessageBox.Show("Data berhasil ditambahkan");
                    break;
                }
            }
            if (i == idx)
            {
                MessageBox.Show("Data tidak ditemukan!");
            }
        }
    }
}
