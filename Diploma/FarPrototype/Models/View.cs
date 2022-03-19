using FarPrototype.Models;

namespace FarPrototype
{
    internal class View
    {
        private const float MIN_SCALE = 0.33f;

        private float _heightScale;
        private float _widthScale;
        public string CurrentDirectoryPath { get; private set; }
        public int Height => (int)(Console.WindowHeight * _heightScale);
        public int Width => (int)(Console.WindowWidth * _widthScale);
        private float HeightScale { init => _heightScale = Math.Clamp(value, MIN_SCALE, 1f); }
        private float WidthScale { init => _widthScale = Math.Clamp(value, MIN_SCALE, 1f); }
        public ViewBody Body { get; private set; }
        public ViewFooter Footer { get; private set; }

        public float OriginScale { get; init; }

        public View(float heigthScale, float widthScale, float originScale)
        {
            HeightScale = heigthScale;
            WidthScale = widthScale;
            OriginScale = originScale;
            Footer = new ViewFooter(Width);
            Body = new ViewBody();

            UpdateState(Directory.GetCurrentDirectory());
        }

        public void UpdateState(string currentDirectoryPath)
        {
            CurrentDirectoryPath = currentDirectoryPath;

            Body.UpdateState(CurrentDirectoryPath);
        }

        public void SelectRaw(int number)
        {
            Body.SelectedRaw = number;
        }

        public int GetSelectedRawNumber()
        {
            return Body.SelectedRaw;
        }
    }
}
