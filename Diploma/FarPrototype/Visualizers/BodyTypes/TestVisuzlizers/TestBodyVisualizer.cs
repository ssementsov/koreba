using FarPrototype.Models;

namespace FarPrototype.Visualizers.BodyTypes.TestVisuzlizers
{
    internal class TestBodyVisualizer : TestDrawer
    {
        public Table Table { get; set; }

        public TestBodyVisualizer(ViewBody body, float heigthScale, float widthScale, float originScale)
        {
            Table = new FullTable(body, heigthScale, widthScale, originScale);
        }

        public void Draw()
        {
            // draw table
        }
    }
}
