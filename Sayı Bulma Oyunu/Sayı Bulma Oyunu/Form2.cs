using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Bulma_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public String isim;
        public Boolean tekrarsiz;
        public int sayi = 0;
        public int[] basamaklar = new int[5];
        public Oyun oyun;
        public int puan;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void txt_CharControl(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)//ASCII Tablosu girilen karakterin rakam olduğunu kontrol ettim
                e.Handled = false; // Girilen karakter rakamsa yazdıracaktır.
            else
                e.Handled = true;
        }
        
     
        public void cevapla(DialogResult answer)
        {
            if (answer == DialogResult.Yes)
            {
                button1.PerformClick();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            oyun.sureDurumu(lblSure);
        }

       
       
        private void Form2_Load(object sender, EventArgs e)
        {

            String alt = "1", ust = "9";
         //   MessageBox.Show("hak satisi:" + oyun.HakSayisi);
            lblKalanHak.Text = oyun.HakSayisi.ToString();

            for (int i = 1; i < oyun.BasamakSayisi; i++)
            {

                alt += "0";
                ust += "9";
            }
            Random rnd = new Random();
            sayi = rnd.Next(int.Parse(alt), int.Parse(ust));
            
      
            while (tekrarsiz == true && oyun.tekrarKontrol(sayi) == 0)
            {
                sayi = rnd.Next(int.Parse(alt), int.Parse(ust));//sayı tekrarlı olduğu müddetçe tekrar sayı üretiliyor.

            }
            oyun.Sayi = sayi;
            puan = oyun.BasamakSayisi * 20 / oyun.HakSayisi;
            oyun.hazirlik();//textBox ları aktif hale getirme vs.
            //MessageBox.Show("Üretilen Sayi : " + oyun.Sayi);//ÜRETİLEN SAYI BURADA
            
            timer1.Enabled = true;
        }
        
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            oyun.kontrolEt(timer1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
