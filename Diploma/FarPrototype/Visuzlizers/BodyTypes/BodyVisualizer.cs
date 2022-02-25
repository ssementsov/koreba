using FarPrototype.Structs;

namespace FarPrototype.Drawers
{
    internal abstract class BodyVisualizer
    {
        protected Body Body;
        public BodyVisualizer(Body body)
        {
            Body = body;
        }
    }
}