using System;
using System.Collections;

namespace Ders5._4
{
    public enum Siralama { IDyeGore=1, AdaGore=2, FiyataGore=3}
    class Karsilastir:IComparer
    {
        public Siralama Sirala { get; set; }

        public int Compare(object x, object y)
        {
            Urun u1 = (Urun)x;
            Urun u2 = (Urun)y;
            if (Sirala == Siralama.IDyeGore)
            {
                return u1.UrunId.CompareTo(u2.UrunId);
            }
            else if (Sirala == Siralama.AdaGore)
            {
                return u1.UrunAdi.CompareTo(u2.UrunAdi);
            }
            else
            {
                return u1.Fiyat.CompareTo(u2.Fiyat);
            }
        }
    }
    class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return UrunId + " " + UrunAdi + " " + Fiyat; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                new Urun{ UrunId=24, UrunAdi="Kalem", Fiyat=20},
                new Urun{ UrunId=12, UrunAdi="Defter", Fiyat=35},
                new Urun{ UrunId=35, UrunAdi="Silgi", Fiyat=10}
            };
            Karsilastir karsilastir = new Karsilastir();
            karsilastir.Sirala = Siralama.IDyeGore;
            list.Sort(karsilastir);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            karsilastir.Sirala= Siralama.FiyataGore;
            list.Sort(karsilastir);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
