using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Ds
{
    public static class DataRowCollectionTest
    {

        public static void Run()
        {
            FindTest();
        }

        /// <summary>
        /// 查找测试
        /// </summary>
        public static void FindTest()
        {
            var deptEmpDt = MockDataUtil.GetDeptEmpDataSet();
            var empTable = deptEmpDt.Tables["Emp"];

            //查找第1行
            var firstRow = empTable.Rows.Find(1);
            Console.WriteLine(firstRow["ID"] + "=" + firstRow["Name"]);

            //查找第二行
            var secondRow = empTable.Rows.Find(new object[] {2});
            Console.WriteLine(secondRow["ID"] + "=" + secondRow["Name"]);
        }


    }
}
