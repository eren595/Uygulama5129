namespace Uygulama5129
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKopyara = new System.Windows.Forms.Button();
            this.listeAsil = new System.Windows.Forms.ListBox();
            this.listeKopya = new System.Windows.Forms.ListBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKopyara
            // 
            this.btnKopyara.Location = new System.Drawing.Point(355, 132);
            this.btnKopyara.Name = "btnKopyara";
            this.btnKopyara.Size = new System.Drawing.Size(52, 24);
            this.btnKopyara.TabIndex = 1;
            this.btnKopyara.Text = "button2";
            this.btnKopyara.UseVisualStyleBackColor = true;
            this.btnKopyara.Click += new System.EventHandler(this.btnKopyara_Click);
            // 
            // listeAsil
            // 
            this.listeAsil.FormattingEnabled = true;
            this.listeAsil.Location = new System.Drawing.Point(188, 133);
            this.listeAsil.Name = "listeAsil";
            this.listeAsil.Size = new System.Drawing.Size(120, 95);
            this.listeAsil.TabIndex = 2;
            // 
            // listeKopya
            // 
            this.listeKopya.FormattingEnabled = true;
            this.listeKopya.Location = new System.Drawing.Point(413, 133);
            this.listeKopya.Name = "listeKopya";
            this.listeKopya.Size = new System.Drawing.Size(120, 95);
            this.listeKopya.TabIndex = 3;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(107, 133);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "button1";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeKopya);
            this.Controls.Add(this.listeAsil);
            this.Controls.Add(this.btnKopyara);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKopyara;
        private System.Windows.Forms.ListBox listeAsil;
        private System.Windows.Forms.ListBox listeKopya;
        private System.Windows.Forms.Button btnOlustur;
    }
}

