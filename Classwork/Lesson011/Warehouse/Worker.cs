using System;
using System.Collections.Generic;

namespace Lesson011.Warehouse
{
    public class Worker
    {
        private string _signature;

        public string Name { get; private set; }

        public Worker(string name, string signature)
        {
            Name = name;
            _signature = signature;
        }

        public void PutReleaseSignature(Waybill waybill)
        {
            waybill.SignatureFrom = _signature;
        }

        public void PutEnterSignature(Waybill waybill)
        {
            waybill.SignatureTo = _signature;
        }


        public Waybill CreateWaybill(uint id, Worker to, Dictionary<Product, uint> products)
        {
            return new Waybill(id, this, to, products);
        }
    }
}
