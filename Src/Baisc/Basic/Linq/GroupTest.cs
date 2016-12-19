using System;
using System.Collections.Generic;
using System.Linq;
using LearnCSharp.Basic.Entity;
using LearnCSharp.Basic.Utils;

namespace LearnCSharp.Basic.Linq
{
    class GroupTest
    {

        public static void Run()
        {
            List<Employee> employees = MockDataUtil.GetEmployees();
            var queryResult = from e in employees
                              group e by e.Gender into eg
                              select new { Gender = eg.Key };
            foreach (var item in queryResult)
            {
                Console.WriteLine(item.Gender.ToString());
            }

        }
    }
}
