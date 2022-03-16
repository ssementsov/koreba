using FarPrototype.Structs;

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
        public bool IsActive { get; set; }

        //public Vector2 Origin { get; private set; }

        public View(float heigthScale, float widthScale, bool isActive = false)
        {
            HeightScale = heigthScale;
            WidthScale = widthScale;
            IsActive = isActive;
            Footer = new ViewFooter(Width);
            Body = new ViewBody();

            UpdateState(Directory.GetCurrentDirectory());
        }

        public void UpdateState(string currentDirectoryPath)
        {
            CurrentDirectoryPath = currentDirectoryPath;

            Body.UpdateState(CurrentDirectoryPath);
        }

        public void HighliteElement(int number)
        {
            Body.HighliteElement(number);
        }

        public Element GetHighlited()
        {
            return Body.GetHighlitedElement();
        }
    }
}
