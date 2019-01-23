using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Bulma_Oyunu
{
    public class Oyun
    {
        Form2 form2;
        int sayi;
        int hakSayisi;
        int basamakSayisi;
        public int HakSayisi { get => hakSayisi; set => hakSayisi = value; }
        public int Sayi { get => sayi; set => sayi = value; }
        public int BasamakSayisi { get => basamakSayisi; set => basamakSayisi = value; }

        public Oyun(Form2 form2,int sayi,int hakSayisi,int basamakSayisi){
            this.form2 = form2;
            this.sayi = sayi;
            this.hakSayisi = hakSayisi;
            this.basamakSayisi = basamakSayisi;
        }
        public void hazirlik()
        {
            //sayılar basamaklarına ayrılıyor ve basamak sayısına göre textBoxlar aktif hale geliyor.
            for (int k = 1; k <= BasamakSayisi; k++)
            {
                TextBox txtBox = (TextBox)form2.Controls["textBox" + k];
                Label lbl = (Label)form2.Controls["label" + k];
                txtBox.Enabled = true;
                lbl.Enabled = true;
                form2.basamaklar[k - 1] = (sayi.ToString())[k - 1] - '0';
            }
        }

        public int boslukKontrol()//Boş olan textBox ları kontrol eder.Boşluk varsa 0 döndürür, yoksa 1 döndürür.
        {
            int durum = 1;
            for (int i = 1; i <= basamakSayisi; i++)
            {
                TextBox txt = (TextBox)form2.Controls["textBox" + i];
                if (txt.Text == "")
                    durum = 0;
            }
            return durum;
        }

        public int tekrarKontrol(int sayi)//Sayının tekrarlı olup olmadığı kontrol ediliyor.
        {
         //   MessageBox.Show("Sayi : " + sayi.ToString());
            Random rnd = new Random();
            int tekrarDurum = 1;
            for (int i = 0; i < BasamakSayisi; i++)
            {
                for (int j = 0; j <BasamakSayisi; j++)
                {
                   
                    if ((i != j) && sayi.ToString()[i] - '0' == sayi.ToString()[j] - '0')
                    {
                        tekrarDurum = 0;
                        break;
                    }
                }
            }
            return tekrarDurum;
        }

        public void dosyayaYaz()
        {
            if (File.Exists("skor.txt") == false) // dizindeki dosya var mı ?
            {
                FileStream fs = File.Create("skor.txt");
                fs.Close();
            }
            FileStream fileStream = new FileStream("skor.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);
            sw.WriteLine(form2.isim+"|" + form2.puan);
            sw.Close();
            fileStream.Close();
        }


            public String girilensayi()
        {

            int j = 0;
            String girilen = "";
            for (int i = BasamakSayisi; i > 0; i--)
            {


                Label lbl = (Label)form2.Controls["label" + i];
                TextBox txt = (TextBox)form2.Controls["textBox" + i];
                lbl.BackColor = Color.FromArgb(255, 255, 192);//label lar orjinal rengini alır.
                girilen += txt.Text; //girilen sayinin basamakları birleştiriliyor.
                if (form2.basamaklar[j].ToString() == txt.Text)
                    lbl.BackColor = Color.Blue;//Doğru yerde olan sayıların label ı
                else
                {
                    for (int z = 0; z < BasamakSayisi; z++)
                    {
                        if (txt.Text == form2.basamaklar[z].ToString())
                        {
                            lbl.BackColor = Color.Red;//Sayının içinde bulunup yanlış yerde bulunanlar
                            break;
                        }
                    }
                }
                j++;
            }
            return girilen;
        }

        public void kontrolEt(Timer timer)
        {
            //Kontrol butonu Click**
            if (1 == boslukKontrol())
            {

                form2.lblKalanHak.Text = (--HakSayisi).ToString();//1 hakkı gitti;

                String girilen = girilensayi();
          //      MessageBox.Show("Gİrilen : " + girilen);
                int girilenSayi;
                girilenSayi = int.Parse(girilen);
                if (girilenSayi == sayi)
                {
                    timer.Enabled = false;
                    form2.lblDurum.Text = "Tebrikler Kazandınız!";
                    dosyayaYaz();
                    form2.btnKontrol.Enabled = false;
                    DialogResult cevap = MessageBox.Show("Tebrikler Bildiniz!\nTekrar Oynamak İster misiniz?", "Kazandınız", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    form2.cevapla(cevap);
                }
                else if (hakSayisi == 0)
                {
                    timer.Enabled = false;
                    form2.lblDurum.Text = "Hakkınız Bitti\n Sayınız : " + sayi;
                    DialogResult cevap = MessageBox.Show("\tARANAN SAYI : " + sayi + "\nTekrar Denemek İster misiniz ? ", "Hakkınız Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    form2.btnKontrol.Enabled = false;

                    form2.cevapla(cevap);

                }
                else
                    form2.lblSure.Text = "10".ToString();



            }
            else
                MessageBox.Show("Lütfen Bütün Basamakları Doldurunuz");

        }

        public void sureDurumu(Label lblSure)
        {
            lblSure.Text = (int.Parse(lblSure.Text) - 1).ToString();
            if (lblSure.Text == "0" && HakSayisi == 1)
            {
                HakSayisi--;
                form2.lblKalanHak.Text = HakSayisi.ToString();
                form2.timer1.Enabled = false;
                form2.btnKontrol.Enabled = false;
                form2.lblDurum.Text = "Süreniz Bitti\nSayınız : " + sayi;
                DialogResult cevap = MessageBox.Show("\tARANAN SAYI : " + sayi + "\nTekrar Denemek İstermisiniz ? ", "Süreniz Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                form2.cevapla(cevap);

            }

            if (lblSure.Text == "0" && HakSayisi > 1)
            {
                lblSure.Text = "10";
                HakSayisi--;
                form2.lblKalanHak.Text = HakSayisi.ToString();
            }


        }
    }
}
