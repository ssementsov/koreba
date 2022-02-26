namespace FarPrototype.Visualizers.BodyTypes
{
    internal abstract class BodyVisualizer
    {
        protected View View;
        protected string[] TableHeader;
        protected string[,] Table;
        protected int[] ColumnsWidth;
        public BodyVisualizer(View view)
        {
            View = view;
        }
        public abstract void Draw();
        protected abstract void InitializeHeader();


        public abstract void Test();
    }
}