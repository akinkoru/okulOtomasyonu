namespace Okul.WinFormUI
{
    partial class Frm_Giris_Yap
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
            this.tb_kAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Parola = new System.Windows.Forms.TextBox();
            this.cb_goster = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_kAdi
            // 
            this.tb_kAdi.Location = new System.Drawing.Point(187, 256);
            this.tb_kAdi.Name = "tb_kAdi";
            this.tb_kAdi.Size = new System.Drawing.Size(203, 26);
            this.tb_kAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // tb_Parola
            // 
            this.tb_Parola.Location = new System.Drawing.Point(187, 319);
            this.tb_Parola.Name = "tb_Parola";
            this.tb_Parola.PasswordChar = '*';
            this.tb_Parola.Size = new System.Drawing.Size(203, 26);
            this.tb_Parola.TabIndex = 2;
            // 
            // cb_goster
            // 
            this.cb_goster.AutoSize = true;
            this.cb_goster.Location = new System.Drawing.Point(405, 319);
            this.cb_goster.Name = "cb_goster";
            this.cb_goster.Size = new System.Drawing.Size(131, 24);
            this.cb_goster.TabIndex = 4;
            this.cb_goster.Text = "Şifreyi Göster";
            this.cb_goster.UseVisualStyleBackColor = true;
            this.cb_goster.CheckedChanged += new System.EventHandler(this.cb_goster_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 209);
            this.label3.TabIndex = 5;
            this.label3.Text = "HIZLI OKUL SİSTEMİ GİRİŞ EKRANINA HOŞGELDİNİZ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(187, 368);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(203, 48);
            this.btn_Giris.TabIndex = 6;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // Frm_Giris_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 484);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_goster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Parola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_kAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Giris_Yap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Frm_Giris_Yap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_kAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Parola;
        private System.Windows.Forms.CheckBox cb_goster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Giris;
    }
}

