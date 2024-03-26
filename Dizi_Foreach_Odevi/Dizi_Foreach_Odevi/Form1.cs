namespace Dizi_Foreach_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 12, 16, 98, 40, 80, 98, 13, 65, 87, 45 };
            int sayac=0, toplam=0;

            foreach(int i in sayilar) 
            {
                if(i%4==0)
                {
                    listBox1.Items.Add(i);
                    sayac++;
                    toplam += i;
                }
            }
            label1.Text = sayac.ToString();
            label2.Text = toplam.ToString();
        }
    }
}