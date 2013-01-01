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
    public partial class frmPengaturanPengguna : Form
    {
        DataTable dataPengguna;
        DataTable dataKewenangan;

        int idPenggunaDipilih;
        string kewenanganDipilih;
        string namaPenggunaDipilih;
        string namaLengkapPenggunaDipilih;

        const int BTN_PASSWORD_MODIFIKASI_PASSWORD = 0;
        const int BTN_PASSWORD_APPLY_PASSWORD = 1;

        const int BTN_HAPUS_PENGGUNA_HAPUS_PENGGUNA = 0;
        const int BTN_HAPUS_PENGGUNA_TAMBAH_PENGGUNA = 1;

        int btnPasswordMode = BTN_PASSWORD_MODIFIKASI_PASSWORD;
        int btnHapusMode = BTN_HAPUS_PENGGUNA_HAPUS_PENGGUNA;

        public frmPengaturanPengguna()
        {
            InitializeComponent();
        }

        private void updateDataPengguna()
        {
            dataPengguna = Program.conn.ExecuteDataTable("SELECT kewenangan.namakewenangan, pengguna.* FROM pengguna INNER JOIN kewenangan ON pengguna.kodekewenangan = kewenangan.kodekewenangan");
        }

        private void updateDataKewenangan()
        {
            dataKewenangan = Program.conn.ExecuteDataTable("SELECT KodeKewenangan, NamaKewenangan FROM kewenangan");
        }
        private void frmPengaturanPengguna_Load(object sender, EventArgs e)
        {
            // Mutakhirkan dataPengguna
            updateDataPengguna();
            updateDataKewenangan();

            // Bariskan daftar nama pengguna pada listPengguna
            for (int i = 0; i < dataPengguna.Rows.Count; i++)
            {
                listPengguna.Items.Add(dataPengguna.Rows[i].ItemArray[3].ToString() + " - [" + dataPengguna.Rows[i].ItemArray[0].ToString() + "]");
            }

            for (int i = 0; i < dataKewenangan.Rows.Count; i++)
            {
                cmbKewenangan.Items.Add(dataKewenangan.Rows[i].ItemArray[1].ToString());
            }
        }

        private void listPengguna_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = listPengguna.SelectedIndex;
            if (index > -1)
            {
                idPenggunaDipilih = Int16.Parse(dataPengguna.Rows[index].ItemArray[1].ToString());
                namaPenggunaDipilih = dataPengguna.Rows[index].ItemArray[3].ToString();
                namaLengkapPenggunaDipilih = dataPengguna.Rows[index].ItemArray[6].ToString();
                kewenanganDipilih = dataPengguna.Rows[index].ItemArray[0].ToString();

                cmbKewenangan.Text = Program.escapeQuoteSQL(kewenanganDipilih);

                lblNamaPengguna.Text = Program.escapeQuoteSQL(namaPenggunaDipilih);
                txtNamaLengkap.Text = Program.escapeQuoteSQL(namaLengkapPenggunaDipilih);
            }
        }

        private void cmbKewenangan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbKewenangan.Text != kewenanganDipilih) && btnHapusMode == BTN_HAPUS_PENGGUNA_HAPUS_PENGGUNA)
            {
                string kewenanganBaru = dataKewenangan.Rows[cmbKewenangan.SelectedIndex].ItemArray[0].ToString();

                // Sebelum mengubah kewenangan, tanyakan terlebih dahulu ke pengguna
                DialogResult jawab = MessageBox.Show("Apakah Anda yakin mengubah hak akses pengguna '" + namaPenggunaDipilih + "' menjadi " + Program.escapeQuoteSQL(cmbKewenangan.Text) + " ?",
                                     "Pengubahak Hak Akses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Jika pengguna menekan tombol "Yes"
                if (jawab == System.Windows.Forms.DialogResult.Yes)
                {
                    Program.conn.ExecuteNonQuery("UPDATE pengguna SET KodeKewenangan='" + kewenanganBaru +
                                                 "' WHERE KodeOperator='" + idPenggunaDipilih + "'");
                    updateDataPengguna();

                    // Modifikasi isi list
                    listPengguna.Items[cmbKewenangan.SelectedIndex] = namaPenggunaDipilih + " [" + Program.escapeQuoteSQL(cmbKewenangan.Text) + "]";

                }

                // Jika tidak
                else
                {
                    cmbKewenangan.Text = Program.escapeQuoteSQL(kewenanganDipilih);
                }
            }
        }

        private void btnUbahPassword_Click(object sender, EventArgs e)
        {
            // Tombol dwi fungsi, lihat sesuai fungsi
            switch (btnPasswordMode)
            {
                // Ketika diklik bertuliskan "Ubah Password"
                case BTN_PASSWORD_MODIFIKASI_PASSWORD:
                    btnPasswordMode = BTN_PASSWORD_APPLY_PASSWORD;
                    btnUbahPassword.Text = "Terapkan Password Baru";
                    txtPassword.Enabled = true;
                    txtPassword.Text = "";
                    listPengguna.Enabled = false;
                    txtPassword.Focus();
                    this.AcceptButton = btnUbahPassword;
                    break;

                // Ketika diklik bertuliskan "Terapkan Password Baru"
                case BTN_PASSWORD_APPLY_PASSWORD:
                    btnPasswordMode = BTN_PASSWORD_MODIFIKASI_PASSWORD;
                    
                    // SHA1(MD5(Password);
                    string newPassword = sha1Encrypt.EncodePassword(md5Encrypt.EncodePassword(txtPassword.Text));

                    // Do password change
                    Program.conn.ExecuteNonQuery("UPDATE pengguna SET password='" + newPassword +
                                                 "' WHERE KodeOperator='" + idPenggunaDipilih + "'");

                    // Kembalikan tombol ke bentuk semula
                    txtPassword.Text = "passwordpasswordpassword";
                    txtPassword.Enabled = false;
                    listPengguna.Enabled = true;
                    btnUbahPassword.Text = "Ubah Password";
                    this.AcceptButton = null;
                    break;
            }
        


        }

      

        private void btnTambahPengguna_Click(object sender, EventArgs e)
        {
            btnHapusMode = BTN_HAPUS_PENGGUNA_TAMBAH_PENGGUNA;
            btnTambahPengguna.Enabled = false;
            btnHapusPengguna.Text = "Tambah Pengguna";
            listPengguna.Enabled = false;
            txtNamaLengkap.Text = "";
            txtPassword.Enabled = true;
            txtPassword.Text = "";
            txtNamaPenggunaBaru.Visible = true;
            btnUbahPassword.Visible = false;
            txtNamaPenggunaBaru.Text = "Nama akun...";
            lblNamaPengguna.Visible = false;
        }


        private void btnHapusPengguna_Click(object sender, EventArgs e)
        {
            int idPenggunaBaru;
            idPenggunaBaru = Int16.Parse(dataPengguna.Rows[dataPengguna.Rows.Count-1].ItemArray[1].ToString());
            idPenggunaBaru++;

            string namaPenggunaBaru = Program.escapeQuoteSQL(txtNamaPenggunaBaru.Text);
            string namaLengkapbaru = Program.escapeQuoteSQL(txtNamaLengkap.Text);
            int kodeKewenanganBaru = Int16.Parse(dataKewenangan.Rows[cmbKewenangan.SelectedIndex].ItemArray[0].ToString());
            string passwordBaru = sha1Encrypt.EncodePassword(md5Encrypt.EncodePassword(txtPassword.Text));

            switch (btnHapusMode)
            {
                case BTN_HAPUS_PENGGUNA_HAPUS_PENGGUNA:
                    DialogResult jawaban = MessageBox.Show("Apakah Anda yakin akan menghapus pengguna '" + namaPenggunaDipilih + "' ?",
                                                            "Konfirmasi Pengahapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (jawaban == System.Windows.Forms.DialogResult.Yes)
                    {
                        // Hapus pengguna dari basis data
                        Program.conn.ExecuteNonQuery("DELETE FROM pengguna WHERE KodeOperator='" + idPenggunaDipilih + "'");
                        listPengguna.Items.RemoveAt(listPengguna.SelectedIndex);
                        listPengguna.SelectedIndex = 0;
                    }
                    else
                    {
                        // Do nothing
                    }
                    break;
                case BTN_HAPUS_PENGGUNA_TAMBAH_PENGGUNA:
                    // OK tambah pengguna
                    Program.conn.ExecuteNonQuery("INSERT INTO pengguna VALUES('" + idPenggunaBaru
                                                 + "', '" + kodeKewenanganBaru + "','" + namaPenggunaBaru
                                                 + "','" + passwordBaru + "','0','" + namaLengkapbaru + "')");

                    updateDataPengguna();

                    // Tambahkan pada daftar
                    listPengguna.Items.Add(namaPenggunaBaru + " [" + cmbKewenangan.Text + "]");

                    // Kembalikan form ke keadaan sebelumnya:
                    btnHapusMode = BTN_HAPUS_PENGGUNA_HAPUS_PENGGUNA;
                    btnHapusPengguna.Text = "Tambah Pengguna";
                    listPengguna.Enabled = true;
                    txtNamaPenggunaBaru.Text = "";
                    txtNamaLengkap.Text = namaLengkapPenggunaDipilih;
                    txtPassword.Enabled = false;
                    txtPassword.Text = "passwordpasswordpassword";
                    txtNamaPenggunaBaru.Visible = false;
                    btnUbahPassword.Visible = true;
                    btnTambahPengguna.Enabled = true;
                    lblNamaPengguna.Visible = true;
                    break;
            }
        }

        private void txtNamaPenggunaBaru_Enter(object sender, EventArgs e)
        {
            txtNamaPenggunaBaru.Text = "";
        }

       
    }
}
