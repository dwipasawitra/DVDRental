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

        DataTable belanja = new DataTable();
        DataTable koleksi = new DataTable();
        DataTable member = new DataTable();
        DataTable stokKoleksi = new DataTable();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private void hitungTotalBiaya()
        {
            int i, totalBiayaSewa = 0;
            int jumlahBelanjaan = belanja.Rows.Count;
            for (i = 0; i < jumlahBelanjaan; i++)
            {
                totalBiayaSewa += int.Parse(belanja.Rows[i].ItemArray[3].ToString());
            }
            totalBiayaSewa *= int.Parse(lblLamaPenyewaan.Text);
            lblBiayaSewa.Text = totalBiayaSewa.ToString();
            txtTambahJudul.ResetText();
        }

        private string randomNota()
        {
            Random rand = new Random();
            char[] buffer = new char[4];
            //char[] nota = new char[12];
            string nota = "VCD";
            int i;
            for (i = 0; i < 4; i++)
            {
                buffer[i] = chars[rand.Next(chars.Length)];
            }
            nota += new string(buffer);
            int angka;
            for (i = 0; i < 5; i++)
            {
                angka = rand.Next(0, 9);
                nota += angka.ToString();
            }
            //MessageBox.Show(nota);
            return nota;
        }

        private void frmTransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            tampilanAwal();
            MessageBox.Show(System.DateTime.Now.Date.ToString());
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
            member = Program.conn.ExecuteDataTable("SELECT * FROM member");

            belanja.Columns.Add("Kode Judul");
            belanja.Columns.Add("Judul Film");
            belanja.Columns.Add("Kode Stok");
            belanja.Columns.Add("Sewa");
            belanja.Columns.Add("Denda");

            dgPeminjaman.DataSource = belanja;

            /*txtTambahJudul.Enabled = false;
            btnCariJudul.Enabled = false;
            btnTambah.Enabled = false;
            lblNmrNota.Text = randomNota();*/
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int i, idx = koleksi.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                if (txtTambahJudul.Text == koleksi.Rows[i].ItemArray[0].ToString())
                {
                    MessageBox.Show("terpilih");
                    stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + txtTambahJudul.Text + "' AND kondisi = 0 AND status = 0");
                    //stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + dgPeminjaman.Rows[y].Cells[0].Value.ToString() + "' AND kondisi = 0 AND STATUS = 0");
                    int idx_stok = stokKoleksi.Rows.Count;

                    MessageBox.Show(idx_stok.ToString());
                    belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()), int.Parse(koleksi.Rows[i].ItemArray[4].ToString()));
                    dgPeminjaman.ReadOnly = true;
                    dgPeminjaman.DataSource = belanja;
                    //MessageBox.Show("Data berhasil ditambahkan");
                    if (dgPeminjaman.Rows.Count == 2)
                    {
                        int l;
                        for (l = 0; l < idx_stok; l++)
                        {
                            cmbStok.Items.Add(stokKoleksi.Rows[l].ItemArray[0].ToString());
                        }
                        cmbStok.Text = stokKoleksi.Rows[0].ItemArray[0].ToString();
                        lblHargaSewaItem.Text = dgPeminjaman.Rows[0].Cells[3].Value.ToString();
                        lblHargaDendaItem.Text = dgPeminjaman.Rows[0].Cells[4].Value.ToString();
                    }
                    break;
                }
            }
            if (i == idx)
            {
                MessageBox.Show("Data tidak ditemukan!");
            }
            hitungTotalBiaya();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DataTable cekPeminjam = new DataTable();
            cekPeminjam = Program.conn.ExecuteDataTable("SELECT * FROM nota WHERE kodemember = '" + txtPeminjam.Text + "' AND tglrealisasikembali IS NOT NULL");
            int cek = cekPeminjam.Rows.Count;
            if (cek == 0)
            {
                MessageBox.Show("Member tidak bisa melakukan peminjaman");
            }
            else
            {
                int i, idx = member.Rows.Count;
                for (i = 0; i < idx; i++)
                {
                    if (txtPeminjam.Text == member.Rows[i].ItemArray[0].ToString())
                    {
                        lblNamaPeminjam.Text = member.Rows[i].ItemArray[1].ToString();
                        lblKodeMember.Text = txtPeminjam.Text;
                        txtTambahJudul.Enabled = true;
                        btnCariJudul.Enabled = true;
                        btnTambah.Enabled = true;
                        txtPeminjam.ResetText();
                        break;
                    }
                }
                if (i == idx)
                {
                    MessageBox.Show("Member tidak ditemukan");
                }
            }
        }

        private void cmbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = dgPeminjaman.CurrentCellAddress.Y;
            belanja.Rows[y][2] = cmbStok.Text;
        }

        private void dgPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;


            lblJudul.Text = dgPeminjaman.Rows[y].Cells[1].Value.ToString();

            stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + dgPeminjaman.Rows[y].Cells[0].Value.ToString() + "' AND kondisi = 0 AND status = 0");
            int i, idx = stokKoleksi.Rows.Count, index = koleksi.Rows.Count;
            MessageBox.Show("jumlah terpilih");
            MessageBox.Show(stokKoleksi.Rows.Count.ToString());
            cmbStok.Items.Clear();
            for (i = 0; i < idx; i++)
            {
                cmbStok.Items.Add(stokKoleksi.Rows[i].ItemArray[0].ToString());
            }
            cmbStok.Text = belanja.Rows[y].ItemArray[2].ToString();
            for (i = 0; i < index; i++)
            {
                if (dgPeminjaman.Rows[y].Cells[0].Value.ToString() == koleksi.Rows[i].ItemArray[0].ToString())
                {
                    lblGenre.Text = koleksi.Rows[i].ItemArray[5].ToString();
                    break;
                }
            }


            lblHargaSewaItem.Text = dgPeminjaman.Rows[y].Cells[3].Value.ToString();
            lblHargaDendaItem.Text = dgPeminjaman.Rows[y].Cells[4].Value.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int x = dgPeminjaman.CurrentCellAddress.X;
            int y = dgPeminjaman.CurrentCellAddress.Y;
            belanja.Rows[y].Delete();
            hitungTotalBiaya();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            string date = System.DateTime.Now.Date.ToString();
            string newDate = date.Substring(0, 10);
            string tglKembali = dtpTanggalKembali.Value.Date.ToString();
            string newTglKembali = tglKembali.Substring(0, 10);
            //insert belanjaan ke tabel

            string insertNota = "INSERT INTO nota (nonota,kodeoperator,kodepenawaranspesial,kodemember,tgltransaksi,tglkembali,hargasewa)VALUES ('" + lblNmrNota.Text + "','" + Program.session.kodeOperator.ToString() + "',0,'" + lblKodeMember.Text + "',to_date('" + newDate + "','mm/dd/yyyy'),to_date('" + newTglKembali + "','mm/dd/yyyy')," + lblBiayaSewa.Text + ")";
            Program.conn.ExecuteNonQuery(insertNota);
            string kodeDipinjam = randomNota();
            int i, idx = belanja.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                string insertDipinjam = "INSERT INTO dipinjam VALUES('" + randomNota() + "','" + belanja.Rows[i].ItemArray[2].ToString() + "','" + lblNmrNota.Text + "')";
                Program.conn.ExecuteNonQuery(insertDipinjam);
                string updateStok = "UPDATE stokkoleksi SET status = 1 WHERE kodestok = '" + belanja.Rows[i].ItemArray[2].ToString() + "'";
                Program.conn.ExecuteNonQuery(updateStok);
            }
            MessageBox.Show("Transaksi Berhasil");
            tampilanAwal();
        }

        private void tampilanAwal()
        {
            //dgPeminjaman.ClearSelection();
            belanja.Clear();
            lblNmrNota.Text = "Kode Nota";
            lblNamaPeminjam.Text = "Nama Peminjam";
            lblKodeMember.Text = "Kode Member";
            btnCariJudul.Enabled = false;
            txtTambahJudul.Enabled = false;
            btnTambah.Enabled = false;
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            lblHargaSewaItem.Text = "0";
            lblHargaDendaItem.Text = "0";
            cmbStok.Items.Clear();
            dtpTanggalKembali.ResetText();
            lblNmrNota.Text = randomNota();
            lblLamaPenyewaan.Text = "0";
            lblBiayaSewa.Text = "0";
        }
        private void dtpTanggalKembali_ValueChanged(object sender, EventArgs e)
        {
            int lamaPenyewaan = dtpTanggalKembali.Value.Day - DateTime.Now.Day;
            lblLamaPenyewaan.Text = lamaPenyewaan.ToString();
            hitungTotalBiaya();
        }

    }
}
