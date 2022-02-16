using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2
{
    class Personel
    {
        public int PerId { get; set; }
        public string PerName { get; set; }
        public decimal Salary { get; set; }

        public Personel(int id, string ad, decimal maas)
        {
            PerId = id;
            PerName = ad;
            Salary = maas;
            Console.WriteLine(PerName);

        }
        //yukarıdaki ctor ile parametreli soyut sınıf var edilebiliyor. yani new edilebiliyor. yani katalogda duran sınıfı seçip imşa ediyorum
        public Personel()
        {

        }
        //yukarıdaki parametre ile parametresiz soyut sınıf var edebilirim proplarını tanımlamak zorundayım
    }
}
