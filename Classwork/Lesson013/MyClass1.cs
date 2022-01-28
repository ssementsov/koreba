using System;

namespace Lesson013
{
    class MyClass1
    {
        int[] array = { 1, 2, 3, 4, 5 };

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
