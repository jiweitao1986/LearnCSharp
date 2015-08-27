using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DevExpress.Data
{
    class EmployeeData
    {
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
    }
}
