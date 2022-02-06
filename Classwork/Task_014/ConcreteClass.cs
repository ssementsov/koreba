namespace Task_014
{
    internal class ConcreteClass : IInterface2
    {
        void IInterface1.Method() => Console.WriteLine("Method - implementation IInterface1");
        void IInterface2.Method() => Console.WriteLine("Method - implementation IInterface2");
    }
}
