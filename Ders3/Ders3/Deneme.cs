using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class Deneme
    {
       
    }
    class Daire
    {
        public double r  { get; set; }
        public double DaireAlan()
        {
            return Math.PI * r * r;
        }
    }
    class Silindir:Daire
    {
        public double h { get; set; }
        public double SilindirAlan()
        {
            return base.DaireAlan() * h;
        }
    }
    class Koni:Silindir
    {
        public double KoniAlan()
        {
            return (base.SilindirAlan()/3);
        }
    }
}
