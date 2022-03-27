using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
   public class Drugs
    {
        private int id;
        List<Brand> brands;
        private string formula;
        private Pack pack;
        DrugType drugTypes;
        public Drugs(int id, List<Brand> brands,DrugType drugType, string formula, Pack pack)
        {
            Id = id;
            Brands = brands;
            DrugTypes = drugType;
            Formula = formula;
            Pack = pack;
        }

        public int Id { get => id; set => id = value; }
        public List<Brand> Brands { get => brands; set => brands = value; }
        public string Formula { get => formula; set => formula = value; }
        public Pack Pack { get => pack; set => pack = value; }
        public DrugType DrugTypes { get => drugTypes; set => drugTypes = value; }

        public enum DrugType
        {
            Syrup,
            Tablet,
            Capsule,
            Drop,
            Injection
        }

    }
}
