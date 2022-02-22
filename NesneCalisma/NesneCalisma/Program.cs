using System;
using System.Collections.Generic;

namespace NesneCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Market<Urun> market = new Market<Urun>();
            market.UrunEkle(new Bulgur { Id = 23,UrunAdi = " Pilavlık", Fiyat = 10, TETT = DateTime.Parse("25.02.2022")});
            market.UrunEkle(new Bardak { Id = 44, UrunAdi = "Altılı su bardağı", Fiyat = 35, Kirik = true });
            market.UrunEkle(new Bardak { Id = 24, UrunAdi = "Altılı çay bardağı", Fiyat = 30, Kirik = false });
            market.UrunEkle(new KagitHavlu { Id = 15, UrunAdi = "4'lü kağıt havlu", Fiyat = 45 });
            market.UrunEkle(new Sut { Id = 55, UrunAdi = "1 Litre Süt", Tipi = "Keçi", Fiyat = 15, SKT = DateTime.Parse("18/02/2022") });
            market.UrunEkle(new Yumurta { Id = 51, UrunAdi = "30'lu yumurta", Fiyat = 40, Kirik = false, SKT = DateTime.Parse("19/02/2022")});
            market.UrunEkle(new Yumurta { Id = 61, UrunAdi = "15'li Yumurta", Fiyat = 20, Kirik = false, SKT = DateTime.Parse("28/02/2022") });

            //Urun Listele
            Console.WriteLine("Tüm");
            foreach (var item in market.TumUrunler())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Kırıklar");
            //Kırık Uurunler
            foreach (var item in market.kirikUrunler())
            {
                Console.WriteLine(item);
            }
            //Bozuk Urunler
            Console.WriteLine();
            Console.WriteLine("Bozuklar");
            foreach (var item in market.bozukUurunler())
            {
                Console.WriteLine(item);
            }
        }
    }
}
