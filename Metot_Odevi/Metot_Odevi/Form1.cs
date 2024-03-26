namespace Metot_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Yazi_Yazdir()
        {
            textBox1.Text = "Eren";
            textBox2.Text = "Eren";
            textBox3.Text = "Eren";
            textBox4.Text = "Eren";
        }
        private void Yazi_Sil()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();
        }
        private int Carpmak(int x, int y, int z)
        {
            return x * y * z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Yazi_Yazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yazi_Sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            s1 = Convert.ToInt32(textBox5.Text);
            s2 = Convert.ToInt32(textBox6.Text);
            s3 = Convert.ToInt32(textBox7.Text);
            label1.Text = Carpmak(s1,s2,s3).ToString();
        }
    }
}