namespace Dongu_Faktoriyel_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc=1;
            sayi = Convert.ToInt32(textBox1.Text);
            for(int i=1;i<=sayi; i++)
            {
                sonuc *= i;
            }
            MessageBox.Show("Sonuc: " + sayi + "! = " + sonuc);
        }
    }
}