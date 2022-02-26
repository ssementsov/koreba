using FarPrototype.Structs;

namespace FarPrototype
{
    internal class View
    {
        private const float MIN_SCALE = 0.33f;

        private float _heightScale;
        private float _widthScale;
        public int Height => (int)(Console.LargestWindowHeight * _heightScale);
        public int Width => (int)(Console.LargestWindowWidth * _widthScale);
        private float HeightScale { set => _heightScale = Math.Clamp(value, MIN_SCALE, 1f); }
        private float WidthScale { set => _widthScale = Math.Clamp(value, MIN_SCALE, 1f); }

        public Body Body { get; private set; }
        public bool IsActive { get; set; }

        //public Vector2 Origin { get; private set; }

        public View(float heigthScale, float widthScale)
        {
            HeightScale = heigthScale;
            WidthScale = widthScale;
            IsActive = false;
            Body = new Body();
        }

        public void UpdateState()
        {
            DirectoryInfo[] directories = DirectoryReader.GetDirectories();
            FileInfo[] files = DirectoryReader.GetFiles();

            Body.UpdateState(directories, files);
        }
    }
}
