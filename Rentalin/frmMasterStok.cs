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
        DataTable stok = new DataTable();
        public frmMasterStok()
        {
            InitializeComponent();           
        
            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi");
            dgStokKoleksi.DataSource = stok;
            dgStokKoleksi.ReadOnly = true;
            MessageBox.Show("no string");
        }        

        public frmMasterStok(string kodeKoleksi)
        {
            InitializeComponent();

            stok = Program.conn.ExecuteDataTable("SELECT * FROM stokkoleksi WHERE kodekoleksi = '"+kodeKoleksi+"'");
            dgStokKoleksi.DataSource = stok;
            dgStokKoleksi.ReadOnly = true;
            MessageBox.Show("string");
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

        private void frmMasterStok_Load(object sender, EventArgs e)
        {

        }

        private void dgStokKoleksi_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (stok.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
            }
        }

        

        
    }
}
