using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
    public class Employee : Person
    {

        private double salary;
        EmployeeType employeeTypes;

        public Employee()
        {
        }

        public Employee(int id,string name,Phone phone,Address address,double salary, EmployeeType employeeTypes):base(id,name,phone,address)
        {
            Salary = salary;
            EmployeeTypes = employeeTypes;
        }

        public double Salary { get => salary; set => salary = value; }
        public EmployeeType EmployeeTypes { get => employeeTypes; set => employeeTypes = value; }

        public enum EmployeeType
        {
            Helper,
            SalePerson
        }
    }
}
