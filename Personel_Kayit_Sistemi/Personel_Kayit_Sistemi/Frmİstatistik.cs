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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERENPC\\SQLEXPRESS;Initial Catalog=Personel_Odevi;Integrated Security=True");
        private void İstatistikForm_Load(object sender, EventArgs e)
        {
            //// TOPLAM PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblPer.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //// EVLİ PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) From Tbl_Personel where Perdurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvli.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //// BEKAR PERSONEL SAYISI
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) From Tbl_Personel where Perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekar.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //// ŞEHİR SAYISI
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //// TOPLAM MAAŞ SAYISI
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblTaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //// ORTALAMA MAAŞ SAYISI
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
