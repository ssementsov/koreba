namespace FarPrototype.WindowStructures
{
    internal class Column
    {
        private List<Row> _rows;

        public Column()
        {
            _rows = new List<Row>();
        }

        public void AddRow(Row row)
        {
            _rows.Add(row);
        }
    }
}
