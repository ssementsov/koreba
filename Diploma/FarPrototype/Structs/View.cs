using FarPrototype.Structs;

namespace FarPrototype
{
    internal class View
    {
        private const float MIN_SCALE = 0.33f;

        private float _heightScale;
        private float _widthScale;
        public int Height => (int)(Console.WindowHeight * _heightScale);
        public int Width => (int)(Console.WindowWidth * _widthScale);
        private float HeightScale { set => _heightScale = Math.Clamp(value, MIN_SCALE, 1f); }
        private float WidthScale { set => _widthScale = Math.Clamp(value, MIN_SCALE, 1f); }

        public ViewBody Body { get; private set; }
        public bool IsActive { get; set; }

        //public Vector2 Origin { get; private set; }

        public View(float heigthScale, float widthScale)
        {
            HeightScale = heigthScale;
            WidthScale = widthScale;
            IsActive = false;
            Body = new ViewBody();
        }

        public void UpdateState()
        {
            DirectoryInfo[] directories = DirectoryReader.GetDirectories();
            FileInfo[] files = DirectoryReader.GetFiles();

            Body.UpdateState(directories, files);
        }
    }
}
