using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace LearnCSharp.Basic
{
    class TimerEventDemo
    {
        static int counter = 0;

        public static void RunDemo()
        {
            Timer timer = new Timer(1000);
            timer.Elapsed += WriteCounter;
            timer.Start();
            Console.ReadKey();
        }

        public static void WriteCounter(object source, ElapsedEventArgs e)
        {
            counter++;
            Console.WriteLine(counter);
        }
    }
}
