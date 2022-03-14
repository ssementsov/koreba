namespace Lesson021
{
    internal class MThread
    {
        public void DoWork()
        {
            Console.WriteLine($"Main thread {Thread.CurrentThread.ManagedThreadId}");
            Thread newThread = new Thread(StartNewThread);
            Console.WriteLine("Current thread is work");
            newThread.Start();
            Console.WriteLine("Current thread still work");
            newThread.Join();
            Console.WriteLine("Do work finish");
        }

        public void StartNewThread()
        {
            Console.WriteLine($"Start new thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(10000);
            Console.WriteLine("Finish new thread ");

        }
    }
}
