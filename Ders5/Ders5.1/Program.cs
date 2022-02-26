using System;
using System.Collections;

namespace Ders5._1
{
    class Depo //: IEnumerable
    {
        string[] _urunler = { "Urun-1", "Urun-2", "Urun-3", "Urun-4" };
        //public IEnumerator GetEnumerator()
        //{
        //    return _urunler.GetEnumerator();
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            foreach (var item in depo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
