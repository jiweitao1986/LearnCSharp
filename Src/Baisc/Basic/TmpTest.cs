using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LearnCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {

            //var path = "RefCSSes/Group[@IsDebug=\"{0}\" and @Theme=\"{1}\"]/RefCss";
            //path = path.Replace("{0}", "true");
            //path = path.Replace("{1}", "classic");
            //Console.WriteLine(Convert.ToBoolean(null));


            //查找
            //List<Employee> employees = MockDataUtil.GetEmployees();
            //var queryResult = from e in employees
            //                  where e.Gender==Gender.Male
            //                  select e;
            //var targetEmployee = queryResult.First();
            //Console.WriteLine(targetEmployee.Name);



            //foreach (var item in targetEmployees)
            //{
            //    Console.WriteLine("查找" + item.Name);
            //}

            //var queryResult = from e in employees
            //                  group e by e.Gender into eg
            //                  select new { Gender = eg.Key };

            //var queryResult = from e in employees
            //                  where e.Gender==Gender.Male
            //                  select e;

            //foreach (var item in queryResult)
            //{
            //    Console.WriteLine(item.Name.ToString());
            //}

            //var result = employees.GroupBy(e=>e.Gender)
            //    .Select(g => g.ToList()).ToList();

            //////////
            //var result = employees.GroupBy(e => e.Gender)
            //    .Select(g => new { Gender=g.Key, Employees=g.ToList() } );

            //foreach (var item in result.ToDictionary(g=>g.Gender))
            //{
            //    Console.WriteLine(item.Key + item.Value.Employees.Count);
            //}


        }
    }


}
