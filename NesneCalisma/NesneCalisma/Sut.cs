using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    class Sut : Urun, IBozulabilir
    {
        public DateTime SKT { get; set; }
        public string Tipi { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"{SKT} {Tipi} ";
        }
    }
}
