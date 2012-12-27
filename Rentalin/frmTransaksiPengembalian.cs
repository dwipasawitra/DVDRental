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
    public partial class frmTransaksiPengembalian : Form
    {
        public frmTransaksiPengembalian()
        {
            InitializeComponent();
        }
        //DataTable peminjam = new DataTable();
        DataTable daftarPinjaman = new DataTable();
        DataTable dipinjam = new DataTable();
        DataTable koleksi = new DataTable();
        private void tampilanAwal()
        {
            txtPeminjam.Enabled = true;
            btnCariPelanggan.Enabled = true;
            lblNamaPeminjam.Text = "Nama Peminjam";
            lblKodeMember.Text = "Kode Member";
            lblIdentitas.Text = "Identitas : ";
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            lblHargaSewaItem.Text = "0";
            lblHargaDendaItem.Text = "0";
            lblStok.Text = "Kode Stok";
            cmbKondisi.Items.Clear();
            cmbKondisi.Items.Add("Baik");
            cmbKondisi.Items.Add("Buruk");
            lblDendaKerusakan.Text = "0";
            lblBiayaDenda.Text = "0";
            lblTanggalSeharusnyaKembali.Text = "Tanggal Kembali";
            lblLamaTelat.Text = "0";
            lblNmrNota.Text = "Kode Nota";
            btnProses.Enabled = false;
            daftarPinjaman.Clear();
        }

        private void frmTransaksiPengembalian_Load(object sender, EventArgs e)
        {
            MessageBox.Show(System.DateTime.Now.ToString());
            tampilanAwal();
            txtPeminjam.Focus();
            daftarPinjaman.Columns.Add("Kode Judul");
            daftarPinjaman.Columns.Add("Judul Film");
            daftarPinjaman.Columns.Add("Kode Stok");
            daftarPinjaman.Columns.Add("Denda");
            daftarPinjaman.Columns.Add("Kondisi");
            daftarPinjaman.Columns.Add("Denda Kerusakan");
            dgPengembalian.DataSource = daftarPinjaman;
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
        }

        private int hitungTotalDenda()
        {
            int i, idx = daftarPinjaman.Rows.Count, totalDenda = 0;
            MessageBox.Show(idx.ToString());
            for (i = 0; i < idx; i++)
            {
                totalDenda = totalDenda + int.Parse(daftarPinjaman.Rows[i].ItemArray[3].ToString()) + int.Parse(daftarPinjaman.Rows[i].ItemArray[5].ToString());
            }
            return totalDenda;
        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            DataTable cekPeminjam = new DataTable();
            cekPeminjam = Program.conn.ExecuteDataTable("SELECT * FROM nota WHERE kodemember = '" + txtPeminjam.Text + "' AND tglrealisasikembali IS NULL");
            int cek = cekPeminjam.Rows.Count;
            if (cek != 1)
            {
                MessageBox.Show("Member tidak sedang meminjam");
            }
            else
            {
                btnCariPelanggan.Enabled = false;
                btnProses.Enabled = true;
                dipinjam = Program.conn.ExecuteDataTable("SELECT stokkoleksi.kodekoleksi, koleksi.namaitem, stokkoleksi.kodestok, koleksi.biayasewafilm, koleksi.biayadendafilm, genre.namakategori FROM ((dipinjam INNER JOIN stokkoleksi ON dipinjam.kodestok = stokkoleksi.kodestok) INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi) INNER JOIN genre ON koleksi.kodekategori=genre.kodekategori WHERE nonota = (SELECT nonota FROM (SELECT RANK() OVER (ORDER BY tgltransaksi DESC) AS rank, nota.* FROM nota WHERE kodemember='" + txtPeminjam.Text + "') WHERE rank=1)");                
                int i, idx = dipinjam.Rows.Count;
                lblNmrNota.Text = cekPeminjam.Rows[0].ItemArray[0].ToString();
                lblTanggalSeharusnyaKembali.Text = cekPeminjam.Rows[0].ItemArray[5].ToString();
                DateTime tanggalHarusKembali = DateTime.Parse(lblTanggalSeharusnyaKembali.Text);
                int selisih = DateTime.Now.Day - tanggalHarusKembali.Day;
                lblLamaTelat.Text = selisih.ToString();
                for (i = 0; i < idx; i++)
                {
                    daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), (int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) * int.Parse(lblLamaTelat.Text)).ToString(), "", 0);
                }
                txtPeminjam.Enabled = false;
                dgPengembalian.DataSource = daftarPinjaman;
                dgPengembalian.ReadOnly = true;
                lblBiayaDenda.Text = hitungTotalDenda().ToString();
                if (idx == 1)
                {
                    lblJudul.Text = daftarPinjaman.Rows[0].ItemArray[1].ToString();
                    lblGenre.Text = dipinjam.Rows[0].ItemArray[5].ToString();
                    lblHargaDendaItem.Text = dipinjam.Rows[0].ItemArray[4].ToString();
                    lblHargaSewaItem.Text = dipinjam.Rows[0].ItemArray[3].ToString();
                    lblStok.Text = daftarPinjaman.Rows[0].ItemArray[2].ToString();
                }
            }
        }

        private void dgPengembalian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            lblJudul.Text = dgPengembalian.Rows[y].Cells[1].Value.ToString();
            lblGenre.Text = dipinjam.Rows[y].ItemArray[5].ToString();
            lblStok.Text = dgPengembalian.Rows[y].Cells[2].Value.ToString();
            lblHargaSewaItem.Text = dipinjam.Rows[y].ItemArray[3].ToString();
            lblHargaDendaItem.Text = dipinjam.Rows[y].ItemArray[4].ToString();
        }

        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = dgPengembalian.CurrentCellAddress.Y;
            daftarPinjaman.Rows[y][4] = cmbKondisi.Text;
            if (cmbKondisi.Text == "Buruk")
            {
                DataTable ambilHarga = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodestok = '" + daftarPinjaman.Rows[y].ItemArray[2].ToString() + "'");
                lblDendaKerusakan.Text = (int.Parse(ambilHarga.Rows[0].ItemArray[4].ToString()) * 50 / 100).ToString();
                daftarPinjaman.Rows[y][5] = int.Parse(lblDendaKerusakan.Text);
            }
            else if (cmbKondisi.Text == "Baik")
            {
                lblDendaKerusakan.Text = "0";
                daftarPinjaman.Rows[y][5] = 0;
            }
            
            lblBiayaDenda.Text = hitungTotalDenda().ToString();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int i, idx = daftarPinjaman.Rows.Count, denda = 0, rusak = 0;            
            string newDate = DateTime.Now.Date.ToString().Substring(0, 10);
            MessageBox.Show(newDate);
            for (i = 0; i < idx; i++)
            {
                denda += int.Parse(daftarPinjaman.Rows[i].ItemArray[3].ToString());
                rusak += int.Parse(daftarPinjaman.Rows[i].ItemArray[5].ToString());
                if (daftarPinjaman.Rows[i].ItemArray[4].ToString() == "Baik")
                {
                    Program.conn.ExecuteNonQuery("UPDATE stokkoleksi SET kondisi = 0, status = 0 WHERE kodestok = '" + daftarPinjaman.Rows[i].ItemArray[2].ToString() + "'");
                }
                else
                {                    
                    Program.conn.ExecuteNonQuery("UPDATE stokkoleksi SET kondisi = 1, status = 0 WHERE kodestok = '" + daftarPinjaman.Rows[i].ItemArray[2].ToString() + "'");
                }
            }            
            Program.conn.ExecuteNonQuery("UPDATE nota SET tglrealisasikembali = to_date('" + newDate + "','MM/dd/yyyy'), hargadenda = " + denda + ", hargarusak = " + rusak + " WHERE nonota = '" + lblNmrNota.Text + "'");
            MessageBox.Show("Transaksi Berhasil");
            tampilanAwal();
        }    

    }
}
