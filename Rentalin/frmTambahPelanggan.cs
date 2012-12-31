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
    public partial class frmTambahPelanggan : Form
    {
        DataTable jenisidentitas;
        DataTable modify;
        DataTable listMember;

        public int mode;
        public string IDMember;
        public frmTambahPelanggan()
        {
            InitializeComponent();
            tampilanAwal();
            mode = 0;

            txtKodeMember.Enabled = true;
        }

        public frmTambahPelanggan(string KodeMember)
        {
            InitializeComponent();
            tampilanAwal(KodeMember);
            mode = 1;
            IDMember = KodeMember;
            txtKodeMember.Enabled = false;
        }


        private void addListJenisIdentitas()
        {
            jenisidentitas = Program.conn.ExecuteDataTable("SELECT * FROM jenisidentitas");

            // Isi combo box jenis identitas
            cmbJenisIdentitas.Items.Clear();
            for (int i = 0; i < jenisidentitas.Rows.Count; i++)
            {
                cmbJenisIdentitas.Items.Add(jenisidentitas.Rows[i].ItemArray[1].ToString());
            }
        }

        public void tampilanAwal()
        {
            lblInfo.Text = "Silahkan menambahkan detail\npelanggan di jendela ini";
            btnTambahkan.Enabled = false;
            txtKodeMember.ResetText();
            txtNamaMember.ResetText();
            txtNomorIdentitas.ResetText();
            addListJenisIdentitas();
            cmbJenisIdentitas.SelectedIndex = 0;
            
        }

        public void tampilanAwal(string kodeMember)
        {
            lblInfo.Text = "Silahkan menyunting detail pelanggan\ndi jendela ini";
            btnTambahkan.Enabled = true;
            btnTambahkan.Text = "Perbarui";

            modify = Program.conn.ExecuteDataTable("SELECT member.*, jenisidentitas.jenis FROM member INNER JOIN jenisidentitas ON member.jenisidentitas = jenisidentitas.id WHERE kodemember = '" + kodeMember + "'");

            txtKodeMember.Text = modify.Rows[0].ItemArray[0].ToString();
            txtNamaMember.Text = modify.Rows[0].ItemArray[1].ToString();
            txtNomorIdentitas.Text = modify.Rows[0].ItemArray[3].ToString();

            addListJenisIdentitas();

            cmbJenisIdentitas.Text = modify.Rows[0].ItemArray[4].ToString();
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            listMember = Program.conn.ExecuteDataTable("SELECT * FROM member");
            int i, idx = listMember.Rows.Count;
            if (txtKodeMember.Text == "" && txtNamaMember.Text == "" && txtNomorIdentitas.Text == "" && cmbJenisIdentitas.Text == "")
            {
                MessageBox.Show("Informasi dibutuhkan");
            }
            else if (txtKodeMember.TextLength != 10)
            {
                MessageBox.Show("Kode Member harus 10 karakter");
            }
            else
            {
                for (i = 0; i < idx; i++)
                {
                    if (listMember.Rows[i].ItemArray[0].ToString() == txtKodeMember.Text && mode == 0)
                    {
                        MessageBox.Show("Kode Member tidak bisa diterima");
                        break;
                    }
                }
                if (i == idx)
                {
                    if (mode == 0)
                    {
                        string insert = "INSERT INTO member VALUES('" + Program.escapeQuoteSQL(txtKodeMember.Text) + "','" + Program.escapeQuoteSQL(txtNamaMember.Text) + "','" + jenisidentitas.Rows[cmbJenisIdentitas.SelectedIndex].ItemArray[0].ToString() + "','" + Program.escapeQuoteSQL(txtNomorIdentitas.Text) + "')";
                        Program.conn.ExecuteNonQuery(insert);
                        MessageBox.Show("Data berhasil ditambahkan");
                        tampilanAwal();
                    }
                    else
                    {
                        string update = "UPDATE member SET kodemember = '" + Program.escapeQuoteSQL(txtKodeMember.Text) + "', namamember='" + Program.escapeQuoteSQL(txtNamaMember.Text) + "', jenisidentitas = '" + jenisidentitas.Rows[cmbJenisIdentitas.SelectedIndex].ItemArray[0].ToString() + "', nomoridentitas = '" + Program.escapeQuoteSQL(txtNomorIdentitas.Text) + "' WHERE kodemember = '" + Program.escapeQuoteSQL(IDMember) + "'";
                        Program.conn.ExecuteNonQuery(update);
                        MessageBox.Show("Data berhasil diperbarui");
                        Close();
                    }
                }                    
            }          
        }

        private void txtKodeMember_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeMember.TextLength > 0)
                btnTambahkan.Enabled = true;
        }

        private void frmTambahPelanggan_Load(object sender, EventArgs e)
        {

        }
    }
}
