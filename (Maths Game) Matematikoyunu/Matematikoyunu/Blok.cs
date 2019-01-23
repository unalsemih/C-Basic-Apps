using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikoyunu
{
    class Blok
    {
        public static int blok = 1;
        public static int level = 1;
        static int nesneSayisi = 0;
        public static Blok blok1;
        Form1 form1;
        public List<SoruCevap> pasSorilari = new List<SoruCevap>();
        List<SoruCevap> blok1Sorular = new List<SoruCevap>();
        List<SoruCevap> blok2Sorular = new List<SoruCevap>();
        List<SoruCevap> blok3Sorular = new List<SoruCevap>();
        List<SoruCevap> blok4Sorular = new List<SoruCevap>();

        public List<SoruCevap> Blok1Sorular { get => blok1Sorular; set => blok1Sorular = value; }
        public List<SoruCevap> Blok2Sorular { get => blok2Sorular; set => blok2Sorular = value; }
        public List<SoruCevap> Blok3Sorular { get => blok3Sorular; set => blok3Sorular = value; }
        public List<SoruCevap> Blok4Sorular { get => blok4Sorular; set => blok4Sorular = value; }

        public Blok(Form1 form1)
        {
            this.form1 = form1;
            if (nesneSayisi == 0)
            {
                blok1 = this;
                nesneSayisi++;
            }

        }
        public static void blokAtla(Form1 form1, int pasSayisi)
        {

            if (blok != 4)
            {
                blok++;
                blokRenklendir(form1);
                form1.soruSayisi = 1;
            }

            else
            {
                MessageBox.Show("GELEN PAS SAYİSİ : " + pasSayisi);
                if (pasSayisi != 0)
                    blok = -1;
                else
                {
                    MessageBox.Show("Tüm soruları çözdünüz...");
                    form1.durum = 0;
                    MessageBox.Show("Sonuc : " + "D:" + Sonuc.Dogru + " Y: " + Sonuc.Yanlis);
                }
                form1.soruSayisi = 1;
            }
        }
        public static void blokIn(Form1 form1)
        {
            if (blok != 1)
            {
                blok--;
                blokRenklendir(form1);
                form1.soruSayisi = 5;
            }
            else
                return;
        }
        public static void blokRenklendir(Form1 form1)
        {
            for (int i = 1; i <= 4; i++)
            {
                Label lbl = (Label)form1.Controls["lblSoruBlok" + i];
                lbl.BackColor = form1.color2;
                if (blok == i)
                    lbl.BackColor = form1.color;
            }
        }
        public List<SoruCevap> blokListe()
        {
            if (blok == -1)
                return pasSorilari;
            else if (blok == 1)
                return Blok1Sorular;
            else if (blok == 2)
                return Blok2Sorular;
            else if (blok == 3)
                return Blok3Sorular;
            else
                return Blok4Sorular;
        }
        public void blokSorulariHazirla()
        {
            Soru soru = new Soru();
            string s;
            for (int i = 0; i < 5; i++)
            {

                Blok1Sorular.Add(new SoruCevap((s = soru.soruUret(0)), Cevap.cevapOlustur(s), i + 1 + (5 * 0), ""));
                Blok2Sorular.Add(new SoruCevap((s = soru.soruUret(1)), Cevap.cevapOlustur(s), i + 1 + (5 * 1), ""));
                Blok3Sorular.Add(new SoruCevap((s = soru.soruUret(2)), Cevap.cevapOlustur(s), i + 1 + (5 * 2), ""));
                Blok4Sorular.Add(new SoruCevap((s = soru.soruUret(3)), Cevap.cevapOlustur(s), i + 1 + (5 * 3), ""));

            }
        }
    }
}
