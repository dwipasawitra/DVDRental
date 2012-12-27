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

                MessageBox.Show(kewenanganDipilih);

                lblNamaPengguna.Text = namaPenggunaDipilih;
                txtNamaLengkap.Text = namaLengkapPenggunaDipilih;
            }
        }
    }
}
