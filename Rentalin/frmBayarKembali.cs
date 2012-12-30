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
    public partial class frmBayarKembali : Form
    {
        bool hasil;
        string Nonota;
        int Biaya;
        public frmBayarKembali(string nonota, int biaya)
        {
            InitializeComponent();
            Nonota = nonota;
            Biaya = biaya;
        }

        public bool getHasil()
        {
            return hasil;
        }

        private void frmBayarKembali_Load(object sender, EventArgs e)
        {
            lblNoNota.ResetText();
            lblBayar.ResetText();
            txtKembali.ResetText();
            txtUangDibayar.ResetText();
            btnSetuju.Enabled = false;
            
            lblNoNota.Text = Nonota;
            lblBayar.Text = Biaya.ToString();
            txtKembali.Enabled = false;
            
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {            
            hasil = true;
            Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            hasil = false;
            Close();
        }

        private void txtUangDibayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetuju_Click(sender, e);
            }
        }

        private void txtUangDibayar_TextChanged(object sender, EventArgs e)
        {
            if (txtUangDibayar.TextLength > 0)
            {                
                try
                {
                    if (int.Parse(txtUangDibayar.Text) > Biaya)
                    {                       
                        txtKembali.Text = (int.Parse(txtUangDibayar.Text) - Biaya).ToString();
                        btnSetuju.Enabled = true;
                    }
                    else
                    {
                        txtKembali.ResetText();
                        btnSetuju.Enabled = false;
                    }
                }
                catch
                {                    
                    int panjang = txtUangDibayar.TextLength;
                    txtUangDibayar.Text = txtUangDibayar.Text.Substring(0, panjang - 1);
                    MessageBox.Show("Silahkan input bilangan");
                }
            }
        }

        
    }
}
