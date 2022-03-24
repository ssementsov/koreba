namespace FarPrototype.Visualizers.BodyTypes.Columns
{
    internal class SizeColumn : Column
    {
        public SizeColumn(int width) : base(width)
        {
            Title = "Size";
        }

        public override void Format(ref string value)
        {
            var size = long.Parse(value);
            var degree = 0;

            while (size / (Width - 1) >= 1)
            {
                size /= 1024;
                degree++;
            }

            value = size.ToString();
            var postfix = string.Empty;

            switch (degree)
            {
                case 0:
                    break;
                case 1:
                    postfix = "K";
                    break;
                case 2:
                    postfix = "M";
                    break;
                case 3:
                    postfix = "G";
                    break;
                case 4:
                    postfix = "T";
                    break;
                default:
                    break;
            }

            value += $" {postfix}";
        }
    }
}
