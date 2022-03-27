using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
    public class Stock
    {
        private int invoiceNumber;
        List<Supplier> suppliers;
        List<Drugs> drugs;

        public Stock(int invoiceNumber, List<Supplier> suppliers, List<Drugs> drugs)
        {
            InvoiceNumber = invoiceNumber;
            Suppliers = suppliers;
            Drugs = drugs;
        }

        public int InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }
        public List<Supplier> Suppliers { get => suppliers; set => suppliers = value; }
        public List<Drugs> Drugs { get => drugs; set => drugs = value; }
    }
}
