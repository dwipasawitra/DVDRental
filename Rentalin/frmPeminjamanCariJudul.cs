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
    public partial class frmPeminjamanCariJudul : Form
    {
        public frmPeminjamanCariJudul()
        {
            InitializeComponent();
        }

        DataTable pencarian = new DataTable();

        private void frmPeminjamanCariJudul_Load(object sender, EventArgs e)
        {
            lblJudul.Text = "Judul Film";
            lblGenre.Text = "Genre";
            lblDenda.Text = "0";
            lblSewa.Text = "0";
            dgPencarian.ReadOnly = true;
        }

        private void pbCover_Click(object sender, EventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            //pencarian = Program.conn.ExecuteDataTable("SELECT kodekoleksi, kodekategori, namaitem, dekripsiitem, biayasewafilm, biayadendafilm, item FROM koleksi WHERE kodekoleksi like '%"+txtPencarian.Text+"%' OR namaitem like '%"+txtPencarian.Text+"%'");
            //if (txtPencarian.TextLength > 0)
            if (txtPencarian.Text != "")
            {
                pencarian = Program.conn.ExecuteDataTable("SELECT kodekoleksi, genre.kodekategori, namaitem, biayasewafilm, biayadendafilm, namakategori FROM koleksi INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori WHERE kodekoleksi like '%" + txtPencarian.Text + "%' OR namaitem like '%" + txtPencarian.Text + "%'");
                //else
                //  dgPencarian.DataSource = pencarian;
                //if (pencarian.Rows.Count > 0)
                //{

                dgPencarian.DataSource = pencarian;
            }
                
            //}
        }

        private void dgPencarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgPencarian_SelectionChanged(object sender, EventArgs e)
        {
            int y = dgPencarian.CurrentCellAddress.Y;
            if (y >= 0 && y < pencarian.Rows.Count)
            {
                lblJudul.Text = dgPencarian.Rows[y].Cells[2].Value.ToString();
                lblGenre.Text = dgPencarian.Rows[y].Cells[5].Value.ToString();
                lblDenda.Text = dgPencarian.Rows[y].Cells[4].Value.ToString();
                lblSewa.Text = dgPencarian.Rows[y].Cells[3].Value.ToString();
            }
            else
            {
                lblJudul.Text = "Judul Film";
                lblGenre.Text = "Genre";
                lblDenda.Text = "0";
                lblSewa.Text = "0";
            }
            
        }


    }
}
