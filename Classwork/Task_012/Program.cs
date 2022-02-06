using Task_012;

class Program
{
    static void Main()
    {
        var derived = new DerivedClass();
        derived.Method();
        derived.Method1();
        derived.Method2();

        var baseClass = new BaseClass();
        baseClass.Method();

        IInterface1 derived_1 = derived as IInterface1;
        derived_1.Method1();

        IInterface2 derived_2 = derived as IInterface2;
        derived_2.Method2();
    }
}