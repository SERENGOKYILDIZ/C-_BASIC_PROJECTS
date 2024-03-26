namespace Dongu_PastaPisirme_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int sira;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
                sira = 1;
            if (progressBar2.Value == 100)
                sira = 2;
            if (progressBar3.Value == 100)
            {
                timer1.Stop();
                sira = 3;
                MessageBox.Show("Pastanız hazır efendim :)");
            }
            switch (sira)
            {
                case 0:
                    progressBar1.Value += 10;
                    if (progressBar1.Value % 20 == 0)
                        label1.BackColor = Color.Red;
                    else
                        label1.BackColor = Color.White;
                    break;

                case 1:
                    progressBar2.Value += 20;
                    if (progressBar2.Value % 50 == 0)
                        label2.BackColor = Color.Red;
                    else
                        label2.BackColor = Color.White;
                    break;

                case 2:
                    progressBar3.Value += 5;
                    if (progressBar3.Value % 10 == 0)
                        label3.BackColor = Color.Red;
                    else
                        label3.BackColor = Color.White;
                    break;
            }
        }
    }
}