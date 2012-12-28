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
        public int mode;
        public frmTambahKoleksi()
        {
            InitializeComponent();
            mode = 0;
        }

        public frmTambahKoleksi(string kodeKoleksi)
        {
            InitializeComponent();
            mode = 1;
            
        }

        public void tampilanAwal()
        {
            if(mode == 0)
            {
                //lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang ingin diedit";
                //btnTambahkan.Text = "Tambahkan";
                btnTambahkan.Enabled = false;
            }
            else
            {
                lblTambahKoleksi.Text = "Silahkan mengubah detail koleksi yang ingin diedit";
                btnTambahkan.Text = "Perbarui";                
            }
        }

        private void frmTambahKoleksi_Load(object sender, EventArgs e)
        {
            daftarKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM koleksi");
            cmbKategori.Items.Add("Anime");
            cmbKategori.Items.Add("Action");
            cmbKategori.Items.Add("Adventure");
            cmbKategori.Items.Add("Comedy");
            cmbKategori.Items.Add("Drama");
            cmbKategori.Items.Add("Horror");
            cmbJenis.Items.Add("1");
            cmbJenis.Items.Add("2");
            cmbJenis.Items.Add("3");
            tampilanAwal();
        }       

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            btnTambahkan.Enabled = true;
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            int i, idx = daftarKoleksi.Rows.Count;

            if(txtKode.Text != "" && txtDeskripsi.Text == "" && txtJudul.Text == "" && cmbJenis.Text == "" && cmbKategori.Text == "")
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
                    if (txtKode.Text == daftarKoleksi.Rows[i].ItemArray[0].ToString())
                    {
                        MessageBox.Show("Masukkan Kode Koleksi yang baru");
                        break;
                    }
                }
                if (i == idx)
                {
                    if (mode == 0)
                    {
                        MessageBox.Show("Koleksi sudah ditambahkan");
                        //Insert table
                        //string insert = "INSERT into kol
                    }
                    else
                    {
                        MessageBox.Show("Koleksi sudah diperbarui");
                        //Update table
                    }
                }
            }
        }
    }
}
