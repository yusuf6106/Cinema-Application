namespace CinemaApplication
{
    partial class Form1
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
            this.lblSalon = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.tBoxSalon = new System.Windows.Forms.TextBox();
            this.tBoxKoltukSayisi = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxOgrenci = new System.Windows.Forms.CheckBox();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.btnBiletIptal = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnBosKoltuk = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalon.Location = new System.Drawing.Point(13, 28);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(48, 16);
            this.lblSalon.TabIndex = 0;
            this.lblSalon.Text = "Salon";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.Location = new System.Drawing.Point(13, 59);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(97, 16);
            this.lblKoltukSayisi.TabIndex = 1;
            this.lblKoltukSayisi.Text = "Koltuk Sayısı";
            // 
            // tBoxSalon
            // 
            this.tBoxSalon.Location = new System.Drawing.Point(116, 24);
            this.tBoxSalon.Name = "tBoxSalon";
            this.tBoxSalon.Size = new System.Drawing.Size(100, 20);
            this.tBoxSalon.TabIndex = 2;
            // 
            // tBoxKoltukSayisi
            // 
            this.tBoxKoltukSayisi.Location = new System.Drawing.Point(116, 55);
            this.tBoxKoltukSayisi.Name = "tBoxKoltukSayisi";
            this.tBoxKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.tBoxKoltukSayisi.TabIndex = 3;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.Yellow;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(411, 28);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(168, 47);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBiletIptal);
            this.groupBox1.Controls.Add(this.btnBiletSat);
            this.groupBox1.Controls.Add(this.cBoxOgrenci);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 167);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış - İptal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBosKoltuk);
            this.groupBox2.Controls.Add(this.btnBakiye);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(411, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 167);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rapor";
            // 
            // cBoxOgrenci
            // 
            this.cBoxOgrenci.AutoSize = true;
            this.cBoxOgrenci.Location = new System.Drawing.Point(7, 22);
            this.cBoxOgrenci.Name = "cBoxOgrenci";
            this.cBoxOgrenci.Size = new System.Drawing.Size(81, 20);
            this.cBoxOgrenci.TabIndex = 0;
            this.cBoxOgrenci.Text = "Öğrenci";
            this.cBoxOgrenci.UseVisualStyleBackColor = true;
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.BackColor = System.Drawing.Color.Yellow;
            this.btnBiletSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletSat.Location = new System.Drawing.Point(119, 22);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(168, 47);
            this.btnBiletSat.TabIndex = 7;
            this.btnBiletSat.Text = "Bilet Sat";
            this.btnBiletSat.UseVisualStyleBackColor = false;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // btnBiletIptal
            // 
            this.btnBiletIptal.BackColor = System.Drawing.Color.Yellow;
            this.btnBiletIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletIptal.Location = new System.Drawing.Point(119, 75);
            this.btnBiletIptal.Name = "btnBiletIptal";
            this.btnBiletIptal.Size = new System.Drawing.Size(168, 47);
            this.btnBiletIptal.TabIndex = 8;
            this.btnBiletIptal.Text = "Bilet İptal";
            this.btnBiletIptal.UseVisualStyleBackColor = false;
            this.btnBiletIptal.Click += new System.EventHandler(this.btnBiletIptal_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.BackColor = System.Drawing.Color.Yellow;
            this.btnBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiye.Location = new System.Drawing.Point(78, 22);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(168, 47);
            this.btnBakiye.TabIndex = 9;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnBosKoltuk
            // 
            this.btnBosKoltuk.BackColor = System.Drawing.Color.Yellow;
            this.btnBosKoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosKoltuk.Location = new System.Drawing.Point(78, 75);
            this.btnBosKoltuk.Name = "btnBosKoltuk";
            this.btnBosKoltuk.Size = new System.Drawing.Size(168, 47);
            this.btnBosKoltuk.TabIndex = 10;
            this.btnBosKoltuk.Text = "Boş Koltuk";
            this.btnBosKoltuk.UseVisualStyleBackColor = false;
            this.btnBosKoltuk.Click += new System.EventHandler(this.btnBosKoltuk_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(16, 339);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(55, 16);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(834, 388);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.tBoxKoltukSayisi);
            this.Controls.Add(this.tBoxSalon);
            this.Controls.Add(this.lblKoltukSayisi);
            this.Controls.Add(this.lblSalon);
            this.Name = "Form1";
            this.Text = "Sinema Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.TextBox tBoxSalon;
        private System.Windows.Forms.TextBox tBoxKoltukSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBiletIptal;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.CheckBox cBoxOgrenci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBosKoltuk;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label lblSonuc;
    }
}

