using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnCSharp.Basic.Entity;

namespace LearnCSharp.Basic.Collection
{
    public class ListTest
    {
        public static void Run()
        {
            //List<Employee> emps = new List<Employee>();
            //emps.Add(new Employee { Name = "n1" });
            //emps.Add(new Employee { Name = "n2" });
            //emps.Add(new Employee { Name = "n3" });
            //emps.Add(new Employee { Name = "n4" });
            //emps.Add(new Employee { Name = "n5" });

            //emps.Sort(delegate(Employee x, Employee y)
            //{
            //    return 0-x.Name.CompareTo(y.Name);

            //});

            //int result = emps.FindIndex(emp => emp.Name == "n1");
            //Console.WriteLine(result.ToString());

            
            string[] test = new string[] {"a", "b", "c"};
            string[] test2 = new string[] {};
            Test(test2);
        }

        public static void Test(string[] strArr)
        {
            if (strArr == null)
            {

            }
            Console.WriteLine("//////////Test//////////");
            Console.WriteLine(strArr.Length);
        }
    }
}
