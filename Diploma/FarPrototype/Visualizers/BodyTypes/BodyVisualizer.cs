namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class BodyVisualizer : Visualizer
    {
        protected View View;
        protected string[] TableHeader;
        protected string[,] Table;
        public int[] ColumnsWidth;
        public BodyVisualizer(View view)
        {
            View = view;
            InitializeHeader();
            InitializeColumnsWidth();
        }
        public abstract void Draw();
        protected abstract void InitializeHeader();
        protected abstract void InitializeColumnsWidth();

        public abstract void PrepareTable();
    }
}