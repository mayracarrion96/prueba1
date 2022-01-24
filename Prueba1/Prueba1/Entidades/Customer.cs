using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public Boolean activebool { get; set; }
        public DateTime createDate { get; set; }
        public DateTime lastUpdate { get; set; }
        public Boolean active { get; set; }

        public int storeId { get; set; }

        public Address Address { get; set; }
        public int addressId { get; set; }

        public List<Payment> Payment { get; set; }
    }
}
