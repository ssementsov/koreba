namespace Lesson021
{
    internal class MTSemaphore
    {
        static Semaphore semaphore = new Semaphore(3, 3);
        Thread currentThread;

        public MTSemaphore()
        {
            currentThread = new Thread(() => DoWork());
            currentThread.Start();
        }

        public void DoWork()
        {
            for (int i = 0; i < 3; i++)
            {
                semaphore.WaitOne();
                Console.WriteLine($"Start Thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
                semaphore.Release();
                Console.WriteLine($"Finish Thread: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
