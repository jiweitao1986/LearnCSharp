using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LearnCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {
            Type threeDayType = typeof(ThreeDay);

            Console.WriteLine("");
            Console.WriteLine("//////////GetNames//////////");
            string[] names = Enum.GetNames(threeDayType);
            foreach  (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("");
            Console.WriteLine("//////////GetValues//////////");
            var values = Enum.GetValues(threeDayType);
            foreach (int value in values)
            {
                Console.WriteLine(value.ToString());
            }

            Console.WriteLine("");
            Console.WriteLine("//////////GetDescriptions 1(仅支持4.5+)//////////");
            foreach (string name in names)
            {
                FieldInfo fieldInfo = threeDayType.GetField(name);
                DescriptionAttribute attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                Console.WriteLine(attribute.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("//////////GetDescriptions 2//////////");
            foreach (string name in names)
            {
                FieldInfo fieldInfo = threeDayType.GetField(name);
                DescriptionAttribute attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute)) as DescriptionAttribute;
                Console.WriteLine(attribute.Description);
            }

            Console.WriteLine("");
            Console.WriteLine("//////////Parse：将name对应的字符串 => 对应枚举值//////////");
            string todayString = "Today";
            ThreeDay today = (ThreeDay)Enum.Parse(threeDayType, todayString);
            if (today == ThreeDay.Today)
            {
                Console.WriteLine("The day is today !");
            }

            Console.WriteLine("");
            Console.WriteLine("//////////ToObject：将value对应的数值 => 对应枚举值//////////");
            int yesterdayInt = 1;
            ThreeDay yesterday = (ThreeDay)Enum.ToObject(threeDayType, yesterdayInt);
            if (yesterday == ThreeDay.Yesterday)
            {
                Console.WriteLine("The day is yesterday !");
            }
        
        }
    }

    enum ThreeDay
    {
        [Description("昨天")]
        Yesterday = 1,

        [Description("今天")]
        Today = 2,
        
        [Description("明天")]
        Tomorrow = 3
    }
}
