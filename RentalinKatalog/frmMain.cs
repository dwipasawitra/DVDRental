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
    public partial class frmMain : Form
    {
        bool sedangMemesan = false;
        bool animateBlink = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Ambil data Nama dan Alamat
            lblNamaLayanan.Text = Program.setting.namaJasa;
            lblAlamatLayanan.Text = Program.setting.alamatJasa;
        }

        private void tmrWaktu_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string day = DateTime.Now.Day.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string year = DateTime.Now.Year.ToString("0000");

            lblDate.Text = day + "/" + month + "/" + year;
            if (animateBlink)
            {
                animateBlink = false;
                lblTime.Text = hour + " " + minute;
            }
            else
            {
                animateBlink = true;
                lblTime.Text = hour + ":" + minute;
            }
        }

        private void tmrScrollingText_Tick(object sender, EventArgs e)
        {
            int len = lblScrollingText.Text.Length;
            lblScrollingText.Text = lblScrollingText.Text.Substring(1, len - 1) + lblScrollingText.Text.Substring(0, 1);
        }

        private void btnLihatDaftarJudul_Click(object sender, EventArgs e)
        {
            

        }

       

        
    }
}
