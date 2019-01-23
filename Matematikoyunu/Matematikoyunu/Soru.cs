using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikoyunu
{
    class Soru
    {

        public Soru() { }
        Random rnd = new Random();

        public string soruUret(int blokNo)
        {
            string soru;
            if (Sonuc.Level == 1 || Sonuc.Level == 2)
                return soru = lvl1ve2Soru(blokNo);
            else if (Sonuc.Level == 3)
                return soru = lvl3Soru(blokNo);
            else if (Sonuc.Level == 4)
                return soru = lvl4Soru(blokNo);
            else
                return soru = lvl5Soru(blokNo);
        }


        public string lvl1ve2Soru(int blokNo)//level 2 ve level 3 için sorular
        {
            string question = "";
            List<float> sayi = new List<float>();
            List<char> isaretler = new List<char>();

            isaretler.Add(Islem.islem[blokNo]);//1.level 1.Blok(+) 2.Blok(-) 3.Blok(*) 4.Blok(/)

            int ustSinir = 10, altSinir = 0;
            if (Sonuc.Level == 2)
                ustSinir = 30;
            if (ustSinir == 30 && isaretler[0] == '*')
                ustSinir = 12;//Çarpma 2.level için ust 12 yeterli...ÇOK ZOR OLMAMALI 2.SEVİYEDE
            sayi.Add(rnd.Next(altSinir, ustSinir));
            sayi.Add(rnd.Next(altSinir, ustSinir));
            if (isaretler[0] == '/')
            {
                altSinir = 1;
                sayi[0] = rnd.Next(altSinir, ustSinir);
                sayi[1] = tamBolenRandom((int)sayi[0]);
            }

            question = sayi[0].ToString() + isaretler[0].ToString() + sayi[1].ToString();
            return question;
        }

        public string lvl3Soru(int blokNo)
        {
            string question = "";
            List<char> isaretler = new List<char>();
            int[] sayi = new int[3];
            for (int i = 0; i < sayi.Length; i++)
                sayi[i] = rnd.Next(1, 10);


            if (blokNo == 1)
            {
                isaretler.Add(Islem.artieksiUret(rnd));
                isaretler.Add(Islem.artieksiUret(rnd));
            }
            else if (blokNo == 2)
            {
                isaretler.Add(Islem.carpiBoluUret(rnd));
                isaretler.Add(Islem.carpiBoluUret(rnd));
            }
            else
            {
                isaretler.Add(Islem.islemUret(rnd));
                isaretler.Add(Islem.islemUret(rnd));
            }

            for (int i = 0; i < isaretler.Count; i++)
                if (isaretler[i] == '/')
                    sayi[i + 1] = tamBolenRandom(sayi[i]);//BÖLME İŞLEMİ VARSA TAM SAYI OLSUN
            question = sayi[0].ToString() + isaretler[0].ToString() + sayi[1].ToString() + isaretler[1].ToString() + sayi[2].ToString();
            //  MessageBox.Show("question : " + question);
            return question;
        }

        public string lvl4Soru(int blokNo)//4 basamaklı...
        {
            string question = "";
            List<char> isaretler = new List<char>();
            int basamak = 4;
            if (blokNo >= 3)
                basamak = 5;
            int[] sayi = new int[basamak];
            for (int i = 0; i < sayi.Length; i++)
                sayi[i] = rnd.Next(1, 10);

            for (int i = 0; i < basamak - 1; i++)
                isaretler.Add(Islem.islemUret(rnd));

            for (int i = 0; i < basamak - 1; i++)
                if (i != (basamak - 2) && isaretler[i] == '/' && isaretler[i + 1] == '/')
                    while (isaretler[i] == '/')
                        isaretler[i] = Islem.islemUret(rnd);


            for (int i = 0; i < isaretler.Count; i++)
                if (isaretler[i] == '/')
                    sayi[i + 1] = tamBolenRandom(sayi[i]);//BÖLME İŞLEMİ VARSA TAM SAYI OLSUN

            for (int i = 0; i < basamak; i++)
            {
                question += sayi[i].ToString();
                if (i < isaretler.Count)
                    question += isaretler[i].ToString();
            }
            Console.WriteLine("4.levelquestion : " + question);
            return question;

        }
        public string lvl5Soru(int blokNo)//5 ve 6 basmaklı
        {
            string question = "";
            List<char> isaretler = new List<char>();
            int basamak = 5;
            if (blokNo >= 4)
                basamak = 6;
            int[] sayi = new int[basamak];
            for (int i = 0; i < sayi.Length; i++)
                sayi[i] = rnd.Next(1, 10);

            for (int i = 0; i < basamak - 1; i++)
                isaretler.Add(Islem.islemUret(rnd));

            for (int i = 0; i < basamak - 1; i++)
                if (i != (basamak - 2) && isaretler[i] == '/' && isaretler[i + 1] == '/')
                    while (isaretler[i] == '/')
                        isaretler[i] = Islem.islemUret(rnd);


            for (int i = 0; i < isaretler.Count; i++)
                if (isaretler[i] == '/')
                    sayi[i + 1] = tamBolenRandom(sayi[i]);//BÖLME İŞLEMİ VARSA TAM SAYI OLSUN

            for (int i = 0; i < basamak; i++)
            {
                question += sayi[i].ToString();
                if (i < isaretler.Count)
                    question += isaretler[i].ToString();
            }
            Console.WriteLine("5.levelquestion : " + question);
            return question;
        }



        int tamBolenRandom(int sayi)
        {
            Random rnd = new Random();
            List<int> sayilar = new List<int>();
            for (int i = 1; i <= sayi; i++)
                if (sayi % i == 0)
                    sayilar.Add(i);
            int index = (int)rnd.Next(0, sayilar.Count);
            Console.WriteLine("index : " + sayilar[index] + "  sayi : " + sayi);
            return sayilar[index];
        }
    }


    class Islem
    {
        private Islem() { }

        public static char[] islem = new char[4] { '+', '-', '*', '/' };
        //Random rnd = new Random();
        public static char islemUret(Random rnd)
        {
            return islem[(int)(rnd.Next(0, 4))];
        }
        public static char artieksiUret(Random rnd)
        {
            return islem[(int)rnd.Next(0, 2)];
        }
        public static char carpiBoluUret(Random rnd)
        {
            return islem[(int)rnd.Next(2, 4)];
        }
    }
}
