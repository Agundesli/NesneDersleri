using Ders5;
using System;
using System.Collections;
using System.Threading;


namespace Ders5
{
    interface IArayuz
    {
        void IslemA();
    }
    class Deneme : IArayuz
    {
        public void IslemA()
        {
            
        }
        public void MethotA()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            IArayuz deneme2 = new Deneme();
            deneme.IslemA();
            deneme.MethotA();
            deneme2.IslemA();
            deneme2.MethotA();
        }
    }
}
