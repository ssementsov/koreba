namespace FarPrototype.Structs
{
    internal class Window
    {
        public Header Header { get; set; }
        public View[] Views { get; set; }
        public Footer Footer { get; set; }

        public void UpdateState()
        {
            foreach (var view in Views)
            {
                view.UpdateState();
            }
        }
    }
}
