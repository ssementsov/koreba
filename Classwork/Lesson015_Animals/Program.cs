namespace Lesson015_Animals
{
    class Program
    {
        static void Main()
        {
            // Рефлексия
            //Type type = Type.GetType("Lesson015_Animals.Dog");
            //Animal animal = Activator.CreateInstance(type) as Animal;
            //animal?.Run(new Dog());

            Random random = new();

            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(2);
                Animal animal;
                if (randomNumber == 0)
                {
                    animal = new Dog();
                }
                else
                {
                    animal = new Cat();
                }
                animal.Run(animal);
                animal.MakeSound();
            }
        }
    }
}