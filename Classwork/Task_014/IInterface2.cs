namespace Task_014
{
    interface IInterface2 : IInterface1
    {
        void IInterface1.Method() { }
        new void Method();
    }
}
