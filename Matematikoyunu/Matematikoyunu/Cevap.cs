using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikoyunu
{
    class Cevap
    {
        private Cevap() { }

        public static float cevapOlustur(String soru)
        {
            soru = "0+" + soru;
            //   MessageBox.Show("Soru : "+soru);
            //soru = "8+12/4+5/5+2-3*2+15/3+3";
            //soru = "5-5/2+2*3-8/4*2";
            List<Char> isaretler = new List<Char>();
            List<float> sayilar = new List<float>();
            int adim = 0;
            string sayi = "", yeni = "";
            for (int i = 0; i < soru.Length; i++)
                if (Char.IsDigit((char)(soru[i])))
                    sayi += soru[i].ToString();
                else
                {
                    //MessageBox.Show(float.Parse(sayi).ToString());
                    sayilar.Add(float.Parse(sayi));
                    sayi = "";
                    isaretler.Add(soru[i]);
                }

            sayilar.Add(float.Parse(sayi));
            while (adim < 3)
            {
                // MessageBox.Show("girdi");
                for (int i = 0; i < isaretler.Count; i++)
                {
                    Console.WriteLine(isaretler.Count + " dad " + sayilar.Count);
                    if (adim == 1)
                        if (isaretler[i] == '+' || isaretler[i] == '-')
                        {

                            float sonuc;
                            if (isaretler[i] == '+')
                                sonuc = sayilar[i] + sayilar[i + 1];
                            else
                                sonuc = sayilar[i] - sayilar[i + 1];
                            //sonuc hesaplandı.
                            sayilar.RemoveAt(i + 1);
                            isaretler.RemoveAt(i);//operator tarafı tamamlandı.
                            sayilar[i] = sonuc;

                            yeni = "";
                            for (int a = 0; a < sayilar.Count; a++)
                            {
                                yeni += sayilar[a];
                                if (a == (sayilar.Count - 1))
                                    break;
                                yeni += isaretler[a];

                            }
                            Console.WriteLine(isaretler.Count + "  " + sayilar.Count + " Sonuc : " + yeni);
                            //  MessageBox.Show("Sonuç : " + yeni);
                            --i;
                        }
                    //   MessageBox.Show("yeni : " + yeni  + " adim:" + adim);
                    if (adim == 0)
                        if (isaretler[i] == '/' || isaretler[i] == '*')
                        {
                            //     MessageBox.Show("İÇERİ GİRDİ");
                            float sonuc;
                            if (isaretler[i] == '/')
                                sonuc = sayilar[i] / sayilar[i + 1];
                            else
                                sonuc = sayilar[i] * sayilar[i + 1];
                            //sonuc hesaplandı.
                            sayilar.RemoveAt(i + 1);
                            isaretler.RemoveAt(i);//operator tarafı tamamlandı.
                            sayilar[i] = sonuc;

                            yeni = "";
                            for (int a = 0; a < sayilar.Count; a++)
                            {
                                yeni += sayilar[a];
                                if (a == (sayilar.Count - 1))
                                    break;
                                yeni += isaretler[a];

                            }
                            // MessageBox.Show("Sonuç : " + yeni);
                            i = 0;
                        }
                    Console.WriteLine(isaretler.Count + "i : " + i + "durum: " + (Boolean)(i < isaretler.Count));
                }
                Console.WriteLine("Çıktı");
                // if(adim==0)
                adim++;
            }
            return float.Parse(yeni);
        }



    }
}
