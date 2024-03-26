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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int sayim;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.mesaj = textBox1.Text;
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = sayim.ToString();
        }
    }
}
