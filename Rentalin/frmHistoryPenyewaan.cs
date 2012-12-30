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
        int Mode;
        public string Kode;
        public frmHistoryPenyewaan(string kode, int mode)
        {
            InitializeComponent();
            Mode = mode;
            Kode = kode;
        }

        private void frmHistoryPenyewaan_Load(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                dgHistory.DataSource = Program.conn.ExecuteDataTable("select nota.tgltransaksi, nota.nonota, member.namamember from dipinjam inner join nota on dipinjam.nonota = nota.nonota inner join member on nota.kodemember = member.kodemember where dipinjam.kodestok = '"+Kode+"' order by nota.tgltransaksi");
            }
            else if (Mode == 1)
            {
                dgHistory.DataSource = Program.conn.ExecuteDataTable("select * from nota where nota.kodemember = '"+Kode+"' ORDER BY nota.tgltransaksi asc");
            }
        }
    }
}
