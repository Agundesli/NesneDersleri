using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    class Bulgur : Urun, ITETT
    {
        public DateTime TETT { get ; set; }
        public override string ToString()
        {
            return base.ToString() + $"{TETT} ";
        
        }
    }
}
