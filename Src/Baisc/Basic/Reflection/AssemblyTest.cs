using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Reflection
{
    class AssemblyTest
    {
        public static void Run()
        {
            //LoadAssemblyTest();
            //CreateInstanceTest();
            GetTypesTest();
        }


        /// <summary>
        /// 加载程序集测试
        /// </summary>
        public static void LoadAssemblyTest()
        {
            Assembly assembly;

            //通过Load方法加载
            //assembly = Assembly.Load("LearnCSharp.Basic");

            //LoadFile，需要完成路径
            //assembly = Assembly.LoadFile(@"D:\Var\C#\LearnCSharp\Src\Baisc\Basic\bin\Debug\LearnCSharp.Basic.exe");

            //LoadFrom加载
            //assembly = Assembly.LoadFrom("LearnCSharp.Basic.exe");
            assembly = Assembly.LoadFrom(@"D:\Var\C#\LearnCSharp\Src\Baisc\Basic\bin\Debug\LearnCSharp.Basic.exe");


            Console.WriteLine(assembly.FullName);
        }

        /// <summary>
        /// 创建对象
        /// </summary>
        public static void CreateInstanceTest()
        {
            Assembly assembly = Assembly.Load("LearnCSharp.Basic");

            //无名氏
            Console.WriteLine("////////////////////");
            Person wuming = (Person)assembly.CreateInstance("LearnCSharp.Basic.Reflection.Person");
            wuming.Say();

            //张三
            Console.WriteLine();
            Console.WriteLine("////////////////////");
            Person zhangsan = (Person)assembly.CreateInstance(
                "LearnCSharp.Basic.Reflection.person",
                true,
                BindingFlags.CreateInstance,
                null,
                new object[] {"张三", "男"},
                null,
                null
            );
            zhangsan.Say();
        }

        public static void GetTypesTest()
        {
            Assembly assembly = Assembly.Load("LearnCSharp.Basic");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {

                Console.WriteLine(type.FullName);
            }
        }


    }
}
