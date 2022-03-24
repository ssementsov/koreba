namespace FarPrototype.Visualizers.BodyTypes.Columns
{
    internal class NameColumn : Column
    {
        public NameColumn(int width) : base(width)
        {
            Title = "Name";
        }

        public override void Format(ref string value)
        {
            if (value.Length > Width)
            {
                value = $"{value[0..(Width - 2)]}\u2026";
            }
        }
    }
}
