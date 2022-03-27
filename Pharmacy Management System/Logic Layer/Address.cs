using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
  public class Address
    {
        private string street;
        private string city;
        private string province;

        public Address(string street, string city, string province)
        {
            Street = street;
            City = city;
            Province = province;
        }

        public override string ToString()
        {
            return (street + " " +  city + " " + province);
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
    }
}
