namespace Sinif_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Motor mtr = new Motor();
            Araba rb = new Araba();

            mtr.HIZ = -100;
            mtr.model = "Nemesis";

            label1.Text= mtr.HIZ.ToString();
            label2.Text = mtr.model;

            rb.HIZ = -98;
            rb.YIL = -2009;
            label3.Text = rb.HIZ.ToString();
            label4.Text = rb.YIL.ToString();
        }
    }
}