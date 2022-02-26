using System;
using System.Collections;

namespace Ders5._2
{
    class Urun:IComparable
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return UrunId.CompareTo(urun.UrunId);//Bu tanımlama ile urunlerimin heap'de kaydedilen referanslarını aldım.
        }
        public override string ToString()
        {
            return UrunId + " " + UrunAdi + " " + Fiyat;//Bu şekilde override ile string ifadeyi ezerek yazmak istediğim düzni getirtiyorum
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList()
            {
                45,12,33,36,75
            };
            list1.Sort();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            ArrayList list2 = new ArrayList()
            {
                "Zonguldak","Ankara","Niğde","Adana"
            };
            list2.Sort();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            ArrayList list3 = new ArrayList()
            {
                new Urun{ UrunId=24, UrunAdi="Kalem", Fiyat=20},
                new Urun{ UrunId=12, UrunAdi="Defter", Fiyat=25},
                new Urun{ UrunId=45, UrunAdi="Silgi", Fiyat=10}
            };
            list3.Sort();//Sort metodu ile sıralama yapabilmesi için class içerisinde ICompareble interface'i implemente edilmelidir.
            foreach (var item in list3)
            {
                Console.WriteLine("Data: "+item);
            }
        }
    }
}
