
﻿using System;
using System.Collections.Generic;
using System.Data;

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


        /// <summary>
        /// 获取部门员工的DataSet
        /// </summary>
        /// <returns></returns>
        public static DataSet GetDeptEmpDataSet()
        {
            var deptEmpDs = new DataSet();

            //部门Table
            DataTable deptDt = new DataTable();
            deptDt.TableName = "Dept";

            //部门主键
            var deptIdColumn = new DataColumn("ID") {Caption = "内码"};
            deptDt.Columns.Add(deptIdColumn);
            deptDt.PrimaryKey = new DataColumn[] {deptIdColumn};

            deptDt.Columns.Add(new DataColumn("Code") { Caption = "编号" });
            deptDt.Columns.Add(new DataColumn("Name") { Caption = "姓名" });
            deptDt.Columns.Add(new DataColumn("Remark") { Caption = "备注" });

            //部门Rows
            deptDt.Rows.Add(1, "Dept0001", "部门0001", "暂无");
            deptDt.Rows.Add(2, "Dept0002", "部门0002", "暂无");

            deptDt.Rows.Add(3, "DeptToUpdate0003", "部门0003", "暂无");
            deptDt.Rows.Add(4, "DeptToDelete0004", "部门0004", "暂无");

            //员工Table
            DataTable empDt = new DataTable();
            empDt.TableName = "Emp";

            //员工主键
            var empIdColumn = new DataColumn("ID") {Caption = "内码"};
            empDt.Columns.Add(empIdColumn);
            empDt.PrimaryKey = new DataColumn[] {empIdColumn};

            empDt.Columns.Add(new DataColumn("DeptID") { Caption = "部门内码" });
            empDt.Columns.Add(new DataColumn("Code") { Caption = "编号" });
            empDt.Columns.Add(new DataColumn("Name") { Caption = "姓名" });
            empDt.Columns.Add(new DataColumn("Age") { Caption = "年龄" });
            empDt.Columns.Add(new DataColumn("Birthday") { Caption = "生日" });
            empDt.Columns.Add(new DataColumn("Salary") { Caption = "工资" });
            empDt.Columns.Add(new DataColumn("IsMarried") { Caption = "结婚" });
            empDt.Columns.Add(new DataColumn("Remark") { Caption = "Remark" });

            //员工Rows
            empDt.Rows.Add(1,  1, "Emp0001", "刘一", 31, new DateTime(1901, 1,  1),  11111.11, '1', "暂无");
            empDt.Rows.Add(2,  2, "Emp0002", "陈二", 32, new DateTime(1902, 2,  2),  22222.22, '0', "暂无");
            empDt.Rows.Add(3,  1, "Emp0003", "张三", 33, new DateTime(1903, 3,  3),  33333.33, '1', "暂无");
            empDt.Rows.Add(4,  2, "Emp0004", "李四", 34, new DateTime(1904, 4,  4),  44444.44, '0', "暂无");
            empDt.Rows.Add(5,  1, "Emp0005", "王五", 35, new DateTime(1905, 5,  5),  55555.55, '1', "暂无");
            empDt.Rows.Add(6,  2, "Emp0006", "赵六", 36, new DateTime(1906, 6,  6),  66666.66, '0', "暂无");
            empDt.Rows.Add(7,  1, "Emp0007", "孙七", 37, new DateTime(1907, 7,  7),  77777.77, '1', "暂无");
            empDt.Rows.Add(8,  2, "Emp0008", "周八", 38, new DateTime(1908, 8,  8),  88888.88, '0', "暂无");
            empDt.Rows.Add(9,  1, "Emp0009", "吴九", 39, new DateTime(1909, 9,  9),  99999.99, '1', "暂无");
            empDt.Rows.Add(10, 2, "Emp0010", "郑十", 40, new DateTime(1910, 10, 10), 10000.00, '0', "暂无");

            empDt.Rows.Add(11, 2, "EmpToUpdate0011", "待更新员工0011", 41, new DateTime(1911, 11, 11), 11000.00, '0', "暂无");
            empDt.Rows.Add(12, 2, "EmpToDelete0012", "待删除员工0012", 42, new DateTime(1912, 12, 12), 12000.00, '1', "暂无");

            deptEmpDs.Tables.Add(deptDt);
            deptEmpDs.Tables.Add(empDt);
            return deptEmpDs;
        }

    }
}
