using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
    public class Sale
    {
        private int id;
        Customer customers;
        Employee employee;
        List<SaleItem> saleItems;

        public Sale(int saleID, Customer customer1, Employee employee, List<SaleItem> saleItems)
        {
            SaleID = saleID;
            Customers = customers;
            Employee = employee;
            SaleItems = saleItems;
        }

        public int SaleID { get => id; set => id = value; }
        public Customer Customers { get => customers; set => customers = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public List<SaleItem> SaleItems { get => saleItems; set => saleItems = value; }
    }
}
