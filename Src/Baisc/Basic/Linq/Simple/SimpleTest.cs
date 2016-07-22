using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Linq.Simple
{
    public static class SimpleTest
    {
        public static void Run()
        {
            //刘一、陈二、张三、李四、王五、赵六、孙七、周八、吴九、郑十
            string[] names = {
                "LiuYi",   "ChenEr", "ZhangSan", "LiSi",  "WangWu",
                "ZhaoLiu", "SunQi",  "ZhouBa",   "WuJiu", "ZhengShi"
            };

            //var queryResult = names.Where(n => n.StartsWith("Z"));

            var queryResult = from n in names
                              where n.StartsWith("Z")
                              select n;

            foreach (var name in queryResult)
            {
                Console.WriteLine(name);
            }

        }
    }
}
