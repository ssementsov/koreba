using Lesson019.Exceptions;

namespace Lesson019
{
    class Program
    {
        static void Main()
        {
            var ce = new CollectionExample();
            ce.ExecuteTask();

            var npe = new NewsProviderExample();
            npe.ExecuteTask();

            try
            {
                var reciever = new MessageReciever();
                reciever.Print("Hello world!");
                reciever.Print(string.Empty);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom exception - {ex.Message}");
            }
        }
    }
}