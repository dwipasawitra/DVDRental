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
        public int mode;
        public string IDMember;
        public frmTambahPelanggan()
        {
            InitializeComponent();
            tampilanAwal();
            mode = 0;
        }

        public frmTambahPelanggan(string KodeMember)
        {
            InitializeComponent();
            tampilanAwal(KodeMember);
            mode = 1;
            IDMember = KodeMember;
        }

        DataTable modify = new DataTable();
        DataTable listMember = new DataTable();

        public void tampilanAwal()
        {
            lblInfo.Text = "Silahkan menambahkan detail\npelanggan di jendela ini";
            btnTambahkan.Enabled = false;
            txtKodeMember.ResetText();
            txtNamaMember.ResetText();
            txtNomorIdentitas.ResetText();
            cmbJenisIdentitas.Items.Clear();
            cmbJenisIdentitas.Items.Add("0");
            cmbJenisIdentitas.Items.Add("1");
            cmbJenisIdentitas.Items.Add("2");
            cmbJenisIdentitas.Items.Add("3");
        }

        public void tampilanAwal(string kodeMember)
        {
            lblInfo.Text = "Silahkan menyunting detail pelanggan\ndi jendela ini";
            btnTambahkan.Enabled = true;
            btnTambahkan.Text = "Perbarui";

            modify = Program.conn.ExecuteDataTable("SELECT * FROM member WHERE kodemember = '" + kodeMember + "'");

            txtKodeMember.Text = modify.Rows[0].ItemArray[0].ToString();
            txtNamaMember.Text = modify.Rows[0].ItemArray[1].ToString();
            txtNomorIdentitas.Text = modify.Rows[0].ItemArray[3].ToString();

            cmbJenisIdentitas.Items.Clear();
            cmbJenisIdentitas.Items.Add("0");
            cmbJenisIdentitas.Items.Add("1");
            cmbJenisIdentitas.Items.Add("2");
            cmbJenisIdentitas.Items.Add("3");
            cmbJenisIdentitas.Text = modify.Rows[0].ItemArray[2].ToString();
        }

        private void btnTambahkan_Click(object sender, EventArgs e)
        {
            listMember = Program.conn.ExecuteDataTable("SELECT * FROM member");
            int i, idx = listMember.Rows.Count;
            if (txtKodeMember.Text == "" && txtNamaMember.Text == "" && txtNomorIdentitas.Text == "" && cmbJenisIdentitas.Text == "")
            {
                MessageBox.Show("Informasi * dibutuhkan");
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
                        string insert = "INSERT INTO member VALUES('" + txtKodeMember.Text + "','" + txtNamaMember.Text + "'," + cmbJenisIdentitas.Text + "," + txtNomorIdentitas.Text + ")";
                        Program.conn.ExecuteNonQuery(insert);
                        MessageBox.Show("Data berhasil ditambahkan");
                        tampilanAwal();
                    }
                    else
                    {
                        string update = "UPDATE member SET kodemember = '" + txtKodeMember.Text + "', namamember='" + txtNamaMember.Text + "', jenisidentitas = " + cmbJenisIdentitas.Text + ", nomoridentitas = " + txtNomorIdentitas.Text + " WHERE kodemember = '" + IDMember + "'";
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
    }
}
