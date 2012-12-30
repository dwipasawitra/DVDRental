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
    public partial class frmHallOfFame : Form
    {
        DataTable pelangganTerbanyak;
        DataTable judulTerbanyal;

        public frmHallOfFame()
        {
            InitializeComponent();
        }

        private void emptyLabel()
        {
            lblNamaMember1.Text = "";
            lblNamaMember2.Text = "";
            lblNamaMember3.Text = "";
            lblNamaMember4.Text = "";
            lblNamaMember5.Text = "";

            lblJumlahPeminjam1.Text = "";
            lblJumlahPeminjam2.Text = "";
            lblJumlahPeminjam3.Text = "";
            lblJumlahPeminjam4.Text = "";
            lblJumlahPeminjam5.Text = "";

            lblJudul1.Text = "";
            lblJudul2.Text = "";
            lblJudul3.Text = "";
            lblJudul4.Text = "";
            lblJudul5.Text = "";

            lblGenre1.Text = "";
            lblGenre2.Text = "";
            lblGenre3.Text = "";
            lblGenre4.Text = "";
            lblGenre5.Text = "";

            lblJumlahJudul1.Text = "";
            lblJumlahJudul2.Text = "";
            lblJumlahJudul3.Text = "";
            lblJumlahJudul4.Text = "";
            lblJumlahJudul5.Text = "";
        }

        private void loadData()
        {
            int month = cmbBulan.SelectedIndex + 1;
            int year = Int16.Parse(cmbTahun.Text);

            string blnTanggal = month.ToString("00") + year.ToString("0000");

            // Berdasarkan bulan dan tahun
            // Ambil 5 besar pelanggan terbanyak meminjam
            pelangganTerbanyak = Program.conn.ExecuteDataTable("SELECT member.kodemember, member.namamember, count(nota.nonota) as jumlah "
                                                                + "FROM member INNER JOIN nota ON member.kodemember = nota.kodemember "
                                                                + "WHERE to_char(nota.tgltransaksi, 'MMYYYY')='" + blnTanggal + "' "
                                                                + "GROUP BY member.kodemember, member.namamember "
                                                                + "ORDER BY jumlah DESC ");

            // Ambil 5 besar judul yang banyak terpinjam
        }
        private void frmHallOfFame_Load(object sender, EventArgs e)
        {
            // Isi tahun pada combobox tahun
            cmbTahun.Items.Clear();
            int tahunsekarang = DateTime.Now.Year;
            for (int i = -10; i <= 10; i++)
            {
                cmbTahun.Items.Add(tahunsekarang - i);
            }

            // Pilih tahun dan bulan sekarang
            cmbTahun.Text = tahunsekarang.ToString();
            cmbBulan.SelectedIndex = DateTime.Now.Month - 1;

            // Load data
            loadData();

        }

        private void pnlJudulTerbanyakDipinjam_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
