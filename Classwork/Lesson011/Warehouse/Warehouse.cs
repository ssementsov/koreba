using System;
using System.Collections.Generic;

namespace Lesson011.Warehouse
{
    public class Warehouse
    {
        private uint _waybill_id = 1;

        private Dictionary<Product, uint> _productsRange;
        private List<Waybill> _waybills;

        public Warehouse()
        {
            _productsRange = new Dictionary<Product, uint>();
            _waybills = new List<Waybill>();
        }

        public Worker Storekeeper { get; set; }

        public void TryReceiveProducts(Dictionary<Product, uint> products, Waybill waybill)
        {
            if (Storekeeper is null)
            {
                Console.WriteLine("The storekeeper is absent from the workplace. " +
                    "Impossible to perform entry control.");
            }
            else
            {

            }
        }

        private void ExecuteEntryControl()
        {

        }
    }
}
