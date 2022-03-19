namespace FarPrototype.Models
{
    internal class Window
    {
        public Header Header { get; init; }
        public View[] Views { get; init; }
        public Footer Footer { get; init; }
        private int _selectedViewNumber;
        public int SelectedView
        {
            get => _selectedViewNumber;
            set
            {
                if (value > Views.Length)
                {
                    _selectedViewNumber = value - Views.Length;
                }
                else if (value < Views.Length)
                {
                    _selectedViewNumber = value + Views.Length;
                }
            }
        }

        public Window(int viewsCount)
        {
            if (viewsCount <= 0)
            {
                throw new ArgumentException("Amount of views should be greater than 0");
            }

            _selectedViewNumber = 0;
            Views = new View[viewsCount];

            float origin = 0;
            for (int i = 0; i < viewsCount; i++)
            {
                float viewWidth = (float)1 / viewsCount;
                var view = new View(1, viewWidth, origin);
                Views[i] = view;
                origin += viewWidth;
            }
        }

        public void UpdateState()
        {
            // TODO : Сюда нужно передать строку через инпут
            Views[_selectedViewNumber].UpdateState(Directory.GetCurrentDirectory());
        }

        public int GetSelectedNumber()
        {
            return Views[_selectedViewNumber].GetSelectedRawNumber();
        }

        public void SelectElement(int number)
        {
            Views[_selectedViewNumber].SelectRaw(number);
        }
    }
}
