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
                Views[_selectedViewNumber].IsSelected = false;

                _selectedViewNumber = value >= Views.Length ? 
                    value - Views.Length : 
                    value < 0 ? 
                    value + Views.Length : 
                    value;

                Views[_selectedViewNumber].IsSelected = true;
            }
        }

        public Window(int viewsCount)
        {
            if (viewsCount <= 0)
            {
                throw new ArgumentException("Amount of views should be greater than 0");
            }

            Views = new View[viewsCount];

            float origin = 0;
            for (int i = 0; i < viewsCount; i++)
            {
                float viewWidth = (float)1 / viewsCount;
                var view = new View(1, viewWidth, origin);
                Views[i] = view;
                origin += viewWidth;
            }

            SelectedView = 0;
        }

        public void UpdateAllViews(string path)
        {
            foreach (var view in Views)
            {
                UpdateView(view, path);
            }
        }

        public int GetSelectedNumber()
        {
            return Views[_selectedViewNumber].GetSelectedRawNumber();
        }

        public void SelectElement(int number)
        {
            Views[_selectedViewNumber].SelectRaw(number);
        }

        public void UpdateSelectedView(string path)
        {
            UpdateView(Views[_selectedViewNumber], path);
        }

        private void UpdateView(View view, string path)
        {
            view.Update(path);
        }
    }
}
