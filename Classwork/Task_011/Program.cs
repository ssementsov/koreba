using Task_011;

class Program
{
    static void Main()
    {
        var test = new DerivedClass();

        IInterface1 test_1 = test as IInterface1;
        test_1.Method();

        IInterface2 test_2 = test as IInterface2;
        test_2.Method();
    }
}