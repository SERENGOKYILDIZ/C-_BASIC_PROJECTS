namespace Integer_Odevi
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
            kisa = 10;
            uzun = 20;
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            label1.Text = "Alan: " + alan + " Cevre: " + cevre;
            int not1, not2, not3, ort;
            not1 = 45;
            not2 = 79;
            not3 = 92;
            ort = (not1 + not2 + not3) / 3;
            label2.Text = "Ortalama= " + ort;
        }
    }
}