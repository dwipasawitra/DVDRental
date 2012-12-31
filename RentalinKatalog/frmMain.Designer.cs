namespace RentalinKatalog
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlScrollingText = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlJam = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScrollingText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.lblNamaLayanan = new System.Windows.Forms.Label();
            this.lblAlamatLayanan = new System.Windows.Forms.Label();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabDepan = new System.Windows.Forms.TabPage();
            this.btnChatDgnOperator = new System.Windows.Forms.Button();
            this.btnPetunjuk = new System.Windows.Forms.Button();
            this.lblInfoBesar = new System.Windows.Forms.Label();
            this.btnLihatDaftarPesanan = new System.Windows.Forms.Button();
            this.lblInfoDetail = new System.Windows.Forms.Label();
            this.gbTopKoleksi = new System.Windows.Forms.GroupBox();
            this.lblJenisKepingTop = new System.Windows.Forms.Label();
            this.lblDeskripsiTop = new System.Windows.Forms.Label();
            this.lblGenreTop = new System.Windows.Forms.Label();
            this.lblJudulTop = new System.Windows.Forms.Label();
            this.picTopKoleksiTerbaik = new System.Windows.Forms.PictureBox();
            this.btnLihatDaftarJudul = new System.Windows.Forms.Button();
            this.tabKoleksi = new System.Windows.Forms.TabPage();
            this.dgKoleksi = new System.Windows.Forms.DataGridView();
            this.gbInfoKoleksi = new System.Windows.Forms.GroupBox();
            this.lblDeskripsiKoleksi = new System.Windows.Forms.Label();
            this.lblGenreKoleksi = new System.Windows.Forms.Label();
            this.lblJudulKoleksi = new System.Windows.Forms.Label();
            this.picDetailKoleksi = new System.Windows.Forms.PictureBox();
            this.btnTambahKePesanan = new System.Windows.Forms.Button();
            this.tabPesanan = new System.Windows.Forms.TabPage();
            this.btnBatalkanPesanan = new System.Windows.Forms.Button();
            this.btnHapusPilihan = new System.Windows.Forms.Button();
            this.btnProsesPesanan = new System.Windows.Forms.Button();
            this.gridPesanan = new System.Windows.Forms.DataGridView();
            this.tabChatOperator = new System.Windows.Forms.TabPage();
            this.btnKirimPesan = new System.Windows.Forms.Button();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.listChat = new System.Windows.Forms.ListBox();
            this.tabPetunjuk = new System.Windows.Forms.TabPage();
            this.tmrWaktu = new System.Windows.Forms.Timer(this.components);
            this.tmrScrollingText = new System.Windows.Forms.Timer(this.components);
            this.lblJenisKepingKoleksi = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.pnlScrollingText.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlJam.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tabControlApp.SuspendLayout();
            this.tabDepan.SuspendLayout();
            this.gbTopKoleksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopKoleksiTerbaik)).BeginInit();
            this.tabKoleksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKoleksi)).BeginInit();
            this.gbInfoKoleksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDetailKoleksi)).BeginInit();
            this.tabPesanan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesanan)).BeginInit();
            this.tabChatOperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScrollingText
            // 
            this.pnlScrollingText.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlScrollingText.Controls.Add(this.panel1);
            this.pnlScrollingText.Controls.Add(this.pnlJam);
            this.pnlScrollingText.Controls.Add(this.lblScrollingText);
            this.pnlScrollingText.Location = new System.Drawing.Point(-1, 570);
            this.pnlScrollingText.Name = "pnlScrollingText";
            this.pnlScrollingText.Size = new System.Drawing.Size(1001, 51);
            this.pnlScrollingText.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(861, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 48);
            this.panel1.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(18, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "30/12/2012";
            // 
            // pnlJam
            // 
            this.pnlJam.BackColor = System.Drawing.Color.Green;
            this.pnlJam.Controls.Add(this.lblTime);
            this.pnlJam.Location = new System.Drawing.Point(0, 0);
            this.pnlJam.Name = "pnlJam";
            this.pnlJam.Size = new System.Drawing.Size(102, 51);
            this.pnlJam.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(18, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 24);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "12:30";
            // 
            // lblScrollingText
            // 
            this.lblScrollingText.AutoSize = true;
            this.lblScrollingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrollingText.Location = new System.Drawing.Point(84, 12);
            this.lblScrollingText.Name = "lblScrollingText";
            this.lblScrollingText.Size = new System.Drawing.Size(2670, 25);
            this.lblScrollingText.TabIndex = 7;
            this.lblScrollingText.Text = resources.GetString("lblScrollingText.Text");
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlHeader.Controls.Add(this.txtPencarian);
            this.pnlHeader.Controls.Add(this.btnPesan);
            this.pnlHeader.Controls.Add(this.lblNamaLayanan);
            this.pnlHeader.Controls.Add(this.lblAlamatLayanan);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1001, 82);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // txtPencarian
            // 
            this.txtPencarian.AcceptsReturn = true;
            this.txtPencarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPencarian.Location = new System.Drawing.Point(522, 16);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(306, 31);
            this.txtPencarian.TabIndex = 13;
            this.txtPencarian.Text = "Pencarian...";
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            this.txtPencarian.Enter += new System.EventHandler(this.txtPencarian_Enter);
            this.txtPencarian.Leave += new System.EventHandler(this.txtPencarian_Leave);
            // 
            // btnPesan
            // 
            this.btnPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.Location = new System.Drawing.Point(834, 8);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(153, 58);
            this.btnPesan.TabIndex = 12;
            this.btnPesan.Text = "Lihat Pesanan Anda";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // lblNamaLayanan
            // 
            this.lblNamaLayanan.AutoSize = true;
            this.lblNamaLayanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaLayanan.ForeColor = System.Drawing.Color.Black;
            this.lblNamaLayanan.Location = new System.Drawing.Point(21, 16);
            this.lblNamaLayanan.Name = "lblNamaLayanan";
            this.lblNamaLayanan.Size = new System.Drawing.Size(130, 25);
            this.lblNamaLayanan.TabIndex = 9;
            this.lblNamaLayanan.Text = "HMTC Disc";
            // 
            // lblAlamatLayanan
            // 
            this.lblAlamatLayanan.AutoSize = true;
            this.lblAlamatLayanan.ForeColor = System.Drawing.Color.Black;
            this.lblAlamatLayanan.Location = new System.Drawing.Point(23, 41);
            this.lblAlamatLayanan.Name = "lblAlamatLayanan";
            this.lblAlamatLayanan.Size = new System.Drawing.Size(170, 13);
            this.lblAlamatLayanan.TabIndex = 10;
            this.lblAlamatLayanan.Text = "Jalan Teknik Kimia, ITS, Surabaya";
            // 
            // tabControlApp
            // 
            this.tabControlApp.Controls.Add(this.tabDepan);
            this.tabControlApp.Controls.Add(this.tabKoleksi);
            this.tabControlApp.Controls.Add(this.tabPesanan);
            this.tabControlApp.Controls.Add(this.tabChatOperator);
            this.tabControlApp.Controls.Add(this.tabPetunjuk);
            this.tabControlApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlApp.Location = new System.Drawing.Point(-1, 85);
            this.tabControlApp.Name = "tabControlApp";
            this.tabControlApp.SelectedIndex = 0;
            this.tabControlApp.Size = new System.Drawing.Size(1001, 479);
            this.tabControlApp.TabIndex = 4;
            // 
            // tabDepan
            // 
            this.tabDepan.Controls.Add(this.btnChatDgnOperator);
            this.tabDepan.Controls.Add(this.btnPetunjuk);
            this.tabDepan.Controls.Add(this.lblInfoBesar);
            this.tabDepan.Controls.Add(this.btnLihatDaftarPesanan);
            this.tabDepan.Controls.Add(this.lblInfoDetail);
            this.tabDepan.Controls.Add(this.gbTopKoleksi);
            this.tabDepan.Controls.Add(this.btnLihatDaftarJudul);
            this.tabDepan.Location = new System.Drawing.Point(4, 33);
            this.tabDepan.Name = "tabDepan";
            this.tabDepan.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepan.Size = new System.Drawing.Size(993, 442);
            this.tabDepan.TabIndex = 0;
            this.tabDepan.Text = "Depan";
            this.tabDepan.UseVisualStyleBackColor = true;
            // 
            // btnChatDgnOperator
            // 
            this.btnChatDgnOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChatDgnOperator.Location = new System.Drawing.Point(471, 355);
            this.btnChatDgnOperator.Name = "btnChatDgnOperator";
            this.btnChatDgnOperator.Size = new System.Drawing.Size(499, 72);
            this.btnChatDgnOperator.TabIndex = 15;
            this.btnChatDgnOperator.Text = "CHAT DENGAN OPERATOR";
            this.btnChatDgnOperator.UseVisualStyleBackColor = true;
            // 
            // btnPetunjuk
            // 
            this.btnPetunjuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetunjuk.Location = new System.Drawing.Point(471, 199);
            this.btnPetunjuk.Name = "btnPetunjuk";
            this.btnPetunjuk.Size = new System.Drawing.Size(499, 72);
            this.btnPetunjuk.TabIndex = 16;
            this.btnPetunjuk.Text = "PETUNJUK";
            this.btnPetunjuk.UseVisualStyleBackColor = true;
            // 
            // lblInfoBesar
            // 
            this.lblInfoBesar.AutoSize = true;
            this.lblInfoBesar.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoBesar.Location = new System.Drawing.Point(190, 10);
            this.lblInfoBesar.Name = "lblInfoBesar";
            this.lblInfoBesar.Size = new System.Drawing.Size(623, 47);
            this.lblInfoBesar.TabIndex = 10;
            this.lblInfoBesar.Text = "SELAMAT DATANG di RENTAL KAMI";
            // 
            // btnLihatDaftarPesanan
            // 
            this.btnLihatDaftarPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatDaftarPesanan.Location = new System.Drawing.Point(471, 277);
            this.btnLihatDaftarPesanan.Name = "btnLihatDaftarPesanan";
            this.btnLihatDaftarPesanan.Size = new System.Drawing.Size(499, 72);
            this.btnLihatDaftarPesanan.TabIndex = 14;
            this.btnLihatDaftarPesanan.Text = "LIHAT DAFTAR PESANAN";
            this.btnLihatDaftarPesanan.UseVisualStyleBackColor = true;
            // 
            // lblInfoDetail
            // 
            this.lblInfoDetail.AutoSize = true;
            this.lblInfoDetail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDetail.Location = new System.Drawing.Point(77, 57);
            this.lblInfoDetail.Name = "lblInfoDetail";
            this.lblInfoDetail.Size = new System.Drawing.Size(811, 25);
            this.lblInfoDetail.TabIndex = 11;
            this.lblInfoDetail.Text = "SILAHKAN MELIHAT ISI KATALOG KAMI MELALUI MENU YANG DISEDIAKAN DI LAYAR INI";
            // 
            // gbTopKoleksi
            // 
            this.gbTopKoleksi.Controls.Add(this.lblJenisKepingTop);
            this.gbTopKoleksi.Controls.Add(this.lblDeskripsiTop);
            this.gbTopKoleksi.Controls.Add(this.lblGenreTop);
            this.gbTopKoleksi.Controls.Add(this.lblJudulTop);
            this.gbTopKoleksi.Controls.Add(this.picTopKoleksiTerbaik);
            this.gbTopKoleksi.Location = new System.Drawing.Point(22, 100);
            this.gbTopKoleksi.Name = "gbTopKoleksi";
            this.gbTopKoleksi.Size = new System.Drawing.Size(443, 327);
            this.gbTopKoleksi.TabIndex = 12;
            this.gbTopKoleksi.TabStop = false;
            this.gbTopKoleksi.Text = "Top Koleksi Terbaik";
            // 
            // lblJenisKepingTop
            // 
            this.lblJenisKepingTop.AutoSize = true;
            this.lblJenisKepingTop.Location = new System.Drawing.Point(59, 279);
            this.lblJenisKepingTop.Name = "lblJenisKepingTop";
            this.lblJenisKepingTop.Size = new System.Drawing.Size(82, 24);
            this.lblJenisKepingTop.TabIndex = 4;
            this.lblJenisKepingTop.Text = "Blu-Ray";
            // 
            // lblDeskripsiTop
            // 
            this.lblDeskripsiTop.AutoEllipsis = true;
            this.lblDeskripsiTop.AutoSize = true;
            this.lblDeskripsiTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsiTop.Location = new System.Drawing.Point(190, 89);
            this.lblDeskripsiTop.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDeskripsiTop.Name = "lblDeskripsiTop";
            this.lblDeskripsiTop.Size = new System.Drawing.Size(250, 210);
            this.lblDeskripsiTop.TabIndex = 3;
            this.lblDeskripsiTop.Text = resources.GetString("lblDeskripsiTop.Text");
            // 
            // lblGenreTop
            // 
            this.lblGenreTop.AutoSize = true;
            this.lblGenreTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreTop.Location = new System.Drawing.Point(190, 73);
            this.lblGenreTop.Name = "lblGenreTop";
            this.lblGenreTop.Size = new System.Drawing.Size(71, 16);
            this.lblGenreTop.TabIndex = 2;
            this.lblGenreTop.Text = "Bollywood";
            // 
            // lblJudulTop
            // 
            this.lblJudulTop.AutoSize = true;
            this.lblJudulTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTop.Location = new System.Drawing.Point(190, 55);
            this.lblJudulTop.Name = "lblJudulTop";
            this.lblJudulTop.Size = new System.Drawing.Size(104, 18);
            this.lblJudulTop.TabIndex = 1;
            this.lblJudulTop.Text = "Mohabbatein";
            // 
            // picTopKoleksiTerbaik
            // 
            this.picTopKoleksiTerbaik.Image = global::RentalinKatalog.Properties.Resources.mohabbatein;
            this.picTopKoleksiTerbaik.Location = new System.Drawing.Point(16, 56);
            this.picTopKoleksiTerbaik.Name = "picTopKoleksiTerbaik";
            this.picTopKoleksiTerbaik.Size = new System.Drawing.Size(168, 220);
            this.picTopKoleksiTerbaik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopKoleksiTerbaik.TabIndex = 0;
            this.picTopKoleksiTerbaik.TabStop = false;
            // 
            // btnLihatDaftarJudul
            // 
            this.btnLihatDaftarJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatDaftarJudul.Location = new System.Drawing.Point(471, 121);
            this.btnLihatDaftarJudul.Name = "btnLihatDaftarJudul";
            this.btnLihatDaftarJudul.Size = new System.Drawing.Size(499, 72);
            this.btnLihatDaftarJudul.TabIndex = 13;
            this.btnLihatDaftarJudul.Text = "LIHAT DAFTAR JUDUL";
            this.btnLihatDaftarJudul.UseVisualStyleBackColor = true;
            this.btnLihatDaftarJudul.Click += new System.EventHandler(this.btnLihatDaftarJudul_Click);
            // 
            // tabKoleksi
            // 
            this.tabKoleksi.Controls.Add(this.dgKoleksi);
            this.tabKoleksi.Controls.Add(this.gbInfoKoleksi);
            this.tabKoleksi.Location = new System.Drawing.Point(4, 33);
            this.tabKoleksi.Name = "tabKoleksi";
            this.tabKoleksi.Size = new System.Drawing.Size(993, 442);
            this.tabKoleksi.TabIndex = 1;
            this.tabKoleksi.Text = "Koleksi";
            this.tabKoleksi.UseVisualStyleBackColor = true;
            // 
            // dgKoleksi
            // 
            this.dgKoleksi.AllowUserToAddRows = false;
            this.dgKoleksi.AllowUserToDeleteRows = false;
            this.dgKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKoleksi.Location = new System.Drawing.Point(13, 16);
            this.dgKoleksi.Name = "dgKoleksi";
            this.dgKoleksi.ReadOnly = true;
            this.dgKoleksi.Size = new System.Drawing.Size(657, 413);
            this.dgKoleksi.TabIndex = 1;
            this.dgKoleksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKoleksi_CellContentClick);
            this.dgKoleksi.SelectionChanged += new System.EventHandler(this.dgKoleksi_SelectionChanged);
            // 
            // gbInfoKoleksi
            // 
            this.gbInfoKoleksi.Controls.Add(this.btnPreview);
            this.gbInfoKoleksi.Controls.Add(this.lblJenisKepingKoleksi);
            this.gbInfoKoleksi.Controls.Add(this.lblDeskripsiKoleksi);
            this.gbInfoKoleksi.Controls.Add(this.lblGenreKoleksi);
            this.gbInfoKoleksi.Controls.Add(this.lblJudulKoleksi);
            this.gbInfoKoleksi.Controls.Add(this.picDetailKoleksi);
            this.gbInfoKoleksi.Controls.Add(this.btnTambahKePesanan);
            this.gbInfoKoleksi.Location = new System.Drawing.Point(690, 11);
            this.gbInfoKoleksi.Name = "gbInfoKoleksi";
            this.gbInfoKoleksi.Size = new System.Drawing.Size(292, 419);
            this.gbInfoKoleksi.TabIndex = 0;
            this.gbInfoKoleksi.TabStop = false;
            this.gbInfoKoleksi.Text = "Info";
            // 
            // lblDeskripsiKoleksi
            // 
            this.lblDeskripsiKoleksi.AutoEllipsis = true;
            this.lblDeskripsiKoleksi.AutoSize = true;
            this.lblDeskripsiKoleksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsiKoleksi.Location = new System.Drawing.Point(12, 213);
            this.lblDeskripsiKoleksi.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDeskripsiKoleksi.Name = "lblDeskripsiKoleksi";
            this.lblDeskripsiKoleksi.Size = new System.Drawing.Size(250, 210);
            this.lblDeskripsiKoleksi.TabIndex = 9;
            this.lblDeskripsiKoleksi.Text = resources.GetString("lblDeskripsiKoleksi.Text");
            // 
            // lblGenreKoleksi
            // 
            this.lblGenreKoleksi.AutoSize = true;
            this.lblGenreKoleksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreKoleksi.Location = new System.Drawing.Point(12, 197);
            this.lblGenreKoleksi.Name = "lblGenreKoleksi";
            this.lblGenreKoleksi.Size = new System.Drawing.Size(71, 16);
            this.lblGenreKoleksi.TabIndex = 8;
            this.lblGenreKoleksi.Text = "Bollywood";
            // 
            // lblJudulKoleksi
            // 
            this.lblJudulKoleksi.AutoSize = true;
            this.lblJudulKoleksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulKoleksi.Location = new System.Drawing.Point(12, 179);
            this.lblJudulKoleksi.Name = "lblJudulKoleksi";
            this.lblJudulKoleksi.Size = new System.Drawing.Size(104, 18);
            this.lblJudulKoleksi.TabIndex = 7;
            this.lblJudulKoleksi.Text = "Mohabbatein";
            // 
            // picDetailKoleksi
            // 
            this.picDetailKoleksi.Image = global::RentalinKatalog.Properties.Resources.mohabbatein;
            this.picDetailKoleksi.Location = new System.Drawing.Point(153, 28);
            this.picDetailKoleksi.Name = "picDetailKoleksi";
            this.picDetailKoleksi.Size = new System.Drawing.Size(104, 131);
            this.picDetailKoleksi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDetailKoleksi.TabIndex = 6;
            this.picDetailKoleksi.TabStop = false;
            // 
            // btnTambahKePesanan
            // 
            this.btnTambahKePesanan.Location = new System.Drawing.Point(15, 28);
            this.btnTambahKePesanan.Name = "btnTambahKePesanan";
            this.btnTambahKePesanan.Size = new System.Drawing.Size(132, 41);
            this.btnTambahKePesanan.TabIndex = 5;
            this.btnTambahKePesanan.Text = "PESAN";
            this.btnTambahKePesanan.UseVisualStyleBackColor = true;
            // 
            // tabPesanan
            // 
            this.tabPesanan.Controls.Add(this.btnBatalkanPesanan);
            this.tabPesanan.Controls.Add(this.btnHapusPilihan);
            this.tabPesanan.Controls.Add(this.btnProsesPesanan);
            this.tabPesanan.Controls.Add(this.gridPesanan);
            this.tabPesanan.Location = new System.Drawing.Point(4, 33);
            this.tabPesanan.Name = "tabPesanan";
            this.tabPesanan.Size = new System.Drawing.Size(993, 442);
            this.tabPesanan.TabIndex = 2;
            this.tabPesanan.Text = "Pesanan Anda";
            this.tabPesanan.UseVisualStyleBackColor = true;
            // 
            // btnBatalkanPesanan
            // 
            this.btnBatalkanPesanan.Location = new System.Drawing.Point(680, 11);
            this.btnBatalkanPesanan.Name = "btnBatalkanPesanan";
            this.btnBatalkanPesanan.Size = new System.Drawing.Size(303, 39);
            this.btnBatalkanPesanan.TabIndex = 3;
            this.btnBatalkanPesanan.Text = "Batalkan Pesanan";
            this.btnBatalkanPesanan.UseVisualStyleBackColor = true;
            // 
            // btnHapusPilihan
            // 
            this.btnHapusPilihan.Location = new System.Drawing.Point(344, 11);
            this.btnHapusPilihan.Name = "btnHapusPilihan";
            this.btnHapusPilihan.Size = new System.Drawing.Size(303, 39);
            this.btnHapusPilihan.TabIndex = 2;
            this.btnHapusPilihan.Text = "Hapus Pilihan";
            this.btnHapusPilihan.UseVisualStyleBackColor = true;
            // 
            // btnProsesPesanan
            // 
            this.btnProsesPesanan.Location = new System.Drawing.Point(9, 11);
            this.btnProsesPesanan.Name = "btnProsesPesanan";
            this.btnProsesPesanan.Size = new System.Drawing.Size(303, 39);
            this.btnProsesPesanan.TabIndex = 1;
            this.btnProsesPesanan.Text = "Proses Pesanan";
            this.btnProsesPesanan.UseVisualStyleBackColor = true;
            // 
            // gridPesanan
            // 
            this.gridPesanan.AllowUserToAddRows = false;
            this.gridPesanan.AllowUserToDeleteRows = false;
            this.gridPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesanan.Location = new System.Drawing.Point(10, 56);
            this.gridPesanan.Name = "gridPesanan";
            this.gridPesanan.ReadOnly = true;
            this.gridPesanan.Size = new System.Drawing.Size(973, 383);
            this.gridPesanan.TabIndex = 0;
            // 
            // tabChatOperator
            // 
            this.tabChatOperator.Controls.Add(this.btnKirimPesan);
            this.tabChatOperator.Controls.Add(this.txtChatInput);
            this.tabChatOperator.Controls.Add(this.listChat);
            this.tabChatOperator.Location = new System.Drawing.Point(4, 33);
            this.tabChatOperator.Name = "tabChatOperator";
            this.tabChatOperator.Size = new System.Drawing.Size(993, 442);
            this.tabChatOperator.TabIndex = 3;
            this.tabChatOperator.Text = "Chat Operator";
            this.tabChatOperator.UseVisualStyleBackColor = true;
            // 
            // btnKirimPesan
            // 
            this.btnKirimPesan.Location = new System.Drawing.Point(808, 403);
            this.btnKirimPesan.Name = "btnKirimPesan";
            this.btnKirimPesan.Size = new System.Drawing.Size(160, 30);
            this.btnKirimPesan.TabIndex = 2;
            this.btnKirimPesan.Text = "Kirim Pesan";
            this.btnKirimPesan.UseVisualStyleBackColor = true;
            // 
            // txtChatInput
            // 
            this.txtChatInput.Location = new System.Drawing.Point(17, 405);
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(779, 29);
            this.txtChatInput.TabIndex = 1;
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 24;
            this.listChat.Location = new System.Drawing.Point(15, 11);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(954, 388);
            this.listChat.TabIndex = 0;
            // 
            // tabPetunjuk
            // 
            this.tabPetunjuk.Location = new System.Drawing.Point(4, 33);
            this.tabPetunjuk.Name = "tabPetunjuk";
            this.tabPetunjuk.Size = new System.Drawing.Size(993, 442);
            this.tabPetunjuk.TabIndex = 4;
            this.tabPetunjuk.Text = "Petunjuk";
            this.tabPetunjuk.UseVisualStyleBackColor = true;
            // 
            // tmrWaktu
            // 
            this.tmrWaktu.Enabled = true;
            this.tmrWaktu.Interval = 500;
            this.tmrWaktu.Tick += new System.EventHandler(this.tmrWaktu_Tick);
            // 
            // tmrScrollingText
            // 
            this.tmrScrollingText.Enabled = true;
            this.tmrScrollingText.Tick += new System.EventHandler(this.tmrScrollingText_Tick);
            // 
            // lblJenisKepingKoleksi
            // 
            this.lblJenisKepingKoleksi.AutoSize = true;
            this.lblJenisKepingKoleksi.Location = new System.Drawing.Point(175, 157);
            this.lblJenisKepingKoleksi.Name = "lblJenisKepingKoleksi";
            this.lblJenisKepingKoleksi.Size = new System.Drawing.Size(52, 24);
            this.lblJenisKepingKoleksi.TabIndex = 10;
            this.lblJenisKepingKoleksi.Text = "DVD";
            this.lblJenisKepingKoleksi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(15, 118);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(132, 41);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "PRATINJAU";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 618);
            this.Controls.Add(this.tabControlApp);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlScrollingText);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENTALIN -- Katalog";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlScrollingText.ResumeLayout(false);
            this.pnlScrollingText.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlJam.ResumeLayout(false);
            this.pnlJam.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlApp.ResumeLayout(false);
            this.tabDepan.ResumeLayout(false);
            this.tabDepan.PerformLayout();
            this.gbTopKoleksi.ResumeLayout(false);
            this.gbTopKoleksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopKoleksiTerbaik)).EndInit();
            this.tabKoleksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKoleksi)).EndInit();
            this.gbInfoKoleksi.ResumeLayout(false);
            this.gbInfoKoleksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDetailKoleksi)).EndInit();
            this.tabPesanan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesanan)).EndInit();
            this.tabChatOperator.ResumeLayout(false);
            this.tabChatOperator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScrollingText;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label lblNamaLayanan;
        private System.Windows.Forms.Label lblAlamatLayanan;
        private System.Windows.Forms.TabControl tabControlApp;
        private System.Windows.Forms.TabPage tabDepan;
        private System.Windows.Forms.Button btnChatDgnOperator;
        private System.Windows.Forms.Button btnPetunjuk;
        private System.Windows.Forms.Label lblInfoBesar;
        private System.Windows.Forms.Button btnLihatDaftarPesanan;
        private System.Windows.Forms.Label lblInfoDetail;
        private System.Windows.Forms.GroupBox gbTopKoleksi;
        private System.Windows.Forms.Button btnLihatDaftarJudul;
        private System.Windows.Forms.TabPage tabKoleksi;
        private System.Windows.Forms.DataGridView dgKoleksi;
        private System.Windows.Forms.GroupBox gbInfoKoleksi;
        private System.Windows.Forms.TabPage tabPesanan;
        private System.Windows.Forms.Button btnBatalkanPesanan;
        private System.Windows.Forms.Button btnHapusPilihan;
        private System.Windows.Forms.Button btnProsesPesanan;
        private System.Windows.Forms.DataGridView gridPesanan;
        private System.Windows.Forms.TabPage tabChatOperator;
        private System.Windows.Forms.Button btnKirimPesan;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.TabPage tabPetunjuk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlJam;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrWaktu;
        private System.Windows.Forms.Label lblScrollingText;
        private System.Windows.Forms.Timer tmrScrollingText;
        private System.Windows.Forms.PictureBox picTopKoleksiTerbaik;
        private System.Windows.Forms.Button btnTambahKePesanan;
        private System.Windows.Forms.Label lblJenisKepingTop;
        private System.Windows.Forms.Label lblDeskripsiTop;
        private System.Windows.Forms.Label lblGenreTop;
        private System.Windows.Forms.Label lblJudulTop;
        private System.Windows.Forms.Label lblDeskripsiKoleksi;
        private System.Windows.Forms.Label lblGenreKoleksi;
        private System.Windows.Forms.Label lblJudulKoleksi;
        private System.Windows.Forms.PictureBox picDetailKoleksi;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblJenisKepingKoleksi;
    }
}

