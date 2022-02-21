using System;

namespace Encapsülation
{
    class Program
    {
        //Id, Ad, OkulNo ve HarcUcreti alanlarından oluşan Ogrenci adlı bir sınıfın; HarcUcreti alanı kapsüllenip, birisi nesneye değer atamasını kontrol eden
        //SetHarcUcreti metodu, diğeri de atanan değeri geriye döndüren GetHarcUcreti metodlarıyla kapsülleme uygulaması şu şekilde yapılır:
        static void Main(string[] args)
        {
            double value;
            Console.WriteLine("Harç Ücreti Giriniz: ");
            value = Convert.ToInt32(Console.ReadLine());
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 1;
            ogrenci.Ad="Abdullah Usame Gündeşli";
            ogrenci.OkulNo = "1281";
            ogrenci.SetHarcUcreti(value);
            Console.WriteLine(ogrenci.Id);
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.OkulNo);
            Console.WriteLine(ogrenci.GetHarcUcreti());
        }
    }
    class Ogrenci
    {
        public int Id;
        public string Ad;
        public string OkulNo;
        private double HarcUcreti;//Harc Ücreti Alanını Kapsülleyeceğim
        public void SetHarcUcreti(double value)
        {
            if (value>0)//Set metoduyla verilen değerin uygun olması durumunda HarcUcreti alanına atama yapılır
            {
                HarcUcreti = value;
            }
            else
            {
                Console.WriteLine("Girilen Tutar Geçersiz...");
            }
            
        }
        public double GetHarcUcreti()
        {
            return HarcUcreti;
        }
    }
}
