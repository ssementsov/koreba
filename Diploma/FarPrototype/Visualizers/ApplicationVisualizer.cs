using FarPrototype.Models;

namespace FarPrototype.Visualizers
{
    internal sealed class ApplicationVisualizer
    {
        public ViewVisualizer[] Visualizers { get; set; }

        public ApplicationVisualizer(Window window)
        {
            Visualizers = new ViewVisualizer[window.Views.Length];

            var origin = 0f;

            for (int i = 0; i < Visualizers.Length; i++)
            {
                float widthScale = 1f / window.Views.Length;
                var vv = new ViewVisualizer(window.Views[i], 1, widthScale, origin);
                Visualizers[i] = vv;
                origin += widthScale;
            }
        }

        public void UpdateAllViews()
        {
            foreach (var visualizer in Visualizers)
            {
                visualizer.PrepareBody();
            }
        }

        public void UpdateView(int number)
        {
            if (number >= 0 && number < Visualizers.Length)
            {
                Visualizers[number].PrepareBody();
            }
            else
            {
                throw new ArgumentException($"View with index {number} does not exist");
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
