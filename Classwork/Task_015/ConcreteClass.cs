namespace Task_015
{
    internal class ConcreteClass : IInterface1, IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface1");
        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface2");
    }
}
