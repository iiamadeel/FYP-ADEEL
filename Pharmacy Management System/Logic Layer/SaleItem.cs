using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
    public class SaleItem
    {
        private int id;
        private int quantity;
        Pack pack;
        Drugs drugs;

        public SaleItem(int id, int quantity, Pack pack, Drugs drugs)
        {
            Id = id;
            Quantity = quantity;
            Pack = pack;
            Drugs = drugs;
        }

        public int Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Pack Pack { get => pack; set => pack = value; }
        public Drugs Drugs { get => drugs; set => drugs = value; }
    }
}
