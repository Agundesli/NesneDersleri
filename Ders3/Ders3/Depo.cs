using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class Depo
    {
        private string[] _store = new string[10];

        public string this[int indis]//this gördüğümüz zaman indexleyici'dir yani classı kastetiyor aslında
        {
            get { return _store[indis]; }
            set { _store[indis] = value; }
        }
    }
}
