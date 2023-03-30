namespace HW15_3exe
{
    public class ThreeExe
    {
        public static void Main(string[] args)
        {
            RunProgram();
        }

        public static void RunProgram()
        {
            var semaphore = new Semaphore(3, 3, "Hillel.HW15 Semaphore");
            var eventWaitH = new EventWaitHandle(false, EventResetMode.ManualReset, "Hillel.HW15 EventWaitHandle");
            bool isActive = semaphore.WaitOne(100);
            if (!isActive)
            {
                Console.WriteLine("программа уже запущена в 3 экземплярах");
                Thread.Sleep(1000);
                return;
            }
            else
            {
                Console.WriteLine("программа запущена");
            }

            eventWaitH.Set();
            while (true)
            {
                eventWaitH.WaitOne();
                Console.WriteLine("запущен новый экземпляр");
                Thread.Sleep(100);
                eventWaitH.Reset();
            }
        }
    }
}