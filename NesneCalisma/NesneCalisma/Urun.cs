using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    abstract class Urun
    {

        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $"{Id} {UrunAdi} {Fiyat} ";
        }

    }
}
