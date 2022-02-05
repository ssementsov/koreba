namespace Lesson015
{
    internal class DerivedClass : BaseClass
    {
        public override string this[int index] => "DerivedClass.Indexer";
        public override string Property => "DerivedClass.Proreprty";
        public override void Method() => Console.WriteLine("DerivedClass.Method");
    }
}
