using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rentalin
{


    public class userSession
    {
        private string userName;
        private string password;
        private bool loged;

        public void login(string userName, string password)
        {

        }

        public void logout()
        {

        }

        public bool isLogin()
        {
            return false;
        }
        

    }

    public class appSetting
    {
        
    }

    static class Program
    {
        /// The main entry point for the application.

        public static dbConnection conn = new dbConnection();
        public static userSession session = new userSession();
        public static appSetting setting = new appSetting();

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
