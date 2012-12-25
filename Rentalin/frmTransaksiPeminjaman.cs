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
        public class peminjaman
        {
            private string kodeJudul, judulFilm, kodeStok;
            private int sewaPerHari, dendaPerHari;
            public peminjaman(string kode_judul, string judul_film, string kode_stok, int sewa, int denda)
            {
                kodeJudul = kode_judul;
                judulFilm = judul_film;
                kodeStok = kode_stok;
                sewaPerHari = sewa;
                dendaPerHari = denda;
            }
            
            public string Kode_Judul
            {
                get { return kodeJudul; }
            }
            public string Judul_Film
            {
                get { return judulFilm; }
            }
            public string Kode_Stok
            {
                get { return kodeStok; }
            }
            public int Sewa_Per_Hari
            {
                get { return sewaPerHari; }
            }
            public int Denda_Per_Hari
            {
                get { return dendaPerHari; }
            }
        }
        //List<peminjaman> Peminjaman = new List<peminjaman>();
        DataTable belanja = new DataTable();
        /*DataColumn col1 = new DataColumn();//("Kode Judul");
        DataColumn col2 = new DataColumn();//("Judul Film");
        DataColumn col3 = new DataColumn();//("Kode Stok");
        DataColumn col4 = new DataColumn();//("Sewa");
        DataColumn col5 = new DataColumn();//("Denda");*/
        //DataRow row = new DataRow();
        


        DataTable koleksi = new DataTable();
        DataTable member = new DataTable();
        DataTable stokKoleksi = new DataTable();
        
        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void frmTransaksiPeminjaman_Load(object sender, EventArgs e)
        {
            //menset label sewa dan denda per hari
            //dgPeminjaman.DataSource = Peminjaman;

            koleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori");
            member = Program.conn.ExecuteDataTable("SELECT * FROM member");

            /*col1.DataType = System.Type.GetType("System.String");
            col2.DataType = System.Type.GetType("System.String");
            col3.DataType = System.Type.GetType("System.String");
            col4.DataType = System.Type.GetType("System.Int");
            col5.DataType = System.Type.GetType("System.Int");*/
            belanja.Columns.Add("Kode Judul");
            belanja.Columns.Add("Judul Film");
            belanja.Columns.Add("Kode Stok");
            belanja.Columns.Add("Sewa");
            belanja.Columns.Add("Denda");
            //DataRow row = belanja.NewRow();*/
            
            //belanja.Columns[0]. = "asd";
            dgPeminjaman.DataSource = belanja;
            //belanja.c
            //dgPeminjaman.ReadOnly = true;
            txtTambahJudul.Enabled = false;
            btnCariJudul.Enabled = false;
            btnTambah.Enabled = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
            int i, idx = koleksi.Rows.Count;
            

            for (i = 0; i < idx; i++)
            {
                if (txtTambahJudul.Text == koleksi.Rows[i].ItemArray[0].ToString())
                {
                    stokKoleksi = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+txtTambahJudul.Text+"'");
                    int j, idx_stok = stokKoleksi.Rows.Count;
                    
                    
                    for (j = 0; j < idx_stok; j++)
                    {
                        if (stokKoleksi.Rows[j].ItemArray[2].ToString() == "0" && stokKoleksi.Rows[j].ItemArray[3].ToString() == "0")
                        {
                            
                            //Peminjaman.Add(new peminjaman(txtTambahJudul.Text,koleksi.Rows[i].ItemArray[1].ToString(),stokKoleksi.Rows[j].ItemArray[0].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()), int.Parse(koleksi.Rows[i].ItemArray[4].ToString())));
                            //dgPeminjaman.DataSource = Peminjaman;
                            //row = belanja.NewRow();
                            /*row[col1] = txtTambahJudul.Text;
                            row[col2] = koleksi.Rows[i].ItemArray[1].ToString();
                            row[col3] = stokKoleksi.Rows[j].ItemArray[0].ToString();
                            row[col4] = int.Parse(koleksi.Rows[i].ItemArray[3].ToString());
                            row[col5] = int.Parse(koleksi.Rows[i].ItemArray[4].ToString());*/

                            belanja.Rows.Add(txtTambahJudul.Text, koleksi.Rows[i].ItemArray[1].ToString(), stokKoleksi.Rows[j].ItemArray[0].ToString(), int.Parse(koleksi.Rows[i].ItemArray[3].ToString()), int.Parse(koleksi.Rows[i].ItemArray[4].ToString()));
                            
                            //belanja.Rows.ItemArray[0] = txtTambahJudul.Text;
                            //belanja.Rows[0].ItemArray[0] = txtTambahJudul.Text;
                            
                            dgPeminjaman.ReadOnly = true;
                            dgPeminjaman.DataSource = belanja;
                            MessageBox.Show("Data berhasil ditambahkan");
                            //MessageBox.Show(dgPeminjaman.Rows.Count.ToString());
                            if (dgPeminjaman.Rows.Count == 2)
                            {
                                //MessageBox.Show("asdasd");
                                int l;
                                for (l = 0; l < idx_stok; l++)
                                {
                                    cmbStok.Items.Add(stokKoleksi.Rows[l].ItemArray[0].ToString());
                                    //cmbStok.AutoCompleteCustomSource.Add(stokKoleksi.Rows[j].ItemArray[0].ToString());
                                }
                                cmbStok.Text = stokKoleksi.Rows[j].ItemArray[0].ToString();
                            }
                            break;
                        }
                    }
                    

                    break;
                }
            }
            if (i == idx)
            {
                MessageBox.Show("Data tidak ditemukan!");
            }              
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int i, idx = member.Rows.Count;
            for (i = 0; i < idx; i++)
            {
                if (txtPeminjam.Text == member.Rows[i].ItemArray[0].ToString())
                {
                    lblNamaPeminjam.Text = member.Rows[i].ItemArray[1].ToString();
                    //lblIdentitas.Text = "Identitas: "+ member.Rows[i].ItemArray[
                    txtTambahJudul.Enabled = true;
                    btnCariJudul.Enabled = true;
                    btnTambah.Enabled = true;
                    break;
                }
            }
        }

        private void cmbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("berubah");
            //dgPeminjaman.ReadOnly = false;
            int y = dgPeminjaman.CurrentCellAddress.Y;
            //Peminjaman[y].Kode_Stok = cmbStok.Text;
            //belanja.Rows[y].ItemArray[2] = cmbStok.Text;
            belanja.Rows[y][2] = cmbStok.Text;
            //MessageBox.Show(belanja.Rows[y].ItemArray[2].ToString());
            dgPeminjaman.DataSource = belanja;
        }

        private void dgPeminjaman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            //MessageBox.Show(y.ToString());
            MessageBox.Show(belanja.Rows[y].ItemArray[2].ToString());
            //cmbStok.Text = stokKoleksi.Rows[y].ItemArray[0].ToString();
        }
    }
}
