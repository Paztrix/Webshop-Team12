using Microsoft.VisualStudio.TestTools.UnitTesting;
using Webshop.Model;
using System;

namespace Webshop_ModelTest {
    [TestClass]
    public sealed class Test1 {
        [TestMethod]
        public void CartConstructerTest() {
            var customer = new Customer(1, "Alice", "123456", "alice@example.com", "Street 1", 10);
            var product = new Product(1, "Widget", "A nice widget", 9.99, "In Stock", "/img/widget.png", "Tools", 5);

            var cart = new Cart(1, customer, product, product.Name);

            Assert.AreEqual(1, cart.PK_CardID);
            Assert.AreEqual(customer.PK_CustomerID, cart.FK1_CustomerID);
            Assert.AreEqual(product.PK_ProductID, cart.FK2_ProductID);
            Assert.AreEqual(product.Name, cart.ProductName);
        }

        [TestMethod]
        public void CustomerConstructerTest() {
            var customer = new Customer(1, "Alice", "123456", "alice@example.com", "Street 1", 10);

            Assert.AreEqual(1, customer.PK_CustomerID);
            Assert.AreEqual("Alice", customer.Name);
            Assert.AreEqual("123456", customer.Phone);
            Assert.AreEqual("alice@example.com", customer.Email);
            Assert.AreEqual("Street 1", customer.Address);
            Assert.AreEqual(10, customer.EarnedPoints);
        }

        [TestMethod]
        public void OrderConstructerTest() {
            var customer = new Customer(1, "Alice", "123456", "alice@example.com", "Street 1", 10);
            var orderPlaceholder = new Order(999, null, customer, null, "Processing", new DateOnly(2025, 1, 1));
            var payment = new Payment(5, customer, orderPlaceholder, "Credit Card");
            var point = new Point(10, orderPlaceholder, payment, 0.1, 50);
            var order = new Order(100, point, customer, payment, "Processing", new DateOnly(2025, 8, 20));

            Assert.AreEqual(100, order.PK_OrderID);
            Assert.AreEqual(point.PK_PointID, order.FK1_PointID);
            Assert.AreEqual(customer.PK_CustomerID, order.FK2_CustomerID);
            Assert.AreEqual(payment.PK_PaymentID, order.FK3_PaymentID);
            Assert.AreEqual("Processing", order.OrderStatus);
            Assert.AreEqual(new DateOnly(2025, 8, 20), order.DeliveryDate);
        }

        [TestMethod]
        public void PaymentConstructerTest() {
            var customer = new Customer(1, "Alice", "123456", "alice@example.com", "Street 1", 10);
            var orderPlaceholder = new Order(999, null, customer, null, "Pending", new DateOnly(2025, 1, 1));
            var payment = new Payment(5, customer, orderPlaceholder, "Credit Card");

            Assert.AreEqual(5, payment.PK_PaymentID);
            Assert.AreEqual(customer.PK_CustomerID, payment.FK1_CustomerID);
            Assert.AreEqual(orderPlaceholder.PK_OrderID, payment.FK2_OrderID);
            Assert.AreEqual("Credit Card", payment.PaymentMethod);
        }

        [TestMethod]
        public void PointConstructerTest() {
            var customer = new Customer(1, "Alice", "123456", "alice@example.com", "Street 1", 10);
            var orderPlaceholder = new Order(999, null, customer, null, "Pending", new DateOnly(2025, 1, 1));
            var payment = new Payment(5, customer, orderPlaceholder, "Credit Card");
            var point = new Point(10, orderPlaceholder, payment, 0.1, 50);

            Assert.AreEqual(10, point.PK_PointID);
            Assert.AreEqual(orderPlaceholder.PK_OrderID, point.FK1_OrderID);
            Assert.AreEqual(payment.PK_PaymentID, point.FK2_PaymentID);
            Assert.AreEqual(0.1, point.Discount);
            Assert.AreEqual(50, point.Earning);
        }

        [TestMethod]
        public void ProductConstructerTest() {
            var product = new Product(1, "Widget", "A nice widget", 9.99, "In Stock", "/img/widget.png", "Tools", 5);

            Assert.AreEqual(1, product.PK_ProductID);
            Assert.AreEqual("Widget", product.Name);
            Assert.AreEqual("A nice widget", product.Description);
            Assert.AreEqual(9.99, product.Price);
            Assert.AreEqual("In Stock", product.StockStatus);
            Assert.AreEqual("/img/widget.png", product.ImagePath);
            Assert.AreEqual("Tools", product.Category);
            Assert.AreEqual(5, product.PointValue);
        }
    }
}
