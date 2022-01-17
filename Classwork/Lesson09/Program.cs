using System;

namespace Lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            //string variable = "HELLO";

            //Task_040 example_040 = new Task_040();
            //Console.WriteLine(example_040.ToLowerCase(variable));


            string origin = "daabdccdbcacd";
            string template = "aad";

            Task_041 example_041 = new Task_041();
            Console.WriteLine(example_041.MinSubstring(origin, template));

            Console.ReadKey();
        }
    }
}
