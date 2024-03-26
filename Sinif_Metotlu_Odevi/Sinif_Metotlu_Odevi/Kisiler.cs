using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Metotlu_Odevi
{
    internal class Kisiler
    {
        public void KisiYaz(string ad)
        {
            Console.WriteLine("Adı: " + ad);
        }
        public int topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int fark(int s1,int s2)
        {
            return s1 - s2;
        }
        public int carp(int s1,int s2)
        {
            return s1 * s2;
        }
        public double bol(int s1,int s2)
        {
            return Convert.ToDouble(s1/s2);
        }
    }
}
