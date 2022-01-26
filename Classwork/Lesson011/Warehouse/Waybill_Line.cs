using System;

namespace Lesson011.Warehouse
{
    public class Waybill_Line
    {
        private uint _id;

        public Product Product { get; private set; }
        public uint Count { get; private set; }

        public Waybill_Line(uint id, Product product, uint count)
        {
            _id = id;
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            return $"{_id,-5}{"|",-5}{Product.Name,-5}{"|",-5}{Count,-5}{"|",-5}{Product.Price,-5}{"|",-5}{GetSum(),-5}";
        }

        private uint GetSum()
        {
            return Product.Price * Count;
        }
    }
}
