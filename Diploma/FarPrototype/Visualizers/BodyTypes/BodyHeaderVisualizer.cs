using FarPrototype.Structs;

namespace FarPrototype.Visualizers.BodyTypes
{
    internal class BodyHeaderVisualizer : Visualizer, IDrawer
    {
        public int Heigth { get; private set; }
        private int _width;
        public string Path { get; private set; }
        public BodyHeaderVisualizer(int heigth, int width)
        {
            Heigth = heigth;
        }

        public void Draw()
        {
            //string path = Directory.GetCurrentDirectory();

            //int count = Width - path.Length - 4;
            //int half = count / 2;

            //string firstLine = string.Empty;
            //if (path.Length + 4 > Width)
            //{
            //    int index = path.Length - Width + 4;
            //    firstLine = $"{Border.TopLeftCorner} {path[0..3]}\u2026{path[(3+index + 1)..]} ";
            //}
            //else
            //{
            //    firstLine = $"{Border.TopLeftCorner}{new string(Border.HorizontalDoubleLine, half)}" +
            //                       $" {path} ";
            //}
        }
    }
}
