using System;

namespace _030
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"J", "F", "M", "A", "May", "June", "July", "A", "S", "O", "N", "D"};

            int currentMonthIndex = 0;
            do
            {
                Console.Write($"Enter the name of the {currentMonthIndex + 1} month: ");
                string usersMonth = Console.ReadLine();

                if (usersMonth != months[currentMonthIndex])
                {
                    if (currentMonthIndex != 4)
                    {
                        Console.WriteLine("Mistake! Try again.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Month {months[currentMonthIndex]} was writen right.");
                    currentMonthIndex++;
                }

            } while (currentMonthIndex < months.Length - 1);

            Console.ReadKey();
        }
    }
}
