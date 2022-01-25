using System;

namespace Lesson012.Task008
{
    internal class Phone
    {
        public SizeType SizeType { get; private set; }
        private int _number;
        private string _model;
        private int _weight;

        public int Number { get => _number; }
        public string Model { get => _model; }
        public int Weight { get => _weight; }

        public Phone() { }

        public Phone(int number, string model)
        {
            _number = number;
            _model = model;
        }

        public Phone(int number, string model, int weigth)
            : this(number, model)
        {
            _weight = weigth;
        }

        public Phone(int number, string model, int weight, int sizeType) 
            : this (number, model, weight)
        {
            SizeType = (SizeType)sizeType;
        }

        public void ReseiveCall(string name, int number)
        {
            ReceiveCall(name);
            Console.WriteLine($"Number = {GetNumber(number)}");
        }

        public void ReceiveCall(string name)
        {
            Console.Write($"Звонит {name}; ");
        }

        public int GetNumber(int number) => number;

        public override string ToString()
        {
            return $"Number = {Number}; Model = {Model}; Weigth = {Weight}";
        }
    }
}
