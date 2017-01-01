using LearnCSharp.Basic.Entity;
using System.Collections.Generic;

namespace LearnCSharp.Basic
{
    public static class MockDataUtil
    {
        public static string[] GetNames()
        {
            //刘一、陈二、张三、李四、王五、赵六、孙七、周八、吴九、郑十
            string[] names = {
                "LiuYi",   "ChenEr", "ZhangSan", "LiSi",  "WangWu",
                "ZhaoLiu", "SunQi",  "ZhouBa",   "WuJiu", "ZhengShi"
            };
            return names;
        }

        public static List<Employee> GetEmployees()
        {
            //刘一、陈二、张三、李四、王五、赵六、孙七、周八、吴九、郑十
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Name = "刘一",
                    Gender = Gender.Male,
                    Age = 21
                },
                new Employee
                {
                    Name = "陈二",
                    Gender = Gender.Female,
                    Age = 21
                },
                                new Employee
                {
                    Name = "张三",
                    Gender = Gender.Male,
                    Age = 21
                },
                new Employee
                {
                    Name = "李四",
                    Gender = Gender.Female,
                    Age = 21
                },
                new Employee
                {
                    Name = "王五",
                    Gender = Gender.Male,
                    Age = 21
                },
                new Employee
                {
                    Name = "赵六",
                    Gender = Gender.Female,
                    Age = 21
                }
            };
            return employees;
        }
    }
}
