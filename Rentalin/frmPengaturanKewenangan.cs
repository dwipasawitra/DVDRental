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
    public partial class frmPengaturanKewenangan : Form
    {
        DataTable roleList;
        int selectedKodeKewenangan;


        public frmPengaturanKewenangan()
        {
            InitializeComponent();
        }

      
        private void frmPengaturanKewenangan_Load(object sender, EventArgs e)
        {
            // Buka basis data
            updateRoleList();
            
            // Daftarkan nama kewenangan di daftar listKewenangan
            for (int i = 0; i < roleList.Rows.Count; i++)
            {
                listKewenangan.Items.Add(roleList.Rows[i].ItemArray[1].ToString());
            }

            // Disable centangan kewenangan sebelum orang memilih daftar kewenangan nantinya
            gbDetailKewenangan.Enabled = false;
        }

        private void listKewenangan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listKewenangan.SelectedIndex;
            if (index > -1)
            {
                gbDetailKewenangan.Enabled = true;
                selectedKodeKewenangan = Int16.Parse(roleList.Rows[index].ItemArray[0].ToString());
                //MessageBox.Show(selectedKodeKewenangan.ToString());
                updateCbKewenangan(index);
            }
        }

        public void updateCbKewenangan(int index)
        {
            if (index > -1)
            {
                // Master pelanggan
                if (roleList.Rows[index].ItemArray[2].ToString() == "1")
                    chkMasterPelanggan.Checked = true;
                else
                    chkMasterPelanggan.Checked = false;
                // Master koleksi
                if (roleList.Rows[index].ItemArray[3].ToString() == "1")
                    chkMasterKoleksi.Checked = true;
                else
                    chkMasterKoleksi.Checked = false;
                // Master stok
                if (roleList.Rows[index].ItemArray[4].ToString() == "1")
                    chkMasterStok.Checked = true;
                else
                    chkMasterStok.Checked = false;
                // Transaksi
                if (roleList.Rows[index].ItemArray[5].ToString() == "1")
                    chkTransaksi.Checked = true;
                else
                    chkTransaksi.Checked = false;
                // Laporan per Transaksi
                if (roleList.Rows[index].ItemArray[6].ToString() == "1")
                    chkLaporanNota.Checked = true;
                else
                    chkLaporanNota.Checked = false;
                // Laporan Transaksi
                if (roleList.Rows[index].ItemArray[7].ToString() == "1")
                    chkLaporanTransaksi.Checked = true;
                else
                    chkLaporanTransaksi.Checked = false;
                // Laporan keuangan
                if (roleList.Rows[index].ItemArray[8].ToString() == "1")
                    chkLaporanKeuangan.Checked = true;
                else
                    chkLaporanKeuangan.Checked = false;
                // Hall of fame
                if (roleList.Rows[index].ItemArray[9].ToString() == "1")
                    chkHallOfFame.Checked = true;
                else
                    chkHallOfFame.Checked = false;
                // Pengaturan sistem
                if (roleList.Rows[index].ItemArray[10].ToString() == "1")
                    chkPengaturanSistem.Checked = true;
                else
                    chkPengaturanSistem.Checked = false;
                // Pengaturan kewenangan
                if (roleList.Rows[index].ItemArray[11].ToString() == "1")
                    chkPengaturanKewenangan.Checked = true;
                else
                    chkPengaturanKewenangan.Checked = false;
                // Pengaturan pengguna
                if (roleList.Rows[index].ItemArray[12].ToString() == "1")
                    chkPengaturanPengguna.Checked = true;
                else
                    chkPengaturanPengguna.Checked = false;
                // Pengaturan penawaran menarik
                if (roleList.Rows[index].ItemArray[13].ToString() == "1")
                    chkPenawaranMenarik.Checked = true;
                else
                    chkPenawaranMenarik.Checked = false;
                // Jendela pertama
                if (roleList.Rows[index].ItemArray[14].ToString() == "1")
                    cmbJendelaPertama.SelectedIndex = 1;
                else
                    cmbJendelaPertama.SelectedIndex = 0;
            }
            else
            {
                gbDetailKewenangan.Enabled = false;
            }

        }

        private void chkMasterPelanggan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasterPelanggan.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterPelanggan=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterPelanggan=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }

        

        }

        private void chkMasterKoleksi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasterKoleksi.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterKoleksi=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterKoleksi=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkMasterStok_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasterStok.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterStok=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET MasterStok=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkTransaksi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaksi.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET Transaksi=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET Transaksi=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkLaporanNota_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaporanNota.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanPerTransaksi=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanPerTransaksi=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkLaporanTransaksi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaporanTransaksi.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanTransaksi=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanTransaksi=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkLaporanKeuangan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLaporanKeuangan.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanKeuangan=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET LaporanKeuangan=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkHallOfFame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHallOfFame.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET HallOfFame=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET HallOfFame=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkPengaturanSistem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPengaturanSistem.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanSistem=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanSistem=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkPengaturanKewenangan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPengaturanKewenangan.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanKewenangan=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanKewenangan=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkPengaturanPengguna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPengaturanPengguna.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanPengguna=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanPengguna=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void chkPenawaranMenarik_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenawaranMenarik.Checked == true)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanPenawaranMenarik=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET PengaturanPenawaranMenarik=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void cmbJendelaPertama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJendelaPertama.SelectedIndex == 1)
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET JendelaPertama=1 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            else
            {
                Program.conn.ExecuteNonQuery("UPDATE kewenangan SET JendelaPertama=0 WHERE kodekewenangan=" + selectedKodeKewenangan);
            }
            updateRoleList();
        }

        private void frmPengaturanKewenangan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.role.roleApplyThis();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            btnTambah.Visible = false;
            btnHapus.Visible = false;
            listKewenangan.Enabled = false;
            gbDetailKewenangan.Enabled = false;

            txtNamaKewenanganBaru.Visible = true;
            btnTambahKewenanganBaru.Visible = true;
            this.AcceptButton = btnTambahKewenanganBaru;

        }

        private void btnTambahKewenanganBaru_Click(object sender, EventArgs e)
        {
            string namaKewenanganBaru;
            int nomorKewenanganTerakhir;

            namaKewenanganBaru = txtNamaKewenanganBaru.Text;
            nomorKewenanganTerakhir = Int16.Parse(roleList.Rows[roleList.Rows.Count - 1].ItemArray[0].ToString());

            // Insert into database, first

            Program.conn.ExecuteNonQuery("INSERT INTO kewenangan VALUES (" + (nomorKewenanganTerakhir+1) + ",'" + namaKewenanganBaru + "',0,0,0,0,0,0,0,0,0,0,0,0,0)");
            updateRoleList();
            listKewenangan.Items.Add(namaKewenanganBaru);
            btnTambahKewenanganBaru.Visible = false;
            txtNamaKewenanganBaru.Visible = false;
            btnTambah.Visible = true;
            btnHapus.Visible = true;
            listKewenangan.Enabled = true;

        }

        private void updateRoleList()
        {
            roleList = Program.conn.ExecuteDataTable("SELECT * from kewenangan");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Cek apakah list ada yang terpilih
            if (listKewenangan.SelectedIndex >= 0)
            {
                // Hapus dari basis data
                Program.conn.ExecuteNonQuery("DELETE FROM kewenangan WHERE kodekewenangan=" + selectedKodeKewenangan);

                // Hapus dari daftar
                listKewenangan.Items.RemoveAt(listKewenangan.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Pilih kewenangan yang ingin dihapus terlebih dahulu", "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbDetailKewenangan_Enter(object sender, EventArgs e)
        {

        }

    }
}
