using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Fragman_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kolpaçinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "KOLPAÇİNO";
            webBrowser1.Navigate("google.com.tr");
        }

        private void pardonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "PARDON";
            webBrowser1.Navigate("https://www.youtube.com/watch?v=kggn0jLsIvA&ab_channel=PLATO");
        }

        private void çALIŞTIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapımcı Erendir.","YaPıMcI",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
