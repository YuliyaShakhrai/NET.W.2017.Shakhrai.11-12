using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace TimerConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var timer = new Timer.Timer { Time = 60 };
            var customer1 = new Customer1();
            var customer2 = new Customer2();

            timer.TimeIsOver += customer1.SayTimeIsOver;
            timer.TimeIsOver += customer2.SayTimeIsOver;

            timer.Start("Time is running - 1 min.");

            Console.ReadLine();

        }
    }
}
