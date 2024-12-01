using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kaydet butonuna basınca label6 daki değeri text box a atadık. Yani textboxa isim girip kaydete basınca label6 ya textbox1'deki değer atandı.
            label6.Text = textBox1.Text;
            lblTel.Text = textBox2.Text;
            
            textBoxCity.Text = comboBox1.Text+"/"+ comboBox2.Text;
            lblAdress.Text = textBoxAdres.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add("İstanbul");
            comboBox2.Items.Add("Ankara");
            comboBox2.Items.Add("Konya");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı kapatır

            }
        }
    }
}
