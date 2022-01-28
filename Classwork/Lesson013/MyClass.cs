using System;

namespace Lesson013
{
    class MyClass
    {
        public MyClass1 MyArray1 { get; set; }

        public MyClass2 MyArray2 { get; set; }

        public MyClass()
        {
            MyArray1 = new MyClass1();
            MyArray2 = new MyClass2();
        }
    }
}
