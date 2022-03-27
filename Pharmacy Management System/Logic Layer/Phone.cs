using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Layer
{
  public  class Phone
    {
        private string countryCode;
        private string teleCompany;
        private NumberType numberTypes;

        public Phone(string countryCode, string teleCompany, NumberType numberTypes)
        {
            CountryCode = countryCode;
            TeleCompany = teleCompany;
            NumberTypes = numberTypes;
        }

        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string TeleCompany { get => teleCompany; set => teleCompany = value; }
        private NumberType NumberTypes { get => numberTypes; set => numberTypes = value; }

       public enum NumberType
        {
            MobileNO,
            PTCL
        }
    }
}
