using System;

namespace Control_Task_4
{
    internal class Book
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }
    }
}
