
namespace AracKiralamaOtomasyonu
{
    partial class FrmAracListeleme
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
            this.CmbAraclar = new System.Windows.Forms.ComboBox();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.CmbYakit = new System.Windows.Forms.ComboBox();
            this.CmbSeri = new System.Windows.Forms.ComboBox();
            this.CmbMarka = new System.Windows.Forms.ComboBox();
            this.TxtKiraUcreti = new System.Windows.Forms.TextBox();
            this.TxtKM = new System.Windows.Forms.TextBox();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.TxtYil = new System.Windows.Forms.TextBox();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CmbAraclar
            // 
            this.CmbAraclar.FormattingEnabled = true;
            this.CmbAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.CmbAraclar.Location = new System.Drawing.Point(531, 12);
            this.CmbAraclar.Name = "CmbAraclar";
            this.CmbAraclar.Size = new System.Drawing.Size(225, 32);
            this.CmbAraclar.TabIndex = 1;
            this.CmbAraclar.SelectedIndexChanged += new System.EventHandler(this.CmbAraclar_SelectedIndexChanged);
            // 
            // BtnIptal
            // 
            this.BtnIptal.BackColor = System.Drawing.Color.White;
            this.BtnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIptal.ForeColor = System.Drawing.Color.Black;
            this.BtnIptal.Location = new System.Drawing.Point(175, 381);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(80, 33);
            this.BtnIptal.TabIndex = 23;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.White;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnGuncelle.Location = new System.Drawing.Point(77, 381);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(80, 33);
            this.BtnGuncelle.TabIndex = 21;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // CmbYakit
            // 
            this.CmbYakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbYakit.FormattingEnabled = true;
            this.CmbYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+Lpg"});
            this.CmbYakit.Location = new System.Drawing.Point(111, 283);
            this.CmbYakit.Name = "CmbYakit";
            this.CmbYakit.Size = new System.Drawing.Size(188, 28);
            this.CmbYakit.TabIndex = 20;
            // 
            // CmbSeri
            // 
            this.CmbSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbSeri.FormattingEnabled = true;
            this.CmbSeri.Location = new System.Drawing.Point(111, 137);
            this.CmbSeri.Name = "CmbSeri";
            this.CmbSeri.Size = new System.Drawing.Size(188, 28);
            this.CmbSeri.TabIndex = 19;
            // 
            // CmbMarka
            // 
            this.CmbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbMarka.FormattingEnabled = true;
            this.CmbMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.CmbMarka.Location = new System.Drawing.Point(111, 99);
            this.CmbMarka.Name = "CmbMarka";
            this.CmbMarka.Size = new System.Drawing.Size(188, 28);
            this.CmbMarka.TabIndex = 18;
            this.CmbMarka.SelectedIndexChanged += new System.EventHandler(this.CmbMarka_SelectedIndexChanged);
            // 
            // TxtKiraUcreti
            // 
            this.TxtKiraUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKiraUcreti.Location = new System.Drawing.Point(111, 321);
            this.TxtKiraUcreti.Name = "TxtKiraUcreti";
            this.TxtKiraUcreti.Size = new System.Drawing.Size(188, 26);
            this.TxtKiraUcreti.TabIndex = 16;
            // 
            // TxtKM
            // 
            this.TxtKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKM.Location = new System.Drawing.Point(111, 247);
            this.TxtKM.Name = "TxtKM";
            this.TxtKM.Size = new System.Drawing.Size(188, 26);
            this.TxtKM.TabIndex = 17;
            // 
            // TxtRenk
            // 
            this.TxtRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRenk.Location = new System.Drawing.Point(111, 211);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(188, 26);
            this.TxtRenk.TabIndex = 15;
            // 
            // TxtYil
            // 
            this.TxtYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYil.Location = new System.Drawing.Point(111, 175);
            this.TxtYil.Name = "TxtYil";
            this.TxtYil.Size = new System.Drawing.Size(188, 26);
            this.TxtYil.TabIndex = 14;
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPlaka.Location = new System.Drawing.Point(111, 63);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(188, 26);
            this.TxtPlaka.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(23, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(60, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(73, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(58, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plaka";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.White;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.Black;
            this.BtnSil.Location = new System.Drawing.Point(895, 63);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(66, 30);
            this.BtnSil.TabIndex = 25;
            this.BtnSil.Text = "Sil";
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAracListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(968, 446);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.CmbYakit);
            this.Controls.Add(this.CmbSeri);
            this.Controls.Add(this.CmbMarka);
            this.Controls.Add(this.TxtKiraUcreti);
            this.Controls.Add(this.TxtKM);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.TxtYil);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbAraclar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAracListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmAracListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbAraclar;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ComboBox CmbYakit;
        private System.Windows.Forms.ComboBox CmbSeri;
        private System.Windows.Forms.ComboBox CmbMarka;
        private System.Windows.Forms.TextBox TxtKiraUcreti;
        private System.Windows.Forms.TextBox TxtKM;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.TextBox TxtYil;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}