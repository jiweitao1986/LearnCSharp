using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DevExpress.Data
{
    class DeptData
    {
        /// <summary>
        /// 获取部门的DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDeptDt()
        {
            DataTable deptDt = new DataTable();
            DataColumn idDc = new DataColumn("ID", Type.GetType("System.String"));
            DataColumn nameDc = new DataColumn("Name", Type.GetType("System.String"));
            deptDt.Columns.Add(idDc);
            deptDt.Columns.Add(nameDc);


            //Rows
            DataRow gspDr = deptDt.NewRow();
            gspDr["ID"] = "gsp";
            gspDr["Name"] = "平台与技术部";
            deptDt.Rows.Add(gspDr);

            DataRow crmDr = deptDt.NewRow();
            crmDr["ID"] = "crm";
            crmDr["Name"] = "CRM产品部";
            deptDt.Rows.Add(crmDr);

            return deptDt;
        }
    }
}
