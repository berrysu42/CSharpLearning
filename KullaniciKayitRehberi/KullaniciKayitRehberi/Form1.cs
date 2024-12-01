using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciKayitRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Merhaba Dünya";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C# dili derslerine hoşgeldiniz ...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TextBox özelliklerini ayarla
            textBox1.Multiline = true; // Çok satırlı mod
            textBox1.WordWrap = true; // Satır sonu taşmasını otomatik yap
            textBox1.ScrollBars = ScrollBars.Vertical; // Dikey kaydırma çubuğu


            textBox1.Text = "Mesajım dünyaya! Ayağını sıcak tut, başını serin. \n" +
                "Çok düşünme derin derin. ALLAH KERİM!";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            //button4.Text = label3.Text;    bu satıra gerek yok tek başına üsteki yeter!

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
