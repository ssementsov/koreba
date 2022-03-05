using FarPrototype.Structs;
using FarPrototype.Visualizers.BodyTypes;

namespace FarPrototype.Visualizers
{
    internal class ViewVisualizer : IDrawer
    {
        public HeaderVisualizer HeaderVisualizer { get; set; }
        public BodyVisualizer BodyVisualizer { get; set; }
        public FooterVisualizer FooterVizualizer { get; set;}

        public ViewVisualizer(View view)
        {
            BodyVisualizer = new FullBodyVisualizer(view.Body, view.Height, view.Width);
        }

        public void PrepareBody()
        {
            BodyVisualizer.PrepareTable();
        }

        public void Draw()
        {
            BodyVisualizer.Draw();
        }
    }
}
