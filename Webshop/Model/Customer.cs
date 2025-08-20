using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Customer {
        public int PK_CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int EarnedPoints { get; set; }

        public Customer(int pkCustomerId, string name, string phone, string email, string address, int earnedPoints) {
            PK_CustomerID = pkCustomerId;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            EarnedPoints = earnedPoints;
        }
    }
}
