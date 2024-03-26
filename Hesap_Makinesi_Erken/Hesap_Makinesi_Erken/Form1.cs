namespace Hesap_Makinesi_Erken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2;
            char islem;
            double sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            islem = Convert.ToChar(textBox3.Text);
            switch(islem)
            {
                case '+': sonuc = Convert.ToDouble(s1 + s2); MessageBox.Show("İşlem sonucu = " + sonuc);  break;
                case '-': sonuc = Convert.ToDouble(s1 - s2); MessageBox.Show("İşlem sonucu = " + sonuc);  break;
                case '*': sonuc = Convert.ToDouble(s1 * s2); MessageBox.Show("İşlem sonucu = " + sonuc);  break;
                case '/': sonuc = Convert.ToDouble(s1 / s2); MessageBox.Show("İşlem sonucu = " + sonuc);  break;
                case '%': sonuc = Convert.ToDouble(s1 % s2); MessageBox.Show("İşlem sonucu = " + sonuc);  break;
                default: MessageBox.Show("Hatalı işlem sembolü"); break;
            }
        }
    }
}