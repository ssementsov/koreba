namespace FarPrototype.Visualizers.BodyTypes.Columns
{
    internal abstract class Column
    {
        public string Title { get; protected set; }
        public int Width { get; init; }
        public Column(int width)
        {
            if (width <= 0)
            {
                throw new ArgumentException("Column with should be positive.");
            }

            Width = width;
        }

        public abstract void Format(ref string value);
    }
}
