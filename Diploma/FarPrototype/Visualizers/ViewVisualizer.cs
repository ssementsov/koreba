using FarPrototype.Structs;
using FarPrototype.Visualizers.BodyTypes;

namespace FarPrototype.Visualizers
{
    internal class ViewVisualizer : IDrawer
    {
        public BodyVisualizer Body { get; set; }
        public FooterVisualizer Footer { get; set;}

        public ViewVisualizer(View view)
        {
            Body = new FullBodyVisualizer(view.Body, view.Height, view.Width);
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
