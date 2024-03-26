namespace Not_Hesaplama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, proje;
            double ort;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            proje = Convert.ToInt32(textBox3.Text);
            ort = (s1 + s2 + proje) / 3;
            if(ort>=50)
            {
                label4.Text = ort.ToString("0.00") + " / GEÇTİ";
            }
            else
            {
                label4.Text = ort.ToString("0.00") + " / KALDI";
            }
        }
    }
}