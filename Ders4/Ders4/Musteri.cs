using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4
{
    class Musteri
    {
        public int MusId { get; set; }
        public string MusAdi { get; set; }
        public override string ToString()
        {
            return MusAdi + " " + MusId;
        }
    }
}
