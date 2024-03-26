namespace Ucak_Rez_Paneli_Kodsuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gecici = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = gecici;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTA: " +textBox1.Text+" --> "+textBox2.Text+" ,Tarih: "+dateTimePicker1.Text+" ,Saat: "+maskedTextBox1.Text+" ;Yolcu Adı: "+textBox3.Text+" ,TC:"+maskedTextBox2.Text+" ,Tel no:"+maskedTextBox3.Text);
            MessageBox.Show("Başarılıyla kaydınız alındı.");
        }
    }
}