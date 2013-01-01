namespace Rentalin
{
    partial class frmTransaksiPengembalian
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
            this.btnProses = new System.Windows.Forms.Button();
            this.lblBiayaDenda = new System.Windows.Forms.Label();
            this.lblBiayaDendaInfo = new System.Windows.Forms.Label();
            this.lblLamaTelat = new System.Windows.Forms.Label();
            this.lblLamaTelatInfo = new System.Windows.Forms.Label();
            this.lblTanggalSeharusnyaKembaliInfo = new System.Windows.Forms.Label();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.lblNmrNota = new System.Windows.Forms.Label();
            this.lblNmrNotaInfo = new System.Windows.Forms.Label();
            this.lblDetailTransaksi = new System.Windows.Forms.Label();
            this.lblKondisi = new System.Windows.Forms.Label();
            this.pnlTransaksi = new System.Windows.Forms.Panel();
            this.lblHari = new System.Windows.Forms.Label();
            this.lblTanggalSeharusnyaKembali = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dgPengembalian = new System.Windows.Forms.DataGridView();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblIdentitas = new System.Windows.Forms.Label();
            this.lblKodeMember = new System.Windows.Forms.Label();
            this.lblNamaPeminjam = new System.Windows.Forms.Label();
            this.pnlPeminjam = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCariPelanggan = new System.Windows.Forms.Button();
            this.txtPeminjam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDendaPersen = new System.Windows.Forms.Label();
            this.lblDendaPersenInfo = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblStokInfo = new System.Windows.Forms.Label();
            this.lblDendaKerusakan = new System.Windows.Forms.Label();
            this.lblHargaDendaItem = new System.Windows.Forms.Label();
            this.lblDendaKerusakanInfo = new System.Windows.Forms.Label();
            this.lblHargaDendaItemInfo = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.pnlTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPengembalian)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.pnlPeminjam.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.ForeColor = System.Drawing.Color.Black;
            this.btnProses.Location = new System.Drawing.Point(740, 8);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(127, 53);
            this.btnProses.TabIndex = 9;
            this.btnProses.Text = "Proses Transaksi";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblBiayaDenda
            // 
            this.lblBiayaDenda.AutoSize = true;
            this.lblBiayaDenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiayaDenda.Location = new System.Drawing.Point(579, 28);
            this.lblBiayaDenda.Name = "lblBiayaDenda";
            this.lblBiayaDenda.Size = new System.Drawing.Size(21, 24);
            this.lblBiayaDenda.TabIndex = 8;
            this.lblBiayaDenda.Text = "0";
            // 
            // lblBiayaDendaInfo
            // 
            this.lblBiayaDendaInfo.AutoSize = true;
            this.lblBiayaDendaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiayaDendaInfo.Location = new System.Drawing.Point(579, 12);
            this.lblBiayaDendaInfo.Name = "lblBiayaDendaInfo";
            this.lblBiayaDendaInfo.Size = new System.Drawing.Size(112, 13);
            this.lblBiayaDendaInfo.TabIndex = 7;
            this.lblBiayaDendaInfo.Text = "Total Biaya Denda";
            // 
            // lblLamaTelat
            // 
            this.lblLamaTelat.AutoSize = true;
            this.lblLamaTelat.Location = new System.Drawing.Point(439, 47);
            this.lblLamaTelat.Name = "lblLamaTelat";
            this.lblLamaTelat.Size = new System.Drawing.Size(13, 13);
            this.lblLamaTelat.TabIndex = 6;
            this.lblLamaTelat.Text = "0";
            this.lblLamaTelat.Click += new System.EventHandler(this.lblLamaTelat_Click);
            // 
            // lblLamaTelatInfo
            // 
            this.lblLamaTelatInfo.AutoSize = true;
            this.lblLamaTelatInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamaTelatInfo.Location = new System.Drawing.Point(312, 47);
            this.lblLamaTelatInfo.Name = "lblLamaTelatInfo";
            this.lblLamaTelatInfo.Size = new System.Drawing.Size(121, 13);
            this.lblLamaTelatInfo.TabIndex = 5;
            this.lblLamaTelatInfo.Text = "Lama keterlambatan";
            // 
            // lblTanggalSeharusnyaKembaliInfo
            // 
            this.lblTanggalSeharusnyaKembaliInfo.AutoSize = true;
            this.lblTanggalSeharusnyaKembaliInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalSeharusnyaKembaliInfo.Location = new System.Drawing.Point(312, 8);
            this.lblTanggalSeharusnyaKembaliInfo.Name = "lblTanggalSeharusnyaKembaliInfo";
            this.lblTanggalSeharusnyaKembaliInfo.Size = new System.Drawing.Size(171, 13);
            this.lblTanggalSeharusnyaKembaliInfo.TabIndex = 3;
            this.lblTanggalSeharusnyaKembaliInfo.Text = "Tanggal Seharusnya Kembali";
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Location = new System.Drawing.Point(7, 229);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.Size = new System.Drawing.Size(172, 21);
            this.cmbKondisi.TabIndex = 16;
            this.cmbKondisi.SelectedIndexChanged += new System.EventHandler(this.cmbKondisi_SelectedIndexChanged);
            // 
            // lblNmrNota
            // 
            this.lblNmrNota.AutoSize = true;
            this.lblNmrNota.Location = new System.Drawing.Point(136, 34);
            this.lblNmrNota.Name = "lblNmrNota";
            this.lblNmrNota.Size = new System.Drawing.Size(58, 13);
            this.lblNmrNota.TabIndex = 2;
            this.lblNmrNota.Text = "Kode Nota";
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
            // lblKondisi
            // 
            this.lblKondisi.AutoSize = true;
            this.lblKondisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKondisi.Location = new System.Drawing.Point(4, 213);
            this.lblKondisi.Name = "lblKondisi";
            this.lblKondisi.Size = new System.Drawing.Size(131, 13);
            this.lblKondisi.TabIndex = 15;
            this.lblKondisi.Text = "Kondisi Pengembalian";
            // 
            // pnlTransaksi
            // 
            this.pnlTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(173)))), ((int)(((byte)(191)))));
            this.pnlTransaksi.Controls.Add(this.lblHari);
            this.pnlTransaksi.Controls.Add(this.lblTanggalSeharusnyaKembali);
            this.pnlTransaksi.Controls.Add(this.btnProses);
            this.pnlTransaksi.Controls.Add(this.lblBiayaDenda);
            this.pnlTransaksi.Controls.Add(this.lblBiayaDendaInfo);
            this.pnlTransaksi.Controls.Add(this.lblLamaTelat);
            this.pnlTransaksi.Controls.Add(this.lblLamaTelatInfo);
            this.pnlTransaksi.Controls.Add(this.lblTanggalSeharusnyaKembaliInfo);
            this.pnlTransaksi.Controls.Add(this.lblNmrNota);
            this.pnlTransaksi.Controls.Add(this.lblNmrNotaInfo);
            this.pnlTransaksi.Controls.Add(this.lblDetailTransaksi);
            this.pnlTransaksi.ForeColor = System.Drawing.Color.White;
            this.pnlTransaksi.Location = new System.Drawing.Point(-6, 452);
            this.pnlTransaksi.Name = "pnlTransaksi";
            this.pnlTransaksi.Size = new System.Drawing.Size(899, 73);
            this.pnlTransaksi.TabIndex = 18;
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Location = new System.Drawing.Point(466, 47);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(26, 13);
            this.lblHari.TabIndex = 11;
            this.lblHari.Text = "Hari";
            // 
            // lblTanggalSeharusnyaKembali
            // 
            this.lblTanggalSeharusnyaKembali.AutoSize = true;
            this.lblTanggalSeharusnyaKembali.Location = new System.Drawing.Point(312, 24);
            this.lblTanggalSeharusnyaKembali.Name = "lblTanggalSeharusnyaKembali";
            this.lblTanggalSeharusnyaKembali.Size = new System.Drawing.Size(86, 13);
            this.lblTanggalSeharusnyaKembali.TabIndex = 10;
            this.lblTanggalSeharusnyaKembali.Text = "Tanggal Kembali";
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
            // dgPengembalian
            // 
            this.dgPengembalian.AllowUserToAddRows = false;
            this.dgPengembalian.AllowUserToDeleteRows = false;
            this.dgPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPengembalian.Location = new System.Drawing.Point(6, 80);
            this.dgPengembalian.Name = "dgPengembalian";
            this.dgPengembalian.ReadOnly = true;
            this.dgPengembalian.Size = new System.Drawing.Size(690, 366);
            this.dgPengembalian.TabIndex = 15;
            this.dgPengembalian.SelectionChanged += new System.EventHandler(this.dgPengembalian_SelectionChanged);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pnlInfo.Controls.Add(this.lblInfoDetail);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.ForeColor = System.Drawing.Color.White;
            this.pnlInfo.Location = new System.Drawing.Point(-6, -4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(571, 75);
            this.pnlInfo.TabIndex = 10;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.ForeColor = System.Drawing.Color.White;
            this.lblInfoDetail.Location = new System.Drawing.Point(58, 35);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(174, 26);
            this.lblInfoDetail.TabIndex = 5;
            this.lblInfoDetail.Text = "Atur pelanggan yang menyewa dan\r\natur kondisi barang setelah disewa";
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
            this.lblInfo.Size = new System.Drawing.Size(271, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Transaksi Pengembalian";
            // 
            // lblIdentitas
            // 
            this.lblIdentitas.AutoSize = true;
            this.lblIdentitas.Location = new System.Drawing.Point(3, 52);
            this.lblIdentitas.Name = "lblIdentitas";
            this.lblIdentitas.Size = new System.Drawing.Size(53, 13);
            this.lblIdentitas.TabIndex = 5;
            this.lblIdentitas.Text = "Identitas: ";
            // 
            // lblKodeMember
            // 
            this.lblKodeMember.AutoSize = true;
            this.lblKodeMember.Location = new System.Drawing.Point(3, 38);
            this.lblKodeMember.Name = "lblKodeMember";
            this.lblKodeMember.Size = new System.Drawing.Size(73, 13);
            this.lblKodeMember.TabIndex = 4;
            this.lblKodeMember.Text = "Kode Member";
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
            // pnlPeminjam
            // 
            this.pnlPeminjam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.pnlPeminjam.Controls.Add(this.btnOk);
            this.pnlPeminjam.Controls.Add(this.lblIdentitas);
            this.pnlPeminjam.Controls.Add(this.lblKodeMember);
            this.pnlPeminjam.Controls.Add(this.lblNamaPeminjam);
            this.pnlPeminjam.Controls.Add(this.btnCariPelanggan);
            this.pnlPeminjam.Controls.Add(this.txtPeminjam);
            this.pnlPeminjam.Controls.Add(this.label1);
            this.pnlPeminjam.ForeColor = System.Drawing.Color.White;
            this.pnlPeminjam.Location = new System.Drawing.Point(576, -1);
            this.pnlPeminjam.Name = "pnlPeminjam";
            this.pnlPeminjam.Size = new System.Drawing.Size(317, 75);
            this.pnlPeminjam.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(232, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 24);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCariPelanggan
            // 
            this.btnCariPelanggan.ForeColor = System.Drawing.Color.Black;
            this.btnCariPelanggan.Location = new System.Drawing.Point(232, 33);
            this.btnCariPelanggan.Name = "btnCariPelanggan";
            this.btnCariPelanggan.Size = new System.Drawing.Size(75, 23);
            this.btnCariPelanggan.TabIndex = 2;
            this.btnCariPelanggan.Text = "Cari...";
            this.btnCariPelanggan.UseVisualStyleBackColor = true;
            this.btnCariPelanggan.Click += new System.EventHandler(this.btnCariPelanggan_Click);
            // 
            // txtPeminjam
            // 
            this.txtPeminjam.Location = new System.Drawing.Point(69, 5);
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
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(4, 10);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(155, 16);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail item Transaksi";
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(166)))));
            this.pnlDetail.Controls.Add(this.lblDendaPersen);
            this.pnlDetail.Controls.Add(this.lblDendaPersenInfo);
            this.pnlDetail.Controls.Add(this.lblStok);
            this.pnlDetail.Controls.Add(this.lblStokInfo);
            this.pnlDetail.Controls.Add(this.lblDendaKerusakan);
            this.pnlDetail.Controls.Add(this.lblHargaDendaItem);
            this.pnlDetail.Controls.Add(this.lblDendaKerusakanInfo);
            this.pnlDetail.Controls.Add(this.lblHargaDendaItemInfo);
            this.pnlDetail.Controls.Add(this.cmbKondisi);
            this.pnlDetail.Controls.Add(this.lblKondisi);
            this.pnlDetail.Controls.Add(this.lblGenre);
            this.pnlDetail.Controls.Add(this.lblDetail);
            this.pnlDetail.Controls.Add(this.lblJudul);
            this.pnlDetail.ForeColor = System.Drawing.Color.White;
            this.pnlDetail.Location = new System.Drawing.Point(702, 81);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(191, 365);
            this.pnlDetail.TabIndex = 16;
            // 
            // lblDendaPersen
            // 
            this.lblDendaPersen.AutoSize = true;
            this.lblDendaPersen.Location = new System.Drawing.Point(4, 315);
            this.lblDendaPersen.Name = "lblDendaPersen";
            this.lblDendaPersen.Size = new System.Drawing.Size(24, 13);
            this.lblDendaPersen.TabIndex = 28;
            this.lblDendaPersen.Text = "0 %";
            // 
            // lblDendaPersenInfo
            // 
            this.lblDendaPersenInfo.AutoSize = true;
            this.lblDendaPersenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaPersenInfo.Location = new System.Drawing.Point(4, 301);
            this.lblDendaPersenInfo.Name = "lblDendaPersenInfo";
            this.lblDendaPersenInfo.Size = new System.Drawing.Size(144, 13);
            this.lblDendaPersenInfo.TabIndex = 27;
            this.lblDendaPersenInfo.Text = "Besar Denda Kerusakan";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(4, 191);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(57, 13);
            this.lblStok.TabIndex = 26;
            this.lblStok.Text = "Kode Stok";
            // 
            // lblStokInfo
            // 
            this.lblStokInfo.AutoSize = true;
            this.lblStokInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokInfo.Location = new System.Drawing.Point(4, 176);
            this.lblStokInfo.Name = "lblStokInfo";
            this.lblStokInfo.Size = new System.Drawing.Size(114, 13);
            this.lblStokInfo.TabIndex = 23;
            this.lblStokInfo.Text = "Stok yang dipinjam";
            // 
            // lblDendaKerusakan
            // 
            this.lblDendaKerusakan.AutoSize = true;
            this.lblDendaKerusakan.Location = new System.Drawing.Point(4, 278);
            this.lblDendaKerusakan.Name = "lblDendaKerusakan";
            this.lblDendaKerusakan.Size = new System.Drawing.Size(13, 13);
            this.lblDendaKerusakan.TabIndex = 25;
            this.lblDendaKerusakan.Text = "0";
            // 
            // lblHargaDendaItem
            // 
            this.lblHargaDendaItem.AutoSize = true;
            this.lblHargaDendaItem.Location = new System.Drawing.Point(4, 92);
            this.lblHargaDendaItem.Name = "lblHargaDendaItem";
            this.lblHargaDendaItem.Size = new System.Drawing.Size(13, 13);
            this.lblHargaDendaItem.TabIndex = 23;
            this.lblHargaDendaItem.Text = "0";
            // 
            // lblDendaKerusakanInfo
            // 
            this.lblDendaKerusakanInfo.AutoSize = true;
            this.lblDendaKerusakanInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDendaKerusakanInfo.Location = new System.Drawing.Point(4, 263);
            this.lblDendaKerusakanInfo.Name = "lblDendaKerusakanInfo";
            this.lblDendaKerusakanInfo.Size = new System.Drawing.Size(133, 13);
            this.lblDendaKerusakanInfo.TabIndex = 24;
            this.lblDendaKerusakanInfo.Text = "Harga Pembelian Stok";
            // 
            // lblHargaDendaItemInfo
            // 
            this.lblHargaDendaItemInfo.AutoSize = true;
            this.lblHargaDendaItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaDendaItemInfo.Location = new System.Drawing.Point(4, 75);
            this.lblHargaDendaItemInfo.Name = "lblHargaDendaItemInfo";
            this.lblHargaDendaItemInfo.Size = new System.Drawing.Size(131, 13);
            this.lblHargaDendaItemInfo.TabIndex = 22;
            this.lblHargaDendaItemInfo.Text = "Harga Denda per Hari";
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
            // frmTransaksiPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 520);
            this.Controls.Add(this.pnlTransaksi);
            this.Controls.Add(this.dgPengembalian);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlPeminjam);
            this.Controls.Add(this.pnlDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTransaksiPengembalian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Transaksi Pengembalian";
            this.Load += new System.EventHandler(this.frmTransaksiPengembalian_Load);
            this.pnlTransaksi.ResumeLayout(false);
            this.pnlTransaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPengembalian)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.pnlPeminjam.ResumeLayout(false);
            this.pnlPeminjam.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblBiayaDenda;
        private System.Windows.Forms.Label lblBiayaDendaInfo;
        private System.Windows.Forms.Label lblLamaTelat;
        private System.Windows.Forms.Label lblLamaTelatInfo;
        private System.Windows.Forms.Label lblTanggalSeharusnyaKembaliInfo;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.Label lblNmrNota;
        private System.Windows.Forms.Label lblNmrNotaInfo;
        private System.Windows.Forms.Label lblDetailTransaksi;
        private System.Windows.Forms.Label lblKondisi;
        private System.Windows.Forms.Panel pnlTransaksi;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DataGridView dgPengembalian;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblIdentitas;
        private System.Windows.Forms.Label lblKodeMember;
        private System.Windows.Forms.Label lblNamaPeminjam;
        private System.Windows.Forms.Panel pnlPeminjam;
        private System.Windows.Forms.Button btnCariPelanggan;
        private System.Windows.Forms.TextBox txtPeminjam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHargaDendaItem;
        private System.Windows.Forms.Label lblHargaDendaItemInfo;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblStokInfo;
        private System.Windows.Forms.Label lblDendaKerusakan;
        private System.Windows.Forms.Label lblDendaKerusakanInfo;
        private System.Windows.Forms.Label lblTanggalSeharusnyaKembali;
        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblDendaPersen;
        private System.Windows.Forms.Label lblDendaPersenInfo;
        private System.Windows.Forms.Button btnOk;
    }
}