using System;
using Lesson012.Task006;
using Lesson012.Task008;

namespace Lesson012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Animal dog = new Dog();
            //Animal cat = new Cat();

            //Animal[] animals = { dog, cat };

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    Animal animal = animals[i];

            //    if (animal is Dog isDog)
            //    {
            //        isDog.BringStick();
            //    }
            //    else if (animal is Cat isCat)
            //    {
            //        isCat.CatchMouse();
            //    }
            //}

            //Employee employee = new Employee("Ivan", 22, "Microsoft");


            //ClassA entity = new ClassC();
            //entity.Print();


            Phone phone_1 = new IPhone(1, "IPhone", 100, 5);
            Phone phone_2 = new Samsung(2, "Samsung", 200, 15);
            Phone phone_3 = new Xiaomi(3, "Xiaomi", 150, 10);

            Phone[] phones = { phone_1, phone_2, phone_3 };

            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone.ToString());
                phone.ReceiveCall("Person_Name");
                Console.WriteLine(phone.GetNumber(1337));
                Console.WriteLine(phone.SizeType);
            }

            Console.ReadLine();
        }
    }
}
