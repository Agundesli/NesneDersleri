using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    class Bardak : Urun, IKirilabilir
    {
        public bool Kirik { get ; set ; }
        public override string ToString()
        {
           return base.ToString() + $"{Kirik} ";
        
    }
    }
}
