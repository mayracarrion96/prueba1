using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Payment
    {
        public int paymentId { get; set; }
        public float amount { get; set; }
        public DateTime paymentDate { get; set; }

       
        public int stafftId { get; set; }
        public int rentalId { get; set; }

        public Customer Customer { get; set; }
        public int customerId { get; set; }
    }
}
