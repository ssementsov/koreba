using FarPrototype.Models;

namespace FarPrototype.Visualizers
{
    internal sealed class ApplicationVisualizer
    {
        public List<ViewVisualizer> Visualizers { get; set; }

        public ApplicationVisualizer(Window window)
        {
            Visualizers = new List<ViewVisualizer>();

            var origin = 0f;

            foreach (var view in window.Views)
            {
                float widthScale = 1f / window.Views.Length;
                var vv = new ViewVisualizer(view ,1, widthScale, origin);
                Visualizers.Add(vv);
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
