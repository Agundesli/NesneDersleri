using System;

namespace Ders2
{
    class Personel
    {
        public int PerId { get; set; }
        public string PerAdi { get; set; }
        public decimal Maas { get; set; }

        public Personel(int id, string ad, decimal maas)
        {
            PerId = id;
            PerAdi = ad;
            Maas = maas;
            Console.WriteLine(PerAdi);
  
        }
        public Personel()
        {
            Console.WriteLine("Nesne Oluşturuldu...");
        }
        ~Personel()
        {
            Console.WriteLine("Nesne Silindi");
        }
    }
    class Musteri
    {

        public int MusID { get; set; }
        public string MusAdi { get; set; }
        public decimal Cari { get; set; }
    }
    class Arac
    {
        public string Plaka { get; set; }

        public Arac(string plaka)
        {
            Plaka = plaka;
        }
    }
    class Customer
    {
        public int MusId { get; set; }
        public string MusAdi { get; set; }
        public string Adress { get; set; }


        //public Customer(string ad, string adres)
        //{
        //    MusAdi = ad;
        //    Adress = adres;
        //}

        public Customer(string ad, string adres):this(1,ad,adres)
        {
           
        }


        public Customer(int id, string ad,string adres)
        {
            MusId = id;
            MusAdi = ad;
            Adress = adres;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Personel p = new Personel();
            //p.PerId = 1;
            //p.PerAdi = "Uğur";
            //p.Maas = 123;
            ////parametresiz çalıştı

            //Personel p2 = new Personel(12, "Okan", 123);
            //parametreli çalıştı

            //Personel personel = new Personel()
            //{
            //    PerId = 2,
            //    PerAdi = "Usame",
            //    Maas = 4555
            //};
            //parametresiz çalıştı

            //Personel personel1 = new Personel();
            //parametreli çalıştı


            Musteri m = new Musteri { MusID = 23, MusAdi = "Uğur", Cari = 123 }; //.object inisilation
            Musteri musteri = new Musteri();

            Arac arac = new Arac("12sa12");
            //Arac arac1 = new Arac();

        }
    }
}
