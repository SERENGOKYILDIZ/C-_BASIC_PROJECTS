namespace String_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyad, yas, meslek, cinsiyet;
            ad = textBox1.Text;
            soyad=textBox2.Text;
            yas=maskedTextBox1.Text;
            cinsiyet = comboBox1.Text;
            meslek = textBox3.Text;
            listBox1.Items.Add(ad + " " + soyad + " " + yas + " " + cinsiyet + " " + meslek);
        }
    }
}