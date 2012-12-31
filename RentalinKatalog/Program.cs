using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace RentalinKatalog
{
    public class appSetting
    {
        public string namaJasa;
        public string alamatJasa;
        public string namaPemilik;
        public int biayaSewaPer;
        public int biayaDendaPer;
        public int lamaPenyewaan;
        public int lamaPenyewaanHari;
        public int maksTransaksi;
        public int maksTransaksiJumlah;
        public int dendaKerusakan;

        public const int BIAYA_SEWA_TIDAK_ADA = 0;
        public const int BIAYA_SEWA_PER_KATEGORI = 1;
        public const int BIAYA_SEWA_PER_JUDUL = 2;
        public const int BIAYA_SEWA_KEDUANYA = 3;
        public const int BIAYA_DENDA_TIDAK_ADA = 0;
        public const int BIAYA_DENDA_PER_KATEGORI = 1;
        public const int BIAYA_DENDA_PER_JUDUL = 2;
        public const int BIAYA_DENDA_KEDUANYA = 3;
        public const int LAMA_PENYEWAAN_FIX = 0;
        public const int LAMA_PENYEWAAN_BEBAS = 1;
        public const int MAKS_TRANSAKSI_MAKS = 0;
        public const int MAKS_TRANSAKSI_BEBAS = 1;

        public void readSetting()
        {
            DataTable setting;

            try
            {
                // namaJasa
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='namaToko'");
                namaJasa = setting.Rows[0].ItemArray[0].ToString();

                // alamatJasa
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='alamatToko'");
                alamatJasa = setting.Rows[0].ItemArray[0].ToString();

                // namaPemilik
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='namaPemilik'");
                namaPemilik = setting.Rows[0].ItemArray[0].ToString();

                // biayaSewaPer
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='skemaBiayaSewa'");
                biayaSewaPer = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                // biayaDendaPer
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='skemaBiayaDenda'");
                biayaDendaPer = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                // lamaPenyewaan
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='skemaHariTransaksi'");
                lamaPenyewaan = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                // lamaPenyewaanHari
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='maksHariTransaksi'");
                lamaPenyewaanHari = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                // maksTransaksi
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='skemaJudulTransaksi'");
                maksTransaksi = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                // maksTransaksiJumlah
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='maksJudulTransaksi'");
                maksTransaksiJumlah = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());

                //dendaKerusakan
                setting = Program.conn.ExecuteDataTable("SELECT data FROM pengaturan WHERE Atribut='dendaKerusakan'");
                dendaKerusakan = Int16.Parse(setting.Rows[0].ItemArray[0].ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void updateSetting()
        {
            //public string namaJasa
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + namaJasa + "' WHERE atribut='namaToko'");
            //public string alamatJasa
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + alamatJasa + "' WHERE atribut='alamatToko'");
            //public string namaPemilik
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + namaPemilik + "' WHERE atribut='namaPemilik'");
            //public int biayaSewaPer
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + biayaSewaPer + "' WHERE atribut='skemaBiayaSewa'");
            //public int biayaDendaPer
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + biayaDendaPer + "' WHERE atribut='skemaBiayaDenda'");
            //public int lamaPenyewaan
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + lamaPenyewaan + "' WHERE atribut='skemaHariTransaksi'");
            //public int lamaPenyewaanHari
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + lamaPenyewaanHari + "' WHERE atribut='maksHariTransaksi'");
            //public int maksTransaksi
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + maksTransaksi + "' WHERE atribut='skemaJudulTransaksi'");
            //public int maksTransaksiJumlah
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + maksTransaksiJumlah + "' WHERE atribut='maksJudulTransaksi'");
            Program.conn.ExecuteNonQuery("UPDATE pengaturan SET data='" + dendaKerusakan + "' WHERE atribut='dendaKerusakan'");
        }
    }

    public class specialOffer
    {
        private DataTable dtSpecialOffer;
        private int specialOfferCode;
        private string specialOfferName;
        private float specialOfferDiscount;
        private bool so;

        public void updateSpecialOffer()
        {
            // Cari query special offer diantara tanggal sekarang
            // Asumsi, hanya ada satu special offer di setiap waktunya
            dtSpecialOffer = Program.conn.ExecuteDataTable("SELECT * FROM penawaranspesial WHERE mulai <= sysdate AND akhir >= sysdate");

            // Jika ada special offer, maka simpan variabelnya
            if (dtSpecialOffer.Rows.Count >= 1)
            {
                so = true;
                specialOfferCode = Int16.Parse(dtSpecialOffer.Rows[0].ItemArray[0].ToString());
                specialOfferName = dtSpecialOffer.Rows[0].ItemArray[1].ToString();
                specialOfferDiscount = float.Parse(dtSpecialOffer.Rows[0].ItemArray[2].ToString());

            }
            else
            {
                so = false;
            }

        }

        public float getSpecialOfferDiscount()
        {
            if (so)
            {
                return specialOfferDiscount;
            }
            return 0;
        }

        public string getSpecialOfferName()
        {
            if (so)
            {
                return specialOfferName;
            }
            return "";
        }

        public bool isSpecialOffer()
        {
            return so;
        }

        public int getSpecialOfferCode()
        {
            if (so)
            {
                return specialOfferCode;
            }
            return -1;
        }
    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            bool isConn;

            // App initialization
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Db Open Connection
            isConn = conn.Open();
            if (isConn)
            {
                setting.readSetting();
                MessageBox.Show("Berhasil melakukan koneksi ke basis data RENTALIN", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Run(new frmMain());
            }
            else
            {
                MessageBox.Show("Gagal melakukan koneksi ke basis data. Pastikan pengaturan basis data sudah sesuai.", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static dbConnection conn = new dbConnection();
        public static appSetting setting = new appSetting();
        public static specialOffer so = new specialOffer();



        public static string convertTglkeOracle(DateTime dtInput)
        {
            int tgl = dtInput.Day;
            int bln = dtInput.Month;
            int thn = dtInput.Year;

            string namaBulan = "";
            switch (bln)
            {
                case 1: namaBulan = "JAN"; break;
                case 2: namaBulan = "FEB"; break;
                case 3: namaBulan = "MAR"; break;
                case 4: namaBulan = "APR"; break;
                case 5: namaBulan = "MAY"; break;
                case 6: namaBulan = "JUN"; break;
                case 7: namaBulan = "JUL"; break;
                case 8: namaBulan = "AUG"; break;
                case 9: namaBulan = "SEP"; break;
                case 10: namaBulan = "OCT"; break;
                case 11: namaBulan = "NOV"; break;
                case 12: namaBulan = "DEC"; break;
            }

            return tgl.ToString() + "-" + namaBulan + "-" + thn.ToString();
        }

        public static void displayBlobImage(byte[] blob, string namaBerkasLuaran)
        {
            try
            {
                FileStream FS = new FileStream(namaBerkasLuaran, FileMode.Create, FileAccess.Write);
                FS.Write(blob, 0, blob.Length);
                FS.Close();
                FS.Dispose();
                FS = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static byte[] getBlobImage(string filePath)
        {
            // Ambil berkas filePath, jadikan dia sebuah blob
            FileStream FS = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] blob = new byte[FS.Length];
            FS.Read(blob, 0, Convert.ToInt32(FS.Length));
            FS.Close();
            FS = null;

            return blob;
        }

        public static string escapeQuoteSQL(string input)
        {
            string output;
            output = input.Replace(@"'", @"''");
            output = output.Replace(@"-", @"\-");

            return output;
        }
    }
}
