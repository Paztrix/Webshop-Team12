using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model {
    public class Product 
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? StockStatus { get; set; }
        public string? ImagePath { get; set; }
        public string? Category { get; set; }
        public int PointValue { get; set; }
    }
}
