using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//kontrollerin yüklendiği nokta...
            //burada form tamamen yüklenmiş olur.
           
        }
       
        public String isim;
        public int harfSayisi;
        List<string> kelimeler = new List<string>();//kelimeler burada toplanır.
        public String cevap;
        int hakSayisi;
        AdamAsmaca adam;
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("tahmin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string satir;
            while ((satir=sw.ReadLine() )!= null)
            {

                if (satir.Length == harfSayisi)
                {
                    kelimeler.Add(satir);
                }
            }
            Random rnd = new Random();
            cevap = kelimeler[rnd.Next(0, kelimeler.Count())].ToString();
            hakSayisi = cevap.Length + 2;
            lblKalanHak.Text = "Kalan Hak : " + hakSayisi;
           
            lblIsim.Text = isim;
    
            adam = new AdamAsmaca(this, hakSayisi, cevap,isim);
            adam.blockControl();
            sw.Close();
            fs.Close();
        }

        private void tusClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            adam.kontrol((char)label.Text[0]);//adam sınıfının kontrol metodu
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar); //Basilan tuşun ASCII numarasını atadım

            if (((basilantus >= 65 && basilantus <= 90) && (basilantus != 81 && basilantus != 87 && basilantus != 88))
                || ((basilantus >= 97 && basilantus <= 122) && (basilantus != 113 && basilantus != 119 && basilantus != 120 && basilantus != 105))
                || (char)basilantus == 'ı' || (char)basilantus == 'u' || (char)basilantus == 'o'
                )
            {   // Basılan tuşun harf aralığında olması kontrol edildi
                e.Handled = false;

                char karakter = (char)basilantus;
                //tus = Convert.ToChar(karakter.ToString().ToUpper());
                //fiziksel klavyeden girilen tuşun tekrar basılan harf olmaması kontrolü
                int status = 1;
                for (int i = 0; i < adam.girilenHarfler.Length; i++)
                    if (adam.girilenHarfler[i] == Convert.ToChar(karakter.ToString().ToUpper()))
                        status = 0;

                if (status == 1)
                    adam.kontrol(Convert.ToChar(karakter.ToString().ToUpper()));

            }
        }

        private void lblAnaForm_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }
    }
}



