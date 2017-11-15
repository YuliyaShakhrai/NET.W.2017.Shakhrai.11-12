using System;
using Timer;

namespace TimerConsole
{
    public class Customer2
    {
        public void SayTimeIsOver(object sender, TimeIsOverEventArgs e)
        {
            Console.WriteLine($"{e.Msg}. Time is out for Customer2.");
        }
    }
}
