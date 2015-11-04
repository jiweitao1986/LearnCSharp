using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Other.ExtendMethod
{
    class Person
    {
        public string name;

        public string sex;

        public string age;
    }

    class Man : Person
    {
        
    }

    static class PersonExtension
    {
        public static string GetInfo(this Person person, string prefix, string suffix)
        {
             string infoText = string.Format("{0} 姓名：{1}，性别：{2}，年龄：{3}。{4}",
                    prefix, person.name, person.sex, person.age, suffix);
             return infoText;
        }
    }

    class PersonExtensionTest
    {
        public static void Run()
        {
            Man man = new Man();
            man.name = "jiweitao";
            man.sex = "male";
            man.age = "30";

            
            string manInfo = man.GetInfo("【", "】");
            Console.WriteLine(manInfo);
        }
    }
}
