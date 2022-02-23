using System;
using System.Collections.Generic;
using System.Text;

namespace Ders8
{
    class Events
    {
        //1) Temsilciye ihtiuaç var. Bizde yazabiliriz var olan temsilciyide kullanabiliriz.
        //2) İlgili temsilciden event tanımlanır.
        //3) Olayı tetikleyecek mekanizma kurulur.
        //4) Class oluşturulur
        //5) Olaya bir metot bağlanır. Nasıl?
        //6) Çalıştır.
        delegate void Temsil();
    }
    class Buton
    {
        public event Temsil Tikla;

        public void Calistir()
        {
            if (Tikla!=null)
            {
                Tikla();
            }
        }

    }
}
