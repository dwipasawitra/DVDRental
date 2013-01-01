using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentalinKatalog
{
    public partial class frmProsesPesanan : Form
    {
        DataTable pelanggan;
        DataTable pesananAnda;
        public bool isSukses = false;

        public frmProsesPesanan(DataTable pesananAnda)
        {
            InitializeComponent();
            this.pesananAnda = pesananAnda;
        }

        private void muatUlangData()
        {
            // Definisikan data member dan nama kolomnya
            pelanggan = Program.conn.ExecuteDataTable("SELECT kodemember, namamember FROM member");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";


            // Masukkan ke dalam grid
            refreshListBox();
        }

        private void cariData(string yangdicari)
        {
            pelanggan = Program.conn.ExecuteDataTable("SELECT kodemember, namamember FROM member WHERE upper(namamember) like '%" + txtPencarian.Text.ToUpper() + "%' OR upper(kodemember) like '%" + txtPencarian.Text.ToUpper() + "%'");
            pelanggan.Columns[0].ColumnName = "Kode Member";
            pelanggan.Columns[1].ColumnName = "Nama Member";


            // Masukkan ke dalam grid
            refreshListBox();
        }

        private void refreshListBox()
        {
            listBoxPelanggan.Items.Clear();
            for (int i = 0; i < pelanggan.Rows.Count; i++)
            {
                listBoxPelanggan.Items.Add(pelanggan.Rows[i].ItemArray[1].ToString());
            }
        }

        private void frmProsesPesanan_Load(object sender, EventArgs e)
        {
            muatUlangData();
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            cariData(txtPencarian.Text);
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if(listBoxPelanggan.SelectedIndex >= 0)
            {
                string kodeMemberDipilih = pelanggan.Rows[listBoxPelanggan.SelectedIndex].ItemArray[0].ToString();
                // Cek apakah pelanggan sudah meminjam sebelumnya
                DataTable cekPeminjam;
                cekPeminjam = Program.conn.ExecuteDataTable("SELECT * FROM nota WHERE kodemember = '" + kodeMemberDipilih + "' AND tglrealisasikembali IS NULL");
                if (cekPeminjam.Rows.Count > 0)
                {
                    MessageBox.Show("Maaf, Anda masih dalam tahap sedang menyewa di rental ini", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Jika tidak ada, maka isi tabel NotaPending
                    // Buat Kode Pending Nota baru
                    DataTable dataPendingNota, dataPendingDipinjam;
                    int kodePendingNotaTerakhir, kodePendingDipinjamTerakhir;
                    dataPendingNota = Program.conn.ExecuteDataTable("SELECT NoPendingNota FROM PendingNota ORDER BY NoPendingNota DESC");
                    if(dataPendingNota.Rows.Count > 0)
                    {
                        kodePendingNotaTerakhir = Int16.Parse(dataPendingNota.Rows[0].ItemArray[0].ToString());
                        kodePendingNotaTerakhir++;
                    }
                    else
                    {
                        kodePendingNotaTerakhir = 0;
                    }

                    // Diproses (kolom ketiga) diset menjadi 0
                    Program.conn.ExecuteNonQuery("INSERT INTO PendingNota VALUES ('" + kodePendingNotaTerakhir.ToString() + "','" + kodeMemberDipilih + "','0')");

                    // Kemudian isi tabel DipinjamDepending untuk masing-masing item yang dimasukkan
                    for (int i = 0; i < pesananAnda.Rows.Count; i++)
                    {
                        dataPendingDipinjam = Program.conn.ExecuteDataTable("SELECT NoPendingDipinjam FROM PendingDipinjam ORDER BY NoPendingDipinjam DESC");
                        if(dataPendingDipinjam.Rows.Count > 0)
                        {
                            kodePendingDipinjamTerakhir = Int16.Parse(dataPendingDipinjam.Rows[0].ItemArray[0].ToString());
                            kodePendingDipinjamTerakhir++;
                        }
                        else
                        {
                            kodePendingDipinjamTerakhir = 0;
                        }
                        Program.conn.ExecuteNonQuery("INSERT INTO PendingDipinjam VALUES('" + kodePendingDipinjamTerakhir + "','" + kodePendingNotaTerakhir + "','" + pesananAnda.Rows[i].ItemArray[0].ToString() + "')");
                    }

                    // Selesai
                    MessageBox.Show("Pemesanan diproses, silahkan memproses pesanan Anda lebih lanjut kepada operator kami. Terima kasih.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSukses = true;
                    Close();

                }
            }
            else
            {
                MessageBox.Show("Maaf, pelanggan belum dipilih", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
}
