namespace Dongu_TrafikLambasi_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac<=30)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
            }
            if (sayac > 30 && sayac <= 40)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.Yellow;
                panel3.BackColor = Color.White;
            }
            if (sayac > 40 && sayac <= 70)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.Green;
            }
            if (sayac > 70)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
                sayac = 0;
            }
        }
    }
}