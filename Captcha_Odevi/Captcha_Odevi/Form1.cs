using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] karakterler_k = { 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] karakterler_b = { 'A', 'B', 'C', 'D', 'E', 'F' };
            char[] karakterler_say = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] karakterler_oze = { '#', '!', '^', '+', '%', '&', '/', '?'};
            Random rn = new Random();
            label1.Text = karakterler_b[rn.Next(1, 5)].ToString() + karakterler_say[rn.Next(1, 10)].ToString() + karakterler_k[rn.Next(1, 5)].ToString() + karakterler_oze[rn.Next(1, 8)].ToString() + karakterler_say[rn.Next(1, 10)].ToString() + karakterler_say[rn.Next(1, 10)].ToString();
        }
    }
}
