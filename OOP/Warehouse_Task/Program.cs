using System;
using System.Collections.Generic;

namespace Warehouse_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var warehouse = new Warehouse();

            var storekeeper = new Worker("Evgeny", "qwerty");
            var driver = new Worker("Andrew", "228");

            warehouse.Storekeeper = storekeeper;

            var apple = new Product("Apple", 10);
            var milk = new Product("Milk", 15);


            // Test receiving products

            Dictionary<Product, uint> products = new Dictionary<Product, uint>
            {
                { apple, 10 },
                { milk, 50 },
            };

            var waybill = new Waybill(1, driver, storekeeper);
            waybill.AddPosition(apple, 10);
            waybill.AddPosition(milk, 60);

            driver.PutReleaseSignature(waybill);

            warehouse.TryReceiveProducts(products, waybill);
            Console.WriteLine(waybill.ToString());


            // Test releasing products

            Dictionary<Product, uint> productsForRelease = new Dictionary<Product, uint>
            {
                { apple, 20 },
                { milk, 30 },
            };

            warehouse.TryReleaseProducts(productsForRelease, driver);

            Console.ReadKey();
        }
    }
}
