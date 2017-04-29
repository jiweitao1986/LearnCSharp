using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Collection
{
    public class ListTest
    {
        public static void Run()
        {
            List<Employee> emps = new List<Employee>();
            emps.Add(new Employee { Name = "n1" });
            emps.Add(new Employee { Name = "n2" });
            emps.Add(new Employee { Name = "n3" });
            emps.Add(new Employee { Name = "n4" });
            emps.Add(new Employee { Name = "n5" });

            int result = emps.FindIndex(emp=>emp.Name=="n1");
            Console.WriteLine(result.ToString());
        }
    }
}
