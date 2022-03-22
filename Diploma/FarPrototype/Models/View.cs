using FarPrototype.Models;

namespace FarPrototype
{
    internal class View
    {
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

        public View()
        {
            //Footer = new ViewFooter(Width);
            Body = new ViewBody();
        }

        public void Update(string currentDirectoryPath)
        {
            Body.Update(currentDirectoryPath);
        }

        public void SelectRaw(int number)
        {
            Body.SelectedRaw = number;
        }

        public int GetSelectedRawNumber()
        {
            return Body.SelectedRaw;
        }

        public FileSystemInfo GetSelectedInfo()
        {
            return Body[Body.SelectedRaw];
        }
    }
}
