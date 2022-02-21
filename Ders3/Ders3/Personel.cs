using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Personel Sınıfı Oluştu");
        }

    }
    class Mudur : Personel
    {
        public Mudur()
        {
            Console.WriteLine("Müdür Sınıfı Oluştu...");
        }
    }
}
