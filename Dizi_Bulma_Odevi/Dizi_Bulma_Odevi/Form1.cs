namespace Dizi_Bulma_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 12, 98, 45, 32, 78, 20, 10, 78, 11, 13 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>10 && sayilar[i]%2==0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}