namespace Maskedtextbox_Picturebox_Datetimepicker_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+" "+ textBox2.Text+" "+maskedTextBox1.Text+" "+maskedTextBox2.Text + " " + comboBox1.Text+" "+dateTimePicker1.Text);
        }
    }
}