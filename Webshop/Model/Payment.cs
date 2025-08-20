using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Payment {
        public int PK_PaymentID { get; set; }
        public int FK1_CustomerID { get; set; }
        public int FK2_OrderID { get; set; }
        public string PaymentMethod { get; set; }

        public Payment(int pkPaymentId, Customer customer, Order order, string paymentMethod) {
            PK_PaymentID = pkPaymentId;
            FK1_CustomerID = customer?.PK_CustomerID ?? 0;
            FK2_OrderID = order?.PK_OrderID ?? 0;
            PaymentMethod = paymentMethod;
        }
    }
}
