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
    public partial class frmMasterKategori : Form
    {
        public frmMasterKategori()
        {
            InitializeComponent();
        }

       DataTable dataKategori;

        private int modePengaturanDipilih;
        private string kodeDipilih;
        private const int MODE_PENGATURAN_LIHATDATA = -1;
        private const int MODE_PENGATURAN_TAMBAH = 0;
        private const int MODE_PENGATURAN_MODIFIKASI = 1;


        private void loadData()
        {
          
            dataKategori = Program.conn.ExecuteDataTable("SELECT * FROM Genre");
            
            // Set nama kolom
            dataKategori.Columns[0].ColumnName = "Kode";
            dataKategori.Columns[1].ColumnName = "Nama";
            dataKategori.Columns[2].ColumnName = "Sewa";
            dataKategori.Columns[3].ColumnName = "Denda";

            // Tampilkan pada grid
            dgKategori.DataSource = dataKategori;

            // Done
        }
       

        private void modePengaturan(int mode)
        {
            // Simpan mode pengaturan saat ini
            modePengaturanDipilih = mode;

            // Lakukan sesuai mode
            switch (mode)
            {
                case MODE_PENGATURAN_LIHATDATA:
                    txtKode.ResetText();
                    txtNama.ResetText();
                    txtHargaPerKategori.ResetText();
                    txtDendaPerKategori.ResetText();
                    dgKategori.Enabled = true;
                    txtKode.Enabled = false;
                    txtNama.Enabled = false;
                    txtHargaPerKategori.Enabled = false;
                    txtDendaPerKategori.Enabled = false;
                    btnTambahModifikasi.Text = "Modifikasi";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Kategori Baru";
                    break;
                case MODE_PENGATURAN_TAMBAH:
                    txtKode.ResetText();
                    txtNama.ResetText();
                    txtHargaPerKategori.ResetText();
                    txtDendaPerKategori.ResetText();
                    dgKategori.Enabled = true;
                    txtKode.Enabled = true;
                    txtNama.Enabled = true;
                    txtHargaPerKategori.Enabled = true;
                    txtDendaPerKategori.Enabled = true;
                    btnTambahModifikasi.Text = "Tambahkan";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Batalkan Penambahan";
                    break;
                case MODE_PENGATURAN_MODIFIKASI:
                    dgKategori.Enabled = false;
                    txtKode.Enabled = true;
                    txtNama.Enabled = true;
                    txtHargaPerKategori.Enabled = true;
                    txtDendaPerKategori.Enabled = true;
                    btnTambahModifikasi.Text = "Modifikasi";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Batalkan Perubahan";
                    break;
            }
        }
      

        private void dgPenawaranMenarik_SelectionChanged(object sender, EventArgs e)
        {
            // Ketika seleksi berubah, tampilkan data pada panel pengaturan
            if(dgKategori.SelectedCells.Count > 0)
            {
                if(dgKategori.SelectedCells[0].RowIndex < dataKategori.Rows.Count)
                {
                    int idx = dgKategori.SelectedCells[0].RowIndex;
                    txtKode.Text = dataKategori.Rows[idx].ItemArray[0].ToString();
                    txtNama.Text = dataKategori.Rows[idx].ItemArray[1].ToString();
                    txtHargaPerKategori.Text = dataKategori.Rows[idx].ItemArray[2].ToString();
                    txtDendaPerKategori.Text = dataKategori.Rows[idx].ItemArray[3].ToString();
                    kodeDipilih = dataKategori.Rows[idx].ItemArray[0].ToString();
                    
                }
            }


            
        }

        private bool validasiDataFormPengaturan()
        {
            if (txtNama.Text == "" && txtKode.Text.Length < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void btnTambahModifikasi_Click(object sender, EventArgs e)
        {
            // Lihat mode pengaturan dan lakukan tugas masing-masing
            switch (modePengaturanDipilih)
            {
                case MODE_PENGATURAN_LIHATDATA:
                    // Ubah ke mode modifikasi data
                    modePengaturan(MODE_PENGATURAN_MODIFIKASI);

                    // OK selesai
                    break;
                case MODE_PENGATURAN_TAMBAH:
                    // Validasi data yang diinput
                    if (validasiDataFormPengaturan())
                    {
     

                        // Query INSERT
                        Program.conn.ExecuteNonQuery("INSERT INTO Genre VALUES('" + Program.escapeQuoteSQL(txtKode.Text)
                                                     + "','" + Program.escapeQuoteSQL(txtNama.Text) + "','" + Program.escapeQuoteSQL(txtHargaPerKategori.Text) + "','"
                                                     + Program.escapeQuoteSQL(txtDendaPerKategori.Text) + "')");

                        // Kembali ke mode normal
                        loadData();
                        modePengaturan(MODE_PENGATURAN_LIHATDATA);

                    }
                    else
                    {
                        MessageBox.Show("Nama atau kode belum diisi", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case MODE_PENGATURAN_MODIFIKASI:
                    if (validasiDataFormPengaturan())
                    {
                        // Jika input benar, update ke basis data
      

                        // Query UPDATE
                        Program.conn.ExecuteNonQuery("UPDATE genre SET KodeKategori='" + txtKode.Text + "', NamaKategori='" + txtNama.Text
                                                     + "', HargaSewaKategori='" + txtHargaPerKategori.Text + "', HargaDendaKategori='" + txtDendaPerKategori.Text
                                                     + "' WHERE KodeKategori='" + kodeDipilih + "'");

                        // Kembali ke mode normal
                        loadData();
                        modePengaturan(MODE_PENGATURAN_LIHATDATA);
                    }
                    else
                    {
                        MessageBox.Show("Nama tidak atau kode belum diisi", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                
            }
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            if (modePengaturanDipilih == MODE_PENGATURAN_LIHATDATA)
            {
                modePengaturan(MODE_PENGATURAN_TAMBAH);
            }
            else
            {
                modePengaturan(MODE_PENGATURAN_LIHATDATA);
                loadData();
            }
        }

        

        private void frmMasterKategori_Load(object sender, EventArgs e)
        {
            // Default, lihat data
            modePengaturan(MODE_PENGATURAN_LIHATDATA);

            // Load data
            loadData();

            // Okay
        }
    }

}
