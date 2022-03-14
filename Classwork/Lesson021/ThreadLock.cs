namespace Lesson021
{
    internal class ThreadLock
    {
        int threadId = 0;
        object obj = new object();
        public void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Start thread: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread Id: {threadId}");
            Thread.Sleep(1000);

            lock (obj)
            {
                threadId = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Start Thread: {Thread.CurrentThread.ManagedThreadId}, Thread Id: {threadId}");
            }
        }
    }
}
