using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikoyunu
{
    class Sonuc
    {
        static int dogru = 0;
        static int yanlis = 0;
        public static Form1 form1;
        private static int level = 1;
        public static int hile = 0;
        public static List<int> yildizlar = new List<int>();
        public static int Dogru
        {
            get => dogru;
            set
            {
                dogru = value;
                form1.lblSoruDurum.Text = "Doğru! Bir sonraki soruya geçiniz!";
            }
        }
        public static int Yanlis
        {
            get => yanlis; set
            {
                yanlis = value;
                form1.lblSoruDurum.Text = "Yanlış! Bir sonraki soruya geçiniz!";

            }
        }

        public static int Level
        {
            get => level; set
            {
                level = value;
                form1.lblSeviyeDurum.Text = "Level : " + value;
            }
        }

        float sonucHesapla()
        {
            return 0;
        }
    }
}
