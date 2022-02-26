using FarPrototype.Structs;
using FarPrototype.Visualizers.BodyTypes;

namespace FarPrototype.Visualizers
{
    internal class ViewVisualizer
    {
        public HeaderVisualizer HeaderVisualizer { get; set; }
        public BodyVisualizer BodyVisualizer { get; set; }
        public FooterVisualizer FooterVizualizer { get; set;}

        public ViewVisualizer(Window window)
        {
            BodyVisualizer = new FullBodyVisualizer(window.Views[0]);
        }

        public void PrintBody()
        {
            BodyVisualizer.Test();
        }
    }
}
