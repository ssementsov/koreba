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
        //public ViewFooter Footer { get; private set; }
        public float OriginScale { get; init; }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                Body.IsSelected = value;
            }
        }

        public View(float heigthScale, float widthScale, float originScale)
        {
            HeightScale = heigthScale;
            WidthScale = widthScale;
            OriginScale = originScale;
            //Footer = new ViewFooter(Width);
            Body = new ViewBody();
        }

        public void Update(string currentDirectoryPath)
        {
            CurrentDirectoryPath = currentDirectoryPath;

            Body.Update(CurrentDirectoryPath);
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
