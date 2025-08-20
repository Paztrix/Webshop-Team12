using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Point {
        public int PK_PointID { get; set; }
        public int FK1_OrderID { get; set; }
        public int FK2_PaymentID { get; set; }
        public double Discount { get; set; }
        public int Earning { get; set; }

        public Point(int pkPointId, Order order, Payment payment, double discount, int earning) { 
            PK_PointID = pkPointId;
            FK1_OrderID = order?.PK_OrderID ?? 0;
            FK2_PaymentID = payment?.PK_PaymentID ?? 0;
            Discount = discount;
            Earning = earning;
        }
    }
}
