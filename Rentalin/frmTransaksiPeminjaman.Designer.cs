namespace Rentalin
{
    partial class frmTransaksiPeminjaman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlPeminjam = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKodeMember = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblIdentitas = new System.Windows.Forms.Label();
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.btnCariPelanggan = new System.Windows.Forms.Button();
            this.txtPeminjam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTambahJudul = new System.Windows.Forms.TextBox();
            this.dgPeminjaman = new System.Windows.Forms.DataGridView();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblNamaPenawaran = new System.Windows.Forms.Label();
            this.lblPenawaranSpesialInfo = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblHargaDendaItem = new System.Windows.Forms.Label();
            this.lblHargaDendaItemInfo = new System.Windows.Forms.Label();
            this.lblHargaSewaItem = new System.Windows.Forms.Label();
            this.lblHargaSewaItemInfo = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.cmbStok = new System.Windows.Forms.ComboBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pnlTransaksi = new System.Windows.Forms.Panel();
            this.lblLamaPenyewaan = new System.Windows.Forms.Label();
            this.lblHari = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblBiayaSewa = new System.Windows.Forms.Label();
            this.lblBiayaSewaInfo = new System.Windows.Forms.Label();
            this.lblLamaMenyewaInfo = new System.Windows.Forms.Label();
            this.dtpTanggalKembali = new System.Windows.Forms.DateTimePicker();
            this.lblTanggalKembaliInfo = new System.Windows.Forms.Label();
            this.lblNmrNota = new System.Windows.Forms.Label();
            this.lblNmrNotaInfo = new System.Windows.Forms.Label();
            this.lblDetailTransaksi = new System.Windows.Forms.Label();
            this.btnCariJudul = new System.Windows.Forms.Button();
            this.lblTambahJudul = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.pnlPeminjam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeminjaman)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.pnlTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(0, -1);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(379, 75);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(58, 35);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(309, 13);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Atur pelanggan yang menyewa dan judul apa saja yang dipinjam";
            // 
            // picInfo
            // 
            this.picInfo.Image = global::Rentalin.Properties.Resources.arrowup2;
            this.picInfo.Location = new System.Drawing.Point(12, 10);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(38, 54);
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(56, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(250, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Transaksi Peminjaman";
            // 
            // pnlPeminjam
            // 
            this.pnlPeminjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
            this.pnlPeminjam.Controls.Add(this.button1);
            this.pnlPeminjam.Controls.Add(this.lblKodeMember);
            this.pnlPeminjam.Controls.Add(this.btnOk);
            this.pnlPeminjam.Controls.Add(this.lblIdentitas);
            this.pnlPeminjam.Controls.Add(this.lblNamaPeminjam);
            this.pnlPeminjam.Controls.Add(this.btnCariPelanggan);
            this.pnlPeminjam.Controls.Add(this.txtPeminjam);
            this.pnlPeminjam.Controls.Add(this.label1);
            this.pnlPeminjam.ForeColor = System.Drawing.Color.White;
            this.pnlPeminjam.Location = new System.Drawing.Point(385, -1);
            this.pnlPeminjam.Name = "pnlPeminjam";
            this.pnlPeminjam.Size = new System.Drawing.Size(317, 75);
            this.pnlPeminjam.TabIndex = 2;
            this.pnlPeminjam.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPeminjam_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(151, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKodeMember
            // 
            this.lblKodeMember.AutoSize = true;
            this.lblKodeMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeMember.Location = new System.Drawing.Point(3, 40);
            this.lblKodeMember.Name = "lblKodeMember";
            this.lblKodeMember.Size = new System.Drawing.Size(84, 13);
            this.lblKodeMember.TabIndex = 7;
            this.lblKodeMember.Text = "Kode Member";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(236, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblIdentitas
            // 
            this.lblIdentitas.AutoSize = true;
            this.lblIdentitas.Location = new System.Drawing.Point(3, 55);
            this.lblIdentitas.Name = "lblIdentitas";
            this.lblIdentitas.Size = new System.Drawing.Size(53, 13);
            this.lblIdentitas.TabIndex = 5;
            this.lblIdentitas.Text = "Identitas: ";
            // 
            // lblNamaPeminjam
            // 
            this.lblNamaPeminjam.AutoSize = true;
            this.lblNamaPeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPeminjam.Location = new System.Drawing.Point(3, 24);
            this.lblNamaPeminjam.Name = "lblNamaPeminjam";
            this.lblNamaPeminjam.Size = new System.Drawing.Size(96, 13);
            this.lblNamaPeminjam.TabIndex = 3;
            this.lblNamaPeminjam.Text = "Nama Peminjam";
            // 
            // btnCariPelanggan
            // 
            this.btnCariPelanggan.ForeColor = System.Drawing.Color.Black;
            this.btnCariPelanggan.Location = new System.Drawing.Point(236, 32);
            this.btnCariPelanggan.Name = "btnCariPelanggan";
            this.btnCariPelanggan.Size = new System.Drawing.Size(75, 23);
            this.btnCariPelanggan.TabIndex = 2;
            this.btnCariPelanggan.Text = "Cari...";
            this.btnCariPelanggan.UseVisualStyleBackColor = true;
            this.btnCariPelanggan.Click += new System.EventHandler(this.btnCariPelanggan_Click);
            // 
            // txtPeminjam
            // 
            this.txtPeminjam.Location = new System.Drawing.Point(69, 4);
            this.txtPeminjam.Name = "txtPeminjam";
            this.txtPeminjam.Size = new System.Drawing.Size(157, 20);
            this.txtPeminjam.TabIndex = 1;
            this.txtPeminjam.TextChanged += new System.EventHandler(this.txtPeminjam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peminjam";
            // 
            // txtTambahJudul
            // 
            this.txtTambahJudul.Location = new System.Drawing.Point(212, 91);
            this.txtTambahJudul.Name = "txtTambahJudul";
            this.txtTambahJudul.Size = new System.Drawing.Size(193, 20);
            this.txtTambahJudul.TabIndex = 4;
            this.txtTambahJudul.TextChanged += new System.EventHandler(this.txtTambahJudul_TextChanged);
            // 
            // dgPeminjaman
            // 
            this.dgPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeminjaman.Location = new System.Drawing.Point(12, 126);
            this.dgPeminjaman.Name = "dgPeminjaman";
            this.dgPeminjaman.Size = new System.Drawing.Size(484, 326);
            this.dgPeminjaman.TabIndex = 6;
            this.dgPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPeminjaman_CellContentClick);
            this.dgPeminjaman.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgPeminjaman_RowsRemoved);
            this.dgPeminjaman.SelectionChanged += new System.EventHandler(this.dgPeminjaman_SelectionChanged);
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnlDetail.Controls.Add(this.lblNamaPenawaran);
            this.pnlDetail.Controls.Add(this.lblPenawaranSpesialInfo);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Controls.Add(this.lblHargaDendaItem);
            this.pnlDetail.Controls.Add(this.lblHargaDendaItemInfo);
            this.pnlDetail.Controls.Add(this.lblHargaSewaItem);
            this.pnlDetail.Controls.Add(this.lblHargaSewaItemInfo);
            this.pnlDetail.Controls.Add(this.btnHapus);
            this.pnlDetail.Controls.Add(this.cmbStok);
            this.pnlDetail.Controls.Add(this.lblStok);
            this.pnlDetail.Controls.Add(this.lblGenre);
            this.pnlDetail.Controls.Add(this.lblJudul);
            this.pnlDetail.ForeColor = System.Drawing.Color.White;
            this.pnlDetail.Location = new System.Drawing.Point(510, 86);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(191, 365);
            this.pnlDetail.TabIndex = 7;
            // 
            // lblNamaPenawaran
            // 
            this.lblNamaPenawaran.AutoSize = true;
            this.lblNamaPenawaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaPenawaran.Location = new System.Drawing.Point(11, 288);
            this.lblNamaPenawaran.Name = "lblNamaPenawaran";
            this.lblNamaPenawaran.Size = new System.Drawing.Size(140, 18);
            this.lblNamaPenawaran.TabIndex = 25;
            this.lblNamaPenawaran.Text = "Nama Penawaran";
            // 
            // lblPenawaranSpesialInfo
            // 
            this.lblPenawaranSpesialInfo.AutoSize = true;
            this.lblPenawaranSpesialInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenawaranSpesialInfo.Location = new System.Drawing.Point(11, 264);
            this.lblPenawaranSpesialInfo.Name = "lblPenawaranSpesialInfo";
            this.lblPenawaranSpesialInfo.Size = new System.Drawing.Size(160, 13);
            this.lblPenawaranSpesialInfo.TabIndex = 24;
            this.lblPenawaranSpesialInfo.Text = "Penawaran Spesial Hari Ini";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(4, 9);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(155, 16);
            this.lblDetail.TabIndex = 23;
            this.lblDetail.Text = "Detail item Transaksi";
            // 
            // lblHargaDendaItem
            // 
            this.lblHargaDendaItem.AutoSize = true;
            this.lblHargaDendaItem.Location = new System.Drawing.Point(7, 144);
            this.lblHargaDendaItem.Name = "lblHargaDendaItem";
            this.lblHargaDendaItem.Size = new System.Drawing.Size(13, 13);
            this.lblHargaDendaItem.TabIndex = 21;
            this.lblHargaDendaItem.Text = "0";
            // 
            // lblHargaDendaItemInfo
            // 
            this.lblHargaDendaItemInfo.AutoSize = true;
            this.lblHargaDendaItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaDendaItemInfo.Location = new System.Drawing.Point(7, 127);
            this.lblHargaDendaItemInfo.Name = "lblHargaDendaItemInfo";
            this.lblHargaDendaItemInfo.Size = new System.Drawing.Size(155, 13);
            this.lblHargaDendaItemInfo.TabIndex = 20;
            this.lblHargaDendaItemInfo.Text = "Harga Denda Asli per Hari";
            // 
            // lblHargaSewaItem
            // 
            this.lblHargaSewaItem.AutoSize = true;
            this.lblHargaSewaItem.Location = new System.Drawing.Point(7, 102);
            this.lblHargaSewaItem.Name = "lblHargaSewaItem";
            this.lblHargaSewaItem.Size = new System.Drawing.Size(13, 13);
            this.lblHargaSewaItem.TabIndex = 19;
            this.lblHargaSewaItem.Text = "0";
            // 
            // lblHargaSewaItemInfo
            // 
            this.lblHargaSewaItemInfo.AutoSize = true;
            this.lblHargaSewaItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaSewaItemInfo.Location = new System.Drawing.Point(7, 85);
            this.lblHargaSewaItemInfo.Name = "lblHargaSewaItemInfo";
            this.lblHargaSewaItemInfo.Size = new System.Drawing.Size(149, 13);
            this.lblHargaSewaItemInfo.TabIndex = 18;
            this.lblHargaSewaItemInfo.Text = "Harga Sewa Asli per Hari";
            // 
            // btnHapus
            // 
            this.btnHapus.ForeColor = System.Drawing.Color.Black;
            this.btnHapus.Location = new System.Drawing.Point(7, 221);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(179, 27);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus item";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // cmbStok
            // 
            this.cmbStok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStok.FormattingEnabled = true;
            this.cmbStok.Location = new System.Drawing.Point(7, 194);
            this.cmbStok.Name = "cmbStok";
            this.cmbStok.Size = new System.Drawing.Size(179, 21);
            this.cmbStok.TabIndex = 16;
            this.cmbStok.SelectedIndexChanged += new System.EventHandler(this.cmbStok_SelectedIndexChanged);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStok.Location = new System.Drawing.Point(4, 178);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(72, 13);
            this.lblStok.TabIndex = 15;
            this.lblStok.Text = "Stok Dipilih";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(4, 51);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Genre";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.White;
            this.lblJudul.Location = new System.Drawing.Point(4, 38);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(63, 13);
            this.lblJudul.TabIndex = 13;
            this.lblJudul.Text = "Judul Film";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(411, 91);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(85, 20);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pnlTransaksi
            // 
            this.pnlTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.pnlTransaksi.Controls.Add(this.lblLamaPenyewaan);
            this.pnlTransaksi.Controls.Add(this.lblHari);
            this.pnlTransaksi.Controls.Add(this.btnProses);
            this.pnlTransaksi.Controls.Add(this.lblBiayaSewa);
            this.pnlTransaksi.Controls.Add(this.lblBiayaSewaInfo);
            this.pnlTransaksi.Controls.Add(this.lblLamaMenyewaInfo);
            this.pnlTransaksi.Controls.Add(this.dtpTanggalKembali);
            this.pnlTransaksi.Controls.Add(this.lblTanggalKembaliInfo);
            this.pnlTransaksi.Controls.Add(this.lblNmrNota);
            this.pnlTransaksi.Controls.Add(this.lblNmrNotaInfo);
            this.pnlTransaksi.Controls.Add(this.lblDetailTransaksi);
            this.pnlTransaksi.ForeColor = System.Drawing.Color.White;
            this.pnlTransaksi.Location = new System.Drawing.Point(0, 458);
            this.pnlTransaksi.Name = "pnlTransaksi";
            this.pnlTransaksi.Size = new System.Drawing.Size(702, 73);
            this.pnlTransaksi.TabIndex = 9;
            // 
            // lblLamaPenyewaan
            // 
            this.lblLamaPenyewaan.AutoSize = true;
            this.lblLamaPenyewaan.Location = new System.Drawing.Point(350, 52);
            this.lblLamaPenyewaan.Name = "lblLamaPenyewaan";
            this.lblLamaPenyewaan.Size = new System.Drawing.Size(13, 13);
            this.lblLamaPenyewaan.TabIndex = 11;
            this.lblLamaPenyewaan.Text = "0";
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Location = new System.Drawing.Point(371, 51);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(24, 13);
            this.lblHari.TabIndex = 10;
            this.lblHari.Text = "hari";
            // 
            // btnProses
            // 
            this.btnProses.ForeColor = System.Drawing.Color.Black;
            this.btnProses.Location = new System.Drawing.Point(552, 10);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(127, 53);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Proses Transaksi";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblBiayaSewa
            // 
            this.lblBiayaSewa.AutoSize = true;
            this.lblBiayaSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiayaSewa.Location = new System.Drawing.Point(408, 28);
            this.lblBiayaSewa.Name = "lblBiayaSewa";
            this.lblBiayaSewa.Size = new System.Drawing.Size(21, 24);
            this.lblBiayaSewa.TabIndex = 8;
            this.lblBiayaSewa.Text = "0";
            // 
            // lblBiayaSewaInfo
            // 
            this.lblBiayaSewaInfo.AutoSize = true;
            this.lblBiayaSewaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiayaSewaInfo.Location = new System.Drawing.Point(408, 12);
            this.lblBiayaSewaInfo.Name = "lblBiayaSewaInfo";
            this.lblBiayaSewaInfo.Size = new System.Drawing.Size(106, 13);
            this.lblBiayaSewaInfo.TabIndex = 7;
            this.lblBiayaSewaInfo.Text = "Total Biaya Sewa";
            // 
            // lblLamaMenyewaInfo
            // 
            this.lblLamaMenyewaInfo.AutoSize = true;
            this.lblLamaMenyewaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamaMenyewaInfo.Location = new System.Drawing.Point(240, 51);
            this.lblLamaMenyewaInfo.Name = "lblLamaMenyewaInfo";
            this.lblLamaMenyewaInfo.Size = new System.Drawing.Size(106, 13);
            this.lblLamaMenyewaInfo.TabIndex = 5;
            this.lblLamaMenyewaInfo.Text = "Lama Penyewaan";
            // 
            // dtpTanggalKembali
            // 
            this.dtpTanggalKembali.Location = new System.Drawing.Point(243, 28);
            this.dtpTanggalKembali.Name = "dtpTanggalKembali";
            this.dtpTanggalKembali.Size = new System.Drawing.Size(152, 20);
            this.dtpTanggalKembali.TabIndex = 4;
            this.dtpTanggalKembali.ValueChanged += new System.EventHandler(this.dtpTanggalKembali_ValueChanged);
            // 
            // lblTanggalKembaliInfo
            // 
            this.lblTanggalKembaliInfo.AutoSize = true;
            this.lblTanggalKembaliInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalKembaliInfo.Location = new System.Drawing.Point(240, 12);
            this.lblTanggalKembaliInfo.Name = "lblTanggalKembaliInfo";
            this.lblTanggalKembaliInfo.Size = new System.Drawing.Size(101, 13);
            this.lblTanggalKembaliInfo.TabIndex = 3;
            this.lblTanggalKembaliInfo.Text = "Tanggal Kembali";
            // 
            // lblNmrNota
            // 
            this.lblNmrNota.AutoSize = true;
            this.lblNmrNota.Location = new System.Drawing.Point(136, 34);
            this.lblNmrNota.Name = "lblNmrNota";
            this.lblNmrNota.Size = new System.Drawing.Size(65, 13);
            this.lblNmrNota.TabIndex = 2;
            this.lblNmrNota.Text = "KI20244913";
            // 
            // lblNmrNotaInfo
            // 
            this.lblNmrNotaInfo.AutoSize = true;
            this.lblNmrNotaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrNotaInfo.Location = new System.Drawing.Point(136, 12);
            this.lblNmrNotaInfo.Name = "lblNmrNotaInfo";
            this.lblNmrNotaInfo.Size = new System.Drawing.Size(74, 13);
            this.lblNmrNotaInfo.TabIndex = 1;
            this.lblNmrNotaInfo.Text = "Nomor Nota";
            // 
            // lblDetailTransaksi
            // 
            this.lblDetailTransaksi.AutoSize = true;
            this.lblDetailTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTransaksi.Location = new System.Drawing.Point(12, 13);
            this.lblDetailTransaksi.Name = "lblDetailTransaksi";
            this.lblDetailTransaksi.Size = new System.Drawing.Size(109, 40);
            this.lblDetailTransaksi.TabIndex = 0;
            this.lblDetailTransaksi.Text = "DETAIL\r\nTRANSAKSI";
            // 
            // btnCariJudul
            // 
            this.btnCariJudul.Location = new System.Drawing.Point(121, 91);
            this.btnCariJudul.Name = "btnCariJudul";
            this.btnCariJudul.Size = new System.Drawing.Size(85, 20);
            this.btnCariJudul.TabIndex = 5;
            this.btnCariJudul.Text = "Cari Judul";
            this.btnCariJudul.UseVisualStyleBackColor = true;
            this.btnCariJudul.Click += new System.EventHandler(this.btnCariJudul_Click);
            // 
            // lblTambahJudul
            // 
            this.lblTambahJudul.AutoSize = true;
            this.lblTambahJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTambahJudul.Location = new System.Drawing.Point(9, 93);
            this.lblTambahJudul.Name = "lblTambahJudul";
            this.lblTambahJudul.Size = new System.Drawing.Size(106, 16);
            this.lblTambahJudul.TabIndex = 3;
            this.lblTambahJudul.Text = "Tambah Judul";
            // 
            // frmTransaksiPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 530);
            this.Controls.Add(this.pnlTransaksi);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.dgPeminjaman);
            this.Controls.Add(this.btnCariJudul);
            this.Controls.Add(this.txtTambahJudul);
            this.Controls.Add(this.lblTambahJudul);
            this.Controls.Add(this.pnlPeminjam);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransaksiPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Transaksi Peminjaman";
            this.Load += new System.EventHandler(this.frmTransaksiPeminjaman_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.pnlPeminjam.ResumeLayout(false);
            this.pnlPeminjam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeminjaman)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.pnlTransaksi.ResumeLayout(false);
            this.pnlTransaksi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Panel pnlPeminjam;
        private System.Windows.Forms.Label lblIdentitas;
        private System.Windows.Forms.Label lblNamaPeminjam;
        private System.Windows.Forms.Button btnCariPelanggan;
        private System.Windows.Forms.TextBox txtPeminjam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTambahJudul;
        private System.Windows.Forms.DataGridView dgPeminjaman;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ComboBox cmbStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel pnlTransaksi;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblBiayaSewa;
        private System.Windows.Forms.Label lblBiayaSewaInfo;
        private System.Windows.Forms.Label lblLamaMenyewaInfo;
        private System.Windows.Forms.DateTimePicker dtpTanggalKembali;
        private System.Windows.Forms.Label lblTanggalKembaliInfo;
        private System.Windows.Forms.Label lblNmrNota;
        private System.Windows.Forms.Label lblNmrNotaInfo;
        private System.Windows.Forms.Label lblDetailTransaksi;
        private System.Windows.Forms.Label lblHargaSewaItem;
        private System.Windows.Forms.Label lblHargaSewaItemInfo;
        private System.Windows.Forms.Label lblHargaDendaItem;
        private System.Windows.Forms.Label lblHargaDendaItemInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblKodeMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLamaPenyewaan;
        private System.Windows.Forms.Button btnCariJudul;
        private System.Windows.Forms.Label lblTambahJudul;
        private System.Windows.Forms.Label lblPenawaranSpesialInfo;
        private System.Windows.Forms.Label lblNamaPenawaran;
    }
}