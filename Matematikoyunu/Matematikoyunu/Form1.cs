using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            color2 = lblSoruBlok2.BackColor;
            color = lblSoruBlok1.BackColor;
            blok = new Blok(this);
            Sonuc.form1 = this;
            if (User.arg.Length != 0)
                Sonuc.hile = 1;
        }
        Soru soru;

        public Color color, color2;

        public int soruSayisi = 1, puan = 0;
        public int pas = 0;//pas sayisini tutar.
        List<SoruCevap> pasSorulari = new List<SoruCevap>();
        Blok blok;
        private void txtCevap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCevap.TextLength >= 3 && (int)e.KeyChar != 8)
                e.Handled = true;

            else
                if ((int)e.KeyChar == 45 && txtCevap.Text == "")
                e.Handled = false;
            else
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        public int durum = 0;

        void sonrakiSoru()
        {
            //pnlCevap.Enabled = true;
            if (Blok.blok != -1)
                if (soruSayisi % 5 != 0 && !((Blok.blok == 4) && soruSayisi == 5))
                    lblSoru.Text = blok.blokListe()[(++soruSayisi) - 1].Soru;
                else
                {
                    Blok.blokAtla(this, pas);
                    lblSoru.Text = blok.blokListe()[(soruSayisi) - 1].Soru;

                }
            else
            {
                if (soruSayisi < pas)
                    lblSoru.Text = blok.pasSorilari[soruSayisi].Soru;
                else
                {
                    MessageBox.Show("Leveli Bitirdiniz..");
                    MessageBox.Show("Sonucunuz D:" + Sonuc.Dogru + " Y:" + Sonuc.Yanlis);
                    durum = 0;

                }
                soruSayisi++;
            }
            if (durum == 1)//oyun devam ediyorsa;;
                label2.Text = blok.blokListe()[soruSayisi - 1].Id.ToString();
            if (durum == 0)
            {
                LevelKontrol levelKontrol = new LevelKontrol(blok, this);
                levelKontrol.levelAtla();
            }
            //label2.Text = soruSayisi.ToString();
        }

        private void lblCevapla_Click(object sender, EventArgs e)
        {


          //  MessageBox.Show(blok.blokListe()[soruSayisi - 1].Soru);
            if (txtCevap.Text == "" || txtCevap.Text == "-")
                MessageBox.Show("Cevap Giriniz...");

            else
                if (blok.blokListe()[soruSayisi - 1].KullaniciCevap == "")
            {
                blok.blokListe()[soruSayisi - 1].KullaniciCevap = txtCevap.Text;
                if (blok.blokListe()[soruSayisi - 1].Cevap == float.Parse(txtCevap.Text))
                    Sonuc.Dogru++;

                else
                    Sonuc.Yanlis++;
                sonrakiSoru();
                txtCevap.Text = "";
            }
            else
                MessageBox.Show("Zaten cevap verdiniz...\nTekrar cevap veremezsiniz..");
            //pnlCevap.Enabled = false;

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Sonuc.hile == 1)
            {
                if (User.arg.Length != 0)//dizide eleman varmı bak ona göre fonk çağır...   
                    User.HileliKullanici(User.arg, new User(this, blok));
            }
            else
            {
                btnPas.Visible = true;

                Sonuc.form1 = this;
                soru = new Soru();

                blok.blokSorulariHazirla();


                List<SoruCevap> list;
                list = blok.blokListe();
                lblSoru.Text = list[0].Soru.ToString();
                durum = 1;
                btnStart.Enabled = false;
            }
        }





        void OncekiSoru()
        {
            pnlCevap.Enabled = true;
            if (soruSayisi % 5 == 1)
            {
                Blok.blokIn(this);
                lblSoru.Text = blok.blokListe()[(soruSayisi) - 1].Soru;
            }
            else
                lblSoru.Text = blok.blokListe()[(--soruSayisi - 1)].Soru;

            label2.Text = blok.blokListe()[soruSayisi].Id.ToString();
            //soruSayisi.ToString();
        }

        private void btnOnceki_Click(object sender, EventArgs e)
        {
            OncekiSoru();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {

            sonrakiSoru();
        }
   
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            User user = new User(this, blok);
            KayıtEklecs kayıtEkle = new KayıtEklecs();

            kayıtEkle.form1 = this;
            kayıtEkle.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            KayitAc kayitAc = new KayitAc();
            kayitAc.Show();
            kayitAc.form1 = this;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = User.parametreler;
            for (int i = 0; i < a.Length; i++)
                MessageBox.Show("i : " + i + "  " + a[i]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sonuc.form1 = this;
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            blok.pasSorilari.Add(blok.blokListe()[soruSayisi - 1]);//Pas geçilen soruların bilgileri burada...
            pas++;
            sonrakiSoru();
        }


    }
}
