using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    abstract class Urunler:IEnumerable,IUrunler
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public double Fiyat { get; set; }
        public void Add()
        {
            Console.WriteLine("Urun Eklendi...");
        }
            
        public IEnumerator GetEnumerator()
        {

        }

        public void Listele()
        {
            throw new NotImplementedException();
        }
    }
}
