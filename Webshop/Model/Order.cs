using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Order
    {
        public int OrderId { get; set; }
        public int PointId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }

        public string? OrderStatus { get; set; }
        public DateTime DeliveryDate { get; set; }

    }
}
