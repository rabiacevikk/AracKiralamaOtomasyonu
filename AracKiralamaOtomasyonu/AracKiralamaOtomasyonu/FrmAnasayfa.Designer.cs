
namespace AracKiralamaOtomasyonu
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.BtnMusteriEkleme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnSatislar = new System.Windows.Forms.Button();
            this.BtnSozlesme = new System.Windows.Forms.Button();
            this.BtnAracListeleme = new System.Windows.Forms.Button();
            this.BtnAracKayit = new System.Windows.Forms.Button();
            this.BtnMusteriListeleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMusteriEkleme
            // 
            this.BtnMusteriEkleme.BackColor = System.Drawing.Color.White;
            this.BtnMusteriEkleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriEkleme.BackgroundImage")));
            this.BtnMusteriEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMusteriEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriEkleme.Location = new System.Drawing.Point(3, 26);
            this.BtnMusteriEkleme.Name = "BtnMusteriEkleme";
            this.BtnMusteriEkleme.Size = new System.Drawing.Size(123, 91);
            this.BtnMusteriEkleme.TabIndex = 0;
            this.BtnMusteriEkleme.Text = "Müşteri Ekleme";
            this.BtnMusteriEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriEkleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMusteriEkleme.UseVisualStyleBackColor = false;
            this.BtnMusteriEkleme.Click += new System.EventHandler(this.BtnMusteriEkleme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnCikis);
            this.panel1.Controls.Add(this.BtnSatislar);
            this.panel1.Controls.Add(this.BtnSozlesme);
            this.panel1.Controls.Add(this.BtnAracListeleme);
            this.panel1.Controls.Add(this.BtnAracKayit);
            this.panel1.Controls.Add(this.BtnMusteriListeleme);
            this.panel1.Controls.Add(this.BtnMusteriEkleme);
            this.panel1.Location = new System.Drawing.Point(-6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 140);
            this.panel1.TabIndex = 2;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.White;
            this.BtnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCikis.BackgroundImage")));
            this.BtnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(777, 26);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(115, 91);
            this.BtnCikis.TabIndex = 0;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnSatislar
            // 
            this.BtnSatislar.BackColor = System.Drawing.Color.Thistle;
            this.BtnSatislar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSatislar.BackgroundImage")));
            this.BtnSatislar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSatislar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatislar.Location = new System.Drawing.Point(648, 26);
            this.BtnSatislar.Name = "BtnSatislar";
            this.BtnSatislar.Size = new System.Drawing.Size(123, 91);
            this.BtnSatislar.TabIndex = 0;
            this.BtnSatislar.Text = "Satışlar";
            this.BtnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSatislar.UseVisualStyleBackColor = false;
            this.BtnSatislar.Click += new System.EventHandler(this.BtnSatislar_Click);
            // 
            // BtnSozlesme
            // 
            this.BtnSozlesme.BackColor = System.Drawing.Color.White;
            this.BtnSozlesme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSozlesme.BackgroundImage")));
            this.BtnSozlesme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSozlesme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSozlesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSozlesme.Location = new System.Drawing.Point(519, 26);
            this.BtnSozlesme.Name = "BtnSozlesme";
            this.BtnSozlesme.Size = new System.Drawing.Size(123, 91);
            this.BtnSozlesme.TabIndex = 0;
            this.BtnSozlesme.Text = "Sözleşme";
            this.BtnSozlesme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSozlesme.UseVisualStyleBackColor = false;
            this.BtnSozlesme.Click += new System.EventHandler(this.BtnSozlesme_Click);
            // 
            // BtnAracListeleme
            // 
            this.BtnAracListeleme.BackColor = System.Drawing.Color.White;
            this.BtnAracListeleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAracListeleme.BackgroundImage")));
            this.BtnAracListeleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAracListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracListeleme.Location = new System.Drawing.Point(390, 26);
            this.BtnAracListeleme.Name = "BtnAracListeleme";
            this.BtnAracListeleme.Size = new System.Drawing.Size(123, 91);
            this.BtnAracListeleme.TabIndex = 0;
            this.BtnAracListeleme.Text = "Araç Listeleme";
            this.BtnAracListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAracListeleme.UseVisualStyleBackColor = false;
            this.BtnAracListeleme.Click += new System.EventHandler(this.BtnAracListeleme_Click);
            // 
            // BtnAracKayit
            // 
            this.BtnAracKayit.BackColor = System.Drawing.Color.White;
            this.BtnAracKayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAracKayit.BackgroundImage")));
            this.BtnAracKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAracKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAracKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracKayit.Location = new System.Drawing.Point(261, 26);
            this.BtnAracKayit.Name = "BtnAracKayit";
            this.BtnAracKayit.Size = new System.Drawing.Size(123, 91);
            this.BtnAracKayit.TabIndex = 0;
            this.BtnAracKayit.Text = "Araç Kayıt";
            this.BtnAracKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAracKayit.UseVisualStyleBackColor = false;
            this.BtnAracKayit.Click += new System.EventHandler(this.BtnAracKayit_Click);
            // 
            // BtnMusteriListeleme
            // 
            this.BtnMusteriListeleme.BackColor = System.Drawing.Color.White;
            this.BtnMusteriListeleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriListeleme.BackgroundImage")));
            this.BtnMusteriListeleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMusteriListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMusteriListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriListeleme.Location = new System.Drawing.Point(132, 26);
            this.BtnMusteriListeleme.Name = "BtnMusteriListeleme";
            this.BtnMusteriListeleme.Size = new System.Drawing.Size(123, 91);
            this.BtnMusteriListeleme.TabIndex = 0;
            this.BtnMusteriListeleme.Text = "Müşteri Listeleme";
            this.BtnMusteriListeleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriListeleme.UseVisualStyleBackColor = false;
            this.BtnMusteriListeleme.Click += new System.EventHandler(this.BtnMusteriListeleme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
       //     this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMusteriEkleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnSatislar;
        private System.Windows.Forms.Button BtnSozlesme;
        private System.Windows.Forms.Button BtnAracListeleme;
        private System.Windows.Forms.Button BtnAracKayit;
        private System.Windows.Forms.Button BtnMusteriListeleme;
    }
}

