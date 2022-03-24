namespace FarPrototype.Visualizers.BodyTypes.Columns
{
    internal class ExtensionColumn : Column
    {
        public ExtensionColumn(int width) : base(width)
        {
            Title = string.Empty;
        }

        public override void Format(ref string value)
        {
            if (value.Length > Width)
            {
                throw new ApplicationException("Extension column created incorrectly. " +
                    "Width must be greater than the maximum extension length");
            }

            var shiftCount = Width - value.Length;
            value = value.Insert(0, new string(' ', shiftCount));
        }
    }
}
