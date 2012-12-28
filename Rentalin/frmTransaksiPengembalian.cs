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
            daftarPinjaman.Columns.Add("Kondisi");
            daftarPinjaman.Columns.Add("Denda");            
            daftarPinjaman.Columns.Add("Denda Kerusakan");
            daftarPinjaman.Columns.Add("Total Denda");
            dgPengembalian.DataSource = daftarPinjaman;
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
        }

        private int hitungTotalDenda()
        {
            int i, idx = dipinjam.Rows.Count, totalDenda = 0;
            MessageBox.Show("hho");
            MessageBox.Show(idx.ToString());
            for (i = 0; i < idx; i++)
            {
                daftarPinjaman.Rows[i][6] = int.Parse(daftarPinjaman.Rows[i].ItemArray[4].ToString())*int.Parse(lblLamaTelat.Text) + int.Parse(daftarPinjaman.Rows[i].ItemArray[5].ToString());
                totalDenda += int.Parse(daftarPinjaman.Rows[i].ItemArray[6].ToString());
            }
            return totalDenda;
        }

        private void labelInfo()
        {
            int y = dgPengembalian.CurrentCellAddress.Y;
            if (dgPengembalian.CurrentCellAddress.Y == dipinjam.Rows.Count)
            {
                y = dgPengembalian.CurrentCellAddress.Y - 1;
                dgPengembalian.CurrentCell = dgPengembalian[dgPengembalian.CurrentCellAddress.X, y];
            }
            lblJudul.Text = daftarPinjaman.Rows[dgPengembalian.CurrentCellAddress.Y].ItemArray[1].ToString();
            lblHargaDendaItem.Text = daftarPinjaman.Rows[dgPengembalian.CurrentCellAddress.Y].ItemArray[4].ToString();            
            lblStok.Text = daftarPinjaman.Rows[dgPengembalian.CurrentCellAddress.Y].ItemArray[2].ToString();

            int i, idx = dipinjam.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                if (dipinjam.Rows[i].ItemArray[2].ToString() == dgPengembalian.Rows[dgPengembalian.CurrentCellAddress.Y].Cells[2].Value.ToString())
                {
                    lblGenre.Text = dipinjam.Rows[i].ItemArray[5].ToString();
                    lblHargaSewaItem.Text = dipinjam.Rows[i].ItemArray[3].ToString();
                    MessageBox.Show(dipinjam.Rows[i].ItemArray[5].ToString());
                }                
            }         
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
                MessageBox.Show("asdasd");
                MessageBox.Show(idx.ToString());
                if (selisih < 0)
                    selisih = 0;
                lblLamaTelat.Text = selisih.ToString();
                for (i = 0; i < idx; i++)
                {
                    daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), "", dipinjam.Rows[i].ItemArray[4].ToString(), 0, int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + 0);
                }
                txtPeminjam.Enabled = false;
                dgPengembalian.DataSource = daftarPinjaman;
                dgPengembalian.ReadOnly = true;
                lblBiayaDenda.Text = hitungTotalDenda().ToString();
                labelInfo();                
            }
        }

        private void dgPengembalian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dipinjam.Rows.Count;
            MessageBox.Show(idx.ToString());
            labelInfo();
        }

        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = dgPengembalian.CurrentCellAddress.Y;
            daftarPinjaman.Rows[y][3] = cmbKondisi.Text;
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
            int i, idx = dipinjam.Rows.Count, error = 1;
            string newDate = DateTime.Now.Date.ToString().Substring(0, 10);
            MessageBox.Show(newDate);
            for (i = 0; i < idx; i++)
            {
                if (daftarPinjaman.Rows[i].ItemArray[3].ToString() == "Baik" || daftarPinjaman.Rows[i].ItemArray[3].ToString() == "Buruk")
                    error = 0;
            }
            if (error == 0)
            {
                for (i = 0; i < idx; i++)
                {
                    if (daftarPinjaman.Rows[i].ItemArray[3].ToString() == "Baik")
                    {                        
                        Program.conn.ExecuteNonQuery("UPDATE stokkoleksi SET kondisi = 0, status = 0 WHERE kodestok = '" + daftarPinjaman.Rows[i].ItemArray[2].ToString() + "'");
                    }
                    else
                    {
                        Program.conn.ExecuteNonQuery("UPDATE stokkoleksi SET kondisi = 1, status = 0 WHERE kodestok = '" + daftarPinjaman.Rows[i].ItemArray[2].ToString() + "'");
                    }
                    Program.conn.ExecuteNonQuery("UPDATE dipinjam SET hargadenda = " + int.Parse(daftarPinjaman.Rows[i].ItemArray[6].ToString()) + " WHERE nonota = '" + lblNmrNota.Text + "' AND kodestok = '" + daftarPinjaman.Rows[i].ItemArray[2].ToString() + "'");                    
                }
                Program.conn.ExecuteNonQuery("UPDATE nota SET tglrealisasikembali = to_date('" + newDate + "','MM/dd/yyyy') WHERE nonota = '" + lblNmrNota.Text + "'");
                MessageBox.Show("Transaksi Berhasil");
                tampilanAwal();
            }
            else
            {
                MessageBox.Show("Silahkan update kondisi");
            }
            
        }    

    }
}
