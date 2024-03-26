using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Constructor_Odevi
{
    class Kimlik
    {
        private string ad;
        private string soyad;
        private int yas;
        public string meslek;
        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper();}
        }
        public int Yas
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public Kimlik(string a, string b, int c) 
        {
            AD = a;
            SOYAD = b;
            Yas = c;
            meslek = "İşsiz";
            Console.WriteLine("Kişi başarıyla oluşturuldu !");
        }
        public void bilgileriYaz()
        {
            Console.WriteLine("Adı: " + this.AD);
            Console.WriteLine("Soyadı: " + this.SOYAD);
            Console.WriteLine("Yaşı: " + this.Yas);
            Console.WriteLine("Mesleği: " + this.meslek);
        }
    }
}
