﻿using System;
using System.Collections.Generic;

namespace Lesson011.Warehouse
{
    public class Warehouse
    {
        private uint _waybill_id = 1;
        private Dictionary<Product, uint> _assortment;
        private List<Waybill> _productsReleaseHistory;

        public Worker Storekeeper { get; set; }

        public Warehouse()
        {
            _assortment = new Dictionary<Product, uint>();
            _productsReleaseHistory = new List<Waybill>();
        }

        public void TryReceiveProducts(Dictionary<Product, uint> assortment, Waybill waybill)
        {
            if (Storekeeper is null)
            {
                Console.WriteLine("The storekeeper is absent from the workplace. " +
                    "Impossible to perform entry control.");
            }
            else
            {
                ExecuteEntryControl(assortment, waybill);
            }
        }

        public void TryReleaseProducts(Dictionary<Product, uint> productsList, Worker to)
        {
            if (Storekeeper is null)
            {
                Console.WriteLine("The storekeeper is absent from the workplace. " +
                    "Impossible to perform release of products.");
            }
            else
            {
                ExecuteReleaseProducts(productsList, to);
            }
        }

        private void ExecuteEntryControl(Dictionary<Product, uint> assortment, Waybill waybill)
        {
            for (int i = 0; i < waybill.GetSize(); i++)
            {
                Waybill_Line line = waybill.GetLine(i);

                if (assortment.ContainsKey(line.Product))
                {
                    uint enteredCount = Math.Min(line.Count, assortment[line.Product]);
                    UnloadProduct(line.Product, enteredCount);

                    string report = GetEntryControlLineReport(line, assortment[line.Product], enteredCount);
                    Console.WriteLine(report);

                }
            }

            Storekeeper.PutEnterSignature(waybill);
        }

        private void UnloadProduct(Product product, uint count)
        {
            if (_assortment.ContainsKey(product))
            {
                _assortment[product] += count;
            }
            else
            {
                _assortment.Add(product, count);
            }
        }

        private string GetEntryControlLineReport(Waybill_Line line, uint actualCount, uint enteredCount)
        {
            return $"Quantity of product {line.Product.Name} on the waybill: {line.Count}. " +
                $"Actual quantity: {actualCount}. Received in warehouse: {enteredCount} \n";
        }

        private void ExecuteReleaseProducts(Dictionary<Product, uint> productsList, Worker to)
        {
            var waybill = new Waybill(_waybill_id++, Storekeeper, to);

            foreach (KeyValuePair<Product, uint> product in productsList)
            {
                if (_assortment.ContainsKey(product.Key))
                {
                    uint count = Math.Min(_assortment[product.Key], product.Value);
                    waybill.AddPosition(product.Key, count);
                }
                else
                {
                    Console.WriteLine($"Out of stock {product.Key.Name}");
                }
            }

            Storekeeper.PutReleaseSignature(waybill);
            _productsReleaseHistory.Add(waybill);
        }
    }
}