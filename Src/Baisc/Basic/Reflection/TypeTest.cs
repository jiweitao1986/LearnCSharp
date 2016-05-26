using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Reflection
{

    /// <summary>
    /// System.Type测试
    /// </summary>
    class TypeTest
    {
        public static void Run()
        {
            //GetMembersTest();
            GetFieldsTest();
            GetPropertiesTest();
            GetMethodsTest();
            GetConstructorsTest();
        }


        public static void GetMembersTest()
        {
            Console.WriteLine("////////////////////GetMembersTest////////////////////");

            Type type = Type.GetType("LearnCSharp.Basic.Reflection.Person");

            BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;

            MemberInfo[] members = type.GetMembers(bindingFlags);
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member.Name);
            }

        }

        /// <summary>
        /// 获取全部字段
        /// </summary>
        public static void GetFieldsTest()
        {
            Console.WriteLine("////////////////////GetFieldsTest////////////////////");
            Type type = Type.GetType("LearnCSharp.Basic.Reflection.Person");
            BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            FieldInfo[] fields = type.GetFields(bindingFlags);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }

        /// <summary>
        /// 获取全部属性
        /// </summary>
        public static void GetPropertiesTest()
        {
            Console.WriteLine("////////////////////GetPropertiesTest////////////////////");
            Type type = Type.GetType("LearnCSharp.Basic.Reflection.Person");
            //BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }

        /// <summary>
        /// 获取全部方法
        /// </summary>
        public static void GetMethodsTest()
        {
            Console.WriteLine("////////////////////GetMethodsTest////////////////////");
            Type type = Type.GetType("LearnCSharp.Basic.Reflection.Person");
            //BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                string methodString = method.Name;
                methodString += "(";
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    if (methodString.EndsWith("(") == false)
                    {
                        methodString += ",";
                    }
                    methodString += parameter.Name;
                }
                methodString += ")";
                Console.WriteLine(methodString);
            }
        }

        /// <summary>
        /// 获取全部方法
        /// </summary>
        public static void GetConstructorsTest()
        {
            Console.WriteLine("////////////////////GetConstructorsTest////////////////////");
            Type type = Type.GetType("LearnCSharp.Basic.Reflection.Person");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                string constructorString = "Person";
                constructorString += "(";
                ParameterInfo[] parameters = constructor.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    if (constructorString.EndsWith("(") == false)
                    {
                        constructorString += ",";
                    }
                    constructorString += parameter.Name;
                }
                constructorString += ")";
                Console.WriteLine(constructorString);
            }
        }

    }
}
