using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kaydir;
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btn_p = new Point();

            btn_p.X = 30 + kaydir;
            btn_p.Y = 30;
            btn.Location = btn_p;
            
            btn.Name = "button1";
            btn.Text = "TIKLA";
            btn.BackColor = Color.White;
            btn.Height = 50;
            btn.Width = 75;

            TextBox tb = new TextBox();
            Point tb_p = new Point();

            tb_p.X = 30 + kaydir;
            tb_p.Y = 100;
            tb.Location = tb_p;

            tb.Name = "textbox1";
            tb.Text = "YAZI";
            tb.BackColor = Color.White;
            tb.Height = 50;
            tb.Width = 75;

            TextBox tb2 = new TextBox();
            Point tb2_p = new Point();

            tb2_p.X = 30 + kaydir;
            tb2_p.Y = 150;
            tb2.Location = tb2_p;

            tb2.Name = "textbox2";
            tb2.Text = "DENEME";
            tb2.BackColor = Color.White;
            tb2.Height = 50;
            tb2.Width = 75;

            TextBox tb3 = new TextBox();
            Point tb3_p = new Point();

            tb3_p.X = 30 + kaydir;
            tb3_p.Y = 300;
            tb3.Location = tb3_p;

            tb3.Name = "textbox3";
            tb3.Text = "EREN";
            tb3.BackColor = Color.White;
            tb3.Height = 50;
            tb3.Width = 75;

            this.Controls.Add(btn);
            this.Controls.Add(tb);
            this.Controls.Add(tb2);
            this.Controls.Add(tb3);
            kaydir += 100;
        }
    }
}
