using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
   public class Pack
    {
        private int id;
        private string name;
        private double packPerUnitPrice;
        private int size;

        public Pack(int id, string name, double packPerUnitPrice, int size)
        {
            Id = id;
            Name = name;
            PackPerUnitPrice = packPerUnitPrice;
            Size = size;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double PackPerUnitPrice { get => packPerUnitPrice; set => packPerUnitPrice = value; }
        public int Size { get => size; set => size = value; }
    }
}
