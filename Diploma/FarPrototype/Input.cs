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

        public void Handle(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == InputSettings.Up)
            {
                SelectElement(--_selectedElement);
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }

            else if (keyInfo.Key == InputSettings.Down)
            {
                SelectElement(++_selectedElement);
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }
            else if (keyInfo.Key == InputSettings.SwitchWindow)
            {
                _window.SelectedView++;
                _selectedElement = _window.GetSelectedNumber();
                _visualizer.Draw();
            }
            else if (keyInfo.Key == InputSettings.Enter)
            {
                var rawInfo = _window.GetSelectedInfo();

                if (rawInfo is DirectoryInfo dir)
                {
                    _window.UpdateSelectedView(rawInfo.FullName);
                    _visualizer.UpdateView(_window.SelectedView);
                    _visualizer.Draw();
                    _selectedElement = _window.GetSelectedNumber();
                }
                else
                {
                    var file = rawInfo as FileInfo;
                    // TODO : Execute file (open or something else depending on the file extension)
                    // USE STREAMS and using!!!!!!!!!! using (FileStream fs = new FileStream(file.FullName))
                }
            }
        }
        private void SelectElement(int number)
        {
            _window.SelectElement(number);
        }

    }
}
