using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    class AdamAsmaca
    {
        string isim;
        Form1 form1;
        int oyun = 1;//OYUNUN DEVAM ETTİĞİ YA DA DURDUĞU BİLGİSİ
        String cevap;
        int hakSayisi;
        int kullanilanSayisi = 0;
        int yanlisSayisi = 0;
        public Char[] girilenHarfler;//girilen harflerin tekrar girilmesini engellemek için 
        int puan = 0;


        public AdamAsmaca(Form1 form1,int hakSayisi,String cevap,String isim)
        {
            this.hakSayisi = hakSayisi;
            this.isim = isim;
            this.cevap = cevap;
            this.form1 = form1;
            girilenHarfler= new Char[hakSayisi + cevap.Length];
        }
            public int acikParca = 0;

            public void yanlisHarf()
            {
            acikParca++;
            form1.parca1.Visible = true;
            PictureBox parca2 = (PictureBox)form1.Controls["parca" + (2).ToString()];
            if (acikParca == 2)
                parca2.Visible = true;
            if (acikParca == 3)
               parca2.ImageLocation="3.png";
             
            else if(acikParca == 4)
            {
                 parca2.ImageLocation = "4.png";
                parca2.Height = 114;
            }
            else if(acikParca==5)
            {
                 parca2.ImageLocation = "5.png";
                parca2.Height = 144;
            }
            else if(acikParca==6)
            {
                parca2.ImageLocation = "6.png";
                parca2.Height = 156;
            }
            else if(acikParca==7 || acikParca==8)
            {
                parca2.ImageLocation = (acikParca).ToString()+".png";
                parca2.Height = 170;
            }
         }

        public void parcalariGoster()
            {
            form1.parca2.ImageLocation = "8.png";
            form1.parca2.Height=171;

            form1.pnlKlavye.Enabled = false;
            // Hepsini göster
            cevapGoster(form1.cevap);
            MessageBox.Show("Kaybettin! \nHe losts, You didn't");

        }
        public void cevapGoster(String cevap)
        {
            for (int i = 0; i < cevap.Length; i++) { 
                
                Label lbl = (Label)form1.Controls["lblHarf" + (i+1)];
                if(lbl.BackColor != Color.GreenYellow)
                {
                    lbl.Text = cevap[i].ToString();
                    lbl.BackColor = Color.LightSeaGreen;
                }
            }
            
            //Labellerde doğru cevabın gösterilmesini sağlar...
        }



        public void kontrol(char harf)
        {

            if (hakSayisi > 0 && oyun == 1)//oyun hala devam ediyorsa;;
            {
                try
                {
                    girilenHarfler[kullanilanSayisi] = harf;//try a koyma sebebi türkçe karakterli harflerin btn yok
                }
                catch
                {
    
                }
                kullanilanSayisi++;

                try
                {
                    Label lblTus = (Label)form1.pnlKlavye.Controls["tus" + harf];
                    lblTus.Enabled = false;
                }
                catch
                {//
                }
                int durum = 1;//kelimenin tamamı bulundumu kontrolü
                int harfDogrulugu = 0;
                for (int i = 0; i < cevap.Length; i++)
                {
                    Label lbl = (Label)form1.Controls["lblHarf" + (i + 1).ToString()];
                    if (cevap[i] == harf)
                    {
                        lbl.Text = harf.ToString();
                        lbl.BackColor = Color.GreenYellow;
                        harfDogrulugu = 1;
                        puan += 60 / cevap.Length;
                        form1.lblPuan.Text = "Puan : " + (puan * 100 / 60).ToString();
                    }
                    if (lbl.BackColor != Color.GreenYellow)
                    {
                        durum = 0;//kelimede daha bulunamayan yer var.
                    }
                }
                if (harfDogrulugu == 0)
                {
                    hakSayisi--;
                    form1.lblKalanHak.Text = "Kalan Hak : " + hakSayisi;
                    //harf dogru değil 
                    yanlisSayisi++;
                    Label lbl = (Label)form1.Controls["yanlis" + (yanlisSayisi)];
                    lbl.Visible = true;
                    lbl.Text = harf.ToString();


                    yanlisHarf();

                }

                if (durum == 1)
                {
                    MessageBox.Show("Tebrikler! Kelimeyi Buldunuz\n Congratulations! You found the word");
                    form1.pnlKlavye.Enabled = false;
                    skorEkle();
                    oyun = 0;
                }

                if (hakSayisi == 0)
                {
                  //  MessageBox.Show("Kaybettin! \nHe losts, You didn't");
                    /*for (int i = 1; i <= 8; i++)
                    {
                        PictureBox parca = (PictureBox)this.Controls["parca" + i.ToString()];
                        parca.Visible = true;
                    }*/
                    parcalariGoster();

                    skorEkle();
                    oyun = 0;
                }
            }

        }
        public static void kelimeSil(TextBox txtSilinecek)
        {
            if (txtSilinecek.Text != null)
            {
                FileStream fileStream = new FileStream("tahmin.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                List<string> liste = new List<string>();
                string kelime;
                int durum = 0;
                while ((kelime = sr.ReadLine()) != null)
                {
                    if (kelime == txtSilinecek.Text.ToUpper())
                    {
                        durum = 1;
                    }
                    else
                        liste.Add(kelime);



                }

                sr.Close();
                fileStream.Close();
                if (durum == 1)
                {

                    File.Delete("tahmin.txt");
                    FileStream filestrm = File.Create("tahmin.txt");
                    filestrm.Close();

                    FileStream fs = new FileStream("tahmin.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i = 0; i < liste.Count; i++)
                    {
                        sw.WriteLine(liste[i]);
                    }
                    sw.Close();

                    fs.Close();
                    MessageBox.Show("Kelime Silindi.");
                }
                else
                    MessageBox.Show("Bu kelime zaten yok");

            }
            else
                MessageBox.Show("Kelime Giriniz.");
        }
         public void skorEkle()
        {
            string dosya_yolu = "skortablosu.txt";

            List<String> skorlar = new List<string>();
            List<String> DuzenliSkorlar = new List<string>();

            if (File.Exists(dosya_yolu) == true) // dizindeki dosya var mı ?
            {

                FileStream fileStream = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    skorlar.Add(satir);
                }
                fileStream.Flush();
                sr.Close();
               
                fileStream.Close();
                skorlar.Add(form1.isim + "|" + puan * 100 / 60);//kullanıcı listeye eklendi.
            }
            else
            {
                //  File.Create(dosya_yolu);
            }
            string gecici;
            for (int i = 0; i < skorlar.Count - 1; i++)
                for (int j = i; j < skorlar.Count; j++)
                {
                    if (Convert.ToInt32((skorlar[i].Split('|'))[1]) < Convert.ToInt32(skorlar[j].Split('|')[1]))
                    {
                        //listede isim|puan ayrıldı ve ona göre if sorgusuna yazdım.
                        gecici = skorlar[i];
                        skorlar[i] = skorlar[j];
                        skorlar[j] = gecici;
                    }
                }

             
            File.Delete(dosya_yolu);
            FileStream filestrm = File.Create(dosya_yolu);
            filestrm.Close();

            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < skorlar.Count; i++)
                sw.WriteLine(skorlar[i]);
            sw.Close();
            fs.Close();
        }
        public void blockControl()
        {
            for (int i = 0; i < 6; i++)
            {
                if (form1.harfSayisi < i + 1)
                {
                    Label lbl = (Label)form1.Controls["lblHarf" + (i + 1).ToString()];
                    lbl.Visible = false;
                }

            }
        }
        public static void kelimeEkle(TextBox txtYeniKelime)
        {
            if (txtYeniKelime.Text != null)
            {
                if (File.Exists("tahmin.txt") == true) // dizindeki dosya var mı ?
                {

                    FileStream fileStream = new FileStream("tahmin.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fileStream);
                    string satir;
                    int durum = 1;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        if (satir == txtYeniKelime.Text)
                            durum = 0;
                    }
                    sr.Close();
                    fileStream.Close();
                    if (durum == 1)
                    {
                        FileStream fs = new FileStream("tahmin.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(txtYeniKelime.Text);
                        sw.Close();
                        fs.Close();
                        MessageBox.Show("Kelime eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kelime zaten var!");
                    }
                }
                else
                    MessageBox.Show("Kelime Giriniz.");
            }
        }

        public static void SkorTablosuAl(ListView listView)
        {

            int sayi = 0;
            string dosya_yolu = "skortablosu.txt";


            if (File.Exists(dosya_yolu) == true) // dizindeki dosya var mı ?
            {

                FileStream fileStream = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    ListViewItem item = new ListViewItem(satir.Split('|')[0]);
                    item.SubItems.Add(satir.Split('|')[1]);
                    if (sayi % 2 == 0)
                        item.BackColor = Color.YellowGreen;

                    listView.Items.Add(item);
                    sayi++;
                    if (sayi == 10)
                        break;
                }
                sr.Close();
                fileStream.Close();

            }
            else
            {
                FileStream fs = File.Create(dosya_yolu);
                fs.Close();
            }
        }

        public static void oyunaBasla(Giris giris)
        {
            if (giris.txtIsim.Text != "")
            {
                Form1 form1 = new Form1();


                form1.isim = giris.txtIsim.Text;

                if (giris.checkboxRandom.Checked == true)
                {
                    Random rnd = new Random();
                    form1.harfSayisi = rnd.Next(2, 7);
                }
                else
                {
                    form1.harfSayisi = (int)giris.numericHakSayisi.Value;
                }

                form1.Show();
                giris.Hide();


            }
            else
                MessageBox.Show("Lütfen bir isim giriniz!");

        }
    }
}
