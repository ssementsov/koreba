using System;

namespace Task_0107
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stack = new MyStack(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            //stack.Push(6);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
