using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Gecis_Odevi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string mesaj;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.sayim = Convert.ToInt32(textBox2.Text);
            fr1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = mesaj;
        }
    }
}
