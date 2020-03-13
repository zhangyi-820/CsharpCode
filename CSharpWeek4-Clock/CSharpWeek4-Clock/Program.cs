using System;


namespace CSharpWeek4_Clock
{
    //响铃
    public class Alarm
    {
        //响铃
        public void Belling(object sender, ReachTimeEventArgs e)
        {
            Clock w = (Clock)sender;
            Console.WriteLine("time:"+w.Time+" didi ");
        }

        //按下任意键后响铃终止
        public void Press(object sender,ReachTimeEventArgs e)
        {
            Clock w = (Clock)sender;
            string str = Console.ReadLine();
            while (str == "\n")
            {

            }
            Console.WriteLine("power off");
            w.Time=(w.Time)+1;
            //Console.WriteLine(w.Time);
            w.Work();
        }
    }


    public class ReachTimeEventArgs : EventArgs
    {
        public int time;
        public ReachTimeEventArgs(int t)
        {
            time = t;
        }
    }

    //声明一个委托类型
    public delegate void ReachTimeEventHandle(object sender, ReachTimeEventArgs e);

    //闹钟
    public class Clock
    {
        public event ReachTimeEventHandle ReachTime;//定义事件

        public Alarm alarm;
        public Clock()
        {
            this.alarm = new Alarm();
        }

        //默认开始事件为0
        private int time = 0;
        private int alarmTime;
        public int Time
        {
            get{ return time; }
            set{ time = value; }
        }
        public void SetAlarmTime(int alarmTime)
        {
            this.alarmTime = alarmTime;
        }
        

        //主函数
        public void Work()
        {
            while (time !=this.alarmTime)//未到响铃时间时或者超过响铃时间时，时间增加
            {
               
                Console.WriteLine("time:"+time+" tick");
                System.Threading.Thread.Sleep(1000);
                time = time + 1;
            }
            ReachTimeEventArgs e = new ReachTimeEventArgs(this.time);
            ReachTime(this, e);//触发事件
        }
    }

   
    class Program
    {
        static void ClockTest()
        {

            Clock w = new Clock();
            w.SetAlarmTime(2);
            w.ReachTime += w.alarm.Belling;
            w.ReachTime += w.alarm.Press;
            w.Work();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ClockTest();
        }
    }
}
