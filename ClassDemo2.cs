using System;

namespace Ayushi_NVB
{
    public class Time
    {
        double hour;
        double minute;
        double second;
    public void getTime(double hour, double minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    public void showTime()
        {
            Console.WriteLine("Time : " + hour + ":" +  minute + ":" + second);
        }
        public void incrementSecond()
        {
            second++;

            if (second == 60)
            {
                second = 0;
                minute++;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;

                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
    }

    internal class ClassDemo2
    {
        public static void Main(string []args)
        {
            Time t1 = new Time();
            t1.getTime(11, 28, 59);
            Console.Write("Current Time => ");
            t1.showTime();

            t1.incrementSecond();
            Console.Write("After Increment => ");
            t1.showTime(); ;

            Time t2 = new Time();
            t2.getTime(11, 59, 59);
            Console.Write("Current Time => ");
            t2.showTime();

            t2.incrementSecond();
            Console.Write("After Increment => ");
            t2.showTime();
        }
    }
}
