using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
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
            //DataColumn idDc = new DataColumn("ID", Type.GetType("System.String"));
            //DataColumn nameDc = new DataColumn("Name", Type.GetType("System.String"));
            //DataColumn deptDc = new DataColumn("DeptID", Type.GetType("System.String"));
            //DataColumn remarkDc = new DataColumn("Remark", Type.GetType("System.String"));

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

            empDt.Rows.Add(new string[] {"chshj", "陈圣杰", "gsp", "暂无"});
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

        //新增一行
        private void addBarButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.empGridView.AddNewRow();
        }

        /// <summary>
        /// 删除当前行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delBarButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            int focusedRowHandle = empGridView.FocusedRowHandle;
            if (focusedRowHandle < 0)
            {
                return;
            }
            this.empGridView.DeleteRow(focusedRowHandle);
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBarButtonItem_ItemClick(object sender, XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 初始化新增行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void empGridView_InitNewRow(object sender, XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            ColumnView View = sender as ColumnView;
            View.SetRowCellValue(e.RowHandle, View.Columns["ID"], "新增ID");
            View.SetRowCellValue(e.RowHandle, View.Columns["Name"], "新增部门");
            View.SetRowCellValue(e.RowHandle, View.Columns["DeptID"], "gsp");
            View.SetRowCellValue(e.RowHandle, View.Columns["Remark"], "员工备注");
        }


    }
}
