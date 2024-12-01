using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaDunyaOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Biz butona basdığımızda bize bir mesaj göstermesini istiyoruz
            //MessageBox.Show("Merhaba Dünya");
            MessageBox.Show("C# dilinde bugün ilk dersimizde Merhaba Dünya adlı metni yazdırdık!");
        }
    }
}
