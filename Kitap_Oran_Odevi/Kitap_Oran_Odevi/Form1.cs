using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_Oran_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz Bölgesi", 4);
            chart1.Series["Kitap"].Points.AddXY("Karadeniz Bölgesi", 3);
            chart1.Series["Kitap"].Points.AddXY("Ege Bölgesi", 4);
            chart1.Series["Kitap"].Points.AddXY("Marmara Bölgesi", 10);
            chart1.Series["Kitap"].Points.AddXY("Doğu Anadolu Bölgesi", 1);
            chart1.Series["Kitap"].Points.AddXY("Güney Anadolu Bölgesi", 3);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu Bölgesi", 3);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulamayı Eren yaptı.","YAPIMCI",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
