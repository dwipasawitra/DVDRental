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
    public partial class frmMasterStok : Form
    {
        DataTable stok = new DataTable();
        DataTable pencarian = new DataTable();
        DataTable info = new DataTable();
        public int mode;
        public int modify;
        public string viewStok;
        public frmMasterStok()
        {
            InitializeComponent();
            tampilanAwal();
        }        

        public frmMasterStok(string kodeKoleksi)
        {
            InitializeComponent();
            viewStok = kodeKoleksi;
            tampilanAwal(kodeKoleksi);
        }

        public void tampilanAwal()
        {
            mode = 0;
            //stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi");
            //dgStokKoleksi.DataSource = stok;
            //dgStokKoleksi.ReadOnly = true;
            //MessageBox.Show("no string");
            btnModifikasi.Enabled = false;
            btnHapus.Enabled = false;
            txtPencarian.Enabled = false;
            txtPilihKoleksi.Focus();
            btnTambah.Enabled = false;
            btnPerbarui.Enabled = false;
            txtPilihKoleksi.Focus();
        }

        public void tampilanAwal(string KodeKoleksi)
        {
            mode = 1;
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + KodeKoleksi + "'");
            dgStokKoleksi.DataSource = stok;
            dgStokKoleksi.ReadOnly = true;
            btnPilihKoleksi.Enabled = false;
            txtPilihKoleksi.Enabled = false;
            btnTambah.Enabled = true;
            btnPerbarui.Enabled = false;
            btnHapus.Enabled = true;
            //MessageBox.Show("string");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgStokKoleksi.CurrentCellAddress.Y;
            string delete = "DELETE FROM stokkoleksi WHERE kodestok = '" + stok.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            stok.Rows[rows].Delete();
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            pencarian = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodestok like '%" + txtPencarian.Text + "%' OR kodekoleksi like '%" + txtPencarian.Text + "%'");// OR kondisi =" + txtPencarian.Text + " OR status = " + txtPencarian.Text + " OR harga like = " + txtPencarian.Text + "");// OR tglbeli like '%" + txtPencarian.Text + "%'");
            if (pencarian.Rows.Count > 0)
            {
                //MessageBox.Show("berhasil");
                dgStokKoleksi.DataSource = pencarian;
            }
        }

        private void frmMasterStok_Load(object sender, EventArgs e)
        {
            info = Program.conn.ExecuteDataTable("SELECT stokkoleksi.kodestok, stokkoleksi.kodekoleksi, koleksi.namaitem, stokkoleksi.kondisi, stokkoleksi.status, stokkoleksi.harga, stokkoleksi.tglbeli, genre.namakategori FROM stokkoleksi INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
            txtKodeStok.Enabled = false;
            txtKodeKoleksi.Enabled = false;
            txtHarga.Enabled = false;
            cmbKondisi.Enabled = false;
            cmbStatus.Enabled = false;
            dtpTglBeli.Enabled = false;
            cmbKondisi.Items.Add("0");
            cmbKondisi.Items.Add("1");
            cmbStatus.Items.Add("0");
            cmbStatus.Items.Add("1");
            //lblJudul.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[
        }

        private void dgStokKoleksi_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (stok.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
                btnModifikasi.Enabled = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            modify = 0;
            txtKodeStok.Enabled = true;            
            cmbStatus.Enabled = true;
            cmbKondisi.Enabled = true;
            dtpTglBeli.Enabled = true;
            txtHarga.Enabled = true;
            btnPerbarui.Enabled = true;
            txtKodeKoleksi.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            modify = 1;
            txtKodeStok.Enabled = false;
            txtKodeStok.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[0].Value.ToString();
            txtKodeKoleksi.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[1].Value.ToString();
            cmbKondisi.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[2].Value.ToString();
            cmbStatus.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[3].Value.ToString();
            txtHarga.Text = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[4].Value.ToString();

            cmbKondisi.Enabled = true;
            cmbStatus.Enabled = true;
            txtHarga.Enabled = true;
            dtpTglBeli.Enabled = true;
            btnPerbarui.Enabled = true;

            string date = dgStokKoleksi.Rows[dgStokKoleksi.CurrentCellAddress.Y].Cells[5].Value.ToString();
            date = date.Substring(0, 10);
            string newDate = "";

            if (date.Substring(1, 1) == "/" && date.Substring(3, 1) == "/")
            {
                newDate = "0";
                newDate += date.Substring(0, 2);
                newDate += "0";
                newDate += date.Substring(3, 5);
            }
            else if (date.Substring(1, 1) == "/" && date.Substring(4, 1) == "/")
            {
                newDate = "0";
                newDate += date.Substring(0, 9);
            }
            else if (date.Substring(2, 1) == "/" && date.Substring(4, 1) == "/")
            {
                newDate = date.Substring(0, 3);
                newDate += "0";
                newDate += date.Substring(3, 6);
            }
            else
                newDate = date.Substring(0, 10);

            dtpTglBeli.Value = DateTime.ParseExact(newDate, "MM/dd/yyyy",null);


        }

        private void dgStokKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            btnModifikasi.Enabled = true;
            int i, idx = info.Rows.Count;
            MessageBox.Show("jumlah" + idx.ToString());
            for(i=0;i<idx;i++)
            {
                if (dgStokKoleksi.Rows[y].Cells[1].Value.ToString() == info.Rows[i].ItemArray[1].ToString())
                {
                    lblJudul.Text = info.Rows[i].ItemArray[2].ToString();
                    lblGenre.Text = info.Rows[i].ItemArray[7].ToString();
                    break;
                }
            }
        }

        private void btnPilihKoleksi_Click(object sender, EventArgs e)
        {
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+txtPilihKoleksi.Text+"'");
            if (stok.Rows.Count > 1)
            {
                dgStokKoleksi.DataSource = stok;
                txtPilihKoleksi.ResetText();
                btnTambah.Enabled = true;
                btnModifikasi.Enabled = true;
                btnHapus.Enabled = true;
            }
            else
            {
                txtPencarian.ResetText();
                MessageBox.Show("Kode Koleksi tidak ada");
            }            
        }

        private void txtKodeStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKodeStok_Enter(object sender, EventArgs e)
        {
            if (txtKodeStok.Text == "Kode Stok")
                txtKodeStok.Text = "";
        }

        private void txtKodeStok_Leave(object sender, EventArgs e)
        {
            if (txtKodeStok.Text == "")
                txtKodeStok.Text = "Kode Stok";
        }

        private void txtHarga_Enter(object sender, EventArgs e)
        {
            if (txtHarga.Text == "Harga")
                txtHarga.Text = "";
        }

        private void txtHarga_Leave(object sender, EventArgs e)
        {
            if (txtHarga.Text == "")
                txtHarga.Text = "Harga";
        }
        private void lblInfoDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblPencarian_Click(object sender, EventArgs e)
        {

        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            int i, idx = info.Rows.Count;
            if (txtKodeStok.Text == "" && txtKodeKoleksi.Text == "" && cmbKondisi.Text == "" && cmbStatus.Text == "" && txtHarga.Text == "")
            {
                MessageBox.Show("Ada informasi yang kosong");
            }
            else if (txtKodeStok.TextLength != 12)
            {
                MessageBox.Show("Kode Stok harus 12 karakter");
            }
            else
            {
                for (i = 0; i < idx; i++)
                {
                    if (info.Rows[i].ItemArray[0].ToString() == txtKodeStok.Text && modify == 0)
                    {
                        MessageBox.Show("Kode Stok tidak bisa diterima");
                        break;
                    }
                }
                if (i == idx)
                {
                    if (modify == 0)
                    {
                        string insert = "INSERT INTO stokkoleksi VALUES('" + txtKodeStok.Text + "','" + txtKodeKoleksi.Text + "'," + cmbKondisi.Text + "," + cmbStatus.Text + "," + txtHarga.Text + ",to_date('" + dtpTglBeli.Value.Date.ToString().Substring(0, 10) + "','mm/dd/yyyy'))";
                        Program.conn.ExecuteNonQuery(insert);
                        MessageBox.Show("Data berhasil ditambahkan");
                        txtKodeStok.ResetText();
                        cmbKondisi.ResetText();
                        cmbStatus.ResetText();
                        dtpTglBeli.ResetText();
                        txtHarga.ResetText();
                        pencarian = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+txtKodeKoleksi.Text+"'");
                        dgStokKoleksi.DataSource = pencarian;
                    }
                    else if (modify == 1)
                    {                        
                        string update = "UPDATE stokkoleksi SET kondisi = " + cmbKondisi.Text + ", status = " + cmbStatus.Text + ", harga = " + txtHarga.Text + ", tglbeli = to_date('" + dtpTglBeli.Value.Date.ToString().Substring(0, 10) + "','MM/dd/yyyy') WHERE kodestok = '" + txtKodeStok.Text + "'";
                        Program.conn.ExecuteNonQuery(update);
                        MessageBox.Show("Data berhasil diperbarui");
                        txtKodeStok.ResetText();
                        cmbKondisi.ResetText();
                        cmbStatus.ResetText();
                        dtpTglBeli.ResetText();
                        txtHarga.ResetText();
                        pencarian = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + txtKodeKoleksi.Text + "'");
                        dgStokKoleksi.DataSource = pencarian;
                    }                    
                }
            }

        }

        
    }
}
