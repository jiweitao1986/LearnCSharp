using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Basic.OOP.Constructor
{
    class InheritanceTest
    {
        public static void Run()
        {
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("调用子类无参数的构造函数");
            Console.WriteLine("1、父类中无参数的构造函数会被自动调用");
            Man zeroMan = new Man();


            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("调用子类1个参数的构造函数");
            Console.WriteLine("1、如果子类没有指定base时，会自动调用父类没有指定参数的构造函数");
            Console.WriteLine("2、如果子类没有指定base时，不会调用父类中相同签名的构造函数");
            Man OneMan = new Man("季维涛");

            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("调用子类2个参数的构造函数");
            Console.WriteLine("1、父类中无参数的构造函数不会被自动调用");
            Console.WriteLine("2、父类中的构造函数由base指定");
            Man TwoMan = new Man("季维涛", "男");

            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine("实例构造函数不能被继承");

        }
    }

    /// <summary>
    /// 人
    /// </summary>
    class Person
    {
        public string name;

        public string sex;

        public Person()
        {
            Console.WriteLine("I am Person() in Person class !");
        }

        public Person(string name)
        {
            Console.WriteLine("I am Person(string name) in Person class !");
        }

        public Person(string name, string sex)
        {
            Console.WriteLine("I am Person(string name, string sex) in Person class !");
        }
    }

    /// <summary>
    /// 男人
    /// </summary>
    class Man : Person
    {
        public Man()
        {
            Console.WriteLine("I am Man() in Man class !");
        }

        public Man(string name)
        {
            Console.WriteLine("I am Man(string name) in Man class !");
        }

        public Man(string name, string sex) : base(name, sex)
        {
            Console.WriteLine("I am Man(string name, string sex) in Man class !");
        }
    }
}
