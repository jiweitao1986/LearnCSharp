using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearnCSharp.Basic.Ds
{
    public static class DataSetTest
    {
        public static void Run()
        {
            //string tableString = "{\"Jiwt_Emp_Avatar\": 2, \"Jiwt_Emp_Photo\": 2, \"Jiwt_Emp_Income\": 2}";
            //var tableDic = JsonConvert.DeserializeObject<Dictionary<string, int>>(tableString);

            //foreach (var keyValue in tableDic)
            //{
            //    Console.WriteLine(keyValue.Key + "=" + keyValue.Value);
            //}


            var ds = GetDeptEmpDs();

            var empDt = ds.Tables["Emp"];
            empDt.DefaultView.Sort = "ID Desc";
            empDt = empDt.DefaultView.ToTable();

            foreach (DataRow empRow in empDt.Rows)
            {
                Console.WriteLine(empRow["ID"] + ":" + empRow["Name"]);
            }

        }


        public static DataSet GetDeptEmpDs()
        {
            var ds = new DataSet();

            //部门Table
            DataTable deptDt = new DataTable();
            deptDt.TableName = "Dept";
            deptDt.Columns.Add(new DataColumn("ID") { Caption = "ID" });
            deptDt.Columns.Add(new DataColumn("Code") { Caption = "Code" });
            deptDt.Columns.Add(new DataColumn("Name") { Caption = "Name" });

            //部门Rows
            deptDt.Rows.Add(1, "Dept0001", "部门0001");
            deptDt.Rows.Add(2, "Dept0002", "部门0002");


            //员工Table
            DataTable empDt = new DataTable();
            empDt.TableName = "Emp";
            empDt.Columns.Add(new DataColumn("ID") { Caption = "ID" });
            empDt.Columns.Add(new DataColumn("Code") { Caption = "Code" });
            empDt.Columns.Add(new DataColumn("Name") { Caption = "Name" });
            empDt.Columns.Add(new DataColumn("DeptID") { Caption = "DeptID" });
            empDt.Columns.Add(new DataColumn("Remark") { Caption = "Remark" });

            //员工Rows
            empDt.Rows.Add("Emp0001",  "LiuYi",    "刘一", "Dept0001", "暂无");
            empDt.Rows.Add("Emp0002",  "ChenEr",   "陈二", "Dept0002", "暂无");
            empDt.Rows.Add("Emp0003",  "ZhangSan", "张三", "Dept0001", "暂无");
            empDt.Rows.Add("Emp0004",  "LiSi",     "李四", "Dept0002", "暂无");
            empDt.Rows.Add("Emp0005",  "WangWu",   "王五", "Dept0001", "暂无");
            empDt.Rows.Add("Emp0006",  "ZhaoLiu",  "赵六", "Dept0002", "暂无");
            empDt.Rows.Add("Emp0007",  "SunQi",    "孙七", "Dept0001", "暂无");
            empDt.Rows.Add("Emp0008",  "ZhouBa",   "周八", "Dept0002", "暂无");
            empDt.Rows.Add("Emp0009",  "WuJiu",    "吴九", "Dept0001", "暂无");
            empDt.Rows.Add("Emp00010", "ZhengShi", "郑十", "Dept0002", "暂无");

            empDt.Rows.Add("Emp00010", "ZhengShi", "郑十", "Dept0002", "暂无");

            ds.Tables.Add(deptDt);
            ds.Tables.Add(empDt);


            return ds;
        }

        /// <summary>
        /// 获取员工的DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable GetEmpDt()
        {
            DataTable empDt = new DataTable();

            empDt.Columns.Add(new DataColumn("ID") { Caption = "ID" });
            empDt.Columns.Add(new DataColumn("Name") { Caption = "Name" });
            empDt.Columns.Add(new DataColumn("DeptID") { Caption = "DeptID" });
            empDt.Columns.Add(new DataColumn("Remark") { Caption = "Remark" });

            //Rows
            DataRow jiwt = empDt.NewRow();
            jiwt["ID"] = "jiwt";
            jiwt["Name"] = "季维涛";
            jiwt["DeptID"] = "gsp";
            jiwt["Remark"] = "暂无";
            empDt.Rows.Add(jiwt);

            empDt.Rows.Add(new string[] { "fanxsh", "范潇生", "gsp", "暂无" });

            empDt.Rows.Add("chshj", "陈圣杰", "gsp", "暂无");
            empDt.Rows.Add("jip", "纪鹏", "gsp", "暂无");
            empDt.Rows.Add("gongbj", "宫宝金", "gsp", "暂无");
            empDt.Rows.Add("zhagnj", "黄秀岭", "gsp", "暂无");
            empDt.Rows.Add("liuy", "刘洋", "gsp", "暂无");
            empDt.Rows.Add("lilj", "李琳杰", "gsp", "暂无");
            empDt.Rows.Add("zhangjq", "黄秀岭", "gsp", "暂无");
            empDt.Rows.Add("renlx", "任丽霞", "gsp", "暂无");
            empDt.Rows.Add("zhoul", "周仑", "gsp", "暂无");
            empDt.Rows.Add("liub", "刘彪", "gsp", "暂无");

            return empDt;
        }



        /// <summary>
        /// 删除测试
        /// </summary>
        public static void DeleteRowsTest()
        {
            var ds = GetDeptEmpDs();

            var dt = ds.Tables["Emp"];
            Console.WriteLine(dt.Rows.Count.ToString());

            var pageSize = 3;
            for (int i = dt.Rows.Count - 1; i >= pageSize; i--)
            {
                dt.Rows.RemoveAt(i);
            }
            Console.WriteLine(dt.Rows.Count.ToString());
        }

    }
}
