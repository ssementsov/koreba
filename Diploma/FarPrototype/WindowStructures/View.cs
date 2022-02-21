using FarPrototype.WindowStructures;

namespace FarPrototype
{
    internal class View
    {
        public string Path { get; set; }
        public Table Table { get; set; }
        public BodyInfo Info { get; set; }

        public bool IsActive { get; set; }
    }
}
