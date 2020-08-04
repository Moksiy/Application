using Application.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL
{
    public class WebInitializer : DropCreateDatabaseAlways<WebContext>
    {
        protected override void Seed(WebContext context)
        {
            var customers = new List<Customer>
                {
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f0"), Name = "Customer1", Code="1111-2001", Address = "Address1", Discount = 0.1 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f1"), Name = "Customer2", Code="1112-2011", Address = "Address2", Discount = 0.2 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f2"), Name = "Customer3", Code="1113-2012", Address = "Address3", Discount = 0.3 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f3"), Name = "Customer4", Code="1114-2013", Address = "Address4", Discount = 0.4 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f4"), Name = "Customer5", Code="1115-2014", Address = "Address5", Discount = 0.5 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f5"), Name = "Customer6", Code="1116-2015", Address = "Address6", Discount = 0.6 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f6"), Name = "Customer7", Code="1117-2005", Address = "Address7", Discount = 0.7 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f7"), Name = "Customer8", Code="1118-2008", Address = "Address8", Discount = 0.8 },
                new Customer {ID = new Guid("0d57629c7d6e484797cb9e2fc25083f8"), Name = "Customer9", Code="1119-2009", Address = "Address9", Discount = null }
                };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
                {
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b0"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f0"), OrderDate = DateTime.Parse("2003-09-01"), ShipmentDate = DateTime.Parse("2003-09-03"), OrderNumber=1, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b1"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f0"), OrderDate = DateTime.Parse("2003-09-02"), ShipmentDate = DateTime.Parse("2003-09-03"), OrderNumber=2, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b2"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f1"), OrderDate = DateTime.Parse("2003-09-03"), ShipmentDate = DateTime.Parse("2003-09-04"), OrderNumber=3, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b3"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f2"), OrderDate = DateTime.Parse("2003-09-04"), ShipmentDate = DateTime.Parse("2003-09-07"), OrderNumber=4, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b4"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f3"), OrderDate = DateTime.Parse("2003-09-04"), ShipmentDate = DateTime.Parse("2003-09-09"), OrderNumber=5, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b5"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f4"), OrderDate = DateTime.Parse("2003-09-04"), ShipmentDate = DateTime.Parse("2003-09-09"), OrderNumber=6, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b6"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f5"), OrderDate = DateTime.Parse("2003-09-05"), ShipmentDate = DateTime.Parse("2003-09-09"), OrderNumber=7, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b7"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f6"), OrderDate = DateTime.Parse("2003-09-06"), ShipmentDate = DateTime.Parse("2003-09-09"), OrderNumber=8, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b8"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f7"), OrderDate = DateTime.Parse("2003-09-07"), ShipmentDate = DateTime.Parse("2003-09-12"), OrderNumber=9, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25083b9"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f8"), OrderDate = DateTime.Parse("2003-09-07"), ShipmentDate = DateTime.Parse("2003-09-11"), OrderNumber=10, Status="доставлено"},
                new Order {ID = new Guid("0d57629c7d6e484797cb9e2fc25013b9"), CustomerID = new Guid("0d57629c7d6e484797cb9e2fc25083f8"), OrderDate = DateTime.Parse("2003-09-07"), ShipmentDate = DateTime.Parse("2003-09-11"), OrderNumber=10, Status="доставлено"}
                };

            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

            var orderElements = new List<OrderElement>
                {
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a0"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b0"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c0"),ItemPrice = 1200, ItemsCount = 2},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a1"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b0"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c1"),ItemPrice = 100, ItemsCount = 21},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a2"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b0"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c2"),ItemPrice = 100, ItemsCount = 12},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a3"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b1"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c3"),ItemPrice = 100, ItemsCount = 23},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a4"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b2"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c4"),ItemPrice = 1300, ItemsCount = 2},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a5"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b3"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c5"),ItemPrice = 600, ItemsCount = 12},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a6"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b4"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c6"),ItemPrice = 300, ItemsCount = 42},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a7"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b4"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c7"),ItemPrice = 100, ItemsCount = 82},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a8"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b5"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c8"),ItemPrice = 10, ItemsCount = 22},
                new OrderElement { ID = new Guid("0d57629c7d6e484797cb9e2fc25083a9"),OrderID = new Guid("0d57629c7d6e484797cb9e2fc25083b5"), ItemID = new Guid("0d57629c7d6e484797cb9e2fc25083c9"),ItemPrice = 1, ItemsCount = 2000}
                };
            orderElements.ForEach(s => context.OrderElements.Add(s));
            context.SaveChanges();

            var products = new List<Product>
                {
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c0"), Name = "Product0", Price = 11, Category = "Category1",Code = "11-2222-AA33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c1"), Name = "Product1", Price = 12, Category = "Category1",Code = "11-2222-BB33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c2"), Name = "Product2", Price = 13, Category = "Category1",Code = "11-2222-CC33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c3"), Name = "Product3", Price = 14, Category = "Category1",Code = "11-2222-DD33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c4"), Name = "Product4", Price = 15, Category = "Category2",Code = "11-2222-EE33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c5"), Name = "Product5", Price = 16, Category = "Category2",Code = "11-2222-FF33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c6"), Name = "Product6", Price = 17, Category = "Category2",Code = "11-2222-GG33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c7"), Name = "Product7", Price = 18, Category = "Category2",Code = "11-2222-HH33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c8"), Name = "Product8", Price = 19, Category = "Category3",Code = "11-2222-II33"},
                new Product {ID = new Guid("0d57629c7d6e484797cb9e2fc25083c9"), Name = "Product9", Price = 20, Category = "Category3",Code = "11-2222-GG33"}
                };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
