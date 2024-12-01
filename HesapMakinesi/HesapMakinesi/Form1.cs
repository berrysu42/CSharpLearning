using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
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

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            string secim = comboBox1.SelectedItem.ToString();

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        MessageBox.Show("Bölme işlemi için ikinci sayı sıfır olamaz!");
                        return;
                    }
                    break;
                default:
                    MessageBox.Show("Geçerli bir işlem seçiniz!");
                    return;
            }
            lblSonuc.Text =sonuc.ToString();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
