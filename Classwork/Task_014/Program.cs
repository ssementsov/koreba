using Task_014;

class Program
{
    static void Main()
    {
        var cc = new ConcreteClass();

        IInterface1 interface1 = cc as IInterface1;
        interface1.Method();

        IInterface2 interface2 = cc as IInterface2;
        interface2.Method();
    }
}