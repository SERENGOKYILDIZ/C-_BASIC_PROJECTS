namespace Kitapci_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap_say;
            double tutar;
            kitap_say = Convert.ToInt16(textBox1.Text);
            if (kitap_say > 0 && kitap_say <= 20)
            {
                tutar = (kitap_say * 8) * 0.8;
                label2.Text = "TOPLAM: " + tutar + " TL";
            }
            else if (kitap_say > 20 && kitap_say <= 40)
            {
                tutar = (kitap_say * 8) * 0.6;
                label2.Text = "TOPLAM: " + tutar + " TL";
            }
            else if (kitap_say > 40)
            {
                tutar = (kitap_say * 8) * 0.5;
                label2.Text = "TOPLAM: " + tutar + " TL";
            }
        }
    }
}