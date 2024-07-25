using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboListPictureKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "İzmir de yaşamış";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Kastamonu da yaşamış";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bilgisayar Programcılığı");
            comboBox1.Items.Add("Havacılık Bölümü");
            comboBox1.Items.Add("Görsel Bölüm");
     
            

            
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            lbSepet.Items.Add(tbSepeteEkle.Text);
        }
    }
}
