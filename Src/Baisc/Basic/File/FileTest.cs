using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.File
{
    class FileTest
    {
        public static void Run()
        {
            /*
            FileStream fs = new FileStream("Log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter("Log.txt", true);
            sw.WriteLine("你好");
            sw.Flush();
            sw.Close();
             */

            Person p1 = new Person("张三");
            Console.WriteLine(p1.GetType());
        }

    }


    public class Person
    {
        public string personName;

        public Person(string name)
        {
            this.personName = name;
        }

        public override string ToString()
        {
            return this.personName;
        }
    }

}
