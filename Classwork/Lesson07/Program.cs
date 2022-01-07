using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------- ЦИКЛЫ --------------------------

            //int counter = 0;
            //do
            //{
            //    counter++;
            //    Console.WriteLine("Counter {0}", counter);
            //} while (counter < 3);


            // ---------------- ФАКТОРИАЛ ---------------

            //int number =  int.Parse(Console.ReadLine());
            //decimal result = 1;
            //do
            //{
            //    result *= number--;
            //}
            //while (number > 0);

            //Console.WriteLine(result);

            //------------------------------------------

            //while (true)
            //{
            //    Console.WriteLine("Infinity cycle");
            //}


            // ----------------- СТРУКТУРЫ ДАННЫХ ------------------


            //byte[] agesList = { 23, 30, 35};

            //int i = 0;
            //while (i < agesList.Length)
            //{
            //    Console.WriteLine(agesList[i++]);
            //}


            //byte[] array = new byte[2];

            //array[0] = 0;
            //array[1] = 1;
            //array[2] = 255;


            // -------------------- TASK 28 -----------------------

            //int number = int.Parse(Console.ReadLine());

            //if (number > 0)
            //{
            //    do
            //    {
            //        Console.Write($"{number--}; ");
            //    } 
            //    while (number >= 0);
            //}
            //else
            //{
            //    do
            //    {
            //        Console.Write($"{number++}; ");
            //    } 
            //    while (number <= 0);
            //}

            // --------------------------------------------------

            //--------------------- TASK 29 ---------------------

            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());

            //if (first > second)
            //{
            //    while (second != first)
            //    {
            //        if (second % 2 != 0)
            //        {
            //            Console.Write($"{second}; ");
            //        }
            //        second++;
            //    }
            //}
            //else
            //{
            //    while (first != second)
            //    {
            //        if (first % 2 != 0)
            //        {
            //            Console.Write($"{first}; ");
            //        }
            //        first++;
            //    }
            //}

            //--------------------------------------------------


            //--------------------- TASK 30 --------------------

            string[] monthes = {"J", "F", "M", "A", "May", "June", "July", "A", "S", "O", "N", "D"};

            bool isBroken = false;

            foreach (string month in monthes)
            {
                string usersMonth = "";

                while (usersMonth != month)
                {
                    Console.Write("Введите название месяца: ");
                    usersMonth = Console.ReadLine();

                    if (usersMonth != month)
                    {
                        if (month != "May")
                        {
                            Console.WriteLine("Mistake!");
                        }
                        else
                        {
                            isBroken = true;
                            break;
                        }
                    }
                }

                if (isBroken)
                {
                    Console.WriteLine("You dont know how to write May month lol");
                    break;
                }

                Console.WriteLine($"Month {month} was writen right");
            }

            //--------------------------------------------------


            //---------------------- TASK 31 -------------------

            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];

            for (int i = 0; i < array.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }

            Array.Sort(array);


            Console.ReadKey();
        }
    }
}
