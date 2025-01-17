namespace QUIZZPROJE
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttn_giriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_baglantıAc = new System.Windows.Forms.Button();
            this.buttnkapat = new System.Windows.Forms.Button();
            this.btnbağlantıdurumu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.richTextBox1.Location = new System.Drawing.Point(-3, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(864, 402);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "GİRİŞ YAP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "kullanıcı adı ya da e-posta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(184, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttn_giriş
            // 
            this.buttn_giriş.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttn_giriş.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttn_giriş.Location = new System.Drawing.Point(6, 222);
            this.buttn_giriş.Name = "buttn_giriş";
            this.buttn_giriş.Size = new System.Drawing.Size(97, 40);
            this.buttn_giriş.TabIndex = 6;
            this.buttn_giriş.Text = "giriş yap";
            this.buttn_giriş.UseVisualStyleBackColor = false;
            this.buttn_giriş.Click += new System.EventHandler(this.buttn_giriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "şifre";
            // 
            // btn_baglantıAc
            // 
            this.btn_baglantıAc.Location = new System.Drawing.Point(1063, 420);
            this.btn_baglantıAc.Name = "btn_baglantıAc";
            this.btn_baglantıAc.Size = new System.Drawing.Size(104, 50);
            this.btn_baglantıAc.TabIndex = 8;
            this.btn_baglantıAc.Text = "bağlanti aç";
            this.btn_baglantıAc.UseVisualStyleBackColor = true;
            this.btn_baglantıAc.Visible = false;
            this.btn_baglantıAc.Click += new System.EventHandler(this.btn_baglantıAc_Click);
            // 
            // buttnkapat
            // 
            this.buttnkapat.Location = new System.Drawing.Point(1173, 420);
            this.buttnkapat.Name = "buttnkapat";
            this.buttnkapat.Size = new System.Drawing.Size(104, 50);
            this.buttnkapat.TabIndex = 9;
            this.buttnkapat.Text = "bağlanti kapat";
            this.buttnkapat.UseVisualStyleBackColor = true;
            this.buttnkapat.Visible = false;
            this.buttnkapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbağlantıdurumu
            // 
            this.btnbağlantıdurumu.Location = new System.Drawing.Point(1110, 476);
            this.btnbağlantıdurumu.Name = "btnbağlantıdurumu";
            this.btnbağlantıdurumu.Size = new System.Drawing.Size(157, 50);
            this.btnbağlantıdurumu.TabIndex = 10;
            this.btnbağlantıdurumu.Text = "bağlanti durumu(açıkmı kapalımı)";
            this.btnbağlantıdurumu.UseVisualStyleBackColor = true;
            this.btnbağlantıdurumu.Visible = false;
            this.btnbağlantıdurumu.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1301, 538);
            this.Controls.Add(this.btnbağlantıdurumu);
            this.Controls.Add(this.buttnkapat);
            this.Controls.Add(this.btn_baglantıAc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttn_giriş);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttn_giriş;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_baglantıAc;
        private System.Windows.Forms.Button buttnkapat;
        private System.Windows.Forms.Button btnbağlantıdurumu;
    }
}

