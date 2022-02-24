using System;
using System.Collections.Generic;
using System.Text;
using static Ders5.Interfaces;

namespace Ders5
{
    class Animals
    {
    }
    public class Hamsi : IYuzuebilir
    {
        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
    public class Kedi : IYuruyebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
    public class Penguen : IYuruyebilir, IYuzuebilir
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
    public class Kanarya : IUcabilir, IYuruyebilir
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
    public class Pelikan : IYuruyebilir, IYuzuebilir, IUcabilir
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
}
