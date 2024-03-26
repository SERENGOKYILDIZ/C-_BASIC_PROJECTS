namespace Sinema_Bufe_Uygulamasi_Kodsuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa, toplam;

        private void button2_Click(object sender, EventArgs e)
        {
            kasa = 0;
            toplam = 0;
            TxtCay.Text = "";
            TxtSu.Text = "";
            TxtMisir.Text = "";
            TxtBilet.Text = "";
            LbToplam.Text = "TOPLAM: 0 TL";
            LbKasa.Text = "KASA: 0 TL";

            TxtCay.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cay, su, misir, bilet;
            cay = Convert.ToInt16(TxtCay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = cay * 5 + su * 2 + misir * 10 + bilet * 30;
            kasa += toplam;
            LbToplam.Text = "TOPLAM: " + toplam.ToString() + " TL";
            LbKasa.Text = "KASA: " + kasa.ToString() + " TL";
            Kayit.Items.Add("Alım => Cay: " + cay * 5 + " TL ,Su: " + su * 2 + " TL ,Mısır: " + misir * 10 + " TL ,Bilet:" + bilet * 30 + " TL, TOPLAM = " + toplam + " TL");
        }
    }
}