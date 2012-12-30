using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Rentalin
{
    // Sha1 encryptor
    public sealed class sha1Encrypt
    {

        public static string EncodePassword(string strToEncryp)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncryp);

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }  
  
    }

    // Md5 encryptor
    public class md5Encrypt
    {
        public static string EncodePassword(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }

    // Usersession class: Define the user login session mechanism
    public class userSession
    {
        private bool loged;

        private DataTable loginChecker = new DataTable();

        private int role;
        private int kodeOperator;
        private string namaUser; 

        public const int LOGIN_USERNAME_PASSWORD_WRONG = 0;
        public const int LOGIN_MULTI = 1;
        public const int LOGIN_SUCCESS = 2;
        
        public int login(string userName, string password)
        {
            // Convert password to sha1(md5(password))

            string passwordMd5 = md5Encrypt.EncodePassword(password);
            string passwordSha1 = sha1Encrypt.EncodePassword(passwordMd5);

            // Check user login in database
            loginChecker = Program.conn.ExecuteDataTable("SELECT * FROM pengguna WHERE username = '"
                                                        + Program.escapeQuoteSQL(userName) +"' and password = '"
                                                        + passwordSha1 + "'");
            
            // If there is one row in table
            //MessageBox.Show(loginChecker.Rows.Count.ToString());
            if (loginChecker.Rows.Count == 1)
            {
                // Check if there is no multiple login
                if (Convert.ToBoolean(loginChecker.Rows[0].ItemArray[4]) == true)
                {
                    return LOGIN_MULTI;
                }
                else
                {
                    // If there is no multiple login, define role
                    role = Convert.ToInt32(loginChecker.Rows[0].ItemArray[1]);
                    Program.role.roleApply(role);

                    // And then login is SUCESS
                    loged = true;
                    Program.conn.ExecuteNonQuery("UPDATE pengguna SET isLogin=1 WHERE kodeOperator='" + kodeOperator + "'");
                    kodeOperator = int.Parse(loginChecker.Rows[0].ItemArray[0].ToString());
                    namaUser = loginChecker.Rows[0].ItemArray[2].ToString();
                    return LOGIN_SUCCESS;
                }
            }
            else
            {
                return LOGIN_USERNAME_PASSWORD_WRONG;
            }           
        }
        
        public void logout()
        {
            loged = false;
            Program.conn.ExecuteNonQuery("UPDATE pengguna SET isLogin=0 WHERE kodeOperator='" + kodeOperator + "'");
        }

        public bool isLogin()
        {
            return loged;
        }

        public int getKodeOperator()
        {
            return kodeOperator;
        }

        public string getNamaUser()
        {
            return namaUser;
        }
    }

    public class userRole
    {
        private string roleName;
        private int role;

        public bool masterPelanggan;
        public bool masterKoleksi;
        public bool masterStok;
        public bool transaksi;
        public bool laporanPerTransaksi;
        public bool laporanTransaksi;
        public bool laporanKeuangan;
        public bool halloffame;
        public bool pengaturanSistem;
        public bool pengaturanKewenangan;
        public bool pengaturanPengguna;
        public bool pengaturanPenawaranMenarik;
        public bool jendelaPertama;
        public const bool JENDELA_PERTAMA_OPERATOR = false;
        public const bool JENDELA_PERTAMA_ADMIN = true;

        public void roleApply(int roleNum)
        {
            DataTable roleChecker;
            roleChecker = Program.conn.ExecuteDataTable("SELECT * FROM kewenangan WHERE kodeKewenangan = '" + roleNum + "'");
            masterPelanggan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[2]);
            masterKoleksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[3]);
            masterStok = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[4]);
            transaksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[5]);
            laporanPerTransaksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[6]);
            laporanTransaksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[7]);
            laporanKeuangan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[8]);
            halloffame = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[9]);
            pengaturanSistem = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[10]);
            pengaturanKewenangan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[11]);
            Program.role.pengaturanPengguna = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[12]);
            Program.role.pengaturanPenawaranMenarik = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[13]);
            Program.role.jendelaPertama = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[14]);

            roleName = roleChecker.Rows[0].ItemArray[1].ToString();
            role = roleNum;
        }

        public void roleApplyThis()
        {
            roleApply(role);
        }
        public string getRoleName()
        {
            return roleName;
        }

    }

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
        public static userSession session = new userSession();
        public static appSetting setting = new appSetting();
        public static userRole role = new userRole();
        public static specialOffer so = new specialOffer();

        public const string IMAGE_FILE_TEMPORARY = "gambarsementara.jpg";
        

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

        public static void displayBlobImage(byte[] blob)
        {
            try
            {
                FileStream FS = new FileStream(IMAGE_FILE_TEMPORARY, FileMode.Create, FileAccess.Write);
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
            output = input.Replace(@"'", @"\'");
            output = output.Replace(@"-", @"\-");

            return output;
        }
    }
}
