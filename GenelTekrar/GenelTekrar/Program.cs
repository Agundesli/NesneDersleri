using System;

namespace GenelTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            IKirilabilir kirilabilir = new Bardak();
        }
    }
    class Bardak : Urunler,IBardak,IKirilabilir
    {
        
    }
    public interface IBardak
    {

    }
    class Sut:Urunler,ISut,IBozulabilir,ISKTarih
    {

    }
    public interface ISut
    {

    }
    class Yogurt : Urunler,IYogurt,ISKTarih,IBozulabilir
    {

    }
    public interface IYogurt
    {

    }
    class KHavlu : Urunler,IKHavlu
    {

    }
    public interface IKHavlu
    {

    }
    class Yumurta : Urunler,IYumurta,IBozulabilir,IKirilabilir,ISKTarih
    {

    }
    public interface IYumurta
    {

    }
}

