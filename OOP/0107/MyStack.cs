using System;

namespace Task_0107
{
    public class MyStack
    {
        private int index = 0;
        private int[] _stack;

        public MyStack(uint size)
        {
            _stack = new int[size];
        }

        public int Pop()
        {
            if (index >= 0)
            {
                int number = _stack[index - 1];
                _stack[index - 1] = default;
                index--;

                return number;
            }
            else
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
        }

        public void Push(int number)
        {
            if (index < _stack.Length)
            {
                _stack[index] = number;
                index++;
            }
            else
            {
                throw new StackOverflowException();
            }
        }
    }
}
