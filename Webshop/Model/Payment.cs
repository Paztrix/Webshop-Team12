using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Payment 
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
