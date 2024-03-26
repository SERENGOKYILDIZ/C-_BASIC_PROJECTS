using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Metotlu_Odevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();
            ks.KisiYaz("Eren");
            Console.WriteLine("İki adet sayı giriniz: ");
            int a = Convert.ToInt32(Console.Read());
            int b = Convert.ToInt32(Console.Read());

            Console.WriteLine("Toplam = " + ks.topla(a, b));
            Console.WriteLine("Çıkart = " + ks.fark(a, b));
            Console.WriteLine("Çarp   = " + ks.carp(a, b));
            Console.WriteLine("Bölüm  = " + ks.bol(a, b));
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
