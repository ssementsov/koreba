using Task_9;

class Program
{
    static void Main()
    {
        var myClass = new MyClass();
        myClass.Method();

        IInterface my = new MyClass();
        my.Method();
    }
}