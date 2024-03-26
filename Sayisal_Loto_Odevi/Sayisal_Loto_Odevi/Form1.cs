using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisal_Loto_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1, say2, say3, say4;
            Random rn = new Random();

            say1 = rn.Next(1, 10);
            say2 = rn.Next(1, 10);
            say3 = rn.Next(1, 10);
            say4 = rn.Next(1, 10);

            textBox1.Text = say1.ToString();
            textBox2.Text = say2.ToString();
            textBox3.Text = say3.ToString();
            textBox4.Text = say4.ToString();

            if(textBox1.Text== textBox8.Text)
            {
                textBox1.BackColor = Color.Green;
                textBox1.ForeColor= Color.White;
            }
            else
            {
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
            }

            if (textBox2.Text == textBox7.Text)
            {
                textBox2.BackColor = Color.Green;
                textBox2.ForeColor = Color.White;
            }
            else
            {
                textBox2.BackColor = Color.White;
                textBox2.ForeColor = Color.Black;
            }

            if (textBox3.Text == textBox6.Text)
            {
                textBox3.BackColor = Color.Green;
                textBox3.ForeColor = Color.White;
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox3.ForeColor = Color.Black;
            }

            if (textBox4.Text == textBox5.Text)
            {
                textBox4.BackColor = Color.Green;
                textBox4.ForeColor = Color.White;
            }
            else
            {
                textBox4.BackColor = Color.White;
                textBox4.ForeColor = Color.Black;
            }

        }
    }
}
