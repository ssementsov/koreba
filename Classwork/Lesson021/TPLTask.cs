namespace Lesson021
{
    internal class TPLTask
    {
        public void DoWork()
        {
            Task<int> newTask = new Task<int>(() => Count());
            newTask.Start();
            Console.WriteLine($"Main task is work {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Main task slill work {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(newTask.Result);
            Console.WriteLine();
        }

        int Count()
        {
            Console.WriteLine($"Start count {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Finish count {Thread.CurrentThread.ManagedThreadId}");
            return 12;
        }
    }
}
