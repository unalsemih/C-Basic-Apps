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

namespace Sayı_Bulma_Oyunu
{
    public partial class FormSkor : Form
    {
        public FormSkor()
        {
            InitializeComponent();
        }

        private void FormSkor_Load(object sender, EventArgs e)
        {
            string satir="";
            string[] row;
            FileStream fileStream = new FileStream("skor.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);
            while((satir=sr.ReadLine())!=null)
            {
                ListViewItem item = new ListViewItem(satir.Split('|')[0]);
                item.SubItems.Add(satir.Split('|')[1]);


                listView1.Items.Add(item);
            }

            sr.Close();
            fileStream.Close();
        }
    }
}
