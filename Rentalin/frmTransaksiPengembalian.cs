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
        DataTable stokKoleksi = new DataTable();

        private void tampilanAwal()
        {
            txtPeminjam.Enabled = true;
            btnCariPelanggan.Enabled = true;
            lblNamaPeminjam.Text = "Nama Peminjam";
            lblKodeMember.Text = "Kode Member";
            lblIdentitas.Text = "Identitas : ";
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            
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
            lblDendaPersen.Text = Program.setting.dendaKerusakan.ToString() + " %";
            daftarPinjaman.Clear();
        }

        private void frmTransaksiPengembalian_Load(object sender, EventArgs e)
        {
           
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
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori, hargasewakategori, hargadendakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
            stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi");            
        }

        private int hitungTotalDenda()
        {
            int i, idx = dipinjam.Rows.Count, totalDenda = 0;            
            
            for (i = 0; i < idx; i++)
            {
                daftarPinjaman.Rows[i][6] = int.Parse(daftarPinjaman.Rows[i].ItemArray[4].ToString())*int.Parse(lblLamaTelat.Text) + int.Parse(daftarPinjaman.Rows[i].ItemArray[5].ToString());
                totalDenda += int.Parse(daftarPinjaman.Rows[i].ItemArray[6].ToString());
            }
            return totalDenda;
        }

        private void labelInfo()
        {
            if (dgPengembalian.CurrentCellAddress.Y >= 0 && dgPengembalian.CurrentCellAddress.Y < daftarPinjaman.Rows.Count)
            {
                int i, idx = stokKoleksi.Rows.Count;
                for (i = 0; i < idx; i++)
                {
                    if (stokKoleksi.Rows[i].ItemArray[0].ToString() == dgPengembalian.Rows[dgPengembalian.CurrentCellAddress.Y].Cells[2].Value.ToString())
                    {

                        lblDendaKerusakan.Text = stokKoleksi.Rows[i].ItemArray[4].ToString();
                        break;
                    }
                }
                idx = koleksi.Rows.Count;
                for (i = 0; i < idx; i++)
                {
                    if (koleksi.Rows[i].ItemArray[0].ToString() == dgPengembalian.Rows[dgPengembalian.CurrentCellAddress.Y].Cells[0].Value.ToString())
                    {

                        if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_TIDAK_ADA)
                        {
                            lblHargaDendaItem.Text = "0";
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_PER_KATEGORI)
                        {
                            lblHargaDendaItem.Text = koleksi.Rows[i].ItemArray[7].ToString();
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_PER_JUDUL)
                        {
                            lblHargaDendaItem.Text = koleksi.Rows[i].ItemArray[4].ToString();
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_KEDUANYA)
                        {
                            lblHargaDendaItem.Text = (int.Parse(koleksi.Rows[i].ItemArray[4].ToString()) + int.Parse(koleksi.Rows[i].ItemArray[7].ToString())).ToString();
                        }

                        lblJudul.Text = koleksi.Rows[i].ItemArray[2].ToString();
                        lblGenre.Text = koleksi.Rows[i].ItemArray[5].ToString();
                        break;
                    }
                }
            }
            lblJudul.Text = "Judul FIlm";
            lblGenre.Text = "Genre";
            lblHargaDendaItem.Text = "0";
         
        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            frmPeminjamanCariPelanggan formPeminjamanCariPelanggan = new frmPeminjamanCariPelanggan();
            formPeminjamanCariPelanggan.ShowDialog(this);
            txtPeminjam.Text = formPeminjamanCariPelanggan.kodePelangganDipilih;
        }
        private void dgPengembalian_SelectionChanged(object sender, EventArgs e)
        {
            int idx = dipinjam.Rows.Count;
            labelInfo();
        }

        private void cmbKondisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = dgPengembalian.CurrentCellAddress.Y;
            if (y < daftarPinjaman.Rows.Count)
            {
                daftarPinjaman.Rows[y][3] = cmbKondisi.Text;
                if (cmbKondisi.Text == "Buruk")
                {
                    daftarPinjaman.Rows[y][5] = (int.Parse(lblDendaKerusakan.Text) * Program.setting.dendaKerusakan / 100).ToString();
                }
                else if (cmbKondisi.Text == "Baik")
                {
                    daftarPinjaman.Rows[y][5] = 0;
                }
                lblBiayaDenda.Text = hitungTotalDenda().ToString();
            }
            
        }

        private void btnProses_Click(object sender, EventArgs e)
        {       
            int i, idx = dipinjam.Rows.Count, error = 1;
            string newDate = DateTime.Now.Date.ToString().Substring(0, 10);

            for (i = 0; i < idx; i++)
            {
                if (daftarPinjaman.Rows[i].ItemArray[3].ToString() == "Baik" || daftarPinjaman.Rows[i].ItemArray[3].ToString() == "Buruk")
                    error = 0;
            }
            if (error == 0)
            {
                frmBayarKembali formBayarKembali = new frmBayarKembali(lblNmrNota.Text, int.Parse(lblBiayaDenda.Text));
                formBayarKembali.ShowDialog(this);
               
                if (int.Parse(lblBiayaDenda.Text) == 0)
                {                    
                    formBayarKembali.ShowDialog(this);
                }                

                if (formBayarKembali.getHasil() == true)
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
                    frmLaporanNota notaTransaksi = new frmLaporanNota(lblNmrNota.Text);
                    notaTransaksi.ShowDialog(this);

                    daftarPinjaman.Clear();
                    tampilanAwal();
                }
                else
                {
                    tampilanAwal();
                }
            }
            else
            {
                MessageBox.Show("Silahkan update kondisi");
            }   
        }

        private void btnOk_Click(object sender, EventArgs e)
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
                dipinjam = Program.conn.ExecuteDataTable("SELECT stokkoleksi.kodekoleksi, koleksi.namaitem, stokkoleksi.kodestok, koleksi.biayasewafilm, koleksi.biayadendafilm, genre.namakategori, genre.hargasewakategori, genre.hargadendakategori FROM ((dipinjam INNER JOIN stokkoleksi ON dipinjam.kodestok = stokkoleksi.kodestok) INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi) INNER JOIN genre ON koleksi.kodekategori=genre.kodekategori WHERE nonota IN (SELECT nonota FROM (SELECT RANK() OVER (ORDER BY tgltransaksi DESC) AS rank, nota.* FROM nota WHERE kodemember='" + txtPeminjam.Text + "') WHERE rank=1)");
                int i, idx = dipinjam.Rows.Count;
                lblNmrNota.Text = cekPeminjam.Rows[0].ItemArray[0].ToString();
                lblTanggalSeharusnyaKembali.Text = cekPeminjam.Rows[0].ItemArray[5].ToString();
                DateTime tanggalHarusKembali = DateTime.Parse(lblTanggalSeharusnyaKembali.Text);
                TimeSpan tsSelisih = DateTime.Now.Date - tanggalHarusKembali;
                int selisih = tsSelisih.Days; 
               
                lblLamaTelat.Text = selisih.ToString();
                
                // Cek apakah tanggal mengembalikan tidak sama dengan tanggal meminjam
                if (selisih > 0)
                {
                    for (i = 0; i < idx; i++)
                    {
                        if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_TIDAK_ADA)
                        {
                            daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), "", 0, 0, int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + 0);
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_PER_KATEGORI)
                        {
                            daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), "", dipinjam.Rows[i].ItemArray[7].ToString(), 0, int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + 0);
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_PER_JUDUL)
                        {
                            daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), "", dipinjam.Rows[i].ItemArray[4].ToString(), 0, int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + 0);
                        }
                        else if (Program.setting.biayaDendaPer == appSetting.BIAYA_DENDA_KEDUANYA)
                        {
                            daftarPinjaman.Rows.Add(dipinjam.Rows[i].ItemArray[0].ToString(), dipinjam.Rows[i].ItemArray[1].ToString(), dipinjam.Rows[i].ItemArray[2].ToString(), "", (int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + int.Parse(dipinjam.Rows[i].ItemArray[7].ToString())).ToString(), 0, int.Parse(dipinjam.Rows[i].ItemArray[4].ToString()) + 0);
                        }

                    }
                    txtPeminjam.Enabled = false;
                    dgPengembalian.DataSource = daftarPinjaman;
                    dgPengembalian.ReadOnly = true;
                    lblBiayaDenda.Text = hitungTotalDenda().ToString();
                    labelInfo();
                }
                else
                {
                    MessageBox.Show("Tidak diperkenankan mengembalikan barang pada hari yang sama");
                }
            }
        }

        private void txtPeminjam_TextChanged(object sender, EventArgs e)
        {
            if (txtPeminjam.TextLength == 10)
                btnOk_Click(sender, e);
        }

        private void lblLamaTelat_Click(object sender, EventArgs e)
        {

        }

        private void dgPengembalian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

    }
}
