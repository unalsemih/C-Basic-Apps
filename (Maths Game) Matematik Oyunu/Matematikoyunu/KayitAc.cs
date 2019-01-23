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

namespace Matematikoyunu
{
    public partial class KayitAc : Form
    {
        public KayitAc()
        {
            InitializeComponent();
        }
        public Form1 form1;

        List<string> kayitlar = new List<string>();
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            User user = new User(form1, Blok.blok1);
            Sonuc.form1 = form1;
            user.KayitAc(kayitlar[listView1.Items.IndexOf(listView1.SelectedItems[0])]);
            form1.Show();
            this.Hide();
        }

        private void KayitAc_Load(object sender, EventArgs e)
        {
            string dosya_yolu = "skor.txt";
            if (File.Exists(dosya_yolu) == true) // dizindeki dosya var mı ?
            {

                FileStream fileStream = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fileStream);
                string satir;
                string[] bilgiler;
                string[] item = new string[10];
                while ((satir = sr.ReadLine()) != null)
                {
                    kayitlar.Add(satir);
                    bilgiler = satir.Split('|');
                    item[0] = bilgiler[0];
                    item[1] = bilgiler.Length.ToString();
                    ListViewItem itm = new ListViewItem(item);
                    listView1.Items.Add(itm);

                }
                sr.Close();
                fileStream.Close();

            }
            else
                MessageBox.Show("Hiçbir kayıt bulunamadi.");
        }

    }
}

