using System;

namespace Control_Task_4
{
    internal class Reader
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string MiddleName { get; private set; }
        public int TicketNumber { get; private set; }
        public string Faculty { get; private set; }
        public DateTime Birthday { get; private set; }
        public string PhoneNumber { get; private set; }

        public Reader(string firstName, string surname, string middleName, int ticketNumber,
            string faculty, DateTime birthday, string phoneNumber)
        {
            FirstName = firstName;
            Surname = surname;
            MiddleName = middleName;
            TicketNumber = ticketNumber;
            Faculty = faculty;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
        }

        public void TakeBook(uint count)
        {
            Console.WriteLine($"{FirstName} {Surname} {MiddleName} took {count} books");
        }

        public void TakeBook(params string[] books)
        {
            Console.Write($"{FirstName} {Surname} {MiddleName} took books: ");
            foreach (var book in books)
            {
                Console.Write($"{book}, ");
            }
        }

        public void TakeBook(params Book[] books)
        {
            Console.Write($"{FirstName} {Surname} {MiddleName} took books: ");
            foreach (var book in books)
            {
                Console.Write($"{book}, ");
            }
        }

        public void ReturnBook(uint count)
        {
            Console.WriteLine($"{FirstName} {Surname} {MiddleName} return {count} books");
        }

        public void ReturnBook(params string[] books)
        {
            Console.Write($"{FirstName} {Surname} {MiddleName} return books: ");
            foreach (var book in books)
            {
                Console.Write($"{book}, ");
            }
        }

        public void ReturnBook(params Book[] books)
        {
            Console.Write($"{FirstName} {Surname} {MiddleName} return books: ");
            foreach (var book in books)
            {
                Console.Write($"{book.Title}, ");
            }
        }


    }
}
