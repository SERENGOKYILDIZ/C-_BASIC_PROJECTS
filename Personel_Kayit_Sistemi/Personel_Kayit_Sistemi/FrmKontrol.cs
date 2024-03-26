using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit_Sistemi
{
    public partial class FrmKontrol : Form
    {
        public FrmKontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERENPC\\SQLEXPRESS;Initial Catalog=Personel_Odevi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_OdeviDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek, PerCinsiyet) values (@a,@b,@c,@d,@e,@f,@g)", baglanti);
            komut.Parameters.AddWithValue("@a", TxtAd.Text);
            komut.Parameters.AddWithValue("@b", TxtSoyad.Text);

            komut.Parameters.AddWithValue("@c", CombSehir.Text);
            komut.Parameters.AddWithValue("@d", MTxtMaas.Text);

            /// Radio Button 1.Yol
            /*
            if(RadBtnBekar.Checked)
                komut.Parameters.AddWithValue("@e", "false");
            if(RadBtnEvli.Checked)
                komut.Parameters.AddWithValue("@e", "true");
            */
            /// Radio Button 2.Yol
            ///Radiolara label9 yazısı yadırma
            komut.Parameters.AddWithValue("@e", label9.Text);
            ///
            komut.Parameters.AddWithValue("@f", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@g", CombCinsiyet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi.");
        }

        private void RadBtnEvli_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "true";
        }

        private void RadBtnBekar_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "false";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CombCinsiyet.Text = "";
            MTxtMaas.Text = "";
            CombSehir.Text = "";
            TxtMeslek.Text = "";
            RadBtnEvli.Checked = false;
            RadBtnBekar.Checked = false;
            TxtAd.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            CombCinsiyet.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            MTxtMaas.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            CombSehir.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            label9.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(label9.Text=="True")
            {
                RadBtnEvli.Checked = true;
            }
            if(label9.Text=="False")
            {
                RadBtnBekar.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ID: " + TxtId.Text + " olan personel başarıyla silinmiştir.");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Update Tbl_Personel Set Perad=@a1, Persoyad=@a2, Persehir=@a3, Permaas=@a4, Perdurum=@a5, Permeslek=@a6, Percinsiyet=@a7 where perid=@a8", baglanti);
            komutsil.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutsil.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutsil.Parameters.AddWithValue("@a3", CombSehir.Text);
            komutsil.Parameters.AddWithValue("@a4", MTxtMaas.Text);
            komutsil.Parameters.AddWithValue("@a5", label9.Text);
            komutsil.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutsil.Parameters.AddWithValue("@a7", CombCinsiyet.Text);
            komutsil.Parameters.AddWithValue("@a8", TxtId.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ID: " + TxtId.Text + " olan personel başarıyla güncellenmiştir.");
        }

        private void BtnIstatisik_Click(object sender, EventArgs e)
        {
            Frmİstatistik isform = new Frmİstatistik();
            isform.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafik gf = new FrmGrafik();
            gf.Show();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            FrmRapor frmRapor= new FrmRapor();
            frmRapor.Show();
        }
    }
}
