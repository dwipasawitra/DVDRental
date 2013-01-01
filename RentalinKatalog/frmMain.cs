using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentalinKatalog
{
    public partial class frmMain : Form
    {
        private const int MAX_TOP_KOLEKSI = 10;
        bool sedangMemesan = false;
        bool animateBlink = false;
        string yangDicari = "";
        int idxTopKoleksi = 0;
        string kodeTopKoleksi = "";
        string kodeKoleksiDipilih = "";

        DataTable judulTerbanyak;
        DataTable dataKoleksi;
        DataTable pesananAnda;
        DataTable chat;

        private void cekPesananAnda()
        {
            if (pesananAnda.Rows.Count > 0)
            {
                btnPesan.Enabled = true;
                btnBatalkanPesanan.Enabled = true;
            }
            else
            {
                btnPesan.Enabled = false;
                btnBatalkanPesanan.Enabled = false;
            }

            if (dgPesananAnda.SelectedCells.Count > 0)
            {
                btnHapusPilihan.Enabled = true;
            }
            else
            {
                btnHapusPilihan.Enabled = false;
            }
        }
        private void siapkanPesananAnda()
        {
            // Siapkan tabel untuk pesanan anda
            pesananAnda = new DataTable();
            pesananAnda.Columns.Add("Kode");
            pesananAnda.Columns.Add("Judul");
            pesananAnda.Columns.Add("Genre");
            pesananAnda.Columns.Add("Jenis");

            dgPesananAnda.DataSource = pesananAnda;
            dgPesananAnda.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgPesananAnda.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgPesananAnda.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgPesananAnda.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // OK, sip

        }

        private void updateKoleksi()
        {
            // Jika tidak ada sesuatu yang dicari, maka tampilkan data
            if(yangDicari == "")
            {
                dataKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, jeniskeping.jenis " +
                                                            "from koleksi, genre, jeniskeping where genre.kodekategori = koleksi.kodekategori AND koleksi.jenis = jeniskeping.ID");
            }
            else
            {
                dataKoleksi = Program.conn.ExecuteDataTable("SELECT kodekoleksi, namaitem, genre.namakategori, jeniskeping.jenis " +
                                                            "from koleksi, genre, jeniskeping where genre.kodekategori = koleksi.kodekategori AND koleksi.jenis = jeniskeping.ID AND (upper(kodekoleksi) like '%" + yangDicari.ToUpper() + "%' OR upper(namaitem) like '%" + yangDicari.ToUpper() + "%')");
            }
            // Atur judul kolom 
            dataKoleksi.Columns[0].ColumnName = "Kode Koleksi";
            dataKoleksi.Columns[1].ColumnName = "Judul";
            dataKoleksi.Columns[2].ColumnName = "Kategori";
            dataKoleksi.Columns[3].ColumnName = "Jenis Keping";
       

            // Update isi data grid
            dgKoleksi.DataSource = dataKoleksi;
            dgKoleksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgKoleksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgKoleksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgKoleksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void updateTopKoleksi()
        {
            try
            {
                // Ambil judul terbanyak berdasarkan orang meminjam
                judulTerbanyak = Program.conn.ExecuteDataTable("SELECT koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori, jeniskeping.jenis, count(dipinjam.kodedipinjam) as jumlah "
                                                                    + "FROM stokkoleksi INNER JOIN dipinjam ON dipinjam.kodestok = stokkoleksi.kodestok INNER JOIN koleksi ON stokkoleksi.kodekoleksi = koleksi.kodekoleksi INNER JOIN nota ON dipinjam.nonota = nota.nonota INNER JOIN genre ON koleksi.kodekategori = genre.kodekategori INNER JOIN jeniskeping ON koleksi.jenis = jeniskeping.id "
                                                                    + "GROUP BY koleksi.kodekoleksi, koleksi.namaitem, genre.namakategori, jeniskeping.jenis "
                                                                    + "ORDER BY jumlah DESC ");
                // Muat informasi utama
                kodeTopKoleksi = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[0].ToString();
                lblJudulTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[1].ToString();
                lblGenreTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[2].ToString();
                lblJenisKepingTop.Text = judulTerbanyak.Rows[idxTopKoleksi].ItemArray[3].ToString();
                
                

                // Muat gambar blob dan  deskripsi
                DataTable blobTable = Program.conn.ExecuteDataTable("SELECT coverart, dekripsiitem FROM koleksi WHERE KodeKoleksi='" + kodeTopKoleksi + "'");

                try
                {
                    if (picTopKoleksiTerbaik.Image != null)
                    {
                        picTopKoleksiTerbaik.Image.Dispose();
                        picTopKoleksiTerbaik.Image = null;
                    }

                    // Convert coverart ke gambar
                    if (!Convert.IsDBNull(blobTable.Rows[0].ItemArray[0]))
                    {
                        

                        byte[] blob = (byte[])blobTable.Rows[0].ItemArray[0];
                        Program.displayBlobImage(blob, "topkoleksi");

                        // Tampilkan gambar
                        picTopKoleksiTerbaik.Image = Image.FromFile("topkoleksi");
                        picTopKoleksiTerbaik.SizeMode = PictureBoxSizeMode.StretchImage;
                        picTopKoleksiTerbaik.Refresh();
                    }
                    lblDeskripsiTop.Text = blobTable.Rows[idxTopKoleksi].ItemArray[1].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch
            {
                return;
            }

        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Ambil data Nama dan Alamat
            lblNamaLayanan.Text = Program.setting.namaJasa;
            lblAlamatLayanan.Text = Program.setting.alamatJasa;

            // Update data koleksi dan top koleksi
            updateKoleksi();
            updateTopKoleksi();
            siapkanPesananAnda();
        }

        private void updateChat()
        {
            chat = Program.conn.ExecuteDataTable("SELECT * FROM chat ORDER BY timestamp ASC");
            listChat.Items.Clear();
            for (int i = 0; i < chat.Rows.Count; i++)
            {
                DateTime timeStamp = DateTime.Parse(chat.Rows[i].ItemArray[1].ToString());
                string toChat = timeStamp.Date + " - " + timeStamp.Hour + ":" + timeStamp.Minute + ":" + timeStamp.Second + " ";
                int sender = Int16.Parse(chat.Rows[i].ItemArray[2].ToString());
                if (sender == 0)
                {
                    toChat += "[OPERATOR] ";
                }
                else
                {
                    toChat += "[PELANGGAN] ";
                }
                int dibaca = Int16.Parse(chat.Rows[i].ItemArray[4].ToString());
                if (dibaca == 0) toChat += "** ";
                toChat += chat.Rows[i].ItemArray[3].ToString();
                
                listChat.Items.Add(toChat);
                
            }
        }

        private void sendChat(string toSend)
        {
            int idChat;

            // Dapatkan idChat sebelumnya
            if (chat.Rows.Count > 0)
            {
                idChat = Int16.Parse(chat.Rows[chat.Rows.Count - 1].ItemArray[0].ToString());
                idChat++;
            }
            else
            {
                idChat = 0;
            }
            

            // Kirim chat
            toSend = Program.escapeQuoteSQL(toSend);
            Program.conn.ExecuteNonQuery("INSERT INTO chat VALUES ('" + idChat + "',sysdate,'1','" + toSend + "','0')");
        }

        private void tmrWaktu_Tick(object sender, EventArgs e)
        {
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string day = DateTime.Now.Day.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string year = DateTime.Now.Year.ToString("0000");

            lblDate.Text = day + "/" + month + "/" + year;
            if (animateBlink)
            {
                animateBlink = false;
                lblTime.Text = hour + " " + minute;
            }
            else
            {
                animateBlink = true;
                lblTime.Text = hour + ":" + minute;
            }
            updateChat();
        }

        private void tmrScrollingText_Tick(object sender, EventArgs e)
        {
            int len = lblScrollingText.Text.Length;
            lblScrollingText.Text = lblScrollingText.Text.Substring(1, len - 1) + lblScrollingText.Text.Substring(0, 1);
        }

        private void btnLihatDaftarJudul_Click(object sender, EventArgs e)
        {

            tabControlApp.TabIndex = 1;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {

        }

        private void dgKoleksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgKoleksi.SelectedCells.Count == 1)
            {
                if (dgKoleksi.SelectedCells[0].RowIndex >= 0 && dgKoleksi.SelectedCells[0].RowIndex < dataKoleksi.Rows.Count)
                {

                    int idx = dgKoleksi.SelectedCells[0].RowIndex;
                    showDataDetail(idx);
                }

            }
        }

        private void showDataDetail(int index)
        {

            // Tampilkan nama judul dan genre
            lblJudulKoleksi.Text = dataKoleksi.Rows[index].ItemArray[1].ToString();
            lblGenreKoleksi.Text = dataKoleksi.Rows[index].ItemArray[2].ToString();
            lblJenisKepingKoleksi.Text = dataKoleksi.Rows[index].ItemArray[3].ToString();

            // Ambil deskripsi dan BLOB gambar dari database
            kodeKoleksiDipilih = dataKoleksi.Rows[index].ItemArray[0].ToString();
            DataTable infoJudul, stokKoleksi;
            infoJudul = Program.conn.ExecuteDataTable("SELECT dekripsiitem, coverart FROM koleksi WHERE KodeKoleksi='" + kodeKoleksiDipilih + "'");

            // Kosongkan gambar
            if (picDetailKoleksi.Image != null)
            {
                picDetailKoleksi.Image.Dispose();
                picDetailKoleksi.Image = null;
            }

            try
            {
                // Convert coverart ke gambar
                if (!Convert.IsDBNull(infoJudul.Rows[0].ItemArray[1]))
                {
                    byte[] blob = (byte[])infoJudul.Rows[0].ItemArray[1];
                    Program.displayBlobImage(blob, kodeKoleksiDipilih);

                    // Tampilkan gambar
                    picDetailKoleksi.Image = Image.FromFile(kodeKoleksiDipilih);
                    picDetailKoleksi.SizeMode = PictureBoxSizeMode.StretchImage;
                    picDetailKoleksi.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tampilkan teks pada deskripsi
            lblDeskripsiKoleksi.Text = infoJudul.Rows[0].ItemArray[0].ToString();

            // Cari jumlah stok yang tersedia dari koleksi yang dipilih
            stokKoleksi = Program.conn.ExecuteDataTable("SELECT count(*) FROM StokKoleksi WHERE KodeKoleksi='" + kodeKoleksiDipilih + "' AND Status='0'");
            int jumlahStok = Int16.Parse(stokKoleksi.Rows[0].ItemArray[0].ToString());
            if (jumlahStok > 0)
            {
                lblStokInfo.Text = "Stok: ";
                lblStokJumlah.Text = jumlahStok.ToString();
                lblStokInfo.ForeColor = Color.Black;
                btnTambahKePesanan.Enabled = true;

            }
            else
            {
                lblStokInfo.Text = "Habis";
                lblStokJumlah.Text = "";
                lblStokInfo.ForeColor = Color.Red;
                btnTambahKePesanan.Enabled = false;
            }
            
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            if (txtPencarian.Text != "Pencarian...")
            {
                yangDicari = txtPencarian.Text;
                updateKoleksi();
            }
        }

        private void txtPencarian_Enter(object sender, EventArgs e)
        {
            if (txtPencarian.Text == "Pencarian...")
                txtPencarian.Text = "";
        }

        private void txtPencarian_Leave(object sender, EventArgs e)
        {
            if (txtPencarian.Text == "")
                txtPencarian.Text = "Pencarian...";
        }

        private void dgKoleksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tmrTopKoleksi_Tick(object sender, EventArgs e)
        {
            if (judulTerbanyak.Rows.Count > 0)
            {
                if (judulTerbanyak.Rows.Count < MAX_TOP_KOLEKSI)
                {

                    idxTopKoleksi = (idxTopKoleksi + 1) % judulTerbanyak.Rows.Count;
                }
                else
                {
                    idxTopKoleksi = (idxTopKoleksi + 1) % MAX_TOP_KOLEKSI;
                }
                updateTopKoleksi();
            }
            else
            {
                picTopKoleksiTerbaik.Image = null;
                lblJudulTop.Text = "";
                lblGenreTop.Text = "";
                lblJenisKepingTop.Text = "";
                lblDeskripsiTop.Text = "";
            }
           
        }

        private void tabDepan_Click(object sender, EventArgs e)
        {

        }

        private void tabKoleksi_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahKePesanan_Click(object sender, EventArgs e)
        {
            bool ada = false;
            // Cek apakah yang dipilih sudah masuk ke dalam daftar pesanan
            for (int i = 0; i < pesananAnda.Rows.Count; i++)
            {
                if (pesananAnda.Rows[i].ItemArray[0].ToString() == kodeKoleksiDipilih)
                    ada = true;
            }
            // Tambahkan item ke pesanananda
            if (!ada)
            {
                pesananAnda.Rows.Add(kodeKoleksiDipilih, lblJudulKoleksi.Text, lblGenreKoleksi.Text, lblJenisKepingKoleksi.Text);
                cekPesananAnda();
            }
            
            // Ok sip
        }

        private void btnHapusPilihan_Click(object sender, EventArgs e)
        {
            // Hapus jika ada yang dipilih
            if (dgPesananAnda.SelectedCells.Count > 0)
            {
                int idx = dgPesananAnda.SelectedCells[0].RowIndex;
                pesananAnda.Rows[idx].Delete();
            }
            cekPesananAnda();
        }

        private void btnBatalkanPesanan_Click(object sender, EventArgs e)
        {
            // Bersihkan daftar pesanan
            pesananAnda.Clear();
            cekPesananAnda();
        }

        private void btnProsesPesanan_Click(object sender, EventArgs e)
        {
            frmProsesPesanan form = new frmProsesPesanan(pesananAnda);
            form.ShowDialog(this);
            if (form.isSukses)
            {
                pesananAnda.Clear();
                updateKoleksi();
                
            }
            cekPesananAnda();
        }

        private void dgPesananAnda_SelectionChanged(object sender, EventArgs e)
        {
            cekPesananAnda();
        }

        private void btnKirimPesan_Click(object sender, EventArgs e)
        {
            
            sendChat(txtChatInput.Text);
            txtChatInput.Text = "";
            updateChat();
        }

        private void txtChatInput_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txtChatInput_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnKirimPesan;
        }

       



      
       

        
    }
}
