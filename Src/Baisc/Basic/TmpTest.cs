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
            Console.WriteLine("////////////////////GetNames////////////////////");

            string[] names = Enum.GetNames(typeof(ThreeDay));
            foreach  (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("////////////////////GetValues////////////////////");
            var values = Enum.GetValues (typeof(ThreeDay));
            foreach (int value in values)
            {
                Console.WriteLine(value.ToString());
            }

            Console.WriteLine("////////////////////GetDescriptions////////////////////");
            Type threeDayType = typeof(ThreeDay);
            foreach (string name in names)
            {
                FieldInfo fieldInfo = threeDayType.GetField(name);
                DescriptionAttribute attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                Console.WriteLine(attribute.Description);
            }
        
        }
    }

    enum ThreeDay
    {
        [Description("昨天")]
        Yestoday = 1,
        [Description("今天")]
        Today = 2,
        [Description("明天")]
        Tomorrow = 3
    }
}
