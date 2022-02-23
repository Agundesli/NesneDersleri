using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4
{
    class Personel
    {
        public int perıd { get; set; }
        public string peradi { get; set; }
        public override string ToString()
        {
            return perıd + " " + peradi;
        }
    }
}
