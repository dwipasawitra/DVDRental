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
    public partial class frmMasterPelanggan : Form
    {
        public frmMasterPelanggan()
        {
            InitializeComponent();
        }
        DataTable pelanggan = new DataTable();
        private void frmMasterPelanggan_Load(object sender, EventArgs e)
        {
            pelanggan = Program.conn.ExecuteDataTable("SELECT * FROM member");
            dgPelanggan.DataSource = pelanggan;
            dgPelanggan.ReadOnly = true;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            int rows = dgPelanggan.CurrentCellAddress.Y;
            string delete = "DELETE FROM member WHERE kodemember = '"+ pelanggan.Rows[rows].ItemArray[0].ToString() + "'";
            Program.conn.ExecuteDataTable(delete);
            //pelanggan.Rows[rows].Delete();
        }

        private void dgPelanggan_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (pelanggan.Rows.Count < 1)
            {
                btnHapus.Enabled = false;
            }
        }

        private void dgPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            lblNamaPelanggan.Text = pelanggan.Rows[y].ItemArray[1].ToString();
            lblIdentitas.Text += pelanggan.Rows[y].ItemArray[3].ToString();

        }
    }
}
