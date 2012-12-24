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
    public partial class frmMasterKoleksi : Form
    {
        public frmMasterKoleksi()
        {
            InitializeComponent();
        }
        
        DataTable koleksi = new DataTable();

        private void frmMasterKoleksi_Load(object sender, EventArgs e)
        {
            koleksi = Program.conn.ExecuteDataTable("SELECT * FROM koleksi");
            dgKoleksi.DataSource = koleksi;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgKoleksi.CurrentCellAddress.Y;
            //menghapus data
            string delete = "DELETE FROM koleksi WHERE kodekoleksi = '" + koleksi.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            koleksi.Rows[rows].Delete();
        }
        
    }
}
