using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikoyunu
{
    class User
    {
        Blok blok;

        string isim;
        string parola;
        List<int> leveller = new List<int>();//LEVELLERİN YILDIZLARINI TUTAR..
        Form1 form1;
        int n = 0;
        public static User user1;
        public static string[] arg;
        public User(Form1 form1, Blok blok)
        {
            this.form1 = form1;
            this.blok = blok;
            
        }
        public User(Form1 form1)
        {
            this.form1 = form1;

        }

        public string Isim { get => isim; set => isim = value; }
        public string Parola { get => parola; set => parola = value; }
        public List<int> Leveller { get => leveller; set => leveller = value; }







        public void formuDuzenle()//formu kullanıcının kaldığı bilgilerin düzenine getirir.
        {
            // MessageBox.Show("Leveller.count : " + leveller.Count);
            Sonuc.Level = leveller.Count + 1;
     
            for (int i = 0; i < Leveller.Count; i++)//burada i+1 level olur.
            {
                for (int j = 0; j < Leveller[i]; j++)
                {
                    PictureBox yildiz = (PictureBox)form1.panel1.Controls["yildiz" + (i + 1).ToString() + (j + 1).ToString()];
                    yildiz.Visible = true;
                }
            }
            Sonuc.Dogru = 0;
            LevelKontrol levelKontrol = new LevelKontrol(blok, form1);
            levelKontrol.levelAtla();
            form1.soruSayisi = 1;
            form1.label2.Text = 1.ToString();
            form1.pas = 0;
            form1.durum = 1;
            form1.lblSoru.Text = blok.blokListe()[0].Soru;
            //Blok.blokRenklendir(form1);

        }

        public void KayitAc(string bilgi)
        {
            string[] kayitBilgisi = bilgi.Split('|');

            Sonuc.Level = kayitBilgisi.Length;
           
            Blok.level = Sonuc.Level;
         //   MessageBox.Show(kayitBilgisi.Length.ToString());
            for (int i = 1; i < kayitBilgisi.Length; i++)
            {
                leveller.Add(int.Parse(kayitBilgisi[i]));
            }
            Sonuc.yildizlar.RemoveAll(item => item > 0);
            for (int i = 1; i < kayitBilgisi.Length; i++)
                Sonuc.yildizlar.Add(int.Parse(kayitBilgisi[i]));
            formuDuzenle();

        }



        public static string[] parametreler;
        public static void HileliKullanici(string[] s,User user)
        {
            parametreler = s;
            if (s.Length > 0)
                if (s[0] == "2")
                    user.KayitAc("hile|" + 3.ToString());

                else if (s[0] == "3")
                    user.KayitAc("hile|" + 3.ToString() + "|" + 3.ToString());

                else if (s[0] == "4")
                    user.KayitAc("hile|" + 3.ToString() + "|" + 3.ToString() + "|" + 3.ToString());
                else if (s[0] == "5" || s[1] == "all")
                    user.KayitAc("hile|" + 3.ToString() + "|" + 3.ToString() + "|" + 3.ToString() + "|" + 3.ToString());
            //for (int i = 0; i < s.Length; i++)
            //    MessageBox.Show("i:" + i + "  " + s[i].ToString());


            //MessageBox.Show("" + s.Length);


            Sonuc.hile = 1;
        }


        public static void skorKaydet(string isim)
        {
            if (File.Exists("skor.txt") == false) // dizindeki dosya var mı ?
            {
                FileStream fs = File.Create("skor.txt");
                fs.Close();
            }
            FileStream fileStream = new FileStream("skor.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);
            string satir = isim;
            for (int i = 0; i < Sonuc.yildizlar.Count; i++)
                satir += "|" + Sonuc.yildizlar[i].ToString();
            sw.WriteLine(satir);
            sw.Close();
            fileStream.Close();
        }



    }
}
