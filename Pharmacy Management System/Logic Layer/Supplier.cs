using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
    public class Supplier:Person
    {
        public Supplier()
        {
        }
        public Supplier(int id, string name, Phone phone, Address address):base(id,name,phone,address)
        {

        }
    }
}
