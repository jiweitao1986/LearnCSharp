using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.DataGrid
{
    public partial class DataGridTestForm : Form
    {
        public DataGridTestForm()
        {
            InitializeComponent();
        }

        private void empGrid_Load(object sender, EventArgs e)
        {
            DataTable empDt = this.GetEmployees();
            empGrid.DataSource = empDt;

            //选择名为chenshj的行
            //this.empGridView.SelectRow(1);
            int i = 0;
            foreach(DataRow empDr in empDt.Rows)
            {
                if (empDr["ID"] == "haha")
                {
                    this.empGridView.MoveBy(i);
                    break;
                }
                i++;
            }
        }

        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        private DataTable GetEmployees()
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

            empDt.Rows.Add("chshj", "陈圣杰", "gsp", "暂无");
            empDt.Rows.Add(new string[] { "fanxsh", "范潇生", "gsp", "暂无" });
            empDt.Rows.Add("huangxl", "黄秀岭", "gsp", "暂无");
            return empDt;
        }

        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <returns></returns>
        private DataTable GetDepartments()
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
