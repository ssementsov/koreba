using System;

namespace Control_Task_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var readers = new Reader[]
            {
                new Reader("Evgeny", "Koreba", "Sergeevich", 123,
                            "PGS", new DateTime(1998, 7, 16), 1337)
                new Reader("Ivan", "Ivanov", "Ivanovich", 456,
                            "Default", DateTime.Now, 6543)
            };

        }
    }
}
