namespace FarPrototype.Structs
{
    internal abstract class Rect
    {
        public int Heigth { get; protected set; }
        public int Width { get; private set; }
        public Rect(int heigth, int width)
            : this(width)
        {
            Heigth = heigth;
        }
        public Rect(int width)
        {
            Width = width;
        }
    }
}
