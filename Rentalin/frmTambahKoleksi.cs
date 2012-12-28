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
                lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang \ningin diedit";
                btnTambahkan.Text = "Perbarui";
                modify = Program.conn.ExecuteDataTable("SELECT kodekoleksi, kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm FROM koleksi WHERE kodekoleksi = '" + KodeKoleksi + "'");
                txtKode.Text = KodeKoleksi;
                txtKode.Enabled = false;
                string kodeKategori = "";
                if (modify.Rows[0].ItemArray[1].ToString() == "A001")
                    kodeKategori = "Anime";
                else if (modify.Rows[0].ItemArray[1].ToString() == "A002")
                    kodeKategori = "Action";
                else if (modify.Rows[0].ItemArray[1].ToString() == "A003")
                    kodeKategori = "Adventure";
                else if (modify.Rows[0].ItemArray[1].ToString() == "C001")
                    kodeKategori = "Comedy";
                else if (modify.Rows[0].ItemArray[1].ToString() == "D001")
                    kodeKategori = "Drama";
                else if (modify.Rows[0].ItemArray[1].ToString() == "H001")
                    kodeKategori = "Horror";
                cmbKategori.Text = kodeKategori;
                txtJudul.Text = modify.Rows[0].ItemArray[2].ToString();
                txtDeskripsi.Text = modify.Rows[0].ItemArray[3].ToString();
                cmbJenis.Text = modify.Rows[0].ItemArray[4].ToString();
                txtHargaSewa.Text = modify.Rows[0].ItemArray[5].ToString();
                txtHargaDenda.Text = modify.Rows[0].ItemArray[6].ToString();

            }
        }

        private void frmTambahKoleksi_Load(object sender, EventArgs e)
        {
            
            daftarKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, kodekategori, namaitem, dekripsiitem, jenis, biayasewafilm, biayadendafilm FROM koleksi");
            cmbKategori.Items.Add("Anime");
            cmbKategori.Items.Add("Action");
            cmbKategori.Items.Add("Adventure");
            cmbKategori.Items.Add("Comedy");
            cmbKategori.Items.Add("Drama");
            cmbKategori.Items.Add("Horror");
            cmbJenis.Items.Add("1");
            cmbJenis.Items.Add("2");
            cmbJenis.Items.Add("3");
            MessageBox.Show("asdadsdsasad");
            tampilanAwal();
            MessageBox.Show("asdadsdsasad");
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
        
    }
}
