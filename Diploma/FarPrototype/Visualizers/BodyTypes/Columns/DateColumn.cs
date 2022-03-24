namespace FarPrototype.Visualizers.BodyTypes.Columns
{
    internal class DateColumn : Column
    {
        public DateColumn(int width) : base(width)
        {
            Title = "Date";
        }

        public override void Format(ref string value)
        {

        }
    }
}
