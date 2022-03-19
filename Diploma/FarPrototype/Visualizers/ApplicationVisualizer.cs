using FarPrototype.Models;

namespace FarPrototype.Visualizers
{
    internal class ApplicationVisualizer
    {
        public List<ViewVisualizer> Visualizers { get; set; }

        public ApplicationVisualizer(Window window)
        {
            Visualizers = new List<ViewVisualizer>();

            foreach (var view in window.Views)
            {
                var visualizer = new ViewVisualizer(view);
                Visualizers.Add(visualizer);
            }
        }

        public void Update()
        {
            foreach (var visualizer in Visualizers)
            {
                visualizer.PrepareBody();
            }
        }

        public void Draw()
        {
            Console.Clear();

            foreach (var visualizer in Visualizers)
            {
                visualizer.Draw();
            }
        }
    }
}
