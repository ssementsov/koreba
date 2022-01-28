using System;

namespace Lesson013
{
    class MyClass2
    {
        int[] array = { 1, 2, 3, 4, 5 };

        [System.Runtime.CompilerServices.IndexerName("Indexer")]
        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
