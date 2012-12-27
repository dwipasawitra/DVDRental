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
    public partial class frmPengaturan : Form
    {
        public frmPengaturan()
        {
            InitializeComponent();
        }

        private void frmPengaturan_Load(object sender, EventArgs e)
        {
            // Read each of pengaturan
            // Nama, alamat, namapemilik jasa
            txtNamaJasa.Text = Program.setting.namaJasa.ToString();
            txtAlamat.Text = Program.setting.alamatJasa.ToString();
            txtNamaPemilik.Text = Program.setting.namaPemilik.ToString();

            // Biaya sewa per apa
            switch (Program.setting.biayaSewaPer)
            {
                case appSetting.BIAYA_SEWA_PER_JUDUL:
                    chkSewaPerItem.Checked = true;
                    break;
                case appSetting.BIAYA_SEWA_PER_KATEGORI:
                    chkSewaPerKategori.Checked = true;
                    break;
                case appSetting.BIAYA_SEWA_KEDUANYA:
                    chkSewaPerKategori.Checked = true;
                    chkSewaPerItem.Checked = true;
                    break;
            }

            // Biaya denda per apa
            switch (Program.setting.biayaDendaPer)
            {
                case appSetting.BIAYA_DENDA_PER_JUDUL:
                    chkDendaPerItem.Checked = true;
                    break;
                case appSetting.BIAYA_DENDA_PER_KATEGORI:
                    chkDendaPerKategori.Checked = true;
                    break;
                case appSetting.BIAYA_DENDA_KEDUANYA:
                    chkDendaPerKategori.Checked = true;
                    chkDendaPerItem.Checked = true;
                    break;
            }

            // Maks hari peminjaman
            switch (Program.setting.lamaPenyewaan)
            {
                case appSetting.LAMA_PENYEWAAN_FIX:
                    rbHariDitetapkan.Checked = true;
                    break;
                case appSetting.LAMA_PENYEWAAN_BEBAS:
                    rbHariBebas.Checked = true;
                    break;
            }

            txtJumlahHari.Text = Program.setting.lamaPenyewaanHari.ToString();

            // Maks jumlah peminjaman per transaksi
            switch (Program.setting.maksTransaksi)
            {
                case appSetting.MAKS_TRANSAKSI_MAKS:
                    rbTetapJudul.Checked = true;
                    break;
                case appSetting.MAKS_TRANSAKSI_BEBAS:
                    rbBebasJudul.Checked = true;
                    break;
            }
            txtJumlahJudul.Text = Program.setting.maksTransaksiJumlah.ToString();


        }

        private void btnTerapkan_Click(object sender, EventArgs e)
        {
            // Update app setting
            //Program.setting.app
        }
    }
}
