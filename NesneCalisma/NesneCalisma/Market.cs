using System;
using System.Collections.Generic;
using System.Text;

namespace NesneCalisma
{
    class Market<T> where T : Urun
    {
        List<T> urunler = new List<T>();
        public void UrunEkle(T t)
        {
            urunler.Add(t);
        }

        public List<T> TumUrunler()
        {
            return urunler;
        }
        public List<IKirilabilir> kirikUrunler()
        {
            List<IKirilabilir> _urunler = new List<IKirilabilir>();
            foreach (var item in urunler)
            {
                if (item is IKirilabilir && ((IKirilabilir)item).Kirik==true)
                {
                        _urunler.Add((IKirilabilir)item);
                }
            }
            return _urunler;
        }
        public List<IBozulabilir> bozukUurunler()
        {
            List<IBozulabilir> _urunler = new List<IBozulabilir>();
            foreach (var item in urunler)
            {
                var urun = item as IBozulabilir;
                if (urun != null && urun.SKT < DateTime.Now)
                {
                    _urunler.Add(urun);
                }
            }
            return _urunler;
        }
    }
}
