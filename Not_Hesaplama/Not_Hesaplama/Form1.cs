namespace Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyad;
            int vize, final;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            vize = Convert.ToInt16(textBox3.Text);
            final = Convert.ToInt16(textBox4.Text);
            ortalama = Convert.ToDouble(vize * 0.4 + final * 0.6);
            listBox1.Items.Add(ad + " " + soyad + " Ortalama: " + ortalama.ToString("0.00"));
            MessageBox.Show("Ortalamanız: " + ortalama.ToString("0.00") + "\nBaşarıyla eklendi.");
        }
    }
}