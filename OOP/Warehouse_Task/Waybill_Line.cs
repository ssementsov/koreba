namespace Warehouse_Task
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
            string line = $"\n{string.Empty, -3}{_id}{string.Empty, -3}{"|", -3}{Product.Name, -60}{"|",-5}{Count,-5}{"|",-5}{Product.Price,-5}{"|",-5}{GetSum(),-5}\n";
            return line;
        }

        private uint GetSum()
        {
            return Product.Price * Count;
        }
    }
}
