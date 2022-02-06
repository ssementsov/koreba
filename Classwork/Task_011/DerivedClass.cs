namespace Task_011
{
    class DerivedClass : IInterface1, IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface1");
        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface2");
    }
}
