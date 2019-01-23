using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikoyunu
{
    class LevelKontrol
    {
        Blok blok;
        Form1 form1;
        public LevelKontrol(Blok blok, Form1 form1)
        {
            this.blok = blok;
            this.form1 = form1;

        }
        public void yildizKontrol(int level, int Dogru)
        {

            for (int i = 0; i < 3; i++)
            {
                PictureBox yildiz = (PictureBox)form1.panel1.Controls["yildiz" + level.ToString() + (i + 1).ToString()];
                yildiz.Visible = true;
                if (Sonuc.Dogru < 19 && i == 1)
                    break;//2tane görünür yapar bırakır...
                if (Sonuc.Dogru < 16 && i == 0)
                    break;


            }
        }


        public void levelAtla()
        {
            Blok.blok = 1;
            if (Sonuc.Level != 5 ||(Sonuc.Level==5 && Sonuc.hile==1))
            {
                if (Sonuc.Dogru >= 11)
                {
                    Sonuc.Level++;
                    yildizKontrol(Sonuc.Level - 1, Sonuc.Dogru);
                    if ((Sonuc.Level) - 1 == 1)
                    {
                        if (Sonuc.Dogru > 19)
                            Sonuc.yildizlar.Add(3);
                        else if (Sonuc.Dogru > 16)
                            Sonuc.yildizlar.Add(2);
                        else
                            Sonuc.yildizlar.Add(1);
                    }

                }
                else
                {
                    MessageBox.Show("En az 11 tane Doğru yapmalısınız...");
                }

                Sonuc.Dogru = 0;
                Sonuc.Yanlis = 0;
                Label lbl = (Label)form1.panel1.Controls["lblLevel" + Sonuc.Level];
                lbl.Enabled = true;
                blok.Blok1Sorular.RemoveAll(item => item.Id > 0);//listelerin içini temizler...
                blok.Blok2Sorular.RemoveAll(item => item.Id > 0);
                blok.Blok3Sorular.RemoveAll(item => item.Id > 0);
                blok.Blok4Sorular.RemoveAll(item => item.Id > 0);
                blok.pasSorilari.RemoveAll(item => item.Id > 0);


                blok.blokSorulariHazirla();
                form1.soruSayisi = 1;
                form1.label2.Text = 1.ToString();
                form1.pas = 0;
                form1.durum = 1;
                form1.lblSoru.Text = blok.blokListe()[0].Soru;
                Blok.blokRenklendir(form1);

            }
            else
            {
                MessageBox.Show("Tebrikler!\nOyunu bitirdiniz...");
                form1.pnlCevap.Enabled = false;
                form1.btnStart.Enabled = false;
            }
        }


    }
}
