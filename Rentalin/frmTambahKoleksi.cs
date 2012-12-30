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
    public partial class frmTambahKoleksi : Form
    {
        DataTable daftarKoleksi = new DataTable();
        DataTable modify = new DataTable();
        DataTable daftarGenre = new DataTable();
        byte[] imgCoverArt;

        public int mode;
        public string KodeKoleksi;
        public frmTambahKoleksi()
        {
            InitializeComponent();
            mode = 0;
            txtKode.Focus();
        }

        public frmTambahKoleksi(string kodeKoleksi)
        {
            InitializeComponent();
            mode = 1;
            KodeKoleksi = kodeKoleksi;
            txtJudul.Focus();
        }

        public void tampilanAwal()
        {
            // Dispose image agar tidak konflik
            if (picCoverArt.Image != null)
            {
                picCoverArt.Image.Dispose();
            }

            // Tampilkan daftar kategori
            for (int i = 0; i < daftarGenre.Rows.Count; i++)
            {
                cmbKategori.Items.Add(daftarGenre.Rows[i].ItemArray[1].ToString());
            }

            // Tampilkan form sesuai mode
            if(mode == 0)
            {
                //lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang ingin diedit";
                //btnTambahkan.Text = "Tambahkan";
                btnTambahkan.Enabled = false;
                txtKode.ResetText();
                txtJudul.ResetText();
                txtHargaSewa.ResetText();
                txtHargaDenda.ResetText();
                txtDeskripsi.ResetText();
                cmbJenis.ResetText();
                cmbKategori.ResetText();
            }
            else
            {
                lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang ingin disunting";
                btnTambahkan.Text = "Perbarui";
                
                // Query rincian data yang akan dimodifikasi
                modify = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm, namakategori, coverart FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori WHERE kodekoleksi = '" + KodeKoleksi + "'");
                
                txtKode.Text = KodeKoleksi;
                txtKode.Enabled = false;

                // Isi teksboks
                cmbKategori.Text = modify.Rows[0].ItemArray[7].ToString();
                txtJudul.Text = modify.Rows[0].ItemArray[2].ToString();
                txtDeskripsi.Text = modify.Rows[0].ItemArray[3].ToString();
                cmbJenis.Text = modify.Rows[0].ItemArray[4].ToString();
                txtHargaSewa.Text = modify.Rows[0].ItemArray[5].ToString();
                txtHargaDenda.Text = modify.Rows[0].ItemArray[6].ToString();

                // Gambar blob image
                try
                {
                    if (!Convert.IsDBNull(modify.Rows[0].ItemArray[8]))
                    {
                        imgCoverArt = (byte[])modify.Rows[0].ItemArray[8];
                        Program.displayBlobImage(imgCoverArt);
                        picCoverArt.Image = Image.FromFile(Program.IMAGE_FILE_TEMPORARY);
                        picCoverArt.Refresh();

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmTambahKoleksi_Load(object sender, EventArgs e)
        {

            // Query data koleksi dan genre
            daftarKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm FROM koleksi");
            daftarGenre = Program.conn.ExecuteDataTable("SELECT kodekategori, namakategori FROM genre");
            
            tampilanAwal();
            
        }       

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            btnTambahkan.Enabled = true;
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            int i, idx = daftarKoleksi.Rows.Count;

            if(txtKode.Text != "" && txtDeskripsi.Text == "" && txtJudul.Text == "" && cmbJenis.Text == "" && cmbKategori.Text == "" && txtHargaDenda.Text == "" && txtHargaSewa.Text == "")
            {                                 
                if (txtKode.Text.Length != 12)
                {
                    MessageBox.Show("Kode Koleksi harus 12 karakter");
                }
                
                else
                {
                    MessageBox.Show("Detail koleksi tidak lengkap");
                }
                
            }            
            else
            {
                for (i = 0; i < idx; i++)
                {
                    if (txtKode.Text == daftarKoleksi.Rows[i].ItemArray[0].ToString() && mode != 1)
                    {
                        MessageBox.Show("Masukkan Kode Koleksi yang baru");
                        break;
                    }
                }
                if (i == idx)
                {
                    if (mode == 0)
                    {                        
                        //Insert table
                        string kodeKategori = daftarGenre.Rows[cmbKategori.SelectedIndex].ItemArray[0].ToString();
                        string insert = "INSERT into koleksi (kodekoleksi, kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm) VALUES ('"+txtKode.Text+"','"+kodeKategori+"','"+txtJudul.Text+"','"+txtDeskripsi.Text+"','"+cmbJenis.Text+"',"+txtHargaSewa.Text+","+txtHargaDenda.Text+")";
                        Program.conn.ExecuteNonQuery(insert);
                        
                        // Insert BLOB image
                        if (imgCoverArt != null)
                        {
                            Program.conn.ExecuteBlobQuery("UPDATE koleksi SET coverart=:IMG WHERE kodekoleksi='" + txtKode.Text + "'", "IMG", imgCoverArt);
                        }
                        
                        MessageBox.Show("Koleksi sudah ditambahkan");
                        tampilanAwal();
                    }
                    else
                    {
                        // Modify data
                        string kodeKategori = daftarGenre.Rows[cmbKategori.SelectedIndex].ItemArray[0].ToString();
                        string update = "UPDATE koleksi SET kodekoleksi = '" + txtKode.Text + "', kodekategori = '" + kodeKategori + "', namaitem = '" + txtJudul.Text + "', dekripsiitem = '" + txtDeskripsi.Text + "', jenis = '" + cmbJenis.Text + "', biayasewafilm = " + txtHargaSewa.Text + ", biayadendafilm = " + txtHargaDenda.Text + " WHERE kodekoleksi = '" + KodeKoleksi + "'";
                        Program.conn.ExecuteNonQuery(update);

                        // Insert BLOB image
                        if (imgCoverArt != null)
                        {
                            Program.conn.ExecuteBlobQuery("UPDATE koleksi SET coverart=:IMG WHERE kodekoleksi='" + txtKode.Text + "'", "IMG", imgCoverArt);
                        }

                        // OK success
                        MessageBox.Show("Koleksi sudah diperbarui");
                        // Dispose image agar tidak konflik
                        if (picCoverArt.Image != null)
                        {
                            picCoverArt.Image.Dispose();
                        }
                        Close();
                    }
                }
            }
        }

        
        private void validateTextInteger(object sender, EventArgs e)
        {
            Exception X = new Exception();
            TextBox T = (TextBox)sender;
            try
            {
                if (T.Text != "")
                {
                    int x = int.Parse(T.Text);                 
                }
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);
                //Align Cursor to same index
                T.SelectionStart = CursorIndex;
                T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (picCoverArt.Image != null)
            {
                picCoverArt.Image.Dispose();
            }

            // Buka file browser
            opdFIleBrowser.ShowDialog();

            // Ambil nama file dari berkas yang dipilih
            string pathBerkasGambar = opdFIleBrowser.FileName;

            // Tampilkan gambar pada kotak gambar
            picCoverArt.Image = Image.FromFile(pathBerkasGambar);

            // Masukkan ke varibel blob untuk kemudian diproses
            imgCoverArt = Program.getBlobImage(pathBerkasGambar);

            picCoverArt.Image = Image.FromFile(pathBerkasGambar);
            picCoverArt.Refresh();
            

        }

       
        
    }
}
