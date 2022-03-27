using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
  public class Person
    {
        private int id;
        private string name;
        private Phone phone;
        private Address address;

        public Person()
        {
        }

        public Person(int id, string name, Phone phone, Address address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Address = address;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Phone Phone { get => phone; set => phone = value; }
        public Address Address { get => address; set => address = value; }
    }
}
