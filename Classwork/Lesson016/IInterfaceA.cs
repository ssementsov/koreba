namespace Lesson016
{
    interface IInterfaceA
    {
        void Method();
    }

    interface IInterfaceB
    {
        void Method();
    }

    interface IInterfaceC : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.Method() => Console.WriteLine("IInterface.Method");
        void IInterfaceB.Method() => Console.WriteLine("IInterface.Method");
        void ConcreteMethod() => Console.WriteLine("IInterfaceC.Method");
    }

    abstract class AbstractClass : IInterfaceC
    {
        public abstract void Method();
        public abstract void ConcreteMethod();
    }

    class ConcreteClass : AbstractClass, IInterfaceA, IInterfaceB
    {
        public override void ConcreteMethod() => Console.WriteLine("ConcreteClass.ConcreteMethod");
        public override void Method() => Console.WriteLine("ConcreteClass.Method");
        void IInterfaceA.Method() => Console.WriteLine("IInterfaceA.Method");
        void IInterfaceB.Method() => Console.WriteLine("IInterfaceB.Method");
    }
}
