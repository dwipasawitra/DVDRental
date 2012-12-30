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
            updateStok();
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
            
            dgStokKoleksi.ReadOnly = true;
            btnPilihKoleksi.Enabled = false;
            btnCariKoleksi.Enabled = false;
            txtPilihKoleksi.Enabled = false;
            btnTambah.Enabled = true;
            btnPerbarui.Enabled = false;
            btnHapus.Enabled = true;
            loadInfo();
            //MessageBox.Show("string");
        }

        private void updateStok()
        {
            stok = Program.conn.ExecuteDataTable("SELECT KodeStok, (CASE WHEN Kondisi=0 THEN 'Baik' ELSE 'Buruk' END) as Kondisi, (CASE WHEN Status=1 THEN 'Dipinjam' ELSE 'Tersedia' END) as Status, harga, tglbeli" 
                                                  + " FROM stokkoleksi WHERE kodekoleksi = '" + viewStok + "'");
            
            // Set masing-masing nama kolom
            stok.Columns[0].ColumnName = "Kode Stok";
            stok.Columns[1].ColumnName = "Kondisi";
            stok.Columns[2].ColumnName = "Status";
            stok.Columns[3].ColumnName = "Harga beli";
            stok.Columns[4].ColumnName = "Tgl Beli";

            // Set isi data grid
            dgStokKoleksi.DataSource = stok;
        }

        private void cariStok(string input)
        {
            stok = Program.conn.ExecuteDataTable("SELECT KodeStok, (CASE WHEN Kondisi=0 THEN 'Baik' ELSE 'Buruk' END) as Kondisi, (CASE WHEN Status=1 THEN 'Dipinjam' ELSE 'Tersedia' END) as Status, harga, tglbeli" 
                                                 + " FROM stokkoleksi WHERE kodestok like '%" + txtPencarian.Text + "%'");
            
            // set masing-masing nama kolom
            stok.Columns[0].ColumnName = "Kode Stok";
            stok.Columns[1].ColumnName = "Kondisi";
            stok.Columns[2].ColumnName = "Status";
            stok.Columns[3].ColumnName = "Harga beli";
            stok.Columns[4].ColumnName = "Tgl Beli";


            // jika ada data
            if (stok.Rows.Count > 0)
            {
                // Set isi data grid
                dgStokKoleksi.DataSource = stok;
            }
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
            cariStok(txtPencarian.Text);
        }

        void loadInfo()
        {
            info = Program.conn.ExecuteDataTable("SELECT koleksi.namaitem, genre.namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori WHERE koleksi.kodekoleksi='" + viewStok + "'");
            lblJudul.Text = info.Rows[0].ItemArray[0].ToString();
            lblGenre.Text = info.Rows[0].ItemArray[1].ToString();
        }

        private void frmMasterStok_Load(object sender, EventArgs e)
        {
            txtKodeStok.Enabled = false;
            txtHarga.Enabled = false;
            cmbKondisi.Enabled = false;
            cmbStatus.Enabled = false;
            dtpTglBeli.Enabled = false;

            cmbKondisi.Items.Add("Baik");
            cmbKondisi.Items.Add("Buruk");
            cmbStatus.Items.Add("Tersedia");
            cmbStatus.Items.Add("Dipinjam");
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
            cmbStatus.SelectedIndex = 0;
            cmbKondisi.SelectedIndex = 0;
            btnPerbarui.Text = "Tambahkan";
            txtKodeStok.Focus();
        }

        private void btnModifikasi_Click(object sender, EventArgs e)
        {
            modify = 1;
            btnPerbarui.Text = "Modifikasi";
            if(dgStokKoleksi.SelectedCells.Count >= 1)
            {
                if(dgStokKoleksi.SelectedCells[0].RowIndex <= stok.Rows.Count)
                {
                    int idx = dgStokKoleksi.SelectedCells[0].RowIndex;
                    txtKodeStok.Enabled = false;
                    cmbKondisi.Enabled = true;
                    cmbStatus.Enabled = true;
                    txtHarga.Enabled = true;
                    dtpTglBeli.Enabled = true;
                    btnPerbarui.Enabled = true;

                }
            }

        }

      

        private void btnPilihKoleksi_Click(object sender, EventArgs e)
        {
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '" + txtPilihKoleksi.Text + "'");
            if (stok.Rows.Count > 1)
            {
                updateStok();
                txtPilihKoleksi.ResetText();
                btnTambah.Enabled = true;
                btnModifikasi.Enabled = true;
                btnHapus.Enabled = true;
                btnPilihKoleksi.Enabled = false;
                btnCariKoleksi.Enabled = false;
                txtPilihKoleksi.Enabled = false;
                viewStok = txtPilihKoleksi.Text;
                loadInfo();
            }
            else
            {
                txtPencarian.ResetText();
                MessageBox.Show("Kode Koleksi tidak ada");
            }
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
            if (txtHarga.Text == "Harga Pembelian")
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
            if (txtKodeStok.Text == ""  && cmbKondisi.Text == "" && cmbStatus.Text == "" && txtHarga.Text == "")
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
                        string insert = "INSERT INTO stokkoleksi VALUES('" + txtKodeStok.Text + "','" + viewStok + "'," + cmbKondisi.SelectedIndex + "," + cmbStatus.SelectedIndex + "," + txtHarga.Text + ",'" + Program.convertTglkeOracle(dtpTglBeli.Value) + "')";
                        Program.conn.ExecuteNonQuery(insert);
                        MessageBox.Show("Data berhasil ditambahkan");
                        txtKodeStok.ResetText();
                        cmbKondisi.ResetText();
                        cmbStatus.ResetText();
                        dtpTglBeli.ResetText();
                        txtHarga.ResetText();
                       
                        updateStok();
                    }
                    else if (modify == 1)
                    {                        
                        string update = "UPDATE stokkoleksi SET kondisi = '" + cmbKondisi.SelectedIndex + "', status = '" + cmbStatus.SelectedIndex + "', harga = '" + txtHarga.Text + "', tglbeli = '" + Program.convertTglkeOracle(dtpTglBeli.Value) + "' WHERE kodestok = '" + txtKodeStok.Text + "'";
                        Program.conn.ExecuteNonQuery(update);
                        MessageBox.Show("Data berhasil diperbarui");
                        txtKodeStok.ResetText();
                        cmbKondisi.ResetText();
                        cmbStatus.ResetText();
                        dtpTglBeli.ResetText();
                        txtHarga.ResetText();
                        updateStok();
                    }
                    btnPerbarui.Text = "Modifikasi";
                    txtKodeStok.Enabled = false;
                    cmbKondisi.Enabled = false;
                    cmbStatus.Enabled = false;
                    dtpTglBeli.Enabled = false;
                    txtHarga.Enabled = false;
                    btnPerbarui.Enabled = false;
                }
            }

        }

        private void dgStokKoleksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgStokKoleksi.SelectedCells.Count >= 1)
            {
                if (dgStokKoleksi.SelectedCells[0].RowIndex < stok.Rows.Count)
                {
                    int idx = dgStokKoleksi.SelectedCells[0].RowIndex;
                    btnModifikasi.Enabled = true;
                    btnHapus.Enabled = true;
                    btnHistori.Enabled = true;
                    txtKodeStok.Text = stok.Rows[idx].ItemArray[0].ToString();
                    cmbKondisi.Text = stok.Rows[idx].ItemArray[1].ToString();
                    cmbStatus.Text = stok.Rows[idx].ItemArray[2].ToString();
                    txtHarga.Text = stok.Rows[idx].ItemArray[3].ToString();
                    dtpTglBeli.Value = DateTime.ParseExact(stok.Rows[idx].ItemArray[4].ToString(), "dd/MM/yyyy h:mm:ss", null);
                    
                }
                else
                {
                    btnModifikasi.Enabled = false;
                    btnHapus.Enabled = false;
                    btnHistori.Enabled = false;
                }
            }
        }


        

    }
}
