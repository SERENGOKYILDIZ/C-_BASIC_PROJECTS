using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Constructor_Odevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik eren = new Kimlik("Semi Eren","Gökyıldız",-21);
            eren.bilgileriYaz();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Adı: " + eren.AD);
            Console.WriteLine("Soyadı: " + eren.SOYAD);
            Console.WriteLine("Yaşı: " + eren.Yas);
            Console.WriteLine("Mesleği: " + eren.meslek);
            Console.WriteLine("-----------------------");
            eren.meslek = "Mekatronik Mühendisliği";
            Console.WriteLine("Mesleği: " + eren.meslek);
            Console.WriteLine("-----------------------");
            eren.bilgileriYaz();
            Console.WriteLine("-----------------------");
            Console.Read();
        }
    }
}
