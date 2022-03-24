namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class Rect
    {
        private const float MIN_SCALE = 0.15f;
        public int Height => (int)(Console.WindowHeight * HeightScale);
        public int Width => (int)(Console.WindowWidth * WidthScale);
        public int Origin => (int)(Console.WindowWidth * OriginScale);
        protected float HeightScale { get; init; }
        protected float WidthScale { get; init; }
        protected float OriginScale { get; init; }
        public Rect(float heigthScale, float widthScale, float originScale)
            : this(widthScale, originScale)
        {
            CheckScale(heigthScale);
            HeightScale = heigthScale;
        }
        public Rect(float widthScale, float originScale)
        {
            CheckScale(widthScale);

            WidthScale = widthScale;
            OriginScale = originScale;
        }
        private static void CheckScale(float scale)
        {
            if (scale is <= MIN_SCALE or >1f)
            {
                throw new ArgumentException($"Cannot create Rect with scale size = {scale}");
            }
        }
    }
}
