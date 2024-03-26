namespace Dort_Islem_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, top, cik, carp, bol;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            top = sayi1 + sayi2;
            cik = sayi1 - sayi2;
            carp = sayi1 * sayi2;
            bol = sayi1 / sayi2;
            MessageBox.Show("TOPLAM: " + top + "\n" + "FARK: " + cik + "\n" + "ÇARPIM: " + carp + "\n" + "BÖLÜM: " + bol);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}