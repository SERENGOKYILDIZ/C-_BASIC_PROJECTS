using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Odevi
{
    internal class Araba : Motor
    {
        public string model;
        private int yil;
        public char durum;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
    }
}
