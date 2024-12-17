using System;
using System.Timers;

class Clock
{
    public class TimeInfo
    {
        public int Seconds { get; set; }
        public DateTime CurrentTime { get; set; }

        public TimeInfo(int elapsedSeconds, DateTime signalTime)
        {
            Seconds = elapsedSeconds;
            CurrentTime = signalTime;
        }
    }

    public delegate void TimerEvent(object source, TimeInfo timeInfo);

    public static event TimerEvent TimePassing;

    static System.Timers.Timer myTimer = new System.Timers.Timer(1000);
    static int Counter { get; set; } = 0;

    static void Main()
    {
        TimePassing += AddSecond;

        myTimer.Elapsed += OnTimerElapsed;
        myTimer.Enabled = true;

        Console.ReadKey();
    }

    private static void OnTimerElapsed(object source, ElapsedEventArgs eventTime)
    {
        TimeInfo timeInfo = new TimeInfo(Counter, eventTime.SignalTime);

        TimePassing?.Invoke(source, timeInfo);
    }

    private static void AddSecond(object source, TimeInfo timeInfo)
    {
        Counter++;
        Console.Write($"\r{timeInfo.CurrentTime}");

        if (Counter == 10)
        {
            myTimer.Stop();
            TimerIsOver();
        }
    }

    private static void TimerIsOver()
    {
        Console.WriteLine("\n10 seconds just passed, press any key to exit the program");
        Console.ReadKey();
    }
}
