using System;
using System.Collections;

namespace Ders5._6
{
    interface IYuzebilir
    {
        void Yuz();
    }

    interface IYuruyebilir
    {
        void Yuru();
    }

    interface IUcabilir
    {
        void Uc();
    }
    class Penguen : IYuruyebilir, IYuzebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Pelikan : IYuzebilir, IYuruyebilir, IUcabilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Hamsi : IYuzebilir
    {
        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Kedi : IYuruyebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
    class Kanarya : IUcabilir, IYuruyebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Penguen());
            list.Add(new Pelikan());
            list.Add(new Hamsi());
            list.Add(new Kedi());
            list.Add(new Kanarya());
            foreach (var item in list)
            {
                if (item is IYuzebilir)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("---------------------------------------------");
            foreach (var item in list)
            {
                if (item is IUcabilir)
                {
                    Console.WriteLine(item.GetType());
                }
            }
        }
    }
}
