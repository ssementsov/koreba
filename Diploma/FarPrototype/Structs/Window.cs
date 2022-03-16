namespace FarPrototype.Structs
{
    internal class Window
    {
        public Header Header { get; set; }
        public View[] Views { get; set; }
        public Footer Footer { get; set; }

        public Window()
        {
            Views = new View[]
            {
                new View(1, 0.5f, true)
            };
        }

        public void UpdateState()
        {
            foreach (var view in Views)
            {
                // TODO : Сюда нужно передать строку через инпут
                view.UpdateState(Directory.GetCurrentDirectory());
            }
        }
    }
}
