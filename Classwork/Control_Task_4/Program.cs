using System;

namespace Control_Task_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book_1 = new Book("Atlas Shrugged", "Ayn Rand");
            var book_2 = new Book("Martin Iden", "Jack London");

            var readers = new Reader[]
            {
                new Reader("Evgeny", "Koreba", "Sergeevich", 123,
                            "PGS", new DateTime(1998, 7, 16), "1337"),
                new Reader("Ivan", "Ivanov", "Ivanovich", 456,
                            "Default", DateTime.Now, "6453")
            };

            readers[0].TakeBook(3);
            readers[0].TakeBook("Atlas Shrugged", "Martin Iden");
            Console.WriteLine();
            readers[0].TakeBook(book_1, book_2);

            readers[0].ReturnBook(3);
            readers[0].ReturnBook("Atlas Shrugged", "Martin Iden");
            Console.WriteLine();
            readers[0].ReturnBook(book_1, book_2);
        }
    }
}
