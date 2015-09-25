using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace LearnCSharp.Basic.Reflection
{
    class ReflectionTest
    {
        public static void Run()
        {
            AssemblyTest("LearningCSharp.Basic");
        }

        public static void AssemblyTest(string assemblyString)
        {
            Assembly SampleAssembly = Assembly.Load(assemblyString);
            foreach (Type oType in SampleAssembly.GetTypes())
            {
                Console.WriteLine(oType.Name);
            }
        }

        public static void TypeTest()
        {
            Type t = typeof(String);

            Console.WriteLine("/////Constructors/////");
            foreach (ConstructorInfo cInfo in t.GetConstructors())
            {
                Console.WriteLine("{0}", cInfo.ToString());
            }

            //字段
            Console.WriteLine("/////Fields/////");
            foreach (FieldInfo fInfo in t.GetFields())
            {
                //Console.WriteLine("{0}", fInfo.Name);
            }

            //方法信息
            Console.WriteLine("/////Methods/////");
            foreach (MemberInfo mInfo in t.GetMembers())
            {
                //Console.WriteLine("{0}/t{1}", mi.MemberType, mi.Name);
            }

            Console.WriteLine("/////Properties/////");
            //属性信息
            foreach (PropertyInfo pInfo in t.GetProperties())
            {
                //Console.WriteLine("{0}", pInfo.Name);
            }
        }
    }
}
