using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
  public class Customer:Person
    {
        private string gender;
        private int age;

        public Customer(int id,string name,Phone phone,Address address,string gender, int age):base(id,name,phone,address)
        {
            Gender = gender;
            Age = age;
        }

        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
    }
}
