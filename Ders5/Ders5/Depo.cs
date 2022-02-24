using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ders5
{
    class Depo : IEnumerable
    {
        string[] _urunler = { "Urun-1, Urun-2, Urun-3, Urun-4 " };
        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
}
