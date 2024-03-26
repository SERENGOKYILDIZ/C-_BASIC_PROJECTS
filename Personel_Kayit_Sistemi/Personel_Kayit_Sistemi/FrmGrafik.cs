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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ERENPC\\SQLEXPRESS;Initial Catalog=Personel_Odevi;Integrated Security=True");
        private void GrafikFrm_Load(object sender, EventArgs e)
        {
            /// 1.Grafik
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,count(*) From Tbl_Personel Group by PerSehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();

            /// 2.Grafik
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select Permeslek,avg(permaas) From Tbl_Personel Group by Permeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();
        }
    }
}
