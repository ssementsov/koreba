using FarPrototype.Models;
using FarPrototype.Settings;
using FarPrototype.Visualizers;

namespace FarPrototype
{
    internal class Input
    {
        private Window _window;
        private ApplicationVisualizer _visualizer;
        private int _selectedElement;

        public Input(Window window, ApplicationVisualizer visualizer)
        {
            _window = window;
            _visualizer = visualizer;
            _selectedElement = window.GetSelectedNumber();
        }

        public void Handle(ConsoleKeyInfo info)
        {
            if (info.Key == InputSettings.Up)
            {
                SelectElement(--_selectedElement);
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }

            else if (info.Key == InputSettings.Down)
            {
                SelectElement(++_selectedElement);
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }
            else if (info.Key == InputSettings.SwitchWindow)
            {
                _window.SelectedView++;
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }
        }
        private void SelectElement(int number)
        {
            _window.SelectElement(number);
        }

    }
}
