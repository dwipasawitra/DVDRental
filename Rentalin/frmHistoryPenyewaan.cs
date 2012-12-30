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
    public partial class frmHistoryPenyewaan : Form
    {
        int mode;
        public frmHistoryPenyewaan()
        {
            InitializeComponent();
            mode = 0;
        }

        public frmHistoryPenyewaan(string kodeMember)
        {
            InitializeComponent();
            mode = 1;
        }

        private void frmHistoryPenyewaan_Load(object sender, EventArgs e)
        {
            if (mode == 0)
            {
 
            }
            else if (mode == 1)
            {
 
            }
        }
    }
}
