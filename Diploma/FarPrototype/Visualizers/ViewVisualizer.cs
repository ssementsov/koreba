using FarPrototype.Visualizers.BodyTypes;

namespace FarPrototype.Visualizers
{
    internal class ViewVisualizer : Visualizer, IDrawer
    {
        public BodyVisualizer Body { get; set; }
        public FooterVisualizer Footer { get; set;}

        public ViewVisualizer(View view, float heigthScale, float widthScale, float originScale)
            : base(heigthScale, widthScale, originScale) 
        {
            Body = new FullBodyVisualizer(view.Body, heigthScale, widthScale, originScale);


        }

        public void PrepareBody()
        {
            Body.PrepareTable();
        }

        public void Draw()
        {
            Body.Draw();
        }
    }
}
