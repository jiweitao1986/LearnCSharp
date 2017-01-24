using System;
using System.Collections.Generic;
using System.Linq;
using LearnCSharp.Basic.Entity;

namespace LearnCSharp.Basic
{
    class TmpTest
    {
        public static void Run()
        {

            List<string> list = new List<string>
            {
                "zhangSan",
                "LiSi"
            };
            Console.WriteLine(list[1]);


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
