using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3
{
    class _Say
    {
        static int sayac = 0;
        public _Say()
        {
            sayac++;
            Console.WriteLine(sayac);
        }

        ~_Say()
        {
            sayac--;
            Console.WriteLine(sayac);
        }
    }
}

