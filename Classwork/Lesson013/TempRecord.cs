using System;

namespace Lesson013
{
    public class TempRecord
    {
        float[] temps = new float[3]
        {
            56.2f, 56.7f, 56.5f,
        };

        public int Length => temps.Length;

        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
}
