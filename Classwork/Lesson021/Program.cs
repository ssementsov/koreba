namespace Lesson021
{
    class Program
    {
        static void Main()
        {
            //var threadExample = new MThread();
            //threadExample.DoWork();

            //--------------------------------------

            //var lockExample = new ThreadLock();

            //var work = new ThreadLock();
            //var t1 = new Thread(() => work.DoWork());
            //var t2 = new Thread(() => work.DoWork());
            //var t3 = new Thread(() => work.DoWork());

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //--------------------------------------

            //var s1 = new MTSemaphore();
            //var s2 = new MTSemaphore();
            //var s3 = new MTSemaphore();
            //var s4 = new MTSemaphore();
            //var s5 = new MTSemaphore();
            //var s6 = new MTSemaphore();
            //var s7 = new MTSemaphore();

            //--------------------------------------

            TPLTask task = new TPLTask();
            task.DoWork();
        }
    }
}