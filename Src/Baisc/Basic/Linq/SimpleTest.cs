using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Linq
{
    public static class SimpleTest
    {
        public static void Run()
        {
            WhereTest();
            OrderTest();
        }

        /// <summary>
        /// Where语句测试
        /// </summary>
        public static void WhereTest()
        {
            var names = MockDataUtil.GetNames();

            OutputUtil.ShowTitle("Where语句");
            var queryResult = from n in names
                              where n.StartsWith("Z") && n.Length == 8
                              select n;
            foreach (var name in queryResult)
            {
                Console.WriteLine(name);
            }

            OutputUtil.ShowTitle("Where方法");
            var queryResult2 = names.Where(n => n.StartsWith("Z") && n.Length == 8);
            foreach (var name in queryResult2)
            {
                Console.WriteLine(name);
            }
        }

        public static void OrderTest()
        {
            var names = MockDataUtil.GetNames();

            OutputUtil.ShowTitle("Order语句：升序");
            var queryResult1 = from n in names
                               where n.StartsWith("Z") && n.Length == 8
                               orderby n.Length
                select n;
            foreach (var name in queryResult1)
            {
                Console.WriteLine(name);
            }

            OutputUtil.ShowTitle("Order语句：降序");
            var queryResult2 = from n in names
                               where n.StartsWith("Z") && n.Length == 8
                               orderby n.Length descending
                               select n;
            foreach (var name in queryResult2)
            {
                Console.WriteLine(name);
            }

            OutputUtil.ShowTitle("Order方法：升序");
            var queryResult3 = names
                .Where(n => n.StartsWith("Z") && n.Length == 8)
                .OrderBy(n => n.Length);
            foreach (var name in queryResult3)
            {
                Console.WriteLine(name);
            }

            OutputUtil.ShowTitle("Order方法：降序");
            var queryResult4 = names
                .Where(n => n.StartsWith("Z") && n.Length == 8)
                .OrderByDescending(n => n.Length);
            foreach (var name in queryResult4)
            {
                Console.WriteLine(name);
            }
        }
    }
}
