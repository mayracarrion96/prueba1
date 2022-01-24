using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string district { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public DateTime lastUpdate { get; set; }

        public int cityId { get; set; }
        public List<Customer> Customer { get; set; }

    }
}
