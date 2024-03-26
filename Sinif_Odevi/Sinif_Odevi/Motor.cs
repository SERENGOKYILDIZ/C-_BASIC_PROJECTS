using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Odevi
{
    internal class Motor
    {
        public string model;
        private int hiz;

        public int HIZ
        {
            get { return hiz; }
            set { hiz = Math.Abs(value); }
        }
    }
}
