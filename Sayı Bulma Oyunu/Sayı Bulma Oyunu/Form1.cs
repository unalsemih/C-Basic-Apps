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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        int uzunluk = 0, hakSayisi = 0, basamakSayisi = 0;

        private void lblSkorListesi_Click(object sender, EventArgs e)
        {
            FormSkor formSkor = new FormSkor();
           
           formSkor.Show();

        }

        private void btnOyunaBasla(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int basamakSayisi = (int)numBasamakSayisi.Value;
            Oyun oyn = new Oyun(form2,0,(int)numHakSayisi.Value,basamakSayisi);
            form2.isim = txtIsim.Text;
            form2.oyun = oyn;
            form2.tekrarsiz = checkBox1.Checked;
            this.Hide();
            
            form2.Show();
        }

        
    }
}
    
