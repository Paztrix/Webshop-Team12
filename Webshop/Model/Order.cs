using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Order {
        public int PK_OrderID { get; set; }
        public int FK1_PointID { get; set; }
        public int FK2_CustomerID { get; set; }
        public int FK3_PaymentID { get; set; }
        public string OrderStatus { get; set; }
        public DateOnly DeliveryDate { get; set; }

        public Order(int pkOrderId, Point point, Customer customer, Payment payment, string orderStatus, DateOnly deliveryDate) {
            PK_OrderID = pkOrderId;
            FK1_PointID = point?.PK_PointID ?? 0;
            FK2_CustomerID = customer?.PK_CustomerID ?? 0;
            FK3_PaymentID = payment?.PK_PaymentID ?? 0;
            OrderStatus = orderStatus;
            DeliveryDate = deliveryDate;
        }
    }
}
