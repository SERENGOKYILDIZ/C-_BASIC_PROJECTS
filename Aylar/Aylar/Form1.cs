namespace Aylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay_no;
            ay_no = Convert.ToInt16(textBox1.Text);
            switch(ay_no)
            {
                case 1:label1.Text = "Ocak";break;
                case 2: label1.Text = "Şubat"; break;
                case 3: label1.Text = "Mart"; break;
                case 4: label1.Text = "Nisan"; break;
                case 5: label1.Text = "Mayıs"; break;
                case 6: label1.Text = "Haziran"; break;
                case 7: label1.Text = "Temmuz"; break;
                case 8: label1.Text = "Ağustos"; break;
                case 9: label1.Text = "Eylül"; break;
                case 10: label1.Text = "Ekim"; break;
                case 11: label1.Text = "Kasım"; break;
                case 12: label1.Text = "Aralık"; break;
                default: label1.Text = "Hatalı ay no"; break;
            }
        }
    }
}