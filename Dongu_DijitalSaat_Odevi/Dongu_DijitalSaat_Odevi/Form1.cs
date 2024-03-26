namespace Dongu_DijitalSaat_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int saniye, dakika, saat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            LbSaniye.Text = saniye.ToString("00");
            if(saniye==60)
            {
                saniye = 0;
                dakika++;
                LbDakika.Text = dakika.ToString("00");
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
                LbSaat.Text = saat.ToString("00");
            }
        }
    }
}