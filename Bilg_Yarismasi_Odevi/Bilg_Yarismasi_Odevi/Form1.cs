namespace Bilg_Yarismasi_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_no, dogru, yanlis;
        char dogru_cevap;
        char verilen_cevap;

        private void BtnB_Click(object sender, EventArgs e)
        {
            verilen_cevap = 'B';
            if (verilen_cevap == dogru_cevap)
            {
                dogru++;
                PicbDogru.Visible = true;
            }
            else
            {
                yanlis++;
                PicbYanlis.Visible = true;
            }
            LbDogru.Text = "Doğru Sayısı: " + dogru;
            LbYanlis.Text = "Yanlış Sayısı: " + yanlis;
            BtnSoru.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            verilen_cevap = 'C';
            if (verilen_cevap == dogru_cevap)
            {
                dogru++;
                PicbDogru.Visible = true;
            }
            else
            {
                yanlis++;
                PicbYanlis.Visible = true;
            }
            LbDogru.Text = "Doğru Sayısı: " + dogru;
            LbYanlis.Text = "Yanlış Sayısı: " + yanlis;
            BtnSoru.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            verilen_cevap = 'D';
            if (verilen_cevap == dogru_cevap)
            {
                dogru++;
                PicbDogru.Visible = true;
            }
            else
            {
                yanlis++;
                PicbYanlis.Visible = true;
            }
            LbDogru.Text = "Doğru Sayısı: " + dogru;
            LbYanlis.Text = "Yanlış Sayısı: " + yanlis;
            BtnSoru.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            verilen_cevap = 'A';
            if(verilen_cevap == dogru_cevap)
            {
                dogru++;
                PicbDogru.Visible = true;
            }
            else
            {
                yanlis++;
                PicbYanlis.Visible = true;
            }
            LbDogru.Text = "Doğru Sayısı: " + dogru;
            LbYanlis.Text = "Yanlış Sayısı: " + yanlis;
            BtnSoru.Enabled = true;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            soru_no++;
            BtnSoru.Enabled = false;
            PicbDogru.Visible = false;
            PicbYanlis.Visible = false;
            if (soru_no!=4)
            {
                BtnA.Enabled = true;
                BtnB.Enabled = true;
                BtnC.Enabled = true;
                BtnD.Enabled = true;
            }
            LbSoruno.Text = "Soru No: " + soru_no;
            if (soru_no == 1)
            {
                TxtSoru.Text = "İstanbul ne zaman fethedildi?";
                BtnA.Text = "1453";
                BtnB.Text = "1457";
                BtnC.Text = "1452";
                BtnD.Text = "1451";
                dogru_cevap = 'A';
                BtnSoru.Text = "SIRADAKİ SORU";
            }
            if (soru_no == 2)
            {
                TxtSoru.Text = "Ayasofya ne zaman ibadete açıldı?";
                BtnA.Text = "2022";
                BtnB.Text = "2021";
                BtnC.Text = "2020";
                BtnD.Text = "2019";
                dogru_cevap = 'C';
            }
            if (soru_no == 3)
            {
                TxtSoru.Text = "Türkiye Yüzyılı hangi yıldır?";
                BtnA.Text = "2023";
                BtnB.Text = "2057";
                BtnC.Text = "2015";
                BtnD.Text = "2123";
                dogru_cevap = 'A';
                BtnSoru.Text = "SONUÇLAR";
            }
            if (soru_no == 4)
            {
                TxtSoru.Text = "Tebrikler bilgi yarişmasını tamamladınız!";
                BtnA.Text = "Tebrikler";
                BtnB.Text = "Tebrikler!";
                BtnC.Text = "Tebrikler";
                BtnD.Text = "Tebrikler";
                MessageBox.Show("Tebrikler bilgi yarışmasını tamamladınız!\nCevaplarınız:\nDoğru: " + dogru + "\nYanlış: " + yanlis);
            }
        }
    }
}