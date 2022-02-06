namespace Task_012
{
    internal class DerivedClass : BaseClass, IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("Implementation of Method1 from IInterface1");
        public void Method2() => Console.WriteLine("Implementation of Method1 from IInterface2");
    }
}
