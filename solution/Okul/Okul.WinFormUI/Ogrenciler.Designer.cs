namespace Okul.WinFormUI
{
    partial class Ogrenciler
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
            this.tb_ogrenciNo = new System.Windows.Forms.TextBox();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sinifi = new System.Windows.Forms.ComboBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(852, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tb_ogrenciNo
            // 
            this.tb_ogrenciNo.Location = new System.Drawing.Point(12, 56);
            this.tb_ogrenciNo.Name = "tb_ogrenciNo";
            this.tb_ogrenciNo.Size = new System.Drawing.Size(218, 26);
            this.tb_ogrenciNo.TabIndex = 1;
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(250, 56);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(154, 26);
            this.tb_ad.TabIndex = 2;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(434, 56);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(143, 26);
            this.tb_soyad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sınıfı";
            // 
            // cb_sinifi
            // 
            this.cb_sinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sinifi.FormattingEnabled = true;
            this.cb_sinifi.Location = new System.Drawing.Point(598, 56);
            this.cb_sinifi.Name = "cb_sinifi";
            this.cb_sinifi.Size = new System.Drawing.Size(121, 28);
            this.cb_sinifi.TabIndex = 9;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(753, 12);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(76, 59);
            this.btn_Ekle.TabIndex = 10;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(753, 77);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(76, 59);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(743, 142);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(86, 59);
            this.btn_Guncelle.TabIndex = 12;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "TC Kimlik Numarası";
            // 
            // tb_tc
            // 
            this.tb_tc.Location = new System.Drawing.Point(12, 128);
            this.tb_tc.Name = "tb_tc";
            this.tb_tc.Size = new System.Drawing.Size(218, 26);
            this.tb_tc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "TC Kimlik Numarası";
            // 
            // tb_ara
            // 
            this.tb_ara.Location = new System.Drawing.Point(2, 219);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(218, 26);
            this.tb_ara.TabIndex = 15;
            this.tb_ara.TextChanged += new System.EventHandler(this.tb_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Arama Çubuğu...";
            // 
            // Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 752);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_ara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tc);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.cb_sinifi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.tb_ogrenciNo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ogrenciler";
            this.Text = "Ogrenciler";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_ogrenciNo;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sinifi;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.Label label7;
    }
}