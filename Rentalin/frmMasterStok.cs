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
    public partial class frmMasterStok : Form
    {
        public frmMasterStok()
        {
            InitializeComponent();
        }
        DataTable stok = new DataTable();

        private void frmMasterStok_Load(object sender, EventArgs e)
        {
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi");
            dgStokKoleksi.DataSource = stok;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgStokKoleksi.CurrentCellAddress.Y;
            string delete = "DELETE FROM stokkoleksi WHERE kodestok = '" + stok.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            stok.Rows[rows].Delete();
        }

        private void lblInfoDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblPencarian_Click(object sender, EventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
