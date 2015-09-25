using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic
{
    class DateTimeDemo
    {
        public static void BasicDemo()
        {
            DateTime dt = DateTime.Now;


            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("dt.Date.ToString()：{0}", dt.Date.ToString());
            Console.WriteLine("dt.Year.ToString()：{0}", dt.Year.ToString());
            Console.WriteLine("dt.Month.ToString()：{0}", dt.Month.ToString());
            Console.WriteLine("dt.Day.ToString()：{0}", dt.Day.ToString());
            Console.WriteLine("dt.DayOfWeek.ToString()：{0}", dt.DayOfWeek.ToString());
            Console.WriteLine("dt.DayOfYear.ToString()：{0}", dt.DayOfYear.ToString());

            Console.WriteLine("dt.TimeOfDay.ToString()：{0}", dt.TimeOfDay.ToString());
            Console.WriteLine("dt.Hour.ToString()：{0}", dt.Hour.ToString());
            Console.WriteLine("dt.Minute.ToString()：{0}", dt.Minute.ToString());
            Console.WriteLine("dt.Second.ToString()：{0}", dt.Second.ToString());
            Console.WriteLine("dt.Millisecond.ToString()：{0}", dt.Millisecond.ToString());

            Console.WriteLine("dt.Ticks.ToString()：{0}", dt.Ticks.ToString());

            Console.WriteLine("////////////////////////////////////////");




            

 

        }
    }
}
