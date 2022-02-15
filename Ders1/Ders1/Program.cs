using System;

namespace Ders1
{ //property dediğim şey zaten bir metot
    //property kendi üzerine değer tutmaz bir değişkne ihtiyacı var
    //property aracıdır.Kullanıcıyı kıstlar. encapsilation ile sadece o işlemi yapmaya iter
    //yani kullanıcı o işi yapacaksa o property kullanır. property bir metot ile kullanır. bir metot vasıtası ile
    //en capsülation prop saklıyor.
    class Personel
    {
        private int id;

        public int GetId() //metot geriye döndürecek mi?, değer alacak mı?
        {
            return id;//Retun birden fazla değer döndürebilir.
        }
        public void SetId(int _id)
        {
            id = _id;
        }
        //özelllik
        string _perad;
        public string PerAd
        {
            get { return _perad; }
            set { _perad = value; }
        }
        //c# 3.0 sonrası
        public decimal Maas { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Class-members
            //1-variable
            //2-methods
            //3-property
            Personel personel = new Personel();
           //personel.id = 10;
        }
    }
}
