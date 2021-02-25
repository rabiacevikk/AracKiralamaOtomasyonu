
namespace AracKiralamaOtomasyonu
{
    partial class FrmSozlesme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTCAra = new System.Windows.Forms.TextBox();
            this.TxtEverildiğiYer = new System.Windows.Forms.TextBox();
            this.TxtEhliyetTarihi = new System.Windows.Forms.TextBox();
            this.TxtEhliyetNo = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.datecikis = new System.Windows.Forms.DateTimePicker();
            this.datedonus = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbKiraSekli = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbAraclar = new System.Windows.Forms.ComboBox();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.TxtKiraUcreti = new System.Windows.Forms.TextBox();
            this.TxtGun = new System.Windows.Forms.TextBox();
            this.TxtSeri = new System.Windows.Forms.TextBox();
            this.TxtModelYil = new System.Windows.Forms.TextBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAracTeslim = new System.Windows.Forms.Button();
            this.TxtAlacakVerecekDurumu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTCAra);
            this.groupBox1.Controls.Add(this.TxtEverildiğiYer);
            this.groupBox1.Controls.Add(this.TxtEhliyetTarihi);
            this.groupBox1.Controls.Add(this.TxtEhliyetNo);
            this.groupBox1.Controls.Add(this.TxtTelefon);
            this.groupBox1.Controls.Add(this.TxtAdSoyad);
            this.groupBox1.Controls.Add(this.TxtTC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(266, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // TxtTCAra
            // 
            this.TxtTCAra.Location = new System.Drawing.Point(104, 19);
            this.TxtTCAra.Name = "TxtTCAra";
            this.TxtTCAra.Size = new System.Drawing.Size(128, 24);
            this.TxtTCAra.TabIndex = 4;
            this.TxtTCAra.TextChanged += new System.EventHandler(this.TxtTCAra_TextChanged);
            // 
            // TxtEverildiğiYer
            // 
            this.TxtEverildiğiYer.Location = new System.Drawing.Point(104, 199);
            this.TxtEverildiğiYer.Name = "TxtEverildiğiYer";
            this.TxtEverildiğiYer.Size = new System.Drawing.Size(128, 24);
            this.TxtEverildiğiYer.TabIndex = 3;
            // 
            // TxtEhliyetTarihi
            // 
            this.TxtEhliyetTarihi.Location = new System.Drawing.Point(104, 169);
            this.TxtEhliyetTarihi.Name = "TxtEhliyetTarihi";
            this.TxtEhliyetTarihi.Size = new System.Drawing.Size(128, 24);
            this.TxtEhliyetTarihi.TabIndex = 3;
            // 
            // TxtEhliyetNo
            // 
            this.TxtEhliyetNo.Location = new System.Drawing.Point(104, 139);
            this.TxtEhliyetNo.Name = "TxtEhliyetNo";
            this.TxtEhliyetNo.Size = new System.Drawing.Size(128, 24);
            this.TxtEhliyetNo.TabIndex = 3;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(104, 109);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(128, 24);
            this.TxtTelefon.TabIndex = 3;
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(104, 79);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(128, 24);
            this.TxtAdSoyad.TabIndex = 3;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(104, 49);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(128, 24);
            this.TxtTC.TabIndex = 3;
            this.TxtTC.TextChanged += new System.EventHandler(this.TxtTC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "E-verildiği yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ehliyet Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "TC Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnTemizle);
            this.groupBox2.Controls.Add(this.BtnHesapla);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnEkle);
            this.groupBox2.Controls.Add(this.datecikis);
            this.groupBox2.Controls.Add(this.datedonus);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.CmbKiraSekli);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.CmbAraclar);
            this.groupBox2.Controls.Add(this.TxtTutar);
            this.groupBox2.Controls.Add(this.TxtRenk);
            this.groupBox2.Controls.Add(this.TxtKiraUcreti);
            this.groupBox2.Controls.Add(this.TxtGun);
            this.groupBox2.Controls.Add(this.TxtSeri);
            this.groupBox2.Controls.Add(this.TxtModelYil);
            this.groupBox2.Controls.Add(this.TxtMarka);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(304, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(579, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.White;
            this.BtnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTemizle.Location = new System.Drawing.Point(491, 106);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(81, 41);
            this.BtnTemizle.TabIndex = 11;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackColor = System.Drawing.Color.White;
            this.BtnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHesapla.Location = new System.Drawing.Point(491, 54);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(81, 41);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = false;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.Location = new System.Drawing.Point(108, 180);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(81, 41);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.White;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEkle.Location = new System.Drawing.Point(8, 180);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(81, 41);
            this.BtnEkle.TabIndex = 9;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // datecikis
            // 
            this.datecikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datecikis.Location = new System.Drawing.Point(350, 144);
            this.datecikis.Name = "datecikis";
            this.datecikis.Size = new System.Drawing.Size(128, 24);
            this.datecikis.TabIndex = 8;
            // 
            // datedonus
            // 
            this.datedonus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedonus.Location = new System.Drawing.Point(350, 174);
            this.datedonus.Name = "datedonus";
            this.datedonus.Size = new System.Drawing.Size(128, 24);
            this.datedonus.TabIndex = 8;
            this.datedonus.ValueChanged += new System.EventHandler(this.datedonus_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(252, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Dönüş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(263, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tutar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "Kira Ücreti";
            // 
            // CmbKiraSekli
            // 
            this.CmbKiraSekli.FormattingEnabled = true;
            this.CmbKiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.CmbKiraSekli.Location = new System.Drawing.Point(350, 19);
            this.CmbKiraSekli.Name = "CmbKiraSekli";
            this.CmbKiraSekli.Size = new System.Drawing.Size(128, 26);
            this.CmbKiraSekli.TabIndex = 6;
            this.CmbKiraSekli.SelectedIndexChanged += new System.EventHandler(this.CmbKiraSekli_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Kira Şekli";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CmbAraclar
            // 
            this.CmbAraclar.FormattingEnabled = true;
            this.CmbAraclar.Location = new System.Drawing.Point(79, 25);
            this.CmbAraclar.Name = "CmbAraclar";
            this.CmbAraclar.Size = new System.Drawing.Size(128, 26);
            this.CmbAraclar.TabIndex = 6;
            this.CmbAraclar.SelectedIndexChanged += new System.EventHandler(this.CmbAraclar_SelectedIndexChanged);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(350, 111);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(128, 24);
            this.TxtTutar.TabIndex = 5;
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(79, 150);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(128, 24);
            this.TxtRenk.TabIndex = 5;
            // 
            // TxtKiraUcreti
            // 
            this.TxtKiraUcreti.Location = new System.Drawing.Point(350, 49);
            this.TxtKiraUcreti.Name = "TxtKiraUcreti";
            this.TxtKiraUcreti.Size = new System.Drawing.Size(128, 24);
            this.TxtKiraUcreti.TabIndex = 5;
            // 
            // TxtGun
            // 
            this.TxtGun.Location = new System.Drawing.Point(350, 79);
            this.TxtGun.Name = "TxtGun";
            this.TxtGun.Size = new System.Drawing.Size(128, 24);
            this.TxtGun.TabIndex = 5;
            // 
            // TxtSeri
            // 
            this.TxtSeri.Location = new System.Drawing.Point(79, 90);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Size = new System.Drawing.Size(128, 24);
            this.TxtSeri.TabIndex = 5;
            // 
            // TxtModelYil
            // 
            this.TxtModelYil.Location = new System.Drawing.Point(79, 120);
            this.TxtModelYil.Name = "TxtModelYil";
            this.TxtModelYil.Size = new System.Drawing.Size(128, 24);
            this.TxtModelYil.TabIndex = 5;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(79, 57);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(128, 24);
            this.TxtMarka.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Model(Yıl)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Araçlar";
            // 
            // BtnAracTeslim
            // 
            this.BtnAracTeslim.BackColor = System.Drawing.Color.White;
            this.BtnAracTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracTeslim.Location = new System.Drawing.Point(757, 463);
            this.BtnAracTeslim.Name = "BtnAracTeslim";
            this.BtnAracTeslim.Size = new System.Drawing.Size(89, 50);
            this.BtnAracTeslim.TabIndex = 10;
            this.BtnAracTeslim.Text = "Araç Teslim\r\n";
            this.BtnAracTeslim.UseVisualStyleBackColor = false;
            this.BtnAracTeslim.Click += new System.EventHandler(this.BtnAracTeslim_Click);
            // 
            // TxtAlacakVerecekDurumu
            // 
            this.TxtAlacakVerecekDurumu.Location = new System.Drawing.Point(520, 475);
            this.TxtAlacakVerecekDurumu.Name = "TxtAlacakVerecekDurumu";
            this.TxtAlacakVerecekDurumu.Size = new System.Drawing.Size(128, 26);
            this.TxtAlacakVerecekDurumu.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(333, 478);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Alacak/Verecek Durumu";
            // 
            // FrmSozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(893, 518);
            this.Controls.Add(this.TxtAlacakVerecekDurumu);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BtnAracTeslim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSozlesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.FrmSozlesme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEverildiğiYer;
        private System.Windows.Forms.TextBox TxtEhliyetTarihi;
        private System.Windows.Forms.TextBox TxtEhliyetNo;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DateTimePicker datecikis;
        private System.Windows.Forms.DateTimePicker datedonus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbKiraSekli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbAraclar;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.TextBox TxtKiraUcreti;
        private System.Windows.Forms.TextBox TxtGun;
        private System.Windows.Forms.TextBox TxtSeri;
        private System.Windows.Forms.TextBox TxtModelYil;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAracTeslim;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtTCAra;
        private System.Windows.Forms.TextBox TxtAlacakVerecekDurumu;
        private System.Windows.Forms.Label label19;
    }
}