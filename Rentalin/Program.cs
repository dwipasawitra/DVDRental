﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Rentalin
{
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

    public class userSession
    {
        private bool loged;

        private DataTable loginChecker = new DataTable();
        private DataTable roleChecker = new DataTable();
        public int kodeOperator;         
        public const int LOGIN_USERNAME_PASSWORD_WRONG = 0;
        public const int LOGIN_MULTI = 1;
        public const int LOGIN_SUCCESS = 2;
        
        public int login(string userName, string password)
        {
            string passwordMd5 = md5Encrypt.EncodePassword(password);
            string passwordSha1 = sha1Encrypt.EncodePassword(passwordMd5);


            loginChecker = Program.conn.ExecuteDataTable("SELECT * FROM pengguna WHERE username = '"
                                                        + userName +"' and password = '"
                                                        + passwordSha1 + "'");
            MessageBox.Show(loginChecker.Rows.Count.ToString());
            if (loginChecker.Rows.Count == 1)
            {
                
                if (Convert.ToBoolean(loginChecker.Rows[0].ItemArray[4]) == true)
                {
                    return LOGIN_MULTI;
                }
                else
                {
                    int role = Convert.ToInt32(loginChecker.Rows[0].ItemArray[1]);
                    roleChecker = Program.conn.ExecuteDataTable("SELECT * FROM kewenangan WHERE kodeKewenangan = '" + role + "'");
                    Program.role.masterPelanggan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[2]);
                    Program.role.masterKoleksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[3]);
                    Program.role.masterStok = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[4]);
                    Program.role.transaksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[5]);
                    Program.role.laporanTransaksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[6]);
                    Program.role.laporanMember = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[7]);
                    Program.role.laporanKoleksi = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[8]);
                    Program.role.laporanKeuangan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[9]);
                    Program.role.pengaturanSistem = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[10]);
                    Program.role.pengaturanKewenangan = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[11]);
                    Program.role.pengaturanPengguna = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[12]);
                    Program.role.pengaturanPenawaranMenarik = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[13]);
                    Program.role.jendelaPertama = Convert.ToBoolean(roleChecker.Rows[0].ItemArray[14]);
                    loged = true;
                    kodeOperator = int.Parse(roleChecker.Rows[0].ItemArray[0].ToString());
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
        }

        public bool isLogin()
        {
            return loged;
        }        
    }

    public class userRole
    {
        public bool masterPelanggan;
        public bool masterKoleksi;
        public bool masterStok;
        public bool transaksi;
        public bool laporanTransaksi;
        public bool laporanMember;
        public bool laporanKoleksi;
        public bool laporanKeuangan;
        public bool pengaturanSistem;
        public bool pengaturanKewenangan;
        public bool pengaturanPengguna;
        public bool pengaturanPenawaranMenarik;
        public bool jendelaPertama;
        public const bool JENDELA_PERTAMA_OPERATOR = false;
        public const bool JENDELA_PERTAMA_ADMIN = true;
    }

    public class appSetting
    {
        public string namaJasa;
        public string alamatJasa;
        public string namaPemilik;
        public int biayaSewaPer;
        public int biayaDendaPer;
        public const int BIAYA_SEWA_TIDAK_ADA = 0;
        public const int BIAYA_SEWA_PER_KATEGORI = 1;
        public const int BIAYA_SEWA_PER_JUDUL = 2;
        public const int BIAYA_SEWA_KEDUANYA = 3;
        public const int BIAYA_DENDA_TIDAK_ADA = 0;
        public const int BIAYA_DENDA_PER_KATEGORI = 1;
        public const int BIAYA_DENDA_PER_JUDUL = 2;
        public const int BIAYA_DENDA_KEDUANYA = 3;
    }

    static class Program
    {
        /// The main entry point for the application.

        public static dbConnection conn = new dbConnection();
        public static userSession session = new userSession();
        public static appSetting setting = new appSetting();
        public static userRole role = new userRole();

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
                MessageBox.Show("Berhasil melakukan koneksi");
                Application.Run(new frmLogin());
            }
            else
            {
                MessageBox.Show("Gagal melakukan koneksi");

            }          
        }
    }
}
