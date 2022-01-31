using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson014
{
    internal class Phone
    {
        public int Number { get; private set; }
        public string Model { get; private set; }
        public int Weight { get; private set; }

        public Phone() { }

        public Phone(int number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone(int number, string model, int weigth)
            : this(number, model)
        {
            Weight = weigth;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Calling {name}");
        }

        public void ReceiveCall(string name, int number)
        {
            ReceiveCall(name);
            Console.WriteLine($"Number - {number}");
        }

        public int GetNumber() => Number;

        public void SendMessage(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
