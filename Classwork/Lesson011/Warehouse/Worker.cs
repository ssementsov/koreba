using System;
using System.Collections.Generic;

namespace Lesson011.Warehouse
{
    public class Worker
    {
        public string Name { get; private set; }
        public string Signature { get; private set; }

        public Worker(string name, string signature)
        {
            Name = name;
            Signature = signature;
        }

        public void PutSignature(Waybill waybill)
        {

        }

        public Waybill CreateWaybill(uint id, Worker to, Dictionary<Product, uint> products)
        {
            return new Waybill(id, this, to, products);
        }
    }
}
