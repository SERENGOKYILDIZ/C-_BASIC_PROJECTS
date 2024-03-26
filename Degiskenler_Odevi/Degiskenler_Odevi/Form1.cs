namespace Degiskenler_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;
            kisa = Convert.ToInt16(textBox1.Text);
            uzun= Convert.ToInt16(textBox2.Text);
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            label3.Text = "Alan: " + alan;
            label4.Text = "Çevre: " + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r;
            double alan, cevre;
            r = Convert.ToInt16(textBox3.Text);
            alan = 3.14*r*r;
            cevre= 2*3.14*r;
            label6.Text = "Alan: " + alan.ToString("0.00");
            label5.Text = "Çevre: " + cevre.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int not1, not2, not3;
            double ort;
            not1 = Convert.ToInt16(textBox4.Text);
            not2 = Convert.ToInt16(textBox5.Text);
            not3 = Convert.ToInt16(textBox6.Text);
            ort = (not1 + not2 + not3) / 3;
            label11.Text = "Ortalama: " + ort.ToString("0.00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            double top, cik, car, bol;
            sayi1 = Convert.ToInt16(textBox9.Text);
            sayi2 = Convert.ToInt16(textBox8.Text);
            sayi3 = Convert.ToInt16(textBox7.Text);
            top = sayi1 + sayi2 + sayi3;
            cik = sayi1 - sayi2 - sayi3;
            car = sayi1 * sayi2 * sayi3;
            bol = sayi1 / sayi2 / sayi3;
            label12.Text = "Toplam: " + top.ToString("0.00");
            label16.Text = "Fark:   " + cik.ToString("0.00");
            label17.Text = "Çarpım: " + car.ToString("0.00");
            label18.Text = "Bölüm:  " + bol.ToString("0.00");
        }
    }
}