using System;
using LearnCSharp.Basic.Utils;

namespace LearnCSharp.Basic.Other
{
    class DateTimeTest
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Run()
        {
            FormatTest();
            ConstructorTest();
        }

        /// <summary>
        /// 日期格式化测试
        /// </summary>
        public static void FormatTest()
        {
            OutputUtil.ShowTitle("格式化测试");

            DateTime dt = DateTime.Now;
            Console.WriteLine("格式：{0}", "yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("结果：{0}", dt.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();

            Console.WriteLine("格式：{0}", "MM/dd/yyyy HH:mm:ss");
            Console.WriteLine("结果：{0}", dt.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine();
        }

        /// <summary>
        /// 构造函数测试
        /// </summary>
        public static void ConstructorTest()
        {
            OutputUtil.ShowTitle("构造函数测试");

            DateTime dateTime = new DateTime(2014, 6, 23, 8, 30, 1);
            Console.WriteLine("构造函数：{0}", "new DateTime(2014, 6, 23, 8, 30, 1)");
            Console.WriteLine("结果：{0}", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();
        }

        /// <summary>
        /// 解析测试
        /// </summary>
        public static void ParseTest()
        {

        }

        /// <summary>
        /// 属性测试
        /// </summary>
        public static void PropertyTest()
        {
            OutputUtil.ShowTitle("属性测试");

            DateTime dt = DateTime.Now;
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
        }


    }
}
