using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ders8
{
    public class Depo:IEnumerable
    {
        List<Product> _store;
        public Depo(int capasity)
        {
            _store = new List<Product>(capasity);
        }
        public event EventHandler StoreVacant;
        public event EventHandler StoreFull;

        public void Add(Product product)
        {
            if (_store.Count<_store.Capacity)
            {
                _store.Add(product);
            }
            else if(StoreFull!= null)
            {
                StoreFull(this, new EventArgs());
            }
        }
        public IEnumerator GetEnumerator()
        {
            return _store.GetEnumerator();
        }

        public void Release(Product product)
        {
            if (_store.Count>0)
            {
                _store.Remove(product);
            }
            else if (StoreVacant != null)
            {
                StoreVacant(this, new EventArgs());
            }
        }
    }
}
