using DevExpress.XtraEditors;
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
    public partial class DataGridPopContainerTestForm : Form
    {
        public DataGridPopContainerTestForm()
        {
            InitializeComponent();
        }

        private void DataGridPopContainerTestForm_Load(object sender, EventArgs e)
        {
            //加载人员列表
            this.empGridControl.DataSource = this.GetEmployees();

            //LookUpEdit
            this.deptRepositoryItemLookUpEdit.ValueMember = "ID";
            this.deptRepositoryItemLookUpEdit.DisplayMember = "Name";
            this.deptRepositoryItemLookUpEdit.DataSource = this.GetDepartments();

            //SearchLookUpEdit
            this.deptRepositoryItemSearchLookUpEdit.ValueMember = "ID";
            this.deptRepositoryItemSearchLookUpEdit.DisplayMember = "Name";
            this.deptRepositoryItemSearchLookUpEdit.DataSource = this.GetDepartments();

            //GridLookUpEdit
            this.deptRepositoryItemGridLookUpEdit.ValueMember = "ID";
            this.deptRepositoryItemGridLookUpEdit.DisplayMember = "Name";
            this.deptRepositoryItemGridLookUpEdit.DataSource = this.GetDepartments();
        }

        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        private DataTable GetEmployees()
        {
            DataTable empDt = new DataTable();
            DataColumn idDc = new DataColumn("ID", Type.GetType("System.String"));
            DataColumn nameDc = new DataColumn("Name", Type.GetType("System.String"));
            DataColumn deptDc = new DataColumn("DeptID", Type.GetType("System.String"));
            DataColumn remarkDc = new DataColumn("Remark", Type.GetType("System.String"));

            empDt.Columns.Add(idDc);
            empDt.Columns.Add(nameDc);
            empDt.Columns.Add(deptDc);
            empDt.Columns.Add(remarkDc);

            //Rows
            DataRow jiwt = empDt.NewRow();
            jiwt["ID"] = "jiwt";
            jiwt["Name"] = "季维涛";
            jiwt["DeptID"] = "gsp";
            jiwt["Remark"] = "暂无";
            empDt.Rows.Add(jiwt);
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

        private void remarkRepositoryItemPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            XtraUserControl remarkEditor = new PopupContainer.BorderEditor();
            this.remarkPopupContainerControl.Width = remarkEditor.Width;
            this.remarkPopupContainerControl.Height = remarkEditor.Height;
            this.remarkRepositoryItemPopupContainerEdit.PopupControl.Controls.Add(remarkEditor);
        }
    }
}
