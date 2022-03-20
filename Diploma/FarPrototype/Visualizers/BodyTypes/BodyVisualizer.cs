using FarPrototype.Models;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class BodyVisualizer : Visualizer
    {
        protected ViewBody Body { get; private set; }

        protected string[] TableHeader;
        protected string[,] Table;
        public int[] ColumnsWidth;

        public BodyVisualizer(ViewBody body, float heigthScale, float widthScale, float originScale)
            : base(heigthScale, widthScale, originScale)
        {
            Body = body;
            InitializeHeader();
            InitializeColumnsWidth();
        }


        public abstract void Draw();
        protected abstract void InitializeHeader();
        protected abstract void InitializeColumnsWidth();
        public abstract void PrepareTable();
    }
}