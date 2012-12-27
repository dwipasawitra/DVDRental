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
    public partial class frmLaporanNota : Form
    {
        public frmLaporanNota()
        {
            InitializeComponent();
        }

        private void frmLaporanNota_Load(object sender, EventArgs e)
        {

            this.reportviewNota.RefreshReport();
        }

        private void reportviewNota_Load(object sender, EventArgs e)
        {

        }
    }
}
