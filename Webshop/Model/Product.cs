using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Product {
        public int PK_ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string StockStatus { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public int PointValue { get; set; }

        public Product(int pkProductId, string name, string description, double price, string stockStatus, string imagePath, string category, int pointValue) {
            PK_ProductID = pkProductId;
            Name = name;
            Description = description;
            Price = price;
            StockStatus = stockStatus;
            ImagePath = imagePath;
            Category = category;
            PointValue = pointValue;
        }
    }
}
