using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.OOP.Constructor
{
    class StaticConstructorTest
    {
        public static void Run()
        {
            //Console.WriteLine("//////////直接调用父类静态字段//////////");
            //Console.WriteLine(Util.name);

            //Console.WriteLine("//////////直接调子类用静态字段//////////");
            //Console.WriteLine(DbUtil.name);

            //Console.WriteLine("//////////实例化父类//////////");
            //Util util = new Util();
            //util.DoSomething();

            Console.WriteLine("//////////实例化子类//////////");
            DbUtil dbUtil = new DbUtil();
            dbUtil.DoSomething();
        }

    }

    internal class Util
    {
        public static string name ;

        public static string desc;

        static Util()
        {
            Console.WriteLine("Util static constructor is called.");
            name = "Util Name";
            desc = "Util Description";
        }

        public void DoSomething()
        {
            Console.WriteLine("Util is doing something !");
        }


    }

    internal class DbUtil : Util
    {
        static DbUtil()
        {
            Console.WriteLine("DbUtil static constructor is called.");
            name = "DbUtil Name";
            desc = "DbUtil Description";
        }

        new public void DoSomething()
        {
            Console.WriteLine("DbUtil is doing something !");
        }
    }



}
