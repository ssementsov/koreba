namespace Lesson015
{
    abstract class BaseClass
    {
        public abstract void Method(); //=> Console.WriteLine("BaseClass.Method");
        public abstract string Property { get; /*{ return "BaseClass.Property"; }*/ }
        public abstract string this[int index] { get; /*{ return "BaseClass.Indexer"; }*/ }
    }
}
