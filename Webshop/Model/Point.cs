using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Point
    {
        public int PointId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public float Discount { get; set; }
        public int Earning { get; set; }

    }
}
