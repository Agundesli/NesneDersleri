using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class Soldier
    {
        public int SicilNo { get; set; }
        public string Task { get; set; }
        protected void Islem()
        {

        }
    }
    class Er : Soldier
    {
        public Er()
        {

        }
    }
}
