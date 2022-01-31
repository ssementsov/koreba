using System;

namespace Lesson014
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task 2
            //var person_1 = new Person();
            //var person_2 = new Person("Evgeny", 23);


            // Task 3
            var samsung = new Phone(123, "Samsung");
            var xiaomi = new Phone(456, "Xiaomi", 100);
            var iPhone = new Phone();

            var phones = new Phone[] { samsung, xiaomi, iPhone };

            foreach (var phone in phones)   
            {
                Console.WriteLine($"{phone.Number} {phone.Model} {phone.Weight}");
                phone.ReceiveCall("Evgeny");
                phone.GetNumber();
                phone.ReceiveCall("Evgeny", 1337);
                phone.SendMessage(111, 222, 333);

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
