using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Cart {
        public int PK_CardID { get; set; }
        public int FK1_CustomerID { get; set; }
        public int FK2_ProductID { get; set; }
        public string ProductName { get; set; }

        public Cart(int pkCardId, Customer customer, Product product, string productName) {
            PK_CardID = pkCardId;
            FK1_CustomerID = customer.PK_CustomerID;
            FK2_ProductID = product.PK_ProductID;
            ProductName = productName;
        }
    }
}
