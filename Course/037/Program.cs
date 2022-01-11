using System;

namespace _037
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,,] library = new string[5, 10, 10];

            library[1, 2, 3] = "Book1";
            library[2, 3, 4] = "Book2";
            library[4, 5, 6] = "Book3";

            Console.Write("Enter the title of the book: ");
            string book = Console.ReadLine();

            FindBook(library, book);

            Console.ReadKey();
        }

        private static void FindBook(string[,,] library ,string book)
        {
            for (int z = 0; z < library.GetLength(0); z++)
            {
                for (int y = 0; y < library.GetLength(1); y++)
                {
                    for (int x = 0; x < library.GetLength(2); x++)
                    {
                        if (library[z,y,x] == book)
                        {
                            Console.WriteLine($"The book {book} is numbered on the rack {z}, shelf {y}, place {x}");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"The book {book} is not found in library.");
        }
    }
}
