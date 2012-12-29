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
                txtCoverArt.ResetText();
                cmbJenis.ResetText();
                cmbKategori.ResetText();
            }
            else
            {
                lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang ingin disunting";
                btnTambahkan.Text = "Perbarui";
                
                // Query rincian data yang akan dimodifikasi
                modify = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm, namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori WHERE kodekoleksi = '" + KodeKoleksi + "'");
                
                txtKode.Text = KodeKoleksi;
                txtKode.Enabled = false;

                cmbKategori.Text = modify.Rows[0].ItemArray[7].ToString();
                
                txtJudul.Text = modify.Rows[0].ItemArray[2].ToString();
                
                txtDeskripsi.Text = modify.Rows[0].ItemArray[3].ToString();
                
                cmbJenis.Text = modify.Rows[0].ItemArray[4].ToString();
                
                txtHargaSewa.Text = modify.Rows[0].ItemArray[5].ToString();
                
                txtHargaDenda.Text = modify.Rows[0].ItemArray[6].ToString();

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
                        string kodeKategori= "";
                        if(cmbKategori.Text == "Anime")
                            kodeKategori = "A001";
                        else if(cmbKategori.Text == "Action")
                            kodeKategori = "A002";
                        else if(cmbKategori.Text == "Adventure")
                            kodeKategori = "A003";
                        else if(cmbKategori.Text == "Comedy")
                            kodeKategori = "C001";
                        else if(cmbKategori.Text == "Drama")
                            kodeKategori = "D001";
                        else if(cmbKategori.Text == "Horror")
                            kodeKategori = "H001";
                        string insert = "INSERT into koleksi (kodekoleksi, kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm) VALUES ('"+txtKode.Text+"','"+kodeKategori+"','"+txtJudul.Text+"','"+txtDeskripsi.Text+"','"+cmbJenis.Text+"',"+txtHargaSewa.Text+","+txtHargaDenda.Text+")";
                        Program.conn.ExecuteNonQuery(insert);
                        MessageBox.Show("Koleksi sudah ditambahkan");
                        tampilanAwal();
                    }
                    else
                    {                        
                        //Update table
                        string kodeKategori = "";
                        if (cmbKategori.Text == "Anime")
                            kodeKategori = "A001";
                        else if (cmbKategori.Text == "Action")
                            kodeKategori = "A002";
                        else if (cmbKategori.Text == "Adventure")
                            kodeKategori = "A003";
                        else if (cmbKategori.Text == "Comedy")
                            kodeKategori = "C001";
                        else if (cmbKategori.Text == "Drama")
                            kodeKategori = "D001";
                        else if (cmbKategori.Text == "Horror")
                            kodeKategori = "H001";
                        string update = "UPDATE koleksi SET kodekoleksi = '" + txtKode.Text + "', kodekategori = '" + kodeKategori + "', namaitem = '" + txtJudul.Text + "', dekripsiitem = '" + txtDeskripsi.Text + "', jenis = '" + cmbJenis.Text + "', biayasewafilm = " + txtHargaSewa.Text + ", biayadendafilm = " + txtHargaDenda.Text + " WHERE kodekoleksi = '" + KodeKoleksi + "'";
                        Program.conn.ExecuteNonQuery(update);
                        MessageBox.Show("Koleksi sudah diperbarui");
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

        }
        
    }
}
