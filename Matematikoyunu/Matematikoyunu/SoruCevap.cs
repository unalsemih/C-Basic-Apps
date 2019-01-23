using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikoyunu
{
    class SoruCevap
    {
        int id;
        string soru;
        float cevap;
        int level;
        string kullaniciCevap;
        public SoruCevap(string soru, float cevap, int id, string kullaniciCevap)
        {
            this.soru = soru;
            this.cevap = cevap;
            this.id = id;
            this.KullaniciCevap = kullaniciCevap;
            Console.WriteLine("Soru : " + id + " Soru : " + soru + " Cevap : " + cevap);
        }


        public int Id { get => id; set => id = value; }
        public string Soru { get => soru; set => soru = value; }
        public float Cevap { get => cevap; set => cevap = value; }
        public int Level { get => level; set => level = value; }
        public string KullaniciCevap { get => kullaniciCevap; set => kullaniciCevap = value; }

        public SoruCevap get()
        {
            return this;
        }

    }
}
