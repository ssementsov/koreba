using System;

namespace Lesson012.Task006
{
    internal class ClassC : ClassA
    {
        private string _customField;

        public ClassC()
        {
            _customField = "123";
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"CustomField = {_customField}");
        }
    }
}
