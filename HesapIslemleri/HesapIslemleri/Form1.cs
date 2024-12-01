using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alan, cevre, kenar;
            kenar = Convert.ToInt32(textBox1.Text);

            alan = kenar * kenar;
            cevre = kenar*4;

            textBox1.Text = kenar.ToString();
            textBox2.Text =alan.ToString();
            textBox3.Text=cevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan, cevre;
            kenar1 = Convert.ToInt32(textBox6.Text);
            kenar2 = Convert.ToInt32(textBox5.Text);
            cevre = (kenar1 + kenar2)*2;
            alan=(kenar2 *kenar1);

            textBox6.Text = kenar1.ToString();
            textBox5.Text = kenar2.ToString();
            textBox4.Text = alan.ToString();
            textBox10.Text = cevre.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r, pi , cevre, alan;
            r = Convert.ToInt32(textBox9.Text);
            pi = Convert.ToInt32(textBox8.Text);

            alan = pi * r * r;
            cevre = 2*pi * r;

            textBox9.Text = r.ToString();
            textBox8.Text = pi.ToString();
            textBox7.Text = alan.ToString();
            textBox11.Text = cevre.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
