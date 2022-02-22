using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    class Yumurta : Urun, IKirilabilir, IBozulabilir
    {
        public bool Kirik { get; set; }
        public DateTime SKT { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"{Kirik} {SKT}";
        }
    }
}

