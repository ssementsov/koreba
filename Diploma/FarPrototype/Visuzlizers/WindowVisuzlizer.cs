using FarPrototype.WindowStructures;

namespace FarPrototype.Drawers
{
    internal class WindowVisuzlizer
    {
        public HeaderVisualizer HeaderVisualizer { get; set; }
        public BodyVisualizer BodyVisuzlizer { get; set; }
        public FooterVisuzlizer FooterVizualizer { get; set;}

        public WindowVisuzlizer(Window window)
        {
            HeaderVisualizer = new(window.Header);
            //BodyVisualizer = 
        }

    }
}
