using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class Circle
    {
        protected double r;
        public Circle(double _r)
        {
            this.r = _r;
        }
        public virtual double AlanHesap()
        {
            return Math.PI * r * r;
        }
    }
    class Cyclinder:Circle
    {
        protected double h;
        public Cyclinder(double _r, double _h) : base(_r)
        {
            this.h = _h;
        }
        public override double AlanHesap()
        {
            return base.AlanHesap()*h;
        }
    }
    class Parcel:Cyclinder
    {
        public Parcel(double _r, double _h) : base(_r, _h)
        {
            
        }
        public override double AlanHesap()
        {
            return base.AlanHesap()/3;
        }
    }
}
