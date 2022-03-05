using FarPrototype.Structs;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class BodyVisualizer : Visualizer
    {
        protected ViewBody Body { get; private set; }
        protected int Height { get; private set; }
        protected int Width { get; private set; }
        protected string[] TableHeader;
        protected string[,] Table;
        public int[] ColumnsWidth;

        protected BodyHeaderVisualizer pathLine;

        public BodyVisualizer(ViewBody body, int heigth, int width)
        {
            Body = body;
            Height = heigth;
            Width = width;
            InitializeHeader();
            InitializeColumnsWidth();
        }
        public abstract void Draw();
        protected abstract void InitializeHeader();
        protected abstract void InitializeColumnsWidth();

        public abstract void PrepareTable();
    }
}