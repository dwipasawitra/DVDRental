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
    public partial class frmPenawaranMenarik : Form
    {
        DataTable dataPenawaranMenarik;

        private int modePengaturanDipilih;
        private int kodeDipilih;
        private const int MODE_PENGATURAN_LIHATDATA = -1;
        private const int MODE_PENGATURAN_TAMBAH = 0;
        private const int MODE_PENGATURAN_MODIFIKASI = 1;


        private void loadData()
        {
            // Alasan kenapa -1 tidak ditampilkan :
            // Karena -1 adalah data dummy yang berarti tidak ada penawaran menarik. Dibuat ada nilainya agar bisa dimasukkan ke tabel Nota 
            // (agar tidak menimbulkan integrity constraint error)
            dataPenawaranMenarik = Program.conn.ExecuteDataTable("SELECT KodePenawaranSpesial, NamaPenawaranSpesial, Diskon, Mulai, Akhir "
                                                                 + "FROM Penawaranspesial WHERE KodePenawaranSpesial != -1 ORDER BY KodePenawaranSpesial ASC");
            
            // Set nama kolom
            dataPenawaranMenarik.Columns[0].ColumnName = "Kode";
            dataPenawaranMenarik.Columns[1].ColumnName = "Nama";
            dataPenawaranMenarik.Columns[2].ColumnName = "Diskon";
            dataPenawaranMenarik.Columns[3].ColumnName = "Mulai";
            dataPenawaranMenarik.Columns[4].ColumnName = "Akhir";

            // Tampilkan pada grid
            dgPenawaranMenarik.DataSource = dataPenawaranMenarik;

            // Done
        }
        public frmPenawaranMenarik()
        {
            InitializeComponent();
        }

        private void modePengaturan(int mode)
        {
            // Simpan mode pengaturan saat ini
            modePengaturanDipilih = mode;

            // Lakukan sesuai mode
            switch (mode)
            {
                case MODE_PENGATURAN_LIHATDATA:
                    txtNama.ResetText();
                    nmrDiskon.ResetText();
                    dtpTanggalMulai.ResetText();
                    dtpTanggalSelesai.ResetText();
                    dgPenawaranMenarik.Enabled = true;
                    txtNama.Enabled = false;
                    nmrDiskon.Enabled = false;
                    dtpTanggalMulai.Enabled = false;
                    dtpTanggalSelesai.Enabled = false;
                    btnTambahModifikasi.Text = "Modifikasi";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Penawaran Menarik Baru";
                    btnHapus.Enabled = true;
                    break;
                case MODE_PENGATURAN_TAMBAH:
                    txtNama.ResetText();
                    nmrDiskon.ResetText();
                    dtpTanggalMulai.ResetText();
                    dtpTanggalSelesai.ResetText();
                    dgPenawaranMenarik.Enabled = false;
                    txtNama.Enabled = true;
                    nmrDiskon.Enabled = true;
                    dtpTanggalMulai.Enabled = true;
                    dtpTanggalSelesai.Enabled = true;
                    btnTambahModifikasi.Text = "Tambahkan";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Batalkan Penambahan";
                    btnHapus.Enabled = false;
                    break;
                case MODE_PENGATURAN_MODIFIKASI:
                    dgPenawaranMenarik.Enabled = false;
                    txtNama.Enabled = true;
                    nmrDiskon.Enabled = true;
                    dtpTanggalMulai.Enabled = true;
                    dtpTanggalSelesai.Enabled = true;
                    btnTambahModifikasi.Text = "Modifikasi";
                    btnTambahModifikasi.Enabled = true;
                    btnBaru.Text = "Batalkan Perubahan";
                    btnHapus.Enabled = false;
                    break;
            }
        }
        private void frmPenawaranMenarik_Load(object sender, EventArgs e)
        {
            // Default, lihat data
            modePengaturan(MODE_PENGATURAN_LIHATDATA);

            // Load data
            loadData();

            // Okay
        }

        private void dgPenawaranMenarik_SelectionChanged(object sender, EventArgs e)
        {
            // Ketika seleksi berubah, tampilkan data pada panel pengaturan
            if(dgPenawaranMenarik.SelectedCells.Count > 0)
            {
                if(dgPenawaranMenarik.SelectedCells[0].RowIndex < dataPenawaranMenarik.Rows.Count)
                {
                    int idx = dgPenawaranMenarik.SelectedCells[0].RowIndex;
                    txtNama.Text = dataPenawaranMenarik.Rows[idx].ItemArray[1].ToString();
                    nmrDiskon.Value = Int16.Parse(dataPenawaranMenarik.Rows[idx].ItemArray[2].ToString());
                    dtpTanggalMulai.Value = DateTime.Parse(dataPenawaranMenarik.Rows[idx].ItemArray[3].ToString());
                    dtpTanggalSelesai.Value = DateTime.Parse(dataPenawaranMenarik.Rows[idx].ItemArray[4].ToString());
                    kodeDipilih = Int16.Parse(dataPenawaranMenarik.Rows[idx].ItemArray[0].ToString());
                    
                }
            }


            
        }

        private bool validasiDataFormPengaturan()
        {
            if (txtNama.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private bool validasiTanggalIris()
        {
            // Cek apakah pada tanggal tersebut terjadi irisan
            DataTable tmp;
            string strTglMulai = dtpTanggalMulai.Value.Day.ToString("00") + "/" + dtpTanggalMulai.Value.Month.ToString("00") + "/" + dtpTanggalMulai.Value.Year.ToString("0000");
            string strTglAkhir = dtpTanggalSelesai.Value.Day.ToString("00") + "/" + dtpTanggalSelesai.Value.Month.ToString("00") + "/" + dtpTanggalSelesai.Value.Year.ToString("0000");

            // Query cek
            string query = "SELECT * FROM PenawaranSpesial WHERE Mulai >= to_date('" + strTglMulai + "', 'DD/MM/YYYY') AND Mulai <= to_date('" + strTglAkhir + "', 'DD/MM/YYYY') OR Akhir >= to_date('" + strTglMulai + "', 'DD/MM/YYYY') AND Akhir <= to_date('" + strTglAkhir + "', 'DD/MM/YYYY') "
                            + "AND KodePenawaranSpesial != '-1' AND KodePenawaranSpesial != '" + kodeDipilih + "'";
            tmp = Program.conn.ExecuteDataTable(query);
            if (tmp.Rows.Count > 0)
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
                    if (validasiDataFormPengaturan() && validasiTanggalIris())
                    {
                        // Jika input benar, masukkan data ke basis data
                        int kodeBaru = Int16.Parse(dataPenawaranMenarik.Rows[dataPenawaranMenarik.Rows.Count - 1].ItemArray[0].ToString());
                        kodeBaru++;
                        string namaPenawaranMenarik = Program.escapeQuoteSQL(txtNama.Text);
                        int diskonPenawaranMenarik = Int16.Parse(nmrDiskon.Value.ToString());
                        string tanggalMulai = Program.convertTglkeOracle(dtpTanggalMulai.Value);
                        string tanggalSelesai = Program.convertTglkeOracle(dtpTanggalSelesai.Value);

                        // Query INSERT
                        Program.conn.ExecuteNonQuery("INSERT INTO PenawaranSpesial VALUES ('" + kodeBaru.ToString() + "','" + namaPenawaranMenarik + "','" + diskonPenawaranMenarik + "','"
                                                                                              + tanggalMulai + "','" + tanggalSelesai + "')");

                        // Kembali ke mode normal
                        loadData();
                        modePengaturan(MODE_PENGATURAN_LIHATDATA);

                    }
                    else
                    {
                        MessageBox.Show("Nama tidak diisi atau tanggal beririsan", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case MODE_PENGATURAN_MODIFIKASI:
                    if (validasiDataFormPengaturan() && validasiTanggalIris())
                    {
                        // Jika input benar, update ke basis data
                        int kodeLama = kodeDipilih;
                        string namaPenawaranMenarik = Program.escapeQuoteSQL(txtNama.Text);
                        int diskonPenawaranMenarik = Int16.Parse(nmrDiskon.Value.ToString());
                        string tanggalMulai = Program.convertTglkeOracle(dtpTanggalMulai.Value);
                        string tanggalSelesai = Program.convertTglkeOracle(dtpTanggalSelesai.Value);

                        // Query UPDATE
                        Program.conn.ExecuteNonQuery("UPDATE PenawaranSpesial SET NamaPenawaranSpesial='" + namaPenawaranMenarik + "', Diskon='" + diskonPenawaranMenarik
                                                     + "', Mulai='" + tanggalMulai + "', Akhir='" + tanggalSelesai + "' WHERE KodePenawaranSpesial='" + kodeLama + "'");

                        // Kembali ke mode normal
                        loadData();
                        modePengaturan(MODE_PENGATURAN_LIHATDATA);
                    }
                    else
                    {
                        MessageBox.Show("Nama tidak diisi atau tanggal beririsan", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgPenawaranMenarik.SelectedCells.Count > 0)
            {
                if (dgPenawaranMenarik.SelectedCells[0].RowIndex < dataPenawaranMenarik.Rows.Count)
                {
                    int idx = dgPenawaranMenarik.SelectedCells[0].RowIndex;
                    DialogResult jawab = MessageBox.Show("Apakah Anda yakin akan menghapus penawaran menarik '" 
                                                        + dataPenawaranMenarik.Rows[idx].ItemArray[1].ToString() 
                                                        + "'?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (jawab == System.Windows.Forms.DialogResult.Yes)
                    {
                        Program.conn.ExecuteNonQuery("DELETE FROM PenawaranSpesial WHERE KodePenawaranSpesial='" + kodeDipilih + "'");
                        loadData();
                    }


                }
            }
        }
    }
}
