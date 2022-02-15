using System;
using System.Collections.Generic;
using System.Text;

namespace Ders2
{
    class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }

        public Employees(string name, string address):this(1,name,address)//this ile yaparsak içeriği yazmamıza gerek kalmaz.
        {

        }

        public Employees(int id, string name, string address)
        {
            EmpId = id;
            EmpName = name;
            Address = address;
        }
    }
}
