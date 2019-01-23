namespace AdamAsmacaOyunu
{
    partial class Giris
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
            this.btnStart = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericHakSayisi = new System.Windows.Forms.NumericUpDown();
            this.checkboxRandom = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.pnlOyunBilgisi = new System.Windows.Forms.Panel();
            this.pnlLblKelimeEkle = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniKelime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKelimeSil = new System.Windows.Forms.Button();
            this.pnlKelimeSil = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSilinecek = new System.Windows.Forms.TextBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericHakSayisi)).BeginInit();
            this.pnlOyunBilgisi.SuspendLayout();
            this.pnlLblKelimeEkle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlKelimeSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(372, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(48, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "İsminiz :";
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(138, 74);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(120, 23);
            this.txtIsim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Harf Sayısı:";
            // 
            // numericHakSayisi
            // 
            this.numericHakSayisi.Location = new System.Drawing.Point(138, 112);
            this.numericHakSayisi.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericHakSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericHakSayisi.Name = "numericHakSayisi";
            this.numericHakSayisi.Size = new System.Drawing.Size(120, 20);
            this.numericHakSayisi.TabIndex = 6;
            this.numericHakSayisi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkboxRandom
            // 
            this.checkboxRandom.AutoSize = true;
            this.checkboxRandom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.checkboxRandom.Location = new System.Drawing.Point(51, 151);
            this.checkboxRandom.Name = "checkboxRandom";
            this.checkboxRandom.Size = new System.Drawing.Size(152, 21);
            this.checkboxRandom.TabIndex = 7;
            this.checkboxRandom.Text = "Rastgele Harf Sayısı";
            this.checkboxRandom.UseVisualStyleBackColor = true;
            this.checkboxRandom.CheckedChanged += new System.EventHandler(this.checkboxRandom_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.listView1.Location = new System.Drawing.Point(16, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 205);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Puan";
            this.columnHeader2.Width = 89;
            // 
            // lblPuan
            // 
            this.lblPuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuan.BackColor = System.Drawing.Color.Transparent;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPuan.Location = new System.Drawing.Point(16, 1);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(272, 38);
            this.lblPuan.TabIndex = 59;
            this.lblPuan.Text = "Skor Tablosu (İlk 10)";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKelimeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelimeEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeEkle.ForeColor = System.Drawing.Color.White;
            this.btnKelimeEkle.Location = new System.Drawing.Point(133, 285);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(115, 44);
            this.btnKelimeEkle.TabIndex = 60;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = false;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // pnlOyunBilgisi
            // 
            this.pnlOyunBilgisi.Controls.Add(this.labelName);
            this.pnlOyunBilgisi.Controls.Add(this.txtIsim);
            this.pnlOyunBilgisi.Controls.Add(this.label1);
            this.pnlOyunBilgisi.Controls.Add(this.numericHakSayisi);
            this.pnlOyunBilgisi.Controls.Add(this.checkboxRandom);
            this.pnlOyunBilgisi.Location = new System.Drawing.Point(22, 9);
            this.pnlOyunBilgisi.Name = "pnlOyunBilgisi";
            this.pnlOyunBilgisi.Size = new System.Drawing.Size(300, 250);
            this.pnlOyunBilgisi.TabIndex = 61;
            // 
            // pnlLblKelimeEkle
            // 
            this.pnlLblKelimeEkle.Controls.Add(this.btnEkle);
            this.pnlLblKelimeEkle.Controls.Add(this.label2);
            this.pnlLblKelimeEkle.Controls.Add(this.txtYeniKelime);
            this.pnlLblKelimeEkle.Location = new System.Drawing.Point(22, 9);
            this.pnlLblKelimeEkle.Name = "pnlLblKelimeEkle";
            this.pnlLblKelimeEkle.Size = new System.Drawing.Size(300, 250);
            this.pnlLblKelimeEkle.TabIndex = 62;
            this.pnlLblKelimeEkle.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(36, 140);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(221, 37);
            this.btnEkle.TabIndex = 61;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kelime :";
            // 
            // txtYeniKelime
            // 
            this.txtYeniKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniKelime.Location = new System.Drawing.Point(119, 88);
            this.txtYeniKelime.Multiline = true;
            this.txtYeniKelime.Name = "txtYeniKelime";
            this.txtYeniKelime.Size = new System.Drawing.Size(139, 22);
            this.txtYeniKelime.TabIndex = 4;
            this.txtYeniKelime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtYeniKelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.lblPuan);
            this.panel1.Location = new System.Drawing.Point(352, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 250);
            this.panel1.TabIndex = 63;
            // 
            // btnKelimeSil
            // 
            this.btnKelimeSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKelimeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelimeSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeSil.ForeColor = System.Drawing.Color.White;
            this.btnKelimeSil.Location = new System.Drawing.Point(254, 285);
            this.btnKelimeSil.Name = "btnKelimeSil";
            this.btnKelimeSil.Size = new System.Drawing.Size(115, 44);
            this.btnKelimeSil.TabIndex = 64;
            this.btnKelimeSil.Text = "Kelime Sil";
            this.btnKelimeSil.UseVisualStyleBackColor = false;
            this.btnKelimeSil.Click += new System.EventHandler(this.btnKelimeSil_Click);
            // 
            // pnlKelimeSil
            // 
            this.pnlKelimeSil.Controls.Add(this.btnSil);
            this.pnlKelimeSil.Controls.Add(this.label3);
            this.pnlKelimeSil.Controls.Add(this.txtSilinecek);
            this.pnlKelimeSil.Location = new System.Drawing.Point(22, 9);
            this.pnlKelimeSil.Name = "pnlKelimeSil";
            this.pnlKelimeSil.Size = new System.Drawing.Size(300, 250);
            this.pnlKelimeSil.TabIndex = 63;
            this.pnlKelimeSil.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(36, 140);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(221, 37);
            this.btnSil.TabIndex = 61;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelime :";
            // 
            // txtSilinecek
            // 
            this.txtSilinecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilinecek.Location = new System.Drawing.Point(119, 88);
            this.txtSilinecek.Multiline = true;
            this.txtSilinecek.Name = "txtSilinecek";
            this.txtSilinecek.Size = new System.Drawing.Size(139, 22);
            this.txtSilinecek.TabIndex = 4;
            this.txtSilinecek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSilinecek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 285);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(115, 44);
            this.btnAnaSayfa.TabIndex = 65;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 357);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnKelimeSil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlLblKelimeEkle);
            this.Controls.Add(this.pnlKelimeSil);
            this.Controls.Add(this.pnlOyunBilgisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximumSize = new System.Drawing.Size(680, 396);
            this.MinimumSize = new System.Drawing.Size(680, 396);
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHakSayisi)).EndInit();
            this.pnlOyunBilgisi.ResumeLayout(false);
            this.pnlOyunBilgisi.PerformLayout();
            this.pnlLblKelimeEkle.ResumeLayout(false);
            this.pnlLblKelimeEkle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlKelimeSil.ResumeLayout(false);
            this.pnlKelimeSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Panel pnlOyunBilgisi;
        private System.Windows.Forms.Panel pnlLblKelimeEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKelimeSil;
        private System.Windows.Forms.Panel pnlKelimeSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSilinecek;
        private System.Windows.Forms.Button btnAnaSayfa;
        public System.Windows.Forms.TextBox txtYeniKelime;
        public System.Windows.Forms.NumericUpDown numericHakSayisi;
        public System.Windows.Forms.TextBox txtIsim;
        public System.Windows.Forms.CheckBox checkboxRandom;
    }
}