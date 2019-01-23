using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            AdamAsmaca.oyunaBasla(this);
           }

        private void checkboxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxRandom.Checked == true)
            {
                numericHakSayisi.Enabled = false;
            }
            else
            {
                numericHakSayisi.Enabled = true;
            }

        }

        private void Giris_Load(object sender, EventArgs e)
        {

            AdamAsmaca.SkorTablosuAl(listView1);
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
                pnlKelimeSil.Visible = false;
                pnlOyunBilgisi.Visible = false;
                pnlLblKelimeEkle.Visible = true;
            
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            AdamAsmaca.kelimeEkle(txtYeniKelime);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == '\b')
                e.Handled = false;
            else if (txt.TextLength == 6)
            {
                e.Handled = true;
            }

            else
            {
                if ('q' == e.KeyChar || 'Q' == e.KeyChar || 'w' == e.KeyChar || 'W' == e.KeyChar
                     || 'x' == e.KeyChar || 'X' == e.KeyChar)
                    e.Handled = true;
                else
                    e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//isLetter harf ise false döndürür.
                       && !char.IsSeparator(e.KeyChar);
            }
         
            //SADECE HARF GİRİLMESİ KONTROLÜ

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.CharacterCasing = CharacterCasing.Upper;
            txt.Text=txt.Text.Replace('ı', 'I');
            txt.Text=txt.Text.Replace('İ', 'I');
            txt.Text = txt.Text.Replace('Ü', 'U');
            txt.Text = txt.Text.Replace('Ö', 'O');
            txt.Text = txt.Text.Replace('Ş', 'S');
            txt.Text = txt.Text.Replace('Ç', 'C');
            txt.Text = txt.Text.Replace('Ğ', 'G');

            txt.Select(txt.Text.Length,0);
        }

        private void btnKelimeSil_Click(object sender, EventArgs e)
        {

            pnlKelimeSil.Visible = true;
            pnlOyunBilgisi.Visible = false;
            pnlLblKelimeEkle.Visible = false;
           

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            AdamAsmaca.kelimeSil(txtSilinecek);
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            pnlKelimeSil.Visible = false;
            pnlOyunBilgisi.Visible = true;
            pnlLblKelimeEkle.Visible = false;

        }
    }
}
