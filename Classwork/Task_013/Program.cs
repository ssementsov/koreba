using Task_013;

class Program
{
    static void Main()
    {
        var cc = new ConcreteClass();
        cc.Method1();
        cc.Method2();

        var interface_1 = cc as IInterface1;
        var interface_2 = cc as IInterface2;
    }
}