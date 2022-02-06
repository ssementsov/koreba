namespace Task_10
{
    internal class DerivedClass : IInterface1, IInterface2
    {
        public void Method1() => Console.WriteLine("Method - implementation IInterface1");
        public void Method2() => Console.WriteLine("Method - implementation IInterface2");
    }
}
