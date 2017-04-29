
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
                    Id = 1,
                    Name = "刘一",
                    Gender = Gender.Male,
                    Age = 21
                },
                new Employee
                {
                    Id = 2,
                    Name = "陈二",
                    Gender = Gender.Female,
                    Age = 22
                },
                                new Employee
                {
                    Id = 3,
                    Name = "张三",
                    Gender = Gender.Male,
                    Age = 23
                },
                new Employee
                {
                    Id = 4,
                    Name = "李四",
                    Gender = Gender.Female,
                    Age = 24
                },
                new Employee
                {
                    Id = 5,
                    Name = "王五",
                    Gender = Gender.Male,
                    Age = 25
                },
                new Employee
                {
                    Id = 6,
                    Name = "赵六",
                    Gender = Gender.Female,
                    Age = 26
                },
                new Employee
                {
                    Id = 7,
                    Name = "孙7",
                    Gender = Gender.Male,
                    Age = 27
                },
                new Employee
                {
                    Id = 8,
                    Name = "周八",
                    Gender = Gender.Female,
                    Age = 28
                },
                new Employee
                {
                    Id = 9,
                    Name = "吴九",
                    Gender = Gender.Male,
                    Age = 29
                },
                new Employee
                {
                    Id = 10,
                    Name = "郑十",
                    Gender = Gender.Female,
                    Age = 30
                }
            };
            return employees;
        }
    }
}
