using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace LearnCSharp.Basic.Types
{

    /// <summary>
    /// 三天枚举
    /// </summary>
    internal enum ThreeDay
    {
        [Description("昨天")]
        Yesterday = 1,

        [Description("今天")]
        Today = 2,

        [Description("明天")]
        Tomorrow = 3
    }

    /// <summary>
    /// 枚举测试
    /// </summary>
    class EnumTest
    {
        public static void Run()
        {
            var t = (ThreeDay)2;

            //GetNamesTest();
            //GetValuesTest();
            //ParseTest();
            //ToObjectTest();
            //GetDescriptionsTest();
        }

        public static void ReflectionTest()
        {
            //Type threeDayType = typeof(ThreeDay);
            //FieldInfo fieldInfo = threeDayType.GetField("Today");
            //foreach (object value in )


        }

        /// <summary>
        /// 测试GetNames方法
        /// </summary>
        public static void GetNamesTest()
        {
            Console.WriteLine("//////////GetNamesTest//////////");

            Type threeDayType = typeof(ThreeDay);
            string[] names = Enum.GetNames(threeDayType);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// GetValues方法测试
        /// </summary>
        public static void GetValuesTest()
        {
            Console.WriteLine("//////////GetValuesTest//////////");
            Type threeDayType = typeof(ThreeDay);
            var values = Enum.GetValues(threeDayType);
            foreach (object value in values)
            {
                Console.WriteLine(value.ToString());
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// 根据枚举值的Name获取对应枚举变量
        /// </summary>
        public static void ParseTest()
        {

            Console.WriteLine("//////////Parse：将name对应的字符串 => 对应枚举值//////////");

            Type threeDayType = typeof(ThreeDay);
            string todayString = "Today";
            ThreeDay today = (ThreeDay)Enum.Parse(threeDayType, todayString);
            if (today == ThreeDay.Today)
            {
                Console.WriteLine("Parse String \"Today\" to \"ThreeDay.Today\" .");
            }

            
            Console.WriteLine("");
        }

        /// <summary>
        /// 根据枚举值的Value获取
        /// </summary>
        public static void ToObjectTest()
        {
            Console.WriteLine("//////////ToObject：将value对应的数值 => 对应枚举值//////////");
            Type threeDayType = typeof(ThreeDay);
            int yesterdayInt = 1;
            ThreeDay yesterday = (ThreeDay)Enum.ToObject(threeDayType, yesterdayInt);
            if (yesterday == ThreeDay.Yesterday)
            {
                Console.WriteLine("Parse int 1 to \"ThreeDay.Yesterday\" .");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GetDescriptionsTest()
        {
            Console.WriteLine("//////////GetDescriptionsTest//////////");
            Type threeDayType = typeof(ThreeDay);
            string[] names = Enum.GetNames(threeDayType);

            //通过FieldInfo的GetCustomAttribute方法获取属性
            foreach (string name in names)
            {
                FieldInfo fieldInfo = threeDayType.GetField(name);
                //DescriptionAttribute attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                //Console.WriteLine(attribute.Description);
            }
            Console.WriteLine("");


            //用Attribute的GetCustomAttribute方法获取属性
            foreach (string name in names)
            {
                FieldInfo fieldInfo = threeDayType.GetField(name);
                DescriptionAttribute attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute)) as DescriptionAttribute;
                Console.WriteLine(attribute.Description);
            }
        
        }
    }
}
