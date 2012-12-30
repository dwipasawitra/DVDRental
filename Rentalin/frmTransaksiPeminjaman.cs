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

        public void cekPenawaranSpesial()
        {
            
            Program.so.updateSpecialOffer();
            if (Program.so.isSpecialOffer())
            {               
                lblNamaPenawaran.Text = Program.so.getSpecialOfferName() + " " + Program.so.getSpecialOfferDiscount().ToString() + " %";
            }
            else
            {
                lblNamaPenawaran.Text = "Tidak Ada";
            }
        }

        private void hitungTotalBiaya()
        {
            int i, totalBiayaSewa = 0;
            int jumlahBelanjaan = belanja.Rows.Count;
            for (i = 0; i < jumlahBelanjaan; i++)
            {               
                totalBiayaSewa += int.Parse(belanja.Rows[i].ItemArray[4].ToString());// *int.Parse(lblLamaPenyewaan.Text);
            }            
            lblBiayaSewa.Text = totalBiayaSewa.ToString();
            txtTambahJudul.ResetText();
        }

        private string randomNota()
        {
            Random rand = new Random();
            char[] buffer = new char[4];            
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
            return nota;
        }

        private void frmTransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            tampilanAwal();
            cekPenawaranSpesial();
            MessageBox.Show(System.DateTime.Now.Date.ToString());
            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori, hargasewakategori, hargadendakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
            member = Program.conn.ExecuteDataTable("SELECT * FROM member");

            belanja.Columns.Add("Kode Judul");
            belanja.Columns.Add("Judul Film");
            belanja.Columns.Add("Kode Stok");
            belanja.Columns.Add("Sewa Per Hari");
            belanja.Columns.Add("Sewa Total");

            dgPeminjaman.DataSource = belanja;
            dgPeminjaman.ReadOnly = true;
        }

        

        //fungsi merubah label Sewa Denda per hari
        private void labelSewaDenda()
        {
            //DataTable newKoleksi = new DataTable();            
            //newKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM koleksi WHERE kodekoleksi = '" + dgPeminjaman.Rows[dgPeminjaman.CurrentCellAddress.Y].Cells[0].Value.ToString() + "'");
            int i, idx = koleksi.Rows.Count;            
            
            for (i = 0; i < idx; i++)
            {
                if (koleksi.Rows[i].ItemArray[0].ToString() == dgPeminjaman.Rows[dgPeminjaman.CurrentCellAddress.Y].Cells[0].Value.ToString())
                {
                    if (Program.setting.biayaSewaPer == 0)
                    {
                        lblHargaSewaItem.Text = "0"; 
                    }
                    else if (Program.setting.biayaSewaPer == 1)
                    {
                        lblHargaSewaItem.Text = koleksi.Rows[i].ItemArray[6].ToString();
                    }
                    else if (Program.setting.biayaSewaPer == 2)
                    {
                        lblHargaSewaItem.Text = koleksi.Rows[i].ItemArray[3].ToString();
                    }
                    else if (Program.setting.biayaSewaPer == 3)
                    {
                        lblHargaSewaItem.Text = (int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) + int.Parse(koleksi.Rows[i].ItemArray[6].ToString())).ToString();
                    }

                    if (Program.setting.biayaDendaPer == 0)
                    {
                        lblHargaDendaItem.Text = "0";
                    }
                    else if (Program.setting.biayaDendaPer == 1)
                    {
                        lblHargaDendaItem.Text = koleksi.Rows[i].ItemArray[7].ToString();
                    }
                    else if (Program.setting.biayaDendaPer == 2)
                    {
                        lblHargaDendaItem.Text = koleksi.Rows[i].ItemArray[4].ToString();
                    }
                    else if (Program.setting.biayaDendaPer == 3)
                    {
                        lblHargaDendaItem.Text = (int.Parse(koleksi.Rows[i].ItemArray[4].ToString()) + int.Parse(koleksi.Rows[i].ItemArray[7].ToString())).ToString();
                    }
                    
                    lblJudul.Text = koleksi.Rows[i].ItemArray[2].ToString();
                    lblGenre.Text = koleksi.Rows[i].ItemArray[5].ToString();
                    break;
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (Program.setting.maksTransaksi == 1 || belanja.Rows.Count+1  <= Program.setting.maksTransaksiJumlah)
            {
                int i, idx = koleksi.Rows.Count;
                for (i = 0; i < idx; i++)
                {
                    if (txtTambahJudul.Text == koleksi.Rows[i].ItemArray[0].ToString())
                    {
                        stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + txtTambahJudul.Text + "' AND kondisi = 0 AND status = 0");
                        int idx_stok = stokKoleksi.Rows.Count;

                        //menambah daftar belanja
                        if (Program.setting.biayaSewaPer == 0)
                        {
                            if (Program.so.isSpecialOffer())
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), 0, int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                            else
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), 0, int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                        }
                        else if (Program.setting.biayaSewaPer == 1)
                        {
                            if (Program.so.isSpecialOffer())
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), (int.Parse(koleksi.Rows[i].ItemArray[6].ToString()) * (100 - Program.so.getSpecialOfferDiscount()) / 100).ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                            else
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), koleksi.Rows[i].ItemArray[6].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                        }
                        else if (Program.setting.biayaSewaPer == 2)
                        {
                            if (Program.so.isSpecialOffer())
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), (int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * (100 - Program.so.getSpecialOfferDiscount()) / 100).ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                            else
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), koleksi.Rows[i].ItemArray[3].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                        }
                        else if (Program.setting.biayaSewaPer == 3)
                        {
                            if (Program.so.isSpecialOffer())
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), (int.Parse(koleksi.Rows[i].ItemArray[3].ToString()+int.Parse(koleksi.Rows[i].ItemArray[6].ToString()) * (100 - Program.so.getSpecialOfferDiscount()) / 100).ToString()), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                            else
                            {
                                belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[2].ToString(), stokKoleksi.Rows[0].ItemArray[0].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString())+int.Parse(koleksi.Rows[i].ItemArray[6].ToString()), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()) * int.Parse(lblLamaPenyewaan.Text));
                            }
                        }                        

                        MessageBox.Show("Data berhasil ditambahkan");
                        btnProses.Enabled = true;
                        btnHapus.Enabled = true;
                        if (dgPeminjaman.Rows.Count == 2)
                        {
                            int l;
                            cmbStok.Items.Clear();
                            for (l = 0; l < idx_stok; l++)
                            {
                                cmbStok.Items.Add(stokKoleksi.Rows[l].ItemArray[0].ToString());
                            }
                            cmbStok.Text = stokKoleksi.Rows[0].ItemArray[0].ToString();
                            labelSewaDenda();
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
            else
            {
                MessageBox.Show("Maaf jumlah terbatas");
                txtTambahJudul.Enabled = false;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DataTable cekPeminjam = new DataTable();
            cekPeminjam = Program.conn.ExecuteDataTable("SELECT * FROM nota WHERE kodemember = '" + txtPeminjam.Text + "' AND tglrealisasikembali IS NULL");
            int cek = cekPeminjam.Rows.Count;
            if (cek != 0)
            {
                MessageBox.Show("Member tidak bisa melakukan peminjaman");
                txtPeminjam.ResetText();
                txtPeminjam.Focus();
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
                        lblIdentitas.Text += member.Rows[i].ItemArray[3].ToString();
                        txtTambahJudul.Enabled = true;
                        //btnCariJudul.Enabled = true;
                        btnTambah.Enabled = true;
                        txtPeminjam.Enabled = false;
                        btOk.Enabled = false;
                        btnCariJudul.Enabled = true;
                        txtTambahJudul.Focus();
                        break;
                    }
                }
                if (i == idx)
                {
                    MessageBox.Show("Member tidak ditemukan");
                    txtPeminjam.ResetText();
                    txtPeminjam.Focus();
                }
            }
        }

        private void cmbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = dgPeminjaman.CurrentCellAddress.Y;
            belanja.Rows[y][2] = cmbStok.Text;
        }

        private void dgPeminjaman_SelectionChanged(object sender, EventArgs e)
        {
            //int x = e.ColumnIndex;
            int y = dgPeminjaman.CurrentCellAddress.Y;
            if (y < belanja.Rows.Count && y>= 0)
            {
                lblJudul.Text = dgPeminjaman.Rows[y].Cells[1].Value.ToString();

                stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + dgPeminjaman.Rows[y].Cells[0].Value.ToString() + "' AND kondisi = 0 AND status = 0");
                int i, idx = stokKoleksi.Rows.Count, index = koleksi.Rows.Count;
                cmbStok.Items.Clear();
                for (i = 0; i < idx; i++)
                {
                    cmbStok.Items.Add(stokKoleksi.Rows[i].ItemArray[0].ToString());
                }
                cmbStok.Text = belanja.Rows[y].ItemArray[2].ToString();

                labelSewaDenda();
            }
        }   

        private void dgPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            string insertNota = "INSERT INTO nota (nonota,kodeoperator,kodepenawaranspesial,kodemember,tgltransaksi,tglkembali)VALUES ('" + lblNmrNota.Text + "','" + Program.session.getKodeOperator().ToString() + "',"+Program.so.getSpecialOfferCode()+",'" + lblKodeMember.Text + "',to_date('" + newDate + "','mm/dd/yyyy'),to_date('" + newTglKembali + "','mm/dd/yyyy'))";
            Program.conn.ExecuteNonQuery(insertNota);
            string kodeDipinjam = randomNota();
            int i, idx = belanja.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                string insertDipinjam = "INSERT INTO dipinjam (kodedipinjam, kodestok, nonota, hargasewa) VALUES('" + randomNota() + "','" + belanja.Rows[i].ItemArray[2].ToString() + "','" + lblNmrNota.Text + "',"+int.Parse(belanja.Rows[i].ItemArray[4].ToString())+")";
                Program.conn.ExecuteNonQuery(insertDipinjam);
                string updateStok = "UPDATE stokkoleksi SET status = 1 WHERE kodestok = '" + belanja.Rows[i].ItemArray[2].ToString() + "'";
                Program.conn.ExecuteNonQuery(updateStok);
            }
            MessageBox.Show("Transaksi Berhasil");
            tampilanAwal();
        }

        private void tampilanAwal()
        {            
            belanja.Clear();
            btOk.Enabled = true;
            txtPeminjam.Enabled = true;
            txtPeminjam.ResetText();
            lblNmrNota.Text = "Kode Nota";
            lblNamaPeminjam.Text = "Nama Peminjam";
            lblKodeMember.Text = "Kode Member";
            txtTambahJudul.Enabled = false;
            btnTambah.Enabled = false;
            btnProses.Enabled = false;
            btnCariJudul.Enabled = false;
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            lblHargaSewaItem.Text = "0";
            lblHargaDendaItem.Text = "0";
            cmbStok.Items.Clear();
            cmbStok.ResetText();
            dtpTanggalKembali.ResetText();
            lblNmrNota.ResetText();
            lblNmrNota.Text = randomNota();
            lblLamaPenyewaan.Text = "0";
            lblBiayaSewa.Text = "0";
            lblIdentitas.Text = "Identitas: ";
            btnHapus.Enabled = false;
        }
        private void dtpTanggalKembali_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dgPeminjaman.Rows.Count.ToString());
            int lamaPenyewaan = dtpTanggalKembali.Value.Day - DateTime.Now.Day;
            if (lamaPenyewaan < 0)
                lamaPenyewaan = 0;
            lblLamaPenyewaan.Text = lamaPenyewaan.ToString();
            int i, idx = dgPeminjaman.Rows.Count;
            for (i = 0; i < idx-1; i++)
            {
                belanja.Rows[i][4] = int.Parse(belanja.Rows[i].ItemArray[3].ToString()) * lamaPenyewaan;
            }
            hitungTotalBiaya();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampilanAwal();
        }

        private void lblLamaPenyewaan_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void dgPeminjaman_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (belanja.Rows.Count < 2)
            {                
                btnHapus.Enabled = false;
            }             
        }

        private void btnCariJudul_Click(object sender, EventArgs e)
        {
            frmPeminjamanCariJudul formPeminjamanCariJudul = new frmPeminjamanCariJudul();
            formPeminjamanCariJudul.ShowDialog(this);
        }

        private void txtTambahJudul_TextChanged(object sender, EventArgs e)
        {
            if (txtTambahJudul.TextLength == 12)
                btnTambah_Click(sender,e);
        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            frmPeminjamanCariPelanggan formPeminjamanCariPelanggan = new frmPeminjamanCariPelanggan();
            formPeminjamanCariPelanggan.ShowDialog(this);
        }       
    }
}
