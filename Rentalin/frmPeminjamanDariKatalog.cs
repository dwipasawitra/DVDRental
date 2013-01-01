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
    public partial class frmPeminjamanDariKatalog : Form
    {
        DataTable listPemesan;

        public frmPeminjamanDariKatalog()
        {
            InitializeComponent();
        }

        private void updateListPemesan()
        {
            listPemesan = Program.conn.ExecuteDataTable("SELECT NoPendingNota, Member.KodeMember, Member.NamaMember FROM PendingNota INNER JOIN Member ON PendingNota.KodeMember = Member.KodeMember WHERE Diproses='0' ORDER BY NoPendingNota DESC");
            listBoxPemesan.Items.Clear();
            for (int i = 0; i < listPemesan.Rows.Count; i++)
            {
                listBoxPemesan.Items.Add(listPemesan.Rows[i].ItemArray[2].ToString());
            }
        }

        private void frmPeminjamanDariKatalog_Load(object sender, EventArgs e)
        {
            // Update daftar list pemesan
            updateListPemesan();
        }

        private void listBoxPemesan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPemesan.SelectedIndex == -1)
            {
                btnProses.Enabled = false;
            }
            else
            {
                btnProses.Enabled = true;
            }
        }

        private void btnMuatUlang_Click(object sender, EventArgs e)
        {
            updateListPemesan();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            // Cek yang mana yang dipilih
            if (listBoxPemesan.SelectedIndex >= 0)
            {
                string noPendingNota = listPemesan.Rows[listBoxPemesan.SelectedIndex].ItemArray[0].ToString();

                // Tandai sudah diproes
                Program.conn.ExecuteNonQuery("UPDATE PendingNota SET Diproses='1' WHERE NoPendingNota='" + noPendingNota + "'");

                // Buka form peminjaman
                string kodeMember = listPemesan.Rows[listBoxPemesan.SelectedIndex].ItemArray[1].ToString();
                //MessageBox.Show(kodeMember);
                frmTransaksiPeminjaman form = new frmTransaksiPeminjaman(noPendingNota, kodeMember);
                form.ShowDialog(this);
                Close();
            }
            else
            {
                MessageBox.Show("Maaf, Anda belum memilih pelanggan.", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
