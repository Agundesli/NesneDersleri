using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2
{
    class Try
    {
        const double pi = 3.1415;
        readonly double katsayi = 1.5;


        public Try()
        {
            pi = 2.5;
            katsayi = 1.1;
        }

        public void Islem()
        {
            katsayi=5.6; //Burada metotda değiştirmeme izin vermiyor.
        }

        //6-readonly => değiştirebilirim o da ctor tek değiştirilecek yer ctordur
        //7-const => asla değiştiremem
    }
}
